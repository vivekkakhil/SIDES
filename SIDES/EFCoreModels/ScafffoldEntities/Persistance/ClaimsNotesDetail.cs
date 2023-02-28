using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class ClaimsNotesDetail
    {
        public int NotesId { get; set; }
        public int? ClaimId { get; set; }
        public string? NotesDescription { get; set; }
        public DateTime DateOfEntry { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? ClientName { get; set; }
    }
}
