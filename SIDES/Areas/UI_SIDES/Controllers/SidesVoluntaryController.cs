using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SIDES.EFCoreModels.ScafffoldEntities.Persistance;
using SIDES.Interface;
using SIDES.ViewModels;
using static System.Net.Mime.MediaTypeNames;

namespace SIDES.Areas.UI_SIDES.Controllers
{
    [Area("UI_SIDES")]
    public class SidesVoluntaryController:Controller
    {
        private  UCAContext _UCAContext;

        private ISidesTPARequest _TPARequest;

        public SidesVoluntaryController(UCAContext uCAContext,ISidesTPARequest TPARequest)
        {
            this._UCAContext = uCAContext;
            this._TPARequest = TPARequest;
        }

        [HttpGet]
        [Route("UI_SIDES/SidesVoluntary/SidesVoluntaryV/{RSID}")]
        public IActionResult SidesVoluntaryV(int RSID)
        {
            try
            {
                var voluntary = GetVoluntaryDetails(RSID);
                return View(voluntary);
            }
            catch(Exception ex)
            {
                return View("Error");
            }

        }

        [HttpPost]
        [Route("UI_SIDES/SidesVoluntary/SidesVoluntaryV/{RSID}")]
        public IActionResult SidesVoluntaryV(int RSID, string Save, string Next,Voluntary model)
        {
            try
            {
                if (!string.IsNullOrEmpty(Save))
                {
                    VoluntarySaveDetails(RSID);
                }
                if (!string.IsNullOrEmpty(Next))
                {
                    VoluntarySaveDetails(RSID);

                    return Redirect("https://localhost:44389/ui_sides/sidesAttachments/sidesAttachmentsV/" + RSID);
                }
                var voluntary = GetVoluntaryDetails(RSID);
                return View(voluntary);
            }
            catch(Exception ex)
            {
                return View("Error");
            }

        }

        public Voluntary GetVoluntaryDetails(int RSID)
        {
            var SidesTPAResponse = _UCAContext.SidesTparesponses.Where(e => e.RequestForSeparationId == RSID).FirstOrDefault();
            Voluntary voluntary = new Voluntary();

            voluntary.sidesRequest = _TPARequest.GetRec(RSID);

            List<SelectListItem> items = new List<SelectListItem>();
            foreach (var voluntaryseparation in _UCAContext.SidesVoluntaryseparations)
            {
                if( SidesTPAResponse.VoluntarySepReasonCode == voluntaryseparation.VoluntarySeparationId)
                    items.Add(new SelectListItem { Text = voluntaryseparation.VoluntarySeparation, Value = voluntaryseparation.VoluntarySeparationId.ToString(), Selected=true });
                else
                items.Add(new SelectListItem { Text = voluntaryseparation.VoluntarySeparation, Value = voluntaryseparation.VoluntarySeparationId.ToString() });
            }

            voluntary.SIDES_VOLUNTARYSEPARATION = items;

            items = new List<SelectListItem>();
            foreach (var hiringagreement in _UCAContext.SidesHiringagreementchanges)
            {
                if(SidesTPAResponse.HiringAgreementChangesCode == hiringagreement.HiringAgreementChangesId)
                    items.Add(new SelectListItem { Text = hiringagreement.HiringAgreementChanges, Value = hiringagreement.HiringAgreementChangesId.ToString(),Selected=true });
                else
                items.Add(new SelectListItem { Text = hiringagreement.HiringAgreementChanges, Value = hiringagreement.HiringAgreementChangesId.ToString() });
            }
            voluntary.SIDES_HIRINGAGREEMENTCHANGES = items;

            voluntary.sidesRequest = _TPARequest.GetRec(RSID);

          
            if (SidesTPAResponse != null)
            {
                voluntary.HiringAgreementChangesComments = SidesTPAResponse.HiringAgreementChangesComments;
                voluntary.ClaimantActionstoAvoidQuitInd = SidesTPAResponse.ClaimantActionstoAvoidQuitInd;
                voluntary.ActionTakenComments = SidesTPAResponse.ActionTakenComments;
                voluntary.ContinuingWorkAvailableInd = SidesTPAResponse.ContinuingWorkAvailableInd;
                voluntary.NotWorkingAvailableHoursReason = SidesTPAResponse.NotWorkingAvailableHoursReason;



            }


            return voluntary;
        }


        public void VoluntarySaveDetails(int RSID)
        {
            var SidesTPAResponse = _UCAContext.SidesTparesponses.Where(e => e.RequestForSeparationId == RSID).FirstOrDefault();

            if (SidesTPAResponse != null)
            {
                SidesTPAResponse.VoluntarySepReasonCode = Convert.ToInt32(HttpContext.Request.Form["SIDES_VOLUNTARYSEPARATION"].ToString());
                SidesTPAResponse.HiringAgreementChangesCode = Convert.ToInt32(HttpContext.Request.Form["HiringAgreementChangesCode"].ToString());
                SidesTPAResponse.HiringAgreementChangesComments = HttpContext.Request.Form["HiringAgreementChangesComments"].ToString();
                SidesTPAResponse.ClaimantActionstoAvoidQuitInd = HttpContext.Request.Form["ClaimantActionstoAvoidQuitInd"].ToString();
              //  // SidesTPAResponse.AllocationBeginDate = HttpContext.Request.Form["AllocationBeginDate"].ToString();
              //  // SidesTPAResponse.AllocationEndDate = HttpContext.Request.Form["AllocationEndDate"].ToString();
             //   SidesTPAResponse.AverageNumberofHoursWorkedperWeek = Convert.ToInt32(HttpContext.Request.Form["AverageNumberofHoursWorkedperWeek"].ToString());

                SidesTPAResponse.ActionTakenComments = HttpContext.Request.Form["ActionTakenComments"].ToString();
                SidesTPAResponse.ContinuingWorkAvailableInd = HttpContext.Request.Form["ContinuingWorkAvailableInd"].ToString();
                SidesTPAResponse.NotWorkingAvailableHoursReason = HttpContext.Request.Form["NotWorkingAvailableHoursReason"].ToString();
              //  SidesTPAResponse.ClaimantPensionContributionPercent = Convert.ToInt32(HttpContext.Request.Form["ClaimantPensionContributionPercent"].ToString());
              //  SidesTPAResponse.PensionComments = HttpContext.Request.Form["PensionComments"].ToString();

                _UCAContext.SidesTparesponses.Update(SidesTPAResponse);
                _UCAContext.SaveChanges();
            }
        }
    }
}
