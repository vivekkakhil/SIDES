using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class BenefitCharge
    {
        public int BenefitChargesId { get; set; }
        public int ClaimId { get; set; }
        public DateTime DateOfCharge { get; set; }
        public decimal Charges { get; set; }
        public string? Notes { get; set; }
        public DateTime PeriodEndingDate { get; set; }
    }
}
