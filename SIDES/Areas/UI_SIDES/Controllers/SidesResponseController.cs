using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SIDES.EFCoreModels.ScafffoldEntities.Persistance;
using SIDES.Interface;
using SIDES.Services;
using SIDES.ViewModels;
using static System.Net.Mime.MediaTypeNames;

namespace SIDES.Areas.UI_SIDES.Controllers
{
    [Area("UI_SIDES")]
    
    public class SidesResponseController : Controller
    {

        private ISidesTPAResponse _sidesTPAResponse;
        private UCAContext _uCAContext;
        string requestparam;

        public SidesResponseController(ISidesTPAResponse sidesTPAResponse, UCAContext uCAContext)
        {
            this._sidesTPAResponse = sidesTPAResponse;
            this._uCAContext = uCAContext;
        }

        [HttpGet]
        [Route("ui_sides/SidesResponse/SidesResponseV/{RSID}")]
        public IActionResult SidesResponseV(string RSID)
        {
            try
            {
                if ((RSID != "") || (RSID != null))
                {

                    ViewBag.RouteId = RSID;
                    _sidesTPAResponse.GetRec(Convert.ToInt32(RSID));

                }
                else
                {
                    throw new Exception("No data found");
                }
                return View(_sidesTPAResponse.GetRec(Convert.ToInt32(RSID)));
            }
            catch(Exception ex)
            {
                return View("Error");
            }

        }


        [HttpPost]
        [Route("ui_sides/SidesResponse/SidesResponseV/{RSID}")]
        public IActionResult SidesResponseV(int RSID,string Save,string Next,SidesResponseModel model)
        {
            try
            {

                if (!string.IsNullOrEmpty(Save))
                {
                    SaveResponseDetails(RSID);

                }
                if (!string.IsNullOrEmpty(Next))
                {
                    SaveResponseDetails(RSID);
                    return Redirect("https://localhost:44389/ui_sides/sidesClaimantInformation/sidesClaimantInformationV/" + RSID);
                }

                var SidesResponse = _sidesTPAResponse.GetRec(Convert.ToInt32(RSID));
                return View(SidesResponse);
            }
            catch(Exception ex)
            {
                return View("Error");
            }

        }


        public SidesResponseModel SaveResponseDetails(int RSID)
        {
            if (RSID != null)
            {
                int requestSeparationID = Convert.ToInt32(RSID);
                SidesResponseModel _sidesResponseModel = new SidesResponseModel();


              // if (ModelState.IsValid)
               // {

                    _sidesResponseModel.CorrectedEmployerName =   HttpContext.Request.Form["DiffEmpName"].ToString();
                    _sidesResponseModel.CorrectedStateEmployerAccountNbr = HttpContext.Request.Form["DiffAcctnbr"].ToString();
                    _sidesResponseModel.CorrectedFEIN = HttpContext.Request.Form["DiffFein"].ToString();
                    _sidesResponseModel.CreatedDate = DateTime.Now;
                    _sidesResponseModel.RequestForSeparationId = requestSeparationID;

                    //return RedirectToAction("SaveDetails(requestSeparationID, _sidesResponseModel)", "_sidesTPAResponse");
              //  }
                return _sidesTPAResponse.SaveDetails(requestSeparationID, _sidesResponseModel);

                
            }


            else
            {
                throw new Exception("No data found");
            }
        }


        
    }

   
}