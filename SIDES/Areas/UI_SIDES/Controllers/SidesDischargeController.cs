using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SIDES.EFCoreModels.ScafffoldEntities.Persistance;
using SIDES.Interface;
using SIDES.Services;
using SIDES.ViewModels;

namespace SIDES.Areas.UI_SIDES.Controllers
{
    [Area("UI_SIDES")]
    public class SidesDischargeController:Controller

    {
        private UCAContext _UCAContext;
        private ISidesTPARequest _TPARequest;
        private readonly IFlagRequestStatus flagRequestStatus;

        public SidesDischargeController(UCAContext uCAContext,ISidesTPARequest TPARequest, IFlagRequestStatus flagRequestStatus)
        {
            this._UCAContext = uCAContext;
            this._TPARequest = TPARequest;
            this.flagRequestStatus = flagRequestStatus;
        }

        [HttpGet]
        [Route("UI_SIDES/SidesDischarge/SidesDischargeV/{RSID}")]
        public IActionResult SidesDischargeV(int RSID)
        {
            try
            {
                var dischargeDetails = GetDischargeDetails(RSID);
                return View(dischargeDetails);
            }
            catch(Exception ex)
            {
                return View("Error");
            }
        }


        [HttpPost]
        [Route("UI_SIDES/SidesDischarge/SidesDischargeV/{RSID}")]
        public IActionResult SidesDischargeV(int RSID,string Save, string Next,DischargeDetails dischargeDetails)
        {
            try
            {
                if (!string.IsNullOrEmpty(Save))
                {
                    DischargeSaveDetails(RSID);
                    flagRequestStatus.FlagRequestStatus(RSID, "Pending");
                }
                if (!string.IsNullOrEmpty(Next))
                {
                    DischargeSaveDetails(RSID);
                    flagRequestStatus.FlagRequestStatus(RSID, "Pending");

                    // return Redirect("https://localhost:44389/ui_sides/sidesPrior/sidesPriorv/" + RSID);
                    return RedirectToAction("sidesPriorv", "sidesPrior", new { id = RSID, Area = "UI_SIDES" });
                }

                //  DischargeDetails Discahrge = GetDischargeDetails(RSID);

                var Discahrge = GetDischargeDetails(RSID);


                return View(Discahrge);
            }
            catch(Exception ex)
            {
                return View("Error");
            }
        }


        public DischargeDetails GetDischargeDetails(int RSID)
        {
            DischargeDetails dischargeDetails = new DischargeDetails();
            var SidesTPAResponse = _UCAContext.SidesTparesponses.Where(e => e.RequestForSeparationId == RSID).FirstOrDefault();

            dischargeDetails.sidesRequestModel = _TPARequest.GetRec(RSID);

            List<SelectListItem> items = new List<SelectListItem>();
            foreach (var Discharge in _UCAContext.SidesDischargereasoncodes)
            {
                if(SidesTPAResponse.DischargeReasonCode == Discharge.DischargeReasonCodeId)
                    items.Add(new SelectListItem { Text = Discharge.DischargeReasonCode, Value = Discharge.DischargeReasonCodeId.ToString(), Selected=true });
                else
                items.Add(new SelectListItem { Text = Discharge.DischargeReasonCode, Value = Discharge.DischargeReasonCodeId.ToString() });
            }

            dischargeDetails.SIDES_DISCHARGEREASONCODE = items;

            items = new List<SelectListItem>();
            foreach (var DischargePolicy in _UCAContext.SidesDischargepolicyawares)
            {
                if(SidesTPAResponse.DischargePolicyAwareExplanationCode == DischargePolicy.DischargePolicyAwareCode)
                    items.Add(new SelectListItem { Text = DischargePolicy.DischargePolicyAwareDesc, Value = DischargePolicy.DischargePolicyAwareCode.ToString() , Selected=true});
                else
                items.Add(new SelectListItem { Text = DischargePolicy.DischargePolicyAwareDesc, Value = DischargePolicy.DischargePolicyAwareCode.ToString() });
            }
            dischargeDetails.SIDES_DISCHARGEPOLICYAWARE = items;

        

            dischargeDetails.EmployerSepReasonComments = SidesTPAResponse.EmployerSepReasonComments;
            dischargeDetails.FinalIncidentReason = SidesTPAResponse.FinalIncidentReason;
            if (SidesTPAResponse.FinalIncidentDate.HasValue)
            {

                 ViewBag.FinalIncidentDate = SidesTPAResponse.FinalIncidentDate.Value.ToString("yyyy-MM-dd");
            }
            dischargeDetails.ViolateCompanyPolicyInd = SidesTPAResponse.ViolateCompanyPolicyInd;
            dischargeDetails.DischargePolicyAwareInd = SidesTPAResponse.DischargePolicyAwareInd;
            dischargeDetails.WhoDischargedName = SidesTPAResponse.WhoDischargedName;
            dischargeDetails.WhoDischargedTitle = SidesTPAResponse.WhoDischargedTitle;



            return dischargeDetails;
        }

        public void DischargeSaveDetails(int RSID)
        {
            var TPAResponse = _UCAContext.SidesTparesponses.Where(e => e.RequestForSeparationId == RSID).FirstOrDefault();

            if (TPAResponse != null)
            {
                TPAResponse.DischargeReasonCode = Convert.ToInt32(HttpContext.Request.Form["DischargeReasonCode"].ToString());
                TPAResponse.EmployerSepReasonComments = HttpContext.Request.Form["EmployerSepReasonComments"].ToString();
                TPAResponse.FinalIncidentReason = HttpContext.Request.Form["FinalIncidentReason"].ToString();
                TPAResponse.ViolateCompanyPolicyInd = HttpContext.Request.Form["ViolateCompanyPolicyInd"].ToString();
               
                if(HttpContext.Request.Form["FinalIncidentDate"].ToString() != "")
                TPAResponse.FinalIncidentDate = Convert.ToDateTime( HttpContext.Request.Form["FinalIncidentDate"].ToString());
                TPAResponse.DischargePolicyAwareInd = HttpContext.Request.Form["DischargePolicyAwareInd"].ToString();
                

                TPAResponse.DischargePolicyAwareExplanationCode = HttpContext.Request.Form["DischargePolicyAwareExplanationCode"].ToString();
                TPAResponse.WhoDischargedName = HttpContext.Request.Form["WhoDischargedName"].ToString();
                TPAResponse.WhoDischargedTitle = HttpContext.Request.Form["WhoDischargedTitle"].ToString();

                _UCAContext.SidesTparesponses.Update(TPAResponse);
                _UCAContext.SaveChanges();




            }
        }
    }
}
