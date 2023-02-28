using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class CompanyName
    {
        public CompanyName()
        {
            Clients = new HashSet<Client>();
        }

        public int CompanyNameId { get; set; }
        public string CompanyName1 { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}
