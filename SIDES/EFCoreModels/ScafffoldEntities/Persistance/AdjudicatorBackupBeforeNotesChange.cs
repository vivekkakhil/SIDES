using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class AdjudicatorBackupBeforeNotesChange
    {
        public int AdjudicatorId { get; set; }
        public int? ClaimId { get; set; }
        public string? AdjTele { get; set; }
        public string? AdjFax { get; set; }
        public string? AdjDt { get; set; }
        public string? Doc { get; set; }
        public string? Notes { get; set; }
        public string? AdjName { get; set; }
        public string? Ssn { get; set; }
    }
}
