using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class ClientDba
    {
        public int ClientDbaid { get; set; }
        public int? ClientId { get; set; }
        public string? Dba { get; set; }
        public string? Notes { get; set; }
    }
}
