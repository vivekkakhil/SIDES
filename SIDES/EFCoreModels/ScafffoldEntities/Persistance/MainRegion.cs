using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class MainRegion
    {
        public short RegionId { get; set; }
        public int? ClientId { get; set; }
        public short? DistrictId { get; set; }
        public string? RegionNumber { get; set; }
        public string? RegionDescription { get; set; }
        public string? Notes { get; set; }
    }
}
