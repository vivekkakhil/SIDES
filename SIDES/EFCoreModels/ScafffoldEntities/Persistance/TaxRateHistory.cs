using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class TaxRateHistory
    {
        public int RateHistoryId { get; set; }
        public int TaxId { get; set; }
        public long? Year { get; set; }
        public string? Percentage { get; set; }
        public string? Note { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? InsertedDate { get; set; }
        public int? Updatedby { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Tax Tax { get; set; } = null!;
    }
}
