using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SIDES.EFCoreModels.ScafffoldEntities.Persistance;
using SIDES.ViewModels;
using System.Security.Cryptography.X509Certificates;

namespace SIDES.Areas.UI_SIDES.Controllers
{

    [Area("UI_SIDES")]
    public class SidesClaimantRemuneration:Controller
    {
        private UCAContext _uCAContext;

        public SidesClaimantRemuneration(UCAContext uCAContext)
        {
            this._uCAContext = uCAContext;
        }
        [HttpGet]
        public IActionResult SidesClaimantRemunerationV(int RSID)
        {
            try
            {
                Remuneration remuneration = new Remuneration();
                List<SelectListItem> items = new List<SelectListItem>();
                foreach (var sidesremuneration in _uCAContext.SidesRemunerations)
                {
                    items.Add(new SelectListItem { Text = sidesremuneration.Remuneration, Value = sidesremuneration.RemunerationId.ToString() });
                }
                remuneration.SIDES_REMUNERATION = items;
                items = new List<SelectListItem>();
                foreach (var frequency in _uCAContext.SidesRemunerationfrequencies)
                {
                    items.Add(new SelectListItem { Text = frequency.RemunerationFrequency, Value = frequency.RemunerationFrequencyId.ToString() });
                }
                remuneration.SIDES_REMUNERATIONFREQUENCY = items;
                return View(remuneration);
            }
            catch(Exception ex)
            {
                return View("Error");
            }
        }




    }
}
