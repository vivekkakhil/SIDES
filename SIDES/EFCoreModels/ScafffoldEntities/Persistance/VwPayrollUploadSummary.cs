using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class VwPayrollUploadSummary
    {
        public string CompanyName { get; set; } = null!;
        public int? ClientId { get; set; }
        public string? FileName { get; set; }
        public int? RecordCount { get; set; }
        public DateTime? DateStamp { get; set; }
    }
}
