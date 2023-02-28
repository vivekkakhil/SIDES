using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class CompReportDetailCompany
    {
        public long Id { get; set; }
        public string? CompanyName { get; set; }
        public int? NoOfClaims { get; set; }
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
    }
}
