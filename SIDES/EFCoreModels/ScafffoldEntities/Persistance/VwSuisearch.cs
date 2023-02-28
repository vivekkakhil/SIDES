using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class VwSuisearch
    {
        public string? CleanSui { get; set; }
        public string Sui { get; set; } = null!;
        public string Client { get; set; } = null!;
        public string ClientNumber { get; set; } = null!;
        public string Business { get; set; } = null!;
    }
}
