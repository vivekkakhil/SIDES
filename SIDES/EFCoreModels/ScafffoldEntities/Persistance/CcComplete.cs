using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class CcComplete
    {
        public int CostCenterId { get; set; }
        public string? CostCenterNumber { get; set; }
        public string? CostCenterDescription { get; set; }
        public short? RegionId { get; set; }
        public string? RegionNumber { get; set; }
        public string? RegionDescription { get; set; }
        public short? DistrictId { get; set; }
        public string? DistrictNumber { get; set; }
        public string? DistrictDescription { get; set; }
        public string? RegCc { get; set; }
        public int? LocationId { get; set; }
    }
}
