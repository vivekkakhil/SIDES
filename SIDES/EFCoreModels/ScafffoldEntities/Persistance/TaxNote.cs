using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class TaxNote
    {
        public int NoteId { get; set; }
        public int TaxId { get; set; }
        public string? Notes { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Tax Tax { get; set; } = null!;
    }
}
