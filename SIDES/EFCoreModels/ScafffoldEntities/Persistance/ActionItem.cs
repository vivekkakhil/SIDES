using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class ActionItem
    {
        public int ActionItemId { get; set; }
        public int? ClientVisitId { get; set; }
        public int? ClientId { get; set; }
        public string? ActionItem1 { get; set; }
        public DateTime? DueDate { get; set; }
        public string? Completed { get; set; }
        public string? Notes { get; set; }
    }
}
