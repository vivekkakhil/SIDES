namespace SIDES.ViewModels
{
    public class EmployerTPASeparationResponse
    {
        public EmployerTPASeparationResponse()
        {
                
        }

        public string StateRequestRecordGUID { get; set; }

        public string BrokerRecordTransactionNumber { get; set; }

        public Decimal SSN { get; set; }

        public string ClaimEffectiveDate { get; set; }

        public string ClaimNumber { get; set; }

        public string StateEmployerAccountNbr { get; set; }

        public string EmployerName { get; set; }

        public string CorrectedEmployerName { get; set; }

        public string CorrectedStateEmployerAccountNbr { get; set; }

        public string CorrectedFEIN { get; set; }

        public string OtherSSN { get; set; }

        public string ClaimantNameWorkedAsForEmployer { get; set; }

        public string ClaimantLastName { get; set; }

        public string ClaimantFirstName { get; set; }

        public string ClaimantMiddleInitial { get; set; }

        public string ClaimantSuffix { get; set; }

        public string ClaimantJobTitle { get; set; }

        public string SeasonalEmploymentInd { get; set; }

        public string EmployerReportedClaimantFirstDayofWork { get; set; }

        public string EmployerReportedClaimantLastDayofWork { get; set; }

        public string EffectiveSeparationDate { get; set; }

        public int? TotalEarnedWagesNeededInd { get; set; }

        public Decimal? TotalEarnedWages { get; set; }

        public int? TotalWeeksWorkedNeededInd { get; set; }

        public int? TotalWeeksWorked { get; set; }

        public Decimal? WagesEarnedAfterClaimEffectiveDate { get; set; }

        public int? NumberOfHoursWorkedAfterClaimEffectiveDate { get; set; }

        public Decimal? AverageWeeklyWage { get; set; }

        public int? EmployerSepReasonCode { get; set; }

        public string ReturnToWorkInd { get; set; }

        public string ReturnToWorkDate { get; set; }

        public string WorkingAllAvailableHoursInd { get; set; }

        public string NotWorkingAvailableHoursReason { get; set; }

        public string LaborDisputeTypeInd { get; set; }

        public Remuneration Remuneration { get; set; }

        public int? AverageNumberofHoursWorkedperWeek { get; set; }

        public string MandatoryRetirementInd { get; set; }

        public string MandatoryPension { get; set; }

        public string ContributoryorNotContributoryClaimantInd { get; set; }

        public int? ClaimantPensionContributionPercent { get; set; }

        public string PensionComments { get; set; }

        public string EmployerSepReasonComments { get; set; }

        public int? DischargeReasonCode { get; set; }

        public string FinalIncidentReason { get; set; }

        public string FinalIncidentDate { get; set; }

        public string ViolateCompanyPolicyInd { get; set; }

        public string DischargePolicyAwareInd { get; set; }

        public string DischargePolicyAwareExplanationCode { get; set; }

        public PriorIncident PriorIncidentOccurrence { get; set; }

        public string WhoDischargedName { get; set; }

        public string WhoDischargedTitle { get; set; }

        public string DischargeReasonComments { get; set; }

        public int? VoluntarySepReasonCode { get; set; }

        public int HiringAgreementChangesCode { get; set; }

        public string HiringAgreementChangesComments { get; set; }

        public string ClaimantActionsToAvoidQuitInd { get; set; }

        public string ActionTakenComments { get; set; }

        public string ContinuingWorkAvailableInd { get; set; }

        public string VoluntarySepReasonComments { get; set; }

        public AttachmentResponse AttachmentOccurrence { get; set; }

        public string PreparerTypeCode { get; set; }

        public string PreparerCompanyName { get; set; }

        public string PreparerTelephoneNumberPlusExt { get; set; }

        public string PreparerContactName { get; set; }

        public string PreparerTitle { get; set; }

        public string PreparerFaxNbr { get; set; }

        public string PreparerEmailAddress { get; set; }

        public int? AmendedResponse { get; set; }

        public string AmendedResponseDescription { get; set; }


    }
}
