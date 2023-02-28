using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class SeparationCode
    {
        public SeparationCode()
        {
            SeparationReasons = new HashSet<SeparationReason>();
        }

        public short SeparationCodeId { get; set; }
        public string? SeparationCode1 { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<SeparationReason> SeparationReasons { get; set; }
    }
}
