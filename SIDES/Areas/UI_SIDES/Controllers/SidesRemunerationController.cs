using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json.Linq;
using SIDES.EFCoreModels.ScafffoldEntities.Persistance;
using SIDES.Interface;
using SIDES.ViewModels;


namespace SIDES.Areas.UI_SIDES.Controllers
{
    [Area("UI_SIDES")]
    public class SidesRemunerationController : Controller
    {
        private readonly UCAContext _UCAContext;
        private readonly ISidesTPARequest _TPARequest;
        private readonly IFlagRequestStatus flagRequestStatus;

        public SidesRemunerationController(UCAContext uCAContext,ISidesTPARequest TPARequest, IFlagRequestStatus flagRequestStatus)
        {
            this._UCAContext = uCAContext;
            this._TPARequest = TPARequest;
            this.flagRequestStatus = flagRequestStatus;
        }

        [HttpGet]
        [Route("UI_SIDES/SidesRemuneration/SidesRemunerationV/{RSID}")]
        public IActionResult SidesRemunerationV(int RSID)
        {
            try
            {
               
                var RemunerationModel = GetRemunerationDetails(RSID);
                return View(RemunerationModel);
            }
            catch(Exception ex)
            {
                return View("Error");
            }

        }

        [HttpPost]
        [Route("UI_SIDES/SidesRemuneration/SidesRemunerationV/{RSID}")]
        public IActionResult SidesRemunerationV(int RSID,string Save,string Next, Remuneration RemunerationModel)
        {
            try
            {
                if (!string.IsNullOrEmpty(Save))
                {
                    RemunerationDetailSave(RSID);
                    flagRequestStatus.FlagRequestStatus(RSID, "Pending");
                }
                if (!string.IsNullOrEmpty(Next))
                {
                    RemunerationDetailSave(RSID);
                    flagRequestStatus.FlagRequestStatus(RSID, "Pending");

                    // return Redirect("https://localhost:44389/ui_sides/sidesDischarge/sidesDischargeV/" + RSID);
                    return RedirectToAction("sidesDischargeV", "sidesDischarge", new { id = RSID, Area = "UI_SIDES" });
                }
                var Remuneration = GetRemunerationDetails(RSID);
                return View(Remuneration);
            }
            catch (Exception ex)
            {
                return View("Error");
            }

        }


            public Remuneration GetRemunerationDetails(int RSID)
        {

            Remuneration RemunerationModel = new Remuneration();

            RemunerationModel.SidesRequest = _TPARequest.GetRec(RSID);

            var Remuneration = _UCAContext.SidesTparesponses.Where(e => e.RequestForSeparationId == RSID).First();
            if (Remuneration != null)
            {
                RemunerationModel.RemunerationAmountPerPeriod = Convert.ToDecimal(Remuneration.RemunerationAmountPerPeriod);

                if (Remuneration.DateRemunerationIssued.HasValue)
                {
                    ViewBag.DateRemunerationIssued = Remuneration.DateRemunerationIssued.Value.ToString("yyyy-MM-dd");
                }
                if (Remuneration.AllocationBeginDate.HasValue)
                {
                    ViewBag.AllocationBeginDate = Remuneration.AllocationBeginDate.Value.ToString("yyyy-MM-dd");
                    // RemunerationModel.AllocationBeginDate = Remuneration.AllocationBeginDate;
                }
                if (Remuneration.AllocationEndDate.HasValue)
                {
                    ViewBag.AllocationEndDate = Remuneration.AllocationEndDate.Value.ToString("yyyy-MM-dd");
                   
                }


                RemunerationModel.AverageNumberofHoursWorkedperWeek = Convert.ToInt32(Remuneration.AverageNumberofHoursWorkedperWeek);
                RemunerationModel.ClaimantPensionContributionPercent = Convert.ToInt32(Remuneration.ClaimantPensionContributionPercent);
                RemunerationModel.PensionComments = Remuneration.PensionComments;
                RemunerationModel.MandatoryPension = Remuneration.MandatoryPension;
                RemunerationModel.ContributoryorNotContributoryClaimantInd = Remuneration.ContributoryorNotContributoryClaimantInd;
                RemunerationModel.EmployerAllocationInd = Remuneration.EmployerAllocationInd;
                RemunerationModel.AverageNumberofHoursWorkedperWeek = Convert.ToInt32( Remuneration.AverageNumberofHoursWorkedperWeek);
                RemunerationModel.MandatoryRetirementInd = Remuneration.MandatoryRetirementInd;
                RemunerationModel.MandatoryPension = Remuneration.MandatoryPension;
                RemunerationModel.ContributoryorNotContributoryClaimantInd = RemunerationModel.ContributoryorNotContributoryClaimantInd;
                
                //   var RemunerationDll = _UCAContext.SidesRemunerations;
                //  ViewBag.RemunerationDll = RemunerationDll;

                List<SelectListItem> items = new List<SelectListItem>();
                foreach (var remuneration in _UCAContext.SidesRemunerations)
                {

                    if (Remuneration.RemunerationTypeCode  == remuneration.RemunerationId)
                       items.Add(new SelectListItem { Text = remuneration.Remuneration, Value = remuneration.RemunerationId.ToString(),Selected=true });
                        else
                    items.Add(new SelectListItem { Text = remuneration.Remuneration, Value = remuneration.RemunerationId.ToString() });
                }

                RemunerationModel.SIDES_REMUNERATION = items;


               // var RemunerationFrequencyDll = _UCAContext.SidesRemunerationfrequencies;
              //  ViewBag.RemunerationFrequencyDll = RemunerationFrequencyDll;

                items = new List<SelectListItem>();
                foreach (var frequency in _UCAContext.SidesRemunerationfrequencies)
                {
                    if( Remuneration.RemunerationPeriodFrequencyCode == frequency.RemunerationFrequencyCode.ToString())
                        items.Add(new SelectListItem { Text = frequency.RemunerationFrequency, Value = frequency.RemunerationFrequencyCode.ToString() , Selected=true });
                    else
                    items.Add(new SelectListItem { Text = frequency.RemunerationFrequency, Value = frequency.RemunerationFrequencyCode.ToString() });
                }

                RemunerationModel.SIDES_REMUNERATIONFREQUENCY = items;



            }

            return RemunerationModel;
        }

