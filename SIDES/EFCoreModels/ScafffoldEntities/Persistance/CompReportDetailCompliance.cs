using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class CompReportDetailCompliance
    {
        public string? Category { get; set; }
        public int? NumberClaims { get; set; }
        public decimal? PotentialLiability { get; set; }
        public decimal? TotalCharges { get; set; }
    }
}
