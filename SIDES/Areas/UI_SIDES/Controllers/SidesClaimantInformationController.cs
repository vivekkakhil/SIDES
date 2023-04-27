using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SIDES.EFCoreModels.ScafffoldEntities.Persistance;
using SIDES.Interface;
using SIDES.Services;
using SIDES.Services.UI_SIDES;
using SIDES.ViewModels;

namespace SIDES.Areas.UI_SIDES.Controllers
{
    [Area("UI_SIDES")]
    public class SidesClaimantInformationController : Controller
    {
        private ISidesResponse_ClaimantInformation _claimantInformation;
        private UCAContext _uCAContext;
        private ISidesTPARequest _TPARequest;
        private readonly IFlagRequestStatus flagRequestStatus;

        public SidesClaimantInformationController(UCAContext uCAContext, ISidesResponse_ClaimantInformation claimantInformation, ISidesTPARequest TPARequest, IFlagRequestStatus flagRequestStatus)
        {
            this._claimantInformation = claimantInformation;
            this._uCAContext = uCAContext;
            this._TPARequest = TPARequest;
            this.flagRequestStatus = flagRequestStatus;
        }

        [HttpGet]
        [Route("UI_SIDES/SidesClaimantInformation/SidesClaimantInformationV/{RSID}")]
        public IActionResult SidesClaimantInformationV(int RSID)
        {
            try
            {
                if ((RSID != 0) && (RSID > 0))
                {
                    var result = GetClaimantDetails(RSID);

                    //if (result.SidesRequest.RequestForSeparationId.Equals(0))
                    //{
                    //    Response.StatusCode = 404;
                    //    return View("ClaimNotFound", Convert.ToInt32(RSID));
                    //}
                }

                return View(GetClaimantDetails(RSID));



            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }

        [HttpPost]
        
        [Route("UI_SIDES/SidesClaimantInformation/SidesClaimantInformationV/{RSID}")]
        public IActionResult SidesClaimantInformationV(int RSID,string Save, string Next,string check)
        {
            try
            {
                if (!string.IsNullOrEmpty(Save))
                {
                    SaveClaimantDetails(RSID);
                    flagRequestStatus.FlagRequestStatus(RSID, "Pending");
                }
                if (!string.IsNullOrEmpty(Next))
                {
                    SaveClaimantDetails(RSID);
                    flagRequestStatus.FlagRequestStatus(RSID, "Pending");
                  //  return Redirect("https://
                  //  /ui_sides/sidesReasonforSeparation/sidesReasonforSeparationv/" + RSID);
                      return RedirectToAction("sidesReasonforSeparationV", "sidesReasonforSeparation", new { id = RSID, Area = "UI_SIDES" });
                }
                var ClaimModel = GetClaimantDetails(RSID);
                return View(ClaimModel);
            }
            catch(Exception ex)
            {
                return View("Error");
            }

        }

        public ClaimantInformation GetClaimantDetails(int RSID)
        {
            var SidesTPAResponse = _uCAContext.SidesTparesponses.Where(e => e.RequestForSeparationId == RSID).FirstOrDefault();

          

              ClaimantInformation ClaimModel = new ClaimantInformation();

            if (SidesTPAResponse.RequestForSeparationId != null)
            {
                ClaimModel.SidesRequest = _TPARequest.GetRec(RSID);

                List<SelectListItem> items = new List<SelectListItem>();
                foreach (var Wagesavailabilities in _uCAContext.SidesWagesavailabilities)
                {
                    if (SidesTPAResponse.TotalEarnedWagesNeededInd == Wagesavailabilities.WagesAvailabilityId)

                        items.Add(new SelectListItem { Text = Wagesavailabilities.WagesAvailabilityDesc, Value = Wagesavailabilities.WagesAvailabilityId.ToString(), Selected = true });
                    else
                        items.Add(new SelectListItem { Text = Wagesavailabilities.WagesAvailabilityDesc, Value = Wagesavailabilities.WagesAvailabilityId.ToString() });
                }

                ClaimModel.WasgesAvailability = items;

                items = new List<SelectListItem>();
                foreach (var Weeksavailables in _uCAContext.SidesWeeksavailables)
                {
                    if (SidesTPAResponse.TotalWeeksWorkedNeededInd == Weeksavailables.WeeksAvailableId)

                        items.Add(new SelectListItem { Text = Weeksavailables.WeeksAvailableDesc, Value = Weeksavailables.WeeksAvailableId.ToString(), Selected = true });
                    else
                        items.Add(new SelectListItem { Text = Weeksavailables.WeeksAvailableDesc, Value = Weeksavailables.WeeksAvailableId.ToString() });
                }

                ClaimModel.WeeksAvailable = items;



                var ClaimantResponse = _uCAContext.SidesTparesponses.Where(b => b.RequestForSeparationId == RSID).FirstOrDefault();
                var ClaimantRequest = _uCAContext.SidesRequestforseparations.Where(b => b.RequestForSeparationId == RSID).FirstOrDefault();

                ClaimModel.OtherSSN = ClaimantResponse.OtherSsn;
                ClaimModel.ClaimantNameWorkedAsForEmployer = ClaimantResponse.ClaimantNameWorkedAsForEmployer;
                ClaimModel.RequestForSeparationId = ClaimantResponse.RequestForSeparationId;
                ClaimModel.ClaimantJobTitle = ClaimantResponse.ClaimantJobTitle;
                ClaimModel.SeasonalEmploymentInd = ClaimantResponse.SeasonalEmploymentInd;
                if (ClaimantResponse.EmployerReportedClaimantFirstDayofWork.HasValue)
                {
                    ViewBag.ClaimEF = (ClaimantResponse.EmployerReportedClaimantFirstDayofWork).Value.ToString("yyyy-MM-dd");
                }
                if (ClaimantResponse.EmployerReportedClaimantLastDayofWork.HasValue)
                {
                    ViewBag.ClaimLD = (ClaimantResponse.EmployerReportedClaimantLastDayofWork).Value.ToString("yyyy-MM-dd");
                }
                if ((ClaimantResponse.EffectiveSeparationDate.HasValue))
                {
                    ViewBag.ClaimESD = (ClaimantResponse.EffectiveSeparationDate).Value.ToString("yyyy-MM-dd");
                }

                ClaimModel.TotalEarnedWages = Convert.ToDecimal(ClaimantResponse.TotalEarnedWages);
                ClaimModel.TotalWeeksWorked = Convert.ToInt32(ClaimantResponse.TotalWeeksWorked);
                ClaimModel.WagesEarnedAfterClaimEffectiveDate = Convert.ToDecimal(ClaimantResponse.WagesEarnedAfterClaimEffectiveDate);
                ClaimModel.NumberOfHoursWorkedAfterClaimEffectiveDate = Convert.ToInt32(ClaimantResponse.NumberOfHoursWorkedAfterClaimEffectiveDate);
                ClaimModel.AverageWeeklyWage = Convert.ToDecimal(ClaimantResponse.AverageWeeklyWage);

                //  ClaimModel.EmployerReportedClaimantLastDayofWork = DateOnly.FromDateTime( ClaimantResponse.EmployerReportedClaimantLastDayofWork);
                // ClaimModel.EmployerReportedClaimantFirstDayofWork = DateOnly.FromDateTime(ClaimantResponse.EmployerReportedClaimantFirstDayofWork);
                // ClaimModel.EffectiveSeparationDate = DateOnly.FromDateTime( ClaimantResponse.EffectiveSeparationDate);

                //   }
            }
            
            return ClaimModel;
        }


        public void SaveClaimantDetails(int RSID)
        {
            var SidesTPAResponse = _uCAContext.SidesTparesponses.Where(e => e.RequestForSeparationId == RSID).FirstOrDefault();
            ClaimantInformation umodel = new ClaimantInformation();

            SidesTPAResponse.OtherSsn = HttpContext.Request.Form["OtherSSN"].ToString();
            SidesTPAResponse.RequestForSeparationId = Convert.ToInt32(HttpContext.Request.Form["RequestId"]);
            SidesTPAResponse.ClaimantNameWorkedAsForEmployer = HttpContext.Request.Form["ClaimantNameWorkedAsForEmployer"].ToString();
            SidesTPAResponse.ClaimantJobTitle = HttpContext.Request.Form["ClaimantJobTitle"].ToString();
            SidesTPAResponse.SeasonalEmploymentInd = HttpContext.Request.Form["SeasonalEmploymentInd"].ToString();
            if(HttpContext.Request.Form["EmployerReportedClaimantFirstDayofWork"].ToString() != "")
            SidesTPAResponse.EmployerReportedClaimantFirstDayofWork = Convert.ToDateTime(HttpContext.Request.Form["EmployerReportedClaimantFirstDayofWork"].ToString());

            if(HttpContext.Request.Form["EmployerReportedClaimantLastDayofWork"].ToString() != "")
            SidesTPAResponse.EmployerReportedClaimantLastDayofWork = Convert.ToDateTime(HttpContext.Request.Form["EmployerReportedClaimantLastDayofWork"].ToString());

            if(HttpContext.Request.Form["EffectiveSeparationDate"].ToString() != "")
            SidesTPAResponse.EffectiveSeparationDate = Convert.ToDateTime(HttpContext.Request.Form["EffectiveSeparationDate"].ToString());

            SidesTPAResponse.TotalEarnedWagesNeededInd = Convert.ToInt32(HttpContext.Request.Form["earnedWagesAailable"]);

            if(HttpContext.Request.Form["earnedWages"].ToString() == "")
            SidesTPAResponse.TotalEarnedWages = 0;
            else
                SidesTPAResponse.TotalEarnedWages = Convert.ToDecimal(HttpContext.Request.Form["earnedWages"]);
            

            SidesTPAResponse.TotalWeeksWorkedNeededInd = Convert.ToInt32(HttpContext.Request.Form["TotalWeeksWorkedNeededInd"]);
           
             if(HttpContext.Request.Form["weeksWorked"].ToString() == "")
                SidesTPAResponse.TotalWeeksWorked = 0;
            else
            SidesTPAResponse.TotalWeeksWorked = Convert.ToInt32(HttpContext.Request.Form["weeksWorked"]);
            if (HttpContext.Request.Form["wagesEarnedLast"].ToString() == "")
                SidesTPAResponse.WagesEarnedAfterClaimEffectiveDate = 0;
            else
                SidesTPAResponse.WagesEarnedAfterClaimEffectiveDate = Convert.ToDecimal(HttpContext.Request.Form["wagesEarnedLast"]);

            if (HttpContext.Request.Form["hoursWorkedLast"].ToString() == "")
                SidesTPAResponse.NumberOfHoursWorkedAfterClaimEffectiveDate = 0;
            else
                SidesTPAResponse.NumberOfHoursWorkedAfterClaimEffectiveDate = Convert.ToInt32(HttpContext.Request.Form["hoursWorkedLast"]);

            if (HttpContext.Request.Form["AverageWeeklyWages"].ToString() == "")
                SidesTPAResponse.AverageWeeklyWage = 0;
            else
                SidesTPAResponse.AverageWeeklyWage = Convert.ToDecimal(HttpContext.Request.Form["AverageWeeklyWages"]);



            _uCAContext.SidesTparesponses.Update(SidesTPAResponse);
            _uCAContext.SaveChanges();
            //  ViewData["AlertMessage"] = "Details successfully saved.";
        }
    }
}
