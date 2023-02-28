using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class CompReportDetailStaging3
    {
        public string? CompanyName { get; set; }
        public int? ClaimId { get; set; }
        public decimal? PotentialLiability { get; set; }
        public decimal? LiabilityRemoved { get; set; }
        public decimal? LiabilityRemaining { get; set; }
        public decimal? TotalChargesToDate { get; set; }
        public int? NoOfHearings { get; set; }
        public int? NoOfBoardAppeals { get; set; }
        public int? Favorable { get; set; }
        public int? Unfavorable { get; set; }
        public int? NonProtestable { get; set; }
        public int? Pending { get; set; }
        public int? Suspended { get; set; }
        public string? CurClaimStatus { get; set; }
        public string? HearingDate { get; set; }
        public string? BoardAppealDate { get; set; }
    }
}
