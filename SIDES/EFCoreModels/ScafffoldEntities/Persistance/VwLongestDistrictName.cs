using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class VwLongestDistrictName
    {
        public int? Legnth { get; set; }
        public string? DistrictDescription { get; set; }
        public short DistrictId { get; set; }
        public int? ClientId { get; set; }
    }
}
