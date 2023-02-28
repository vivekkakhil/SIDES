using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class VwMaxNoteLength
    {
        public int? Legnth { get; set; }
        public string ClaimNote { get; set; } = null!;
        public int ClaimId { get; set; }
    }
}
