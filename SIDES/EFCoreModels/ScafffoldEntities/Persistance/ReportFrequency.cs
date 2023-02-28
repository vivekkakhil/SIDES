using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class ReportFrequency
    {
        public byte ReportFreqId { get; set; }
        public string? ReportFreq { get; set; }
        public string? Notes { get; set; }
    }
}