        public void RemunerationDetailSave(int RSID) {

            var SidesTPAResponse = _UCAContext.SidesTparesponses.Where(e => e.RequestForSeparationId == RSID).FirstOrDefault();

            if (SidesTPAResponse != null)
            {
                SidesTPAResponse.RemunerationTypeCode = Convert.ToInt32(HttpContext.Request.Form["RemunerationTypeCode"].ToString());
                SidesTPAResponse.RemunerationAmountPerPeriod = Convert.ToDecimal(HttpContext.Request.Form["RemunerationAmountPerPeriod"].ToString());
                SidesTPAResponse.RemunerationPeriodFrequencyCode = HttpContext.Request.Form["RemunerationPeriodFrequencyCodes"].ToString();

                if(HttpContext.Request.Form["DateRemunerationIssued"].ToString() != "")
                SidesTPAResponse.DateRemunerationIssued = Convert.ToDateTime(HttpContext.Request.Form["DateRemunerationIssued"].ToString());
                SidesTPAResponse.EmployerAllocationInd = HttpContext.Request.Form["EmployerAllocationInd"].ToString(); 

                if (HttpContext.Request.Form["AllocationBeginDate"].ToString() != "")
                SidesTPAResponse.AllocationBeginDate = Convert.ToDateTime( HttpContext.Request.Form["AllocationBeginDate"].ToString());

                if (HttpContext.Request.Form["AllocationEndDate"].ToString() != "")
                SidesTPAResponse.AllocationEndDate = Convert.ToDateTime( HttpContext.Request.Form["AllocationEndDate"].ToString());
                SidesTPAResponse.AverageNumberofHoursWorkedperWeek = Convert.ToInt32(HttpContext.Request.Form["AverageNumberofHoursWorkedperWeek"].ToString());

                SidesTPAResponse.MandatoryRetirementInd = HttpContext.Request.Form["MandatoryRetirementInd"].ToString();
                SidesTPAResponse.MandatoryPension = HttpContext.Request.Form["MandatoryPension"].ToString();
                SidesTPAResponse.ContributoryorNotContributoryClaimantInd = HttpContext.Request.Form["ContributoryorNotContributoryClaimantInd"].ToString();
                SidesTPAResponse.ClaimantPensionContributionPercent = Convert.ToInt32(HttpContext.Request.Form["ClaimantPensionContributionPercent"].ToString());
                SidesTPAResponse.PensionComments = HttpContext.Request.Form["PensionComments"].ToString();

                _UCAContext.SidesTparesponses.Update(SidesTPAResponse);
                _UCAContext.SaveChanges();
            }

        }

        
    }
}
