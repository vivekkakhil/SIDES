using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class ClientContact
    {
        public int ClientContactId { get; set; }
        public int ClientId { get; set; }
        public short ClientContactTypeId { get; set; }
        public string? ContactName { get; set; }
        public string? Title { get; set; }
        public string? Address { get; set; }
        public string? MailingAddress { get; set; }
        public string? Phone1 { get; set; }
        public string? Phone2 { get; set; }
        public string? Fax { get; set; }
        public string? Notes { get; set; }
        public string? Email { get; set; }
        public int? CurrentInvoiceTypeId { get; set; }

        public virtual ClientContactType ClientContactType { get; set; } = null!;
    }
}
