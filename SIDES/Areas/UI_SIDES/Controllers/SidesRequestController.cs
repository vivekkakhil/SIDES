using Microsoft.AspNetCore.Authorization;
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
        private readonly ILogger<SidesRequestController> _logger;

        public SidesRequestController(ISidesTPARequest sidesTPARequest,UCAContext uCAContext,ILogger<SidesRequestController> logger)
        {
            this._sidesTPARequest = sidesTPARequest;
            this._uCAContext = uCAContext;
            this._logger = logger;
        }



       // [HttpGet]
        public IActionResult SidesRequestV(string Go, string Cancel, string EmployeeText = "",string EmployerText = "" , DateTime? RequestDate = null,DateTime? ResponseDueDate = null,int pg = 1,int pageSize = 5)
        {
            try
            {

                if (EmployeeText == "")
                    EmployeeText = null;
                else
                ViewBag.EmployeeText = EmployeeText;

                if (EmployerText == "")
                    EmployerText = null;
                else
                ViewBag.EmployerText = EmployerText;

                if (RequestDate != null)
                {
                    DateTime FromDate = Convert.ToDateTime(RequestDate);
                    ViewBag.RequestDate = FromDate.ToString("yyyy-MM-dd");

                }

                if (ResponseDueDate != null)
                {
                    DateTime ToDate = Convert.ToDateTime(ResponseDueDate);
                    ViewBag.ResponseDueDate = ToDate.ToString("yyyy-MM-dd");
                }

                if((Cancel != null))
                {
                    ViewBag.RequestDate = null;
                    ViewBag.ResponseDueDate = null;
                }
              

              
             //   const int pageSize = 5;
                if (pg < 1)
                    pg = 1;

                //search filter
                List<SidesRequestModel> srs = _sidesTPARequest.GetAll(Go,Cancel,EmployeeText, EmployerText, RequestDate, ResponseDueDate,pg);

                 int recsCount = srs.Count();

                var pager = new Pager(recsCount, pg, pageSize);
                int recSkip = (pg - 1) * pageSize;


                var data = srs.Skip(recSkip).Take(pager.PageSize).ToList();
                this.ViewBag.Pager = pager;
             //   _logger.LogInformation("This is log from UCA", data);
                return View(data);
            }
            catch(Exception ex)
            {
              //  _logger.LogInformation("Error from error:", ex);
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
