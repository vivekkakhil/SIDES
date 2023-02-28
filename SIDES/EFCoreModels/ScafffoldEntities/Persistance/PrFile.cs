using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class PrFile
    {
        public int Id { get; set; }
        public string FileName { get; set; } = null!;
    }
}
