using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using SIDES.EFCoreModels.ScafffoldEntities.Persistance;
using SIDES.ViewModels;
using SIDES.Interface;

namespace SIDES.Areas.UI_SIDES.Controllers
{
    [Area("UI_SIDES")]
    public class SidesReasonforSeparation : Controller
    {
        private UCAContext _uCAContext;
        private ISidesTPARequest _TPARequest;
        private readonly IFlagRequestStatus flagRequestStatus;

        public SidesReasonforSeparation(UCAContext uCAContext,ISidesTPARequest TPARequest, IFlagRequestStatus flagRequestStatus)
        {
            this._uCAContext = uCAContext;
            this._TPARequest = TPARequest;
            this.flagRequestStatus = flagRequestStatus;
        }

        [HttpGet]
        [Route("ui_sides/sidesreasonforseparation/sidesreasonforseparationv/{RSID}")]
        public IActionResult SidesReasonforSeparationV(int RSID)
        {
            try
            {
                var reasonForSeparation = GetReasonforSeparationDetails(RSID);

                if (reasonForSeparation.SidesRequest.RequestForSeparationId.Equals(0))
                {
                    Response.StatusCode = 404;
                    return View("ClaimNotFound", Convert.ToInt32(RSID));
                }

                return View(reasonForSeparation);
            }
            catch(Exception ex)
            {
                return View("Error");
            }

        }


        [HttpPost]
        [Route("ui_sides/sidesreasonforseparation/sidesreasonforseparationv/{RSID}")]
        public IActionResult SidesReasonforSeparationV(int RSID,string Save,string Next, ReasonForSeparation ReasonForSeparation)
        {
            try
            {
                if (!string.IsNullOrEmpty(Save))
                {
                    ReasonSaveDetails(RSID);
                    flagRequestStatus.FlagRequestStatus(RSID, "Pending");
                }
                if (!string.IsNullOrEmpty(Next))
                {
                    ReasonSaveDetails(RSID);
                    flagRequestStatus.FlagRequestStatus(RSID, "Pending");

                    // return Redirect("https://
                    //
                    //
                    // /ui_sides/sidesRemuneration/sidesRemunerationv/" + RSID);
                    return RedirectToAction("sidesRemunerationV", "sidesRemuneration", new { id = RSID, Area = "UI_SIDES" });
                }
                ReasonforSeparation reasonforSeparation = GetReasonforSeparationDetails(RSID);
                reasonforSeparation = GetReasonforSeparationDetails(RSID);
                return View(reasonforSeparation);
            }
            catch(Exception ex)
            {
                return View("Error");
            }
        }



        public ReasonforSeparation GetReasonforSeparationDetails(int RSID)
        {
            var SidesTPAResponse = _uCAContext.SidesTparesponses.Where(e => e.RequestForSeparationId == RSID).FirstOrDefault();
            
            
            ReasonforSeparation reasonForSeparation = new ReasonforSeparation();
            reasonForSeparation.SidesRequest = _TPARequest.GetRec(RSID);

            

            List<SelectListItem> items = new List<SelectListItem>();
            foreach (var ReasonCode in _uCAContext.SidesClaimantsepreasoncodes)
            {

               
                if (SidesTPAResponse.EmployerSepReasonCode == ReasonCode.ClaimantSeparationReasonCodeId)
                   
                items.Add(new SelectListItem { Text = ReasonCode.ClaimantSeparationReasonCode, Value = ReasonCode.ClaimantSeparationReasonCodeId.ToString(),Selected=true }) ;
                else
                    items.Add(new SelectListItem { Text = ReasonCode.ClaimantSeparationReasonCode, Value = ReasonCode.ClaimantSeparationReasonCodeId.ToString()});





            }





            reasonForSeparation.SIDES_CLAIMANTSEPREASONCODE = items;


            items = new List<SelectListItem>();

            foreach (var WorkingHours in _uCAContext.SidesWorkingallavailablehours)
            {
                items.Add(new SelectListItem { Text = WorkingHours.WorkingAllAvailableHrsDesc, Value = WorkingHours.WorkingAllAvailableHrsId.ToString() });
            }
            reasonForSeparation.SIDES_WORKINGALLAVAILABLEHOURS = items;

            items = new List<SelectListItem>();

            foreach (var LaborDisputes in _uCAContext.SidesLabordisputetypes)
            {
                if (SidesTPAResponse.LaborDisputeTypeInd == LaborDisputes.LaborDisputeTypeId.ToString())
                {
                    items.Add(new SelectListItem { Text = LaborDisputes.LaborDisputeTypeDesc, Value = LaborDisputes.LaborDisputeTypeId.ToString(), Selected = true });
                }
                else
                {
                    items.Add(new SelectListItem { Text = LaborDisputes.LaborDisputeTypeDesc, Value = LaborDisputes.LaborDisputeTypeId.ToString() });

                }
            }

            reasonForSeparation.SIDES_LABORDISPUTETYPES = items;


            SidesRequestModel sidesRequestModel = new();



            if (SidesTPAResponse.ReturnToWorkDate.HasValue)
            {

                ViewBag.ReturntoWorkDate = SidesTPAResponse.ReturnToWorkDate.Value.ToString("yyyy-MM-dd");
            }
            reasonForSeparation.NotWorkingAvailableHoursReason = SidesTPAResponse.NotWorkingAvailableHoursReason;
            reasonForSeparation.ReturnToWorkInd = SidesTPAResponse.ReturnToWorkInd;

            return reasonForSeparation; 
        }

        public void ReasonSaveDetails(int RSID)
        {
            var SidesTPAResponse = _uCAContext.SidesTparesponses.Where(e => e.RequestForSeparationId == RSID).FirstOrDefault();

            SidesTPAResponse.EmployerSepReasonCode = Convert.ToInt32(HttpContext.Request.Form["EmployerSepReasonCode"].ToString());
            SidesTPAResponse.ReturnToWorkInd = HttpContext.Request.Form["ReturnToWorkInd"].ToString();

            

           // if(HttpContext.Request.Form["ReturnToWorkDate"].ToString() != null && HttpContext.Request.Form["ReturnToWorkDate"].ToString() != "")

                if(HttpContext.Request.Form["ReturnToWorkDate"].ToString() == null)
                {
                    SidesTPAResponse.ReturnToWorkDate = null;
                }
                else {

                    SidesTPAResponse.ReturnToWorkDate = Convert.ToDateTime(HttpContext.Request.Form["ReturnToWorkDate"].ToString());
                }
           

            SidesTPAResponse.WorkingAllAvailableHoursInd = HttpContext.Request.Form["WorkingAllAvailableHoursInd"].ToString();
            SidesTPAResponse.NotWorkingAvailableHoursReason = HttpContext.Request.Form["NotWorkingAvailableHoursReason"].ToString();


            if (HttpContext.Request.Form["LaborDisputeTypeInd"].ToString() == "")
                SidesTPAResponse.LaborDisputeTypeInd = null;
            else
                SidesTPAResponse.LaborDisputeTypeInd = HttpContext.Request.Form["LaborDisputeTypeInd"].ToString();

            _uCAContext.SidesTparesponses.Update(SidesTPAResponse);
            _uCAContext.SaveChanges();
        }

        
    }
}
