using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class ClientAnalyst
    {
        public int ClientAnalystId { get; set; }
        public int ClientId { get; set; }
        public Guid AnalystId { get; set; }
    }
}
