using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class ReportDetailSeparationWhg
    {
        public string? SeparationCode { get; set; }
        public string? SeparationReason { get; set; }
        public string? NoOfClaims { get; set; }
        public string? PotentialLiability { get; set; }
        public string? LiabilityRemoved { get; set; }
        public string? LiabilityRemaining { get; set; }
        public string? TotalChargesToDate { get; set; }
        public string? NoOfHearings { get; set; }
        public string? NoOfBoardAppeals { get; set; }
        public string? Favorable { get; set; }
        public string? Unfavorable { get; set; }
        public string? NonProtestable { get; set; }
        public string? Pending { get; set; }
        public string? Suspended { get; set; }
    }
}
