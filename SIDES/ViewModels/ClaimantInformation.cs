using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIDES.ViewModels
{
    public class ClaimantInformation
    {
        public SidesRequestModel SidesRequest { get; set; } 
        public int RequestForSeparationId { get; set; }
        public int WagesAvailabilityId { get; set; }  

        public int WeeksAvailableId { get; set; }
        public   List<SelectListItem> WeeksAvailable { get; set; }
        public List<SelectListItem> WasgesAvailability { get; set; }

        public string? OtherSSN { get; set; }

        [NotMapped]
        public DateOnly EmployerReportedClaimantFirstDayofWork { get; set; }

        [NotMapped]
        public DateOnly  EmployerReportedClaimantLastDayofWork { get; set; }

        [NotMapped]
        public DateOnly EffectiveSeparationDate { get; set; }

        public string? ClaimantNameWorkedAsForEmployer { get; set; }

        public string? ClaimantJobTitle { get; set; }


        public string ?SeasonalEmploymentInd { get; set; }

        public int TotalEarnedWagesNeededInd { get; set; }

        public decimal TotalEarnedWages { get; set; }

        public int TotalWeeksWorkedNeededInd { get; set; }

        public int TotalWeeksWorked { get; set; }

        public decimal WagesEarnedAfterClaimEffectiveDate { get; set; }

        public int NumberOfHoursWorkedAfterClaimEffectiveDate { get; set; }

        public decimal AverageWeeklyWage { get; set; }







    }
}
