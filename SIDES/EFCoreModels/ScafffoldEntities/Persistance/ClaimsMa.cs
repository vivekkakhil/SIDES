using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class ClaimsMa
    {
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Ssn { get; set; }
        public string? CostCenter { get; set; }
        public string? ClaimDate { get; set; }
        public decimal? TotalBenefitCharges { get; set; }
        public decimal? TotalCredits { get; set; }
        public string? Fixneeded { get; set; }
        public int? ClaimId { get; set; }
    }
}
