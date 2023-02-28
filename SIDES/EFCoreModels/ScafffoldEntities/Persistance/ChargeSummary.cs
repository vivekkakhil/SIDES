using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class ChargeSummary
    {
        public string? TotalPotential { get; set; }
        public string? TotalCurrent { get; set; }
        public string? TotaltoDate { get; set; }
        public string? TotalRemaining { get; set; }
    }
}
