using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class PayrollClient
    {
        public int PayrollClientId { get; set; }
        public int? ClientId { get; set; }
        public string? Login { get; set; }
        public string? Pwd { get; set; }
        public string? Folder { get; set; }
        public string? Notes { get; set; }
    }
}
