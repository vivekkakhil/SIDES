using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class StateIdNumber
    {
        public short StateIdnumbersId { get; set; }
        public int ClientId { get; set; }
        public string StateCode { get; set; } = null!;
        public string StateIdnumber1 { get; set; } = null!;
        public int CompanyNameId { get; set; }
        public string? Notes { get; set; }
        public string? Fein { get; set; }
        public bool UnknownSui { get; set; }

        public virtual StateCode StateCodeNavigation { get; set; } = null!;
    }
}
