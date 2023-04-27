using MessagePack.Formatters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.Differencing;
using Microsoft.VisualBasic;
using Newtonsoft.Json.Linq;
using SIDES.EFCoreModels.ScafffoldEntities.Persistance;
using SIDES.Interface;
using SIDES.Services;
using SIDES.ViewModels;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace SIDES.Areas.UI_SIDES.Controllers
{
    [Area("UI_SIDES")]
    public class SidesPrepareController : Controller
    {
        private UCAContext _UCAContext;
        private ISidesTPARequest _TPARequest;
        private readonly IFlagRequestStatus flagRequestStatus;
        private readonly ILogger<SidesPrepareController> _logger;


        public SidesPrepareController(UCAContext uCAContext, ISidesTPARequest TPARequest,IFlagRequestStatus flagRequestStatus, ILogger<SidesPrepareController> logger)
        {
            this._UCAContext = uCAContext;
            this._TPARequest = TPARequest;
            this.flagRequestStatus = flagRequestStatus;
            _logger = logger;
        }

        [HttpGet]
        [Route("UI_SIDES/SidesPrepare/SidesPrepareV/{RSID}")]
        public IActionResult SidesPrepareV(int RSID)
        {
            try
            {
                GetPrepareDetails(RSID);
                var PrepareModel = GetPrepareDetails(RSID);
                return View(PrepareModel);
            }
            catch(Exception ex)
            {
                return View("Error");
            }

        }

      
        [Route("UI_SIDES/SidesPrepare/SidesPrepareV/{RSID}")]
        [HttpPost]
        public IActionResult SidesPrepareV(int RSID, string Save, string SendResponse,Prepare model)
        {
            try
            {
                if (!string.IsNullOrEmpty(Save))
                {
                    SavePrepareDetails(RSID);
                    flagRequestStatus.FlagRequestStatus(RSID, "Pending");
                }
                if (!string.IsNullOrEmpty(SendResponse))
                {
                    SavePrepareDetails(RSID);
                  //  flagRequestStatus.FlagRequestStatus(RSID, "Completed");
                    GenerateResponseXml(RSID);
                }
                var SidesPrepare = GetPrepareDetails(RSID);
                return View(SidesPrepare);
            }
            catch(Exception ex)
            {
                return View("Error");
            }
        }

        public Prepare GetPrepareDetails(int RSID)
        {
            var SidesTPAResponse = _UCAContext.SidesTparesponses.Where(e => e.RequestForSeparationId == RSID).FirstOrDefault();
            var Users = _UCAContext.AspnetUsers.Where(e => e.UserName == "gcosta")
               .Select(e => new
               {
                   UserId = e.UserId
               }).SingleOrDefault();
            //  var MemberShip = _UCAContext.AspnetMemberships.Where(e =>e.UserId == Users.UserId ).SingleOrDefault();

            Prepare PrepareModel = new Prepare();
            PrepareModel.SidesRequest = _TPARequest.GetRec(RSID);

            List<SelectListItem> items = new List<SelectListItem>();
            foreach (var Preparertypes in _UCAContext.SidesPreparertypes)
            {

                if (SidesTPAResponse.PreparerTypeCode == Preparertypes.PreparerTypeCode)
                    items.Add(new SelectListItem { Text = Preparertypes.PreparerType, Value = Preparertypes.PreparerTypeCode.ToString(), Selected = true });
                else
                    items.Add(new SelectListItem { Text = Preparertypes.PreparerType, Value = Preparertypes.PreparerTypeCode.ToString() });
            }
            PrepareModel.SIDES_PREPARERTYPE = items;


            items = new List<SelectListItem>();
            foreach (var Amendedresponses in _UCAContext.SidesAmendedresponses)
            {

                if (SidesTPAResponse.AmendedResponse == Amendedresponses.AmendedResponseValue)
                    items.Add(new SelectListItem { Text = Amendedresponses.AmendedResponse, Value = Amendedresponses.AmendedResponseValue.ToString(), Selected = true });
                else
                    items.Add(new SelectListItem { Text = Amendedresponses.AmendedResponse, Value = Amendedresponses.AmendedResponseValue.ToString() });
            }

            PrepareModel.SIDES_AMENDEDRESPONSE = items;

            PrepareModel.PreparerCompanyName = SidesTPAResponse.PreparerCompanyName;
            if (SidesTPAResponse.TparesponseId > 0)
            {

                PrepareModel.PreparerTelephoneNumberPlusExt = SidesTPAResponse.PreparerTelephoneNumberPlusExt;
                PrepareModel.PreparerContactName = SidesTPAResponse.PreparerContactName;
                PrepareModel.PreparerTitle = SidesTPAResponse.PreparerTitle;
                PrepareModel.PreparerFaxNbr = SidesTPAResponse.PreparerFaxNbr;
                PrepareModel.PreparerEmailAddress = SidesTPAResponse.PreparerEmailAddress;

            }
            else
            {
                //  PrepareModel.PreparerTelephoneNumberPlusExt = MemberShip.TelephoneNumber;
                //  PrepareModel.PreparerContactName = MemberShip.FirstName + MemberShip.LastName;
                //  PrepareModel.PreparerTitle = MemberShip.JobTitle;
                //  PrepareModel.PreparerFaxNbr = MemberShip.FaxNumber;
                //  PrepareModel.PreparerEmailAddress = MemberShip.Email
            }
            PrepareModel.AmendedResponseDescription = SidesTPAResponse.AmendedResponseDescription;
            return PrepareModel;
        }


        public void SavePrepareDetails(int RSID)
        {
            var SidesTPAResponse = _UCAContext.SidesTparesponses.Where(e => e.RequestForSeparationId == RSID).FirstOrDefault();




            SidesTPAResponse.PreparerTypeCode = HttpContext.Request.Form["SIDES_PREPARERTYPE"].ToString();
            SidesTPAResponse.PreparerCompanyName = HttpContext.Request.Form["PreparerCompanyName"].ToString();
            SidesTPAResponse.PreparerTelephoneNumberPlusExt = Request.Form["PreparerTelephoneNumberPlusExt"].ToString();
            SidesTPAResponse.PreparerContactName = Request.Form["PreparerContactName"].ToString();
            SidesTPAResponse.PreparerTitle = Request.Form["PreparerTitle"].ToString();
            SidesTPAResponse.PreparerFaxNbr = Request.Form["PreparerFaxNbr"].ToString();
            SidesTPAResponse.PreparerEmailAddress = Request.Form["PreparerEmailAddress"].ToString();
            SidesTPAResponse.AmendedResponse = Convert.ToInt32(Request.Form["SIDES_AMENDEDRESPONSE"]);
            SidesTPAResponse.AmendedResponseDescription = Request.Form["AmendedResponseDescription"];

            _UCAContext.SidesTparesponses.Update(SidesTPAResponse);
            _UCAContext.SaveChanges();

            flagRequestStatus.FlagRequestStatus(RSID, "Pending");





        }

        public void GenerateResponseXml(int RSID)
        {

            try
            {

                var oResponseList = new List<EmployerTPASeparationResponse>();
                var oRsponse = new EmployerTPASeparationResponse();


                //Load Request

                var SidesTPARequestModel = _UCAContext.SidesRequestforseparations.Where(e => e.RequestForSeparationId == RSID).FirstOrDefault();

                oRsponse.StateRequestRecordGUID = SidesTPARequestModel.StateRequestRecordGuid;
                oRsponse.BrokerRecordTransactionNumber = SidesTPARequestModel.BrokerRecordTransactionNumber;
                oRsponse.SSN = Convert.ToInt32(SidesTPARequestModel.Ssn);
                oRsponse.ClaimEffectiveDate = SidesTPARequestModel.ClaimEffectiveDate.Value.ToString("yyyy-MM-dd");
                oRsponse.ClaimNumber = SidesTPARequestModel.ClaimNumber;
                oRsponse.StateEmployerAccountNbr = SidesTPARequestModel.StateEmployerAccountNbr;
                oRsponse.EmployerName = SidesTPARequestModel.EmployerName;


                //Load Response
                var SidesResponse = _UCAContext.SidesTparesponses.Where(e => e.RequestForSeparationId == RSID).FirstOrDefault();


                //SidesResponse.aspx
                if (!String.IsNullOrEmpty(SidesResponse.CorrectedEmployerName.Trim()))
                {
                    oRsponse.CorrectedEmployerName = SidesResponse.CorrectedEmployerName;
                }
                if (!String.IsNullOrEmpty(SidesResponse.CorrectedStateEmployerAccountNbr.Trim()))
                {
                    oRsponse.CorrectedStateEmployerAccountNbr = SidesResponse.CorrectedStateEmployerAccountNbr;
                }
                if (!String.IsNullOrEmpty(SidesResponse.CorrectedFein.Trim()))
                {
                    oRsponse.CorrectedFEIN = SidesResponse.CorrectedFein;
                }

                //ÇlaimantInformation.aspx
                if (!String.IsNullOrEmpty(SidesResponse.OtherSsn.Trim()))
                {
                    oRsponse.OtherSSN = SidesResponse.OtherSsn;
                }
                if (!String.IsNullOrEmpty(SidesTPARequestModel.ClaimantLastName.Trim()))
                {
                    oRsponse.ClaimantLastName = SidesTPARequestModel.ClaimantLastName;
                }
                if (!String.IsNullOrEmpty(SidesTPARequestModel.ClaimantFirstName.Trim()))
                {
                    oRsponse.ClaimantFirstName = SidesTPARequestModel.ClaimantFirstName;
                }
                if (!String.IsNullOrEmpty(SidesTPARequestModel.ClaimantMiddleInitial.Trim()))
                {
                    oRsponse.ClaimantMiddleInitial = SidesTPARequestModel.ClaimantMiddleInitial;
                }
                if (!String.IsNullOrEmpty(SidesResponse.ClaimantNameWorkedAsForEmployer.Trim()))
                {
                    oRsponse.ClaimantNameWorkedAsForEmployer = SidesResponse.ClaimantNameWorkedAsForEmployer;
                }
                if (!String.IsNullOrEmpty(SidesTPARequestModel.ClaimantSuffix.Trim()))
                {
                    oRsponse.ClaimantSuffix = SidesTPARequestModel.ClaimantSuffix;
                }
                if (!String.IsNullOrEmpty(SidesTPARequestModel.ClaimantJobTitle.Trim()))
                {
                    oRsponse.ClaimantJobTitle = SidesTPARequestModel.ClaimantJobTitle;
                }
                if (!String.IsNullOrEmpty(SidesResponse.SeasonalEmploymentInd.Trim()))
                {
                    oRsponse.SeasonalEmploymentInd = SidesResponse.SeasonalEmploymentInd;
                }

                oRsponse.EmployerReportedClaimantFirstDayofWork = (SidesResponse.EmployerReportedClaimantFirstDayofWork).Value.ToString("yyyy-MM-dd");
                if (!String.IsNullOrEmpty(SidesResponse.EmployerReportedClaimantLastDayofWork.ToString().Trim()))
                {
                    oRsponse.EmployerReportedClaimantLastDayofWork = (SidesResponse.EmployerReportedClaimantLastDayofWork).Value.ToString("yyyy-MM-dd");
                }
                if (!String.IsNullOrEmpty(SidesResponse.EffectiveSeparationDate.ToString().Trim()))
                {
                    oRsponse.EffectiveSeparationDate = (SidesResponse.EffectiveSeparationDate).Value.ToString("yyyy-MM-dd");
                }
                oRsponse.TotalEarnedWagesNeededInd = SidesResponse.TotalEarnedWagesNeededInd;
                oRsponse.TotalEarnedWages = SidesResponse.TotalEarnedWages;
                oRsponse.TotalWeeksWorkedNeededInd = SidesResponse.TotalWeeksWorkedNeededInd;
                if (SidesResponse.TotalWeeksWorked.HasValue)
                {
                    oRsponse.TotalWeeksWorked = SidesResponse.TotalWeeksWorked;
                }
                oRsponse.WagesEarnedAfterClaimEffectiveDate = SidesResponse.WagesEarnedAfterClaimEffectiveDate;
                if (SidesResponse.NumberOfHoursWorkedAfterClaimEffectiveDate.HasValue)
                {
                    oRsponse.NumberOfHoursWorkedAfterClaimEffectiveDate = SidesResponse.NumberOfHoursWorkedAfterClaimEffectiveDate;
                }
                oRsponse.AverageWeeklyWage = SidesResponse.AverageWeeklyWage;



                //Reason for Separation - ClaimantInformation-Wages.aspx
                oRsponse.EmployerSepReasonCode = SidesResponse.EmployerSepReasonCode;
                if ((SidesResponse.EmployerSepReasonCode == 7) || (SidesResponse.EmployerSepReasonCode == 8))
                {
                    oRsponse.ReturnToWorkInd = SidesResponse.ReturnToWorkInd;
                }
                oRsponse.ReturnToWorkDate = (SidesResponse.ReturnToWorkDate).Value.ToString("yyyy-MM-dd");


                if ((SidesResponse.EmployerSepReasonCode == 9) || (SidesResponse.EmployerSepReasonCode == 10) || (SidesResponse.EmployerSepReasonCode == 11))
                {
                    oRsponse.WorkingAllAvailableHoursInd = SidesResponse.WorkingAllAvailableHoursInd;
                }


                oRsponse.NotWorkingAvailableHoursReason = SidesResponse.NotWorkingAvailableHoursReason; ;

                if (SidesResponse.EmployerSepReasonCode == 16)
                {
                    oRsponse.LaborDisputeTypeInd = SidesResponse.LaborDisputeTypeInd;
                }



                //Remunaration.aspx
                if (SidesResponse.EmployerSepReasonCode == 14)
                {
                    if (SidesResponse.RemunerationTypeCode.HasValue)
                    {
                        oRsponse.Remuneration = new Remuneration();
                        oRsponse.Remuneration.RemunerationTypeCode = Convert.ToInt32(SidesResponse.RemunerationTypeCode);
                        oRsponse.Remuneration.RemunerationAmountPerPeriod = Convert.ToDecimal(SidesResponse.RemunerationAmountPerPeriod);
                        oRsponse.Remuneration.RemunerationPeriodFrequencyCode = SidesResponse.RemunerationPeriodFrequencyCode;
                        oRsponse.Remuneration.DateRemunerationIssued = (SidesResponse.DateRemunerationIssued).Value.ToString("yyyy-MM-dd");
                        oRsponse.Remuneration.EmployerAllocationInd = SidesResponse.EmployerAllocationInd;
                        oRsponse.Remuneration.AllocationBeginDate = (SidesResponse.AllocationBeginDate).Value.ToString("yyyy-MM-dd");
                        oRsponse.Remuneration.AllocationEndDate = (SidesResponse.AllocationEndDate).Value.ToString("yyyy-MM-dd");
                        oRsponse.AverageNumberofHoursWorkedperWeek = SidesResponse.AverageNumberofHoursWorkedperWeek;
                        oRsponse.MandatoryRetirementInd = SidesResponse.MandatoryRetirementInd;
                        oRsponse.MandatoryPension = SidesResponse.MandatoryPension;
                        oRsponse.ContributoryorNotContributoryClaimantInd = SidesResponse.ContributoryorNotContributoryClaimantInd;
                        oRsponse.ClaimantPensionContributionPercent = SidesResponse.ClaimantPensionContributionPercent;


                        if (!String.IsNullOrEmpty(SidesResponse.PensionComments.Trim()))
                        {
                            oRsponse.PensionComments = SidesResponse.PensionComments.Trim();
                        }
                        else
                        {
                            oRsponse.PensionComments = "";
                        }
                    }
                }
                if (SidesResponse.AverageNumberofHoursWorkedperWeek.HasValue)
                {
                    oRsponse.AverageNumberofHoursWorkedperWeek = SidesResponse.AverageNumberofHoursWorkedperWeek;
                }
                else
                { oRsponse.AverageNumberofHoursWorkedperWeek = 0; }

                if (SidesResponse.ClaimantPensionContributionPercent.HasValue)
                {
                    oRsponse.ClaimantPensionContributionPercent = SidesResponse.ClaimantPensionContributionPercent;
                }
                else
                {
                    oRsponse.ClaimantPensionContributionPercent = 0;
                }




                //DischargeDetails.aspx
                oRsponse.DischargeReasonCode = SidesResponse.DischargeReasonCode;
                if (!(SidesResponse.EmployerSepReasonCode == 2) || (SidesResponse.EmployerSepReasonCode == 6) || (SidesResponse.EmployerSepReasonCode == 13) || (SidesResponse.EmployerSepReasonCode == 9) || (SidesResponse.EmployerSepReasonCode == 10) || (SidesResponse.EmployerSepReasonCode == 11))
                {
                    oRsponse.EmployerSepReasonComments = SidesResponse.EmployerSepReasonComments;
                    oRsponse.FinalIncidentReason = SidesResponse.FinalIncidentReason;
                    oRsponse.FinalIncidentDate = SidesResponse.FinalIncidentDate.Value.ToString("yyyy-MM-dd");
                    oRsponse.ViolateCompanyPolicyInd = SidesResponse.ViolateCompanyPolicyInd;
                    oRsponse.DischargePolicyAwareInd = SidesResponse.DischargePolicyAwareInd;
                    oRsponse.DischargePolicyAwareExplanationCode = SidesResponse.DischargePolicyAwareExplanationCode;
                    oRsponse.WhoDischargedName = SidesResponse.WhoDischargedName;
                    oRsponse.WhoDischargedTitle = SidesResponse.WhoDischargedTitle;
                }
                else
                {
                    oRsponse.WhoDischargedName = SidesResponse.WhoDischargedName;
                    oRsponse.WhoDischargedTitle = SidesResponse.WhoDischargedTitle;
                }


                //PriorIncident.aspx
                oRsponse.PriorIncidentOccurrence = new PriorIncident();

                if (!String.IsNullOrEmpty(SidesResponse.PriorIncidentDate.ToString().Trim())) ;
                {

                    oRsponse.PriorIncidentOccurrence.PriorIncidentDate = (SidesResponse.PriorIncidentDate).Value.ToString("yyyy-MM-dd");
                }
                if (!String.IsNullOrEmpty(SidesResponse.PriorIncidentReason.Trim()))
                {
                    oRsponse.PriorIncidentOccurrence.PriorIncidentReason = SidesResponse.PriorIncidentReason;
                }
                if (!String.IsNullOrEmpty(SidesResponse.PriorIncidentWarningInd.Trim()))
                {
                    oRsponse.PriorIncidentOccurrence.PriorIncidentWarningInd = SidesResponse.PriorIncidentWarningInd;
                }
                if (!String.IsNullOrEmpty(SidesResponse.PriorIncidentWarningDate.ToString().Trim()))
                {
                    oRsponse.PriorIncidentOccurrence.PriorIncidentWarningDate = (SidesResponse.PriorIncidentWarningDate).Value.ToString("yyyy-MM-dd");
                }
                if (!String.IsNullOrEmpty(SidesResponse.PriorIncidentWarningDescription.Trim()))
                {
                    oRsponse.PriorIncidentOccurrence.PriorIncidentWarningDescription = SidesResponse.PriorIncidentWarningDescription;
                }
                if (!String.IsNullOrEmpty(SidesResponse.DischargeReasonComments.Trim()))
                {
                    oRsponse.DischargeReasonComments = SidesResponse.DischargeReasonComments;
                }

                //VoluntaryQuit.aspx
                if (SidesResponse.EmployerSepReasonCode == 6)
                {
                    oRsponse.VoluntarySepReasonCode = SidesResponse.VoluntarySepReasonCode;
                    if (SidesResponse.VoluntarySepReasonCode.HasValue)
                    {
                        if (SidesResponse.VoluntarySepReasonCode != 1)
                        {
                            oRsponse.HiringAgreementChangesCode = Convert.ToInt32(SidesResponse.HiringAgreementChangesCode);
                            oRsponse.HiringAgreementChangesComments = SidesResponse.HiringAgreementChangesComments;
                            oRsponse.ClaimantActionsToAvoidQuitInd = SidesResponse.ClaimantActionstoAvoidQuitInd;
                            oRsponse.ActionTakenComments = SidesResponse.ActionTakenComments;
                            oRsponse.ContinuingWorkAvailableInd = SidesResponse.ContinuingWorkAvailableInd;
                            oRsponse.VoluntarySepReasonComments = SidesResponse.VoluntarySepReasonComments;
                        }
                        else
                        {
                            oRsponse.HiringAgreementChangesCode = Convert.ToInt32(SidesResponse.HiringAgreementChangesCode);
                        }

                    }
                }
                else
                {
                    oRsponse.VoluntarySepReasonCode = 1;
                    oRsponse.HiringAgreementChangesCode = 1;
                }

                //Attachments.aspx
                var SidesResponseAttacment = LoadResponseAttachment(RSID);
                if (!(String.IsNullOrEmpty(SidesResponseAttacment.TypeofDocument)))
                {
                    oRsponse.AttachmentOccurrence = new AttachmentResponse();
                    oRsponse.AttachmentOccurrence.UniqueAttachmentId = SidesResponseAttacment.UniqueAttachmentId;
                    oRsponse.AttachmentOccurrence.DescriptionofAttachmentCode = Convert.ToInt32(SidesResponseAttacment.DescriptionOfAttachmentCode);
                    oRsponse.AttachmentOccurrence.TypeofDocument = SidesResponseAttacment.TypeofDocument;
                    oRsponse.AttachmentOccurrence.AttachmentSize = Convert.ToInt64(SidesResponseAttacment.AttachmentSize);
                    if (SidesResponseAttacment.AttachmentData.Length > 0)
                    {
                        oRsponse.AttachmentOccurrence.AttachmentData = Convert.ToBase64String(SidesResponseAttacment.AttachmentData);
                    }
                }

                //Preparer.aspx
                if (!String.IsNullOrEmpty(SidesResponse.PreparerTypeCode.Trim()))
                {
                    oRsponse.PreparerTypeCode = SidesResponse.PreparerTypeCode;
                }
                if (!String.IsNullOrEmpty(SidesResponse.PreparerCompanyName.Trim()))
                {
                    oRsponse.PreparerCompanyName = SidesResponse.PreparerCompanyName;
                }
                if (!String.IsNullOrEmpty(SidesResponse.PreparerTelephoneNumberPlusExt.Trim()))
                {
                    oRsponse.PreparerTelephoneNumberPlusExt = SidesResponse.PreparerTelephoneNumberPlusExt;
                }
                if (!String.IsNullOrEmpty(SidesResponse.PreparerContactName.Trim()))
                {
                    oRsponse.PreparerContactName = SidesResponse.PreparerContactName;
                }
                if (!String.IsNullOrEmpty(SidesResponse.PreparerTitle.Trim()))
                {
                    oRsponse.PreparerTitle = SidesResponse.PreparerTitle;
                }
                if (!String.IsNullOrEmpty(SidesResponse.PreparerFaxNbr))
                {
                    oRsponse.PreparerFaxNbr = SidesResponse.PreparerFaxNbr;
                }
                if (!String.IsNullOrEmpty(SidesResponse.PreparerEmailAddress.Trim()))
                {
                    oRsponse.PreparerEmailAddress = SidesResponse.PreparerEmailAddress;
                }
                oRsponse.AmendedResponse = SidesResponse.AmendedResponse;
                if (!String.IsNullOrEmpty(SidesResponse.AmendedResponseDescription.Trim()))
                {
                    oRsponse.AmendedResponseDescription = SidesResponse.AmendedResponseDescription;
                }




                oResponseList.Add(oRsponse);
                var doc = new XDocument();
                SerializeParams(doc, oResponseList);


                var EmployerClientConsole = "\"C:\\sides-employer-client-wcf-black-box\\employerclientconsole.exe\"";

                var ValidResponsePath = String.Format("C:\\sides-employer-client-wcf\\data\\{0}-Model.xml", SidesTPARequestModel.StateRequestRecordGuid);
                doc.Save(ValidResponsePath);
                var processStartInfo = new ProcessStartInfo(EmployerClientConsole,
                                                               String.Format(ValidResponsePath, SidesTPARequestModel.StateRequestRecordGuid));
                processStartInfo.WindowStyle = ProcessWindowStyle.Minimized;
                processStartInfo.UseShellExecute = false;
                var currentProcess = new Process();
                currentProcess.EnableRaisingEvents = false;
                currentProcess.StartInfo = processStartInfo;
                currentProcess.Start();
                currentProcess.WaitForExit();

                var dirInfoClaims = new DirectoryInfo("C:\\uisides\\employer\\log\\debug");
                FileInfo[] claimsLogFiles = dirInfoClaims.GetFiles("*.log");

                var claimsLogFilesList = claimsLogFiles.Where(i => i.Name != null && i.Name == SidesTPARequestModel.StateRequestRecordGuid).OrderByDescending(i => i.CreationTime);

                foreach (var claimFiles in claimsLogFilesList)
                {
                    //try
                    //    {
                    if (claimFiles.CreationTime.Date == DateAndTime.Now.Date)
                    {
                        var attachmentBytes = System.IO.File.ReadAllBytes(claimFiles.FullName);


                        // HTTPResponse.Buffer = true;

                        HttpContext.Response.ContentType = "text/plain";




                        HttpContext.Response.Headers.Add("Content-Disposition", String.Format("attachment; filename={0}", claimFiles.Name));
                        HttpContext.Response.Body.Write(attachmentBytes);
                        HttpContext.Response.Body.Flush();
                        // HttpContext.Response.Body.EndWrite();
                    }



                    //catch (ex  Exception)
                    //    Console.WriteLine(ex.Message)
                    // End Try



                }

            }
            catch(Exception ex)
            {
                _logger.LogInformation("Error from error:", ex);
            }


        }


        public void SerializeParams(XDocument doc, List<EmployerTPASeparationResponse> oResponseList)
        {
            var xRoot = new  XmlRootAttribute();
            xRoot.ElementName = "EmployerTPASeparationResponseCollection";
            xRoot.Namespace = "https://uidataexchange.org/schemas";
            xRoot.IsNullable = true;
            var serializer = new XmlSerializer(oResponseList.GetType(), xRoot);
            var xmlnsEmpty = new XmlSerializerNamespaces();
            xmlnsEmpty.Add("schemaLocation", "https://uidataexchange.org/schemas SeparationResponse.xsd");
            xmlnsEmpty.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            var writer = doc.CreateWriter();
            serializer.Serialize(writer, oResponseList, xmlnsEmpty);
        writer.Close();
        }

        public SidesTparesponseattachment LoadResponseAttachment(int RSID)
        {
            var Request = _UCAContext.SidesTparesponses.Where(e => e.RequestForSeparationId == RSID)
               .Select(e => new
               {
                   TPAResponseId = e.TparesponseId
               }).FirstOrDefault();


            var TPAResponseAttachment = _UCAContext.SidesTparesponseattachments.Where(e => e.TparesponseId == Request.TPAResponseId).FirstOrDefault();

            return TPAResponseAttachment;

        }


    }
}
