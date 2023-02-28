using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class VwLongestRegionName
    {
        public int? Legnth { get; set; }
        public string? RegionDescription { get; set; }
        public short RegionId { get; set; }
        public int? ClientId { get; set; }
    }
}
