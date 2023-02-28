using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class Letter
    {
        public int LetterId { get; set; }
        public int ClaimId { get; set; }
        public string? LetterType { get; set; }
        public string? MailTo { get; set; }
        public string? Addr1 { get; set; }
        public string? Addr2 { get; set; }
        public string? Fax { get; set; }
        public DateTime? DateCreated { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? LetterDate { get; set; }
        public string? LetterText { get; set; }
    }
}
