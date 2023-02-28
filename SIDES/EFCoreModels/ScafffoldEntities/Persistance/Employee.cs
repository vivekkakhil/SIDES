using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class Employee
    {
        public Employee()
        {
            QuestionAnswers = new HashSet<QuestionAnswer>();
        }

        public int EmployeeId { get; set; }
        public Guid EmployeeUnique { get; set; }
        public int EmployerId { get; set; }
        public string Name { get; set; } = null!;
        public string EmailId { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string ContactNo { get; set; } = null!;
        public int StatusId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? EmailDate { get; set; }
        public DateTime? PhoneDate { get; set; }
        public DateTime? LetterDate { get; set; }
        public DateTime? AttemptCompletedDate { get; set; }
        public DateTime? BillDate { get; set; }

        public virtual Employer Employer { get; set; } = null!;
        public virtual Status Status { get; set; } = null!;
        public virtual ICollection<QuestionAnswer> QuestionAnswers { get; set; }
    }
}
