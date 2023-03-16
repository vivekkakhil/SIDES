using Microsoft.AspNetCore.Mvc.Rendering;

namespace SIDES.ViewModels
{
    public class Remuneration
    {

        public SidesRequestModel SidesRequest { get; set; }
        
        public SidesResponseModel sidesResponse { get; set; }
        public List<SelectListItem> SIDES_REMUNERATION { get; set; }

        public List<SelectListItem> SIDES_REMUNERATIONFREQUENCY { get; set; }

        public string? RemunerationPeriodFrequencyCode { get; set; }


        public int RemunerationTypeCode { get; set; }

        public Decimal RemunerationAmountPerPeriod { get; set; }
        public string? DateRemunerationIssued { get; set; }

        public string? AllocationBeginDate { get; set; }

        public string? AllocationEndDate { get; set; }

        public int AverageNumberofHoursWorkedperWeek { get; set; }

        public int ClaimantPensionContributionPercent { get; set; }

        public string? PensionComments { get; set; }
        
        public string? ContributoryorNotContributoryClaimantInd { get; set; }

        public string? MandatoryPension { get; set; }
        
        public string? MandatoryRetirementInd { get; set; }

        public string? EmployerAllocationInd { get; set; }


    }
}
