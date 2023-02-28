using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class SidesDischargepolicyaware
    {
        public int DischargePolicyAwareId { get; set; }
        public string DischargePolicyAwareCode { get; set; } = null!;
        public string? DischargePolicyAwareDesc { get; set; }
        public int? Id { get; set; }
        public string? RecordStatus { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Status { get; set; }
    }
}
