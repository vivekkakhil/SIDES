using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class ClientDocument
    {
        public int UploadId { get; set; }
        public string? UploadfileName { get; set; }
        public int? ClientId { get; set; }
    }
}
