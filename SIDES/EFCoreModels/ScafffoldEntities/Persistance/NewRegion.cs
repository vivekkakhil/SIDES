using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class NewRegion
    {
        public string? Reg { get; set; }
        public int DistrictId { get; set; }
        public int ClientId { get; set; }
        public int? RegId { get; set; }
    }
}
