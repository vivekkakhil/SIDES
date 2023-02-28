using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class SidesTparesponseattachment
    {
        public int TparesponseAttachmentId { get; set; }
        public int? DescriptionOfAttachmentCode { get; set; }
        public string? TypeofDocument { get; set; }
        public string? UniqueAttachmentId { get; set; }
        public long? AttachmentSize { get; set; }
        public byte[]? AttachmentData { get; set; }
        public int TparesponseId { get; set; }
        public string? ContentType { get; set; }

        public virtual SidesTparesponse Tparesponse { get; set; } = null!;
    }
}
