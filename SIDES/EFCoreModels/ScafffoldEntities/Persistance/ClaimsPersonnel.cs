using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class ClaimsPersonnel
    {
        public short ClaimsPersonnelId { get; set; }
        public short? EmployeeId { get; set; }
        public string? Name { get; set; }
        public string? EmployeeStatus { get; set; }
        public string? Notes { get; set; }
        public string? AnalystEmailId { get; set; }
    }
}
