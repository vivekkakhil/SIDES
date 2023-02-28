using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class VwMainstayCc
    {
        public int ClaimId { get; set; }
        public string? Ssn { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? Ccid { get; set; }
        public string? Ccnum { get; set; }
        public string? Ccname { get; set; }
        public short? RegId { get; set; }
        public string? RegNum { get; set; }
        public string? RegName { get; set; }
        public short? DisId { get; set; }
        public string? DisNum { get; set; }
        public string? DisName { get; set; }
    }
}
