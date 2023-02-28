using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class ZzPendingToWonClaim
    {
        public int Claimid { get; set; }
        public string ClaimDate { get; set; } = null!;
        public byte? CurClaimStatusId { get; set; }
    }
}
