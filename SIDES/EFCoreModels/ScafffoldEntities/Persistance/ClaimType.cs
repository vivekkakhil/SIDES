using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class ClaimType
    {
        public string ClaimTypeId { get; set; } = null!;
        public string? ClaimType1 { get; set; }
        public string? Description { get; set; }
    }
}
