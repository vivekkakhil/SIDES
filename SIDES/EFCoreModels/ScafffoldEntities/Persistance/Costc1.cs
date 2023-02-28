using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class Costc1
    {
        public int CostCenterId { get; set; }
        public string? CostCenterDescription { get; set; }
        public string? RegCc { get; set; }
        public string C1 { get; set; } = null!;
        public string C2 { get; set; } = null!;
        public string C3 { get; set; } = null!;
    }
}
