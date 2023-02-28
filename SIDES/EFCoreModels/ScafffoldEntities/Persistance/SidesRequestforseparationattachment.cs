using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class SidesRequestforseparationattachment
    {
        public int AttachmentId { get; set; }
        public int RequestForSeparationId { get; set; }
        public int DescriptionOfAttachmentCodeId { get; set; }
        public string TypeOfDocument { get; set; } = null!;
        public Guid UniqueAttachmentId { get; set; }
        public int ActionableAttachmentId { get; set; }
        public decimal AttachmentSize { get; set; }
        public byte[] AttachmentData { get; set; } = null!;
        public int? Id { get; set; }
        public string? RecordStatus { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Status { get; set; }
    }
}
