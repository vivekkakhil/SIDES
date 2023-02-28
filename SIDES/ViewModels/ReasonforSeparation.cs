using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace SIDES.ViewModels
{
    public class ReasonforSeparation
    {
        [Required(ErrorMessage = "*Field is required")]
        public List<SelectListItem> SIDES_CLAIMANTSEPREASONCODE { get; set; }

        public List<SelectListItem> SIDES_WORKINGALLAVAILABLEHOURS { get; set; }

        public List<SelectListItem> SIDES_LABORDISPUTETYPES { get; set; }

        public SidesRequestModel SidesRequest { get; set; }

        public SidesResponseModel sidesResponse { get;set; }    

        public DateTime ReturntoWorkDate { get; set; }

        public string ReturnToWorkInd { get; set; }

        public string NotWorkingAvailableHoursReason { get; set; }

        public string WorkingAllAvailableHoursInd { get; set; }

    }
}
