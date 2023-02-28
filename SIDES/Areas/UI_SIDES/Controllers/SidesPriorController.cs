using Microsoft.AspNetCore.Mvc;
using SIDES.EFCoreModels.ScafffoldEntities.Persistance;
using SIDES.Interface;
using SIDES.Services;
using SIDES.ViewModels;

namespace SIDES.Areas.UI_SIDES.Controllers
{
    [Area("UI_SIDES")]
    public class SidesPriorController:Controller
    {
        private UCAContext _uCAContext;
        private ISidesTPARequest _TPARequest;

        public SidesPriorController(UCAContext uCAContext,ISidesTPARequest  TPARequest)
        {
            this._uCAContext = uCAContext;
            this._TPARequest = TPARequest;
        }

        [HttpGet]
        [Route("UI_SIDES/SidesPrior/SidesPriorV/{RSID}")]
        public IActionResult SidesPriorV(int RSID)
        {
            try
            {
                var priorIncidentModel = Get(RSID);
                return View(priorIncidentModel);
            }
            catch(Exception ex)
            {
                return View("Error");
            }
        }

        [Route("UI_SIDES/SidesPrior/SidesPriorV/{RSID}")]
        [HttpPost]
        public IActionResult SidesPriorV(int RSID, string Save, string Next, PriorIncident priorincident)
        {
            try
            {
                if (!string.IsNullOrEmpty(Save))
                {
                    PriorSaveDetails(RSID);
                }
                if (!string.IsNullOrEmpty(Next))
                {
                    PriorSaveDetails(RSID);
                    return Redirect("https://localhost:44389/ui_sides/sidesVoluntary/sidesvoluntaryv/" + RSID);
                }
                PriorIncident priorIncident = new PriorIncident();
                PriorIncident priorincidentmodel = new PriorIncident();
                priorIncident = Get(RSID);
                return View(priorIncident);
            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }

        public PriorIncident Get(int RSID)
        {
            PriorIncident priorIncidentModel = new PriorIncident();
            // Console.WriteLine(RSID);

            priorIncidentModel.SidesRequest = _TPARequest.GetRec(RSID);
            var priorincident = _uCAContext.SidesTparesponses.Where(b => b.RequestForSeparationId == RSID).FirstOrDefault();
            if (priorincident != null)
            {
                if (priorincident.PriorIncidentDate.HasValue)
                {
                    ViewBag.PriorIncidentDate = priorincident.PriorIncidentDate.Value.ToString("yyyy-MM-dd");
                }
                priorIncidentModel.PriorIncidentReason = priorincident.PriorIncidentReason;
                if (priorincident.PriorIncidentWarningInd == "Y")
                {
                    priorIncidentModel.PriorIncidentWarningInd = "Y";

                }
                else if(priorincident.PriorIncidentWarningInd == "N")
                {
                    priorIncidentModel.PriorIncidentWarningInd = "N";
                }
                else
                {
                    priorIncidentModel.PriorIncidentWarningInd = " ";
                }

                if (priorincident.PriorIncidentWarningDate.HasValue)
                {
                    ViewBag.PriorIncidentWarningDate = priorincident.PriorIncidentWarningDate.Value.ToString("yyyy-MM-dd");
                }
                    priorIncidentModel.PriorIncidentWarningDescription = priorincident.PriorIncidentWarningDescription;
                priorIncidentModel.DischargeReasonComments = priorincident.DischargeReasonComments;
            }

            return priorIncidentModel;
        }


        public void PriorSaveDetails(int RSID)
        {

            var sidesTparesponse = _uCAContext.SidesTparesponses.Where(e => e.RequestForSeparationId == RSID).FirstOrDefault();

            if (sidesTparesponse != null)
            {
                if(HttpContext.Request.Form["PriorIncidentDate"].ToString() != "")
                sidesTparesponse.PriorIncidentDate =   Convert.ToDateTime( HttpContext.Request.Form["PriorIncidentDate"].ToString());
                sidesTparesponse.PriorIncidentReason = HttpContext.Request.Form["priorincident"].ToString();
                sidesTparesponse.DischargeReasonComments = HttpContext.Request.Form["DischargeReasonComments"].ToString();

                if (HttpContext.Request.Form["PriorIncidentWarningDate"].ToString() != "")
                    sidesTparesponse.PriorIncidentWarningDate = Convert.ToDateTime(HttpContext.Request.Form["PriorIncidentWarningDate"].ToString());

                sidesTparesponse.PriorIncidentWarningDescription = HttpContext.Request.Form["PriorIncidentWarningDescription"].ToString();
                sidesTparesponse.PriorIncidentWarningInd = HttpContext.Request.Form["PriorIncidentWarningInd"].ToString();

                _uCAContext.SidesTparesponses.Update(sidesTparesponse);
                _uCAContext.SaveChanges();

            }
        }
    }
}
