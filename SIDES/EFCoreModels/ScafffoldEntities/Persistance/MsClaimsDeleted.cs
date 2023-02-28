using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class MsClaimsDeleted
    {
        public int ClaimId { get; set; }
        public int? ClaimNumber { get; set; }
        public int ClientId { get; set; }
        public short? StateIdnumbersId { get; set; }
        public int? CostCenterId { get; set; }
        public int? ClaimantId { get; set; }
        public string HireDate { get; set; } = null!;
        public string LastDayWorked { get; set; } = null!;
        public byte? CurClaimStatusId { get; set; }
        public string ClaimDate { get; set; } = null!;
        public string? ClaimState { get; set; }
        public short? SeparationCodeId { get; set; }
        public short? SeparationReasonId { get; set; }
        public byte InitialDecisionId { get; set; }
        public string InitialDecisionDate { get; set; } = null!;
        public byte HearingDecisionId { get; set; }
        public string HearingDecisionDate { get; set; } = null!;
        public int? HearingRepId { get; set; }
        public string HearingDate { get; set; } = null!;
        public byte BoardDecisionId { get; set; }
        public string BoardDecisionDate { get; set; } = null!;
        public int? BoardRepId { get; set; }
        public string BoardAppealDate { get; set; } = null!;
        public decimal? PotentialBenefitCharge { get; set; }
        public string? ClaimTypeId { get; set; }
        public bool Protestable { get; set; }
        public string ProtestOfChargesDate { get; set; } = null!;
        public string Bye { get; set; } = null!;
        public short? HearingAppellantId { get; set; }
        public short? BoardAppellantId { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Ssn { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime RevisedDate { get; set; }
        public string RevisedBy { get; set; } = null!;
    }
}
