using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class VwClientInfoForPayrollDatum
    {
        public string CompanyName { get; set; } = null!;
        public string ClientNumber { get; set; } = null!;
        public int ClientId { get; set; }
        public int CompanyNameId { get; set; }
        public int? PayrollClientId { get; set; }
        public string? Login { get; set; }
        public string? Pwd { get; set; }
        public string? Folder { get; set; }
    }
}
