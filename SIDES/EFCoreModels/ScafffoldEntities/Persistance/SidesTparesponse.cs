using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class SidesTparesponse
    {
        public SidesTparesponse()
        {
            SidesTparesponseattachments = new HashSet<SidesTparesponseattachment>();
        }

        public int TparesponseId { get; set; }
        public int RequestForSeparationId { get; set; }
        public string? CorrectedEmployerName { get; set; }
        public string? CorrectedStateEmployerAccountNbr { get; set; }
        public string? CorrectedFein { get; set; }
        public string? OtherSsn { get; set; }
        public string? ClaimantNameWorkedAsForEmployer { get; set; }
        public string? ClaimantJobTitle { get; set; }
        public string? SeasonalEmploymentInd { get; set; }
        public DateTime? EmployerReportedClaimantFirstDayofWork { get; set; }
        public DateTime? EmployerReportedClaimantLastDayofWork { get; set; }
        public DateTime? EffectiveSeparationDate { get; set; }
        public int? TotalEarnedWagesNeededInd { get; set; }
        public decimal? TotalEarnedWages { get; set; }
        public int? TotalWeeksWorkedNeededInd { get; set; }
        public int? TotalWeeksWorked { get; set; }
        public decimal? WagesEarnedAfterClaimEffectiveDate { get; set; }
        public int? NumberOfHoursWorkedAfterClaimEffectiveDate { get; set; }
        public decimal? AverageWeeklyWage { get; set; }
        public int? EmployerSepReasonCode { get; set; }
        public string? ReturnToWorkInd { get; set; }
        public DateTime? ReturnToWorkDate { get; set; }
        public string? WorkingAllAvailableHoursInd { get; set; }
        public string? NotWorkingAvailableHoursReason { get; set; }
        public string? LaborDisputeTypeInd { get; set; }
        public int? RemunerationTypeCode { get; set; }
        public decimal? RemunerationAmountPerPeriod { get; set; }
        public string? RemunerationPeriodFrequencyCode { get; set; }
        public DateTime? DateRemunerationIssued { get; set; }
        public string? EmployerAllocationInd { get; set; }
        public DateTime? AllocationBeginDate { get; set; }
        public DateTime? AllocationEndDate { get; set; }
        public int? AverageNumberofHoursWorkedperWeek { get; set; }
        public string? MandatoryRetirementInd { get; set; }
        public string? MandatoryPension { get; set; }
        public string? ContributoryorNotContributoryClaimantInd { get; set; }
        public int? ClaimantPensionContributionPercent { get; set; }
        public string? PensionComments { get; set; }
        public string? EmployerSepReasonComments { get; set; }
        public int? DischargeReasonCode { get; set; }
        public string? FinalIncidentReason { get; set; }
        public DateTime? FinalIncidentDate { get; set; }
        public string? ViolateCompanyPolicyInd { get; set; }
        public string? DischargePolicyAwareInd { get; set; }
        public string? DischargePolicyAwareExplanationCode { get; set; }
        public DateTime? PriorIncidentDate { get; set; }
        public string? PriorIncidentReason { get; set; }
        public string? PriorIncidentWarningInd { get; set; }
        public DateTime? PriorIncidentWarningDate { get; set; }
        public string? PriorIncidentWarningDescription { get; set; }
        public string? WhoDischargedName { get; set; }
        public string? WhoDischargedTitle { get; set; }
        public string? DischargeReasonComments { get; set; }
        public int? VoluntarySepReasonCode { get; set; }
        public int? HiringAgreementChangesCode { get; set; }
        public string? HiringAgreementChangesComments { get; set; }
        public string? ClaimantActionstoAvoidQuitInd { get; set; }
        public string? ActionTakenComments { get; set; }
        public string? ContinuingWorkAvailableInd { get; set; }
        public string? VoluntarySepReasonComments { get; set; }
        public string? PreparerTypeCode { get; set; }
        public string? PreparerCompanyName { get; set; }
        public string? PreparerTelephoneNumberPlusExt { get; set; }
        public string? PreparerContactName { get; set; }
        public string? PreparerTitle { get; set; }
        public string? PreparerFaxNbr { get; set; }
        public string? PreparerEmailAddress { get; set; }
        public int? AmendedResponse { get; set; }
        public string? AmendedResponseDescription { get; set; }
        public string? Status { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual SidesRequestforseparation RequestForSeparation { get; set; } = null!;
        public virtual ICollection<SidesTparesponseattachment> SidesTparesponseattachments { get; set; }
    }
}
