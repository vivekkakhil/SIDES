using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class ReportDetailComplianceWhg
    {
        public string? Category { get; set; }
        public short? NumberClaims { get; set; }
        public decimal? PotentialLiability { get; set; }
        public decimal? TotalCharges { get; set; }
    }
}
