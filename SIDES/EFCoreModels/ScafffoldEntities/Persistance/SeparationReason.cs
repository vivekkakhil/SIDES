using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    /// <summary>
    /// Subset of SEPARATION_CODES.  Each Code will have 1 or more reasons.
    /// </summary>
    public partial class SeparationReason
    {
        public short SeparationReasonId { get; set; }
        public short? SeparationCodeId { get; set; }
        public string? SeparationReason1 { get; set; }
        public string? PossStatusCode { get; set; }
        public string? SepCodeText { get; set; }
        public string? PossCodes { get; set; }
        public string? Notes { get; set; }

        public virtual SeparationCode? SeparationCode { get; set; }
    }
}
