using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class ClaimsMsOld
    {
        public int? ClaimId { get; set; }
        public int? ClientId { get; set; }
        public short? StateIdnumbersId { get; set; }
        public int? CostCenterId { get; set; }
        public string? CostCenter { get; set; }
        public byte? CurClaimStatusId { get; set; }
        public string? ClaimDate { get; set; }
        public string? ClaimState { get; set; }
        public short? SeparationCodeId { get; set; }
        public short? SeparationReasonId { get; set; }
        public byte? InitialDecisionId { get; set; }
        public byte? HearingDecisionId { get; set; }
        public int? HearingRepId { get; set; }
        public byte? BoardDecisionId { get; set; }
        public int? BoardRepId { get; set; }
        public decimal? PotentialBenefitCharge { get; set; }
        public string? ClaimTypeId { get; set; }
        public string? Bye { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Ssn { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? RevisedDate { get; set; }
        public string? RevisedBy { get; set; }
        public decimal? TotalBenefitCharges { get; set; }
        public decimal? TotalCredits { get; set; }
        public DateTime? PeriodEndingDate { get; set; }
    }
}
