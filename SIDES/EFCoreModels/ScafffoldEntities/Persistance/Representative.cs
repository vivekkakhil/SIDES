using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class Representative
    {
        public int RepresentativeId { get; set; }
        public string LastName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public string? Rate1 { get; set; }
        public string? Rate1Description { get; set; }
        public string? Rate2 { get; set; }
        public string? Rate2Description { get; set; }
        public string? Rate3 { get; set; }
        public string? Rate3Description { get; set; }
        public string? Notes { get; set; }
        public string? Fax { get; set; }
        public string? StateCode { get; set; }
    }
}
