using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class Decision
    {
        public byte DecisionId { get; set; }
        public string? Decision1 { get; set; }
        public string? Description { get; set; }
    }
}
