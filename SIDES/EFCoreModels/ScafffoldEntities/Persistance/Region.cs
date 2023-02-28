using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class Region
    {
        public Region()
        {
            CostCenters = new HashSet<CostCenter>();
        }

        public short RegionId { get; set; }
        public int? ClientId { get; set; }
        public short? DistrictId { get; set; }
        public string? RegionNumber { get; set; }
        public string? RegionDescription { get; set; }
        public string? Notes { get; set; }

        public virtual District? District { get; set; }
        public virtual ICollection<CostCenter> CostCenters { get; set; }
    }
}
