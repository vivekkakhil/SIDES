using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class MainDistrict
    {
        public short DistrictId { get; set; }
        public int? ClientId { get; set; }
        public string? DistrictNumber { get; set; }
        public string? DistrictDescription { get; set; }
        public string? Notes { get; set; }
    }
}
