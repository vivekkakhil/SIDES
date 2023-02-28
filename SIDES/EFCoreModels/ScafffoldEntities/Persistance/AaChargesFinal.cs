using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class AaChargesFinal
    {
        public int? ClaimId { get; set; }
        public int? CostCenterId { get; set; }
        public string? Ssn { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? SeparationReason { get; set; }
        public decimal? Potential { get; set; }
        public decimal? Current { get; set; }
        public decimal? Total { get; set; }
        public decimal? Remaining { get; set; }
        public string? ClaimDate { get; set; }
        public string? Decision { get; set; }
    }
}
