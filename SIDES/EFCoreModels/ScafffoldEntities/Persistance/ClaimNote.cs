using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class ClaimNote
    {
        public int ClaimNotesId { get; set; }
        public int ClaimId { get; set; }
        public DateTime DateOfEntry { get; set; }
        public string ClaimNote1 { get; set; } = null!;
        public string EnteredBy { get; set; } = null!;
    }
}
