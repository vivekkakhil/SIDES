using Microsoft.AspNetCore.Mvc;
using SIDES.EFCoreModels.ScafffoldEntities.Persistance;
using SIDES.Interface;
using SIDES.Services;
using SIDES.Services.UI_SIDES.DTO;
using SIDES.ViewModels;

namespace SIDES.Areas.UI_SIDES.Controllers
{
    [Area("UI_SIDES")]
    public class SidesRequestController : Controller
    {
        private ISidesTPARequest _sidesTPARequest;
        private UCAContext _uCAContext;

        public SidesRequestController(ISidesTPARequest sidesTPARequest,UCAContext uCAContext)
        {
            this._sidesTPARequest = sidesTPARequest;
            this._uCAContext = uCAContext;
        }


        public void SidesLogout()
        {

        }

        [HttpGet]
        public IActionResult SidesRequestV(int pg = 1)
        {
            try
            {
                const int pageSize = 5;
                if (pg < 1)
                    pg = 1;


                List<SidesRequestModel> srs = _sidesTPARequest.GetAll();
                int recsCount = srs.Count();

                var pager = new Pager(recsCount, pg, pageSize);
                int recSkip = (pg - 1) * pageSize;


                var data = srs.Skip(recSkip).Take(pager.PageSize).ToList();
                this.ViewBag.Pager = pager;

                return View(data);
            }
            catch(Exception ex)
            {
                return View("Error");
            }
        }

        [HttpPost]
        public IActionResult ResponseClick(string ResponseBtn)
        {
            try
            {
                ViewBag.Name = ResponseBtn;
                return View();
            }
            catch(Exception ex)
            {
                return View("Error");
            }
        }
    }
}
