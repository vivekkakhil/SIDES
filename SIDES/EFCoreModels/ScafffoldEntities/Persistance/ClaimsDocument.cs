using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class ClaimsDocument
    {
        public int Docid { get; set; }
        public string? DocumentUpload { get; set; }
        public int? ClaimId { get; set; }
        public string? SiteUrl { get; set; }
        public DateTime? DateOfEntry { get; set; }
        public string? ClientName { get; set; }
    }
}
