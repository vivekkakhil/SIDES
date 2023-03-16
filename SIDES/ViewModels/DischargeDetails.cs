using Microsoft.AspNetCore.Mvc.Rendering;

namespace SIDES.ViewModels
{
    public class DischargeDetails
    {
        public List<SelectListItem> SIDES_DISCHARGEREASONCODE { get; set; }
        public List<SelectListItem> SIDES_DISCHARGEPOLICYAWARE { get; set; }

        public SidesRequestModel sidesRequestModel { get; set; }

        public SidesResponseModel sidesResponseModel { get; set; }

        public string? EmployerSepReasonComments { get; set; }

        public string? FinalIncidentReason { get; set; }

        public DateOnly FinalIncidentDate { get; set; }

        public string ? ViolateCompanyPolicyInd { get; set; }

        public string? DischargePolicyAwareInd { get; set; }

        public string ?WhoDischargedName { get; set; }

        public string? WhoDischargedTitle { get; set; }
    }
}
