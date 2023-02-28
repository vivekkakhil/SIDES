using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class ClaimsDeleted
    {
        public int ClaimId { get; set; }
        public string? ClaimNumber { get; set; }
        public int ClientId { get; set; }
        public short? StateIdnumbersId { get; set; }
        public int? CostCenterId { get; set; }
        public int? ClaimantId { get; set; }
        public string? HireDate { get; set; }
        public string? LastDayWorked { get; set; }
        public byte? CurClaimStatusId { get; set; }
        public string? ClaimDate { get; set; }
        public string? ClaimState { get; set; }
        public short? SeparationCodeId { get; set; }
        public short? SeparationReasonId { get; set; }
        public byte? InitialDecisionId { get; set; }
        public string? InitialDecisionDate { get; set; }
        public byte? HearingDecisionId { get; set; }
        public string? HearingDecisionDate { get; set; }
        public int? HearingRepId { get; set; }
        public string? HearingDate { get; set; }
        public byte? BoardDecisionId { get; set; }
        public string? BoardDecisionDate { get; set; }
        public int? BoardRepId { get; set; }
        public string? BoardAppealDate { get; set; }
        public decimal? PotentialBenefitCharge { get; set; }
        public string? ClaimTypeId { get; set; }
        public bool? Protestable { get; set; }
        public string? ProtestOfChargesDate { get; set; }
        public string? Bye { get; set; }
        public short? HearingAppellantId { get; set; }
        public short? BoardAppellantId { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Ssn { get; set; }
        public string? DelReason { get; set; }
        public DateTime? DelDate { get; set; }
    }
}
