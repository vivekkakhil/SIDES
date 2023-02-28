using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class CompReportSummary
    {
        public string? Client { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? TotalClaims { get; set; }
        public int? ProtestableClaims { get; set; }
        public int? NonProtestableClaims { get; set; }
        public int? FavorableClaims { get; set; }
        public int? UnfavorableClaims { get; set; }
        public decimal? ProtestableToTotal { get; set; }
        public int? PendingClaims { get; set; }
        public decimal? PendingToProtestable { get; set; }
        public decimal? WinRatioProtestable { get; set; }
        public int? Hearings { get; set; }
        public int? BoardAppeals { get; set; }
        public decimal? PotentialLiability { get; set; }
        public decimal? LiabilityRemoved { get; set; }
        public decimal? LiabilityRemaining { get; set; }
        public decimal? TotalCharges { get; set; }
        public decimal? TotalCredits { get; set; }
    }
}
