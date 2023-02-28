using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class Employer
    {
        public Employer()
        {
            Employees = new HashSet<Employee>();
        }

        public int EmployerId { get; set; }
        public Guid EmployerUnique { get; set; }
        public string CompanyName { get; set; } = null!;
        public string EmailId { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string ContactNo { get; set; } = null!;
        public int StatusId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? StartDate { get; set; }
        public string? Contact { get; set; }
        public string? FeeStructure { get; set; }
        public string? Procedure { get; set; }

        public virtual Status Status { get; set; } = null!;
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
