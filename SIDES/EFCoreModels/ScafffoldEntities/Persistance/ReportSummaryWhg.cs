using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class ReportSummaryWhg
    {
        public string? Client { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public short? TotalClaims { get; set; }
        public short? ProtestableClaims { get; set; }
        public short? NonProtestableClaims { get; set; }
        public short? FavorableClaims { get; set; }
        public short? UnfavorableClaims { get; set; }
        public decimal? ProtestableToTotal { get; set; }
        public short? PendingClaims { get; set; }
        public decimal? PendingToProtestable { get; set; }
        public decimal? WinRatioProtestable { get; set; }
        public short? Hearings { get; set; }
        public short? BoardAppeals { get; set; }
        public decimal? PotentialLiability { get; set; }
        public decimal? LiabilityRemoved { get; set; }
        public decimal? LiabilityRemaining { get; set; }
        public decimal? TotalCharges { get; set; }
        public decimal? TotalCredits { get; set; }
        public short? HemployerAppeals { get; set; }
        public short? HclaimantAppeals { get; set; }
        public short? BemployerAppeals { get; set; }
        public short? BclaimantAppeals { get; set; }
        public short? Hdfavorable { get; set; }
        public short? Hdunfavorable { get; set; }
        public short? Hdpending { get; set; }
        public short? Bdfavorable { get; set; }
        public short? Bdunfavorable { get; set; }
        public short? Bdpending { get; set; }
    }
}
