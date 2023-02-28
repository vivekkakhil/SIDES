using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class CompanyNamesBu
    {
        public int CompanyNameId { get; set; }
        public string CompanyName { get; set; } = null!;
        public string? Description { get; set; }
    }
}
