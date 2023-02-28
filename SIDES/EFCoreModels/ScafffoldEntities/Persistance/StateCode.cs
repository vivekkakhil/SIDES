using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class StateCode
    {
        public StateCode()
        {
            StateIdNumbers = new HashSet<StateIdNumber>();
        }

        public string StateCode1 { get; set; } = null!;
        public string StateName { get; set; } = null!;

        public virtual ICollection<StateIdNumber> StateIdNumbers { get; set; }
    }
}
