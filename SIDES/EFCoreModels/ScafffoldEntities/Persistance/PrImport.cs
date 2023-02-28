using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class PrImport
    {
        public int Id { get; set; }
        public int? Client { get; set; }
        public string? Record { get; set; }
        public string? Filename { get; set; }
    }
}
