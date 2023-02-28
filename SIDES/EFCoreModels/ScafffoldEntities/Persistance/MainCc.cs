using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class MainCc
    {
        public int CostCenterId { get; set; }
        public int? ClientId { get; set; }
        public short? RegionId { get; set; }
        public string? CostCenterNumber { get; set; }
        public string? CostCenterDescription { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Notes { get; set; }
        public string? Fax { get; set; }
    }
}
