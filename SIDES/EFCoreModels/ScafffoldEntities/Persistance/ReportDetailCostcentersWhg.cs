using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class ReportDetailCostcentersWhg
    {
        public long Id { get; set; }
        public string? DistrictDescription { get; set; }
        public string? RegionDescription { get; set; }
        public string? CostCenterDescription { get; set; }
        public int? NoOfClaims { get; set; }
        public decimal? PotentialLiability { get; set; }
        public decimal? LiabilityRemoved { get; set; }
        public decimal? LiabilityRemaining { get; set; }
        public decimal? TotalChargesToDate { get; set; }
        public short? NoOfHearings { get; set; }
        public short? NoOfBoardAppeals { get; set; }
        public short? Favorable { get; set; }
        public short? Unfavorable { get; set; }
        public short? NonProtestable { get; set; }
        public short? Pending { get; set; }
        public short? Suspended { get; set; }
    }
}
