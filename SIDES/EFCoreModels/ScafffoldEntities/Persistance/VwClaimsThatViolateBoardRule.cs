using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class VwClaimsThatViolateBoardRule
    {
        public int ClaimId { get; set; }
        public string BoardAppealDate { get; set; } = null!;
        public byte BoardDecisionId { get; set; }
        public short? BoardAppellantId { get; set; }
    }
}
