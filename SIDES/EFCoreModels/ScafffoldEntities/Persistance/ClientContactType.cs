using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class ClientContactType
    {
        public ClientContactType()
        {
            ClientContacts = new HashSet<ClientContact>();
        }

        public short ClientContactTypeId { get; set; }
        public string ClientContactType1 { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<ClientContact> ClientContacts { get; set; }
    }
}
