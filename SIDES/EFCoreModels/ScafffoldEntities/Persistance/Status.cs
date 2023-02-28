using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class Status
    {
        public Status()
        {
            Employees = new HashSet<Employee>();
            Employers = new HashSet<Employer>();
        }

        public int StatusId { get; set; }
        public string StatusName { get; set; } = null!;

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Employer> Employers { get; set; }
    }
}
