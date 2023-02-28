using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class VwSui
    {
        public string StateCode { get; set; } = null!;
        public string StateIdnumber { get; set; } = null!;
        public string? Fein { get; set; }
        public string LegalName { get; set; } = null!;
        public string? Notes { get; set; }
        public string ClientName { get; set; } = null!;
        public string ClientNumber { get; set; } = null!;
    }
}
