using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class ClaimsZz
    {
        public string? Ssn { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? ClaimDate { get; set; }
        public decimal? TotalCredits { get; set; }
    }
}
