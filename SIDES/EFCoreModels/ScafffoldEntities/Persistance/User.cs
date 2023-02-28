using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class User
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Pwd { get; set; }
        public string? Type { get; set; }
        public string? IsActive { get; set; }
        public string? ClientNo { get; set; }
        public int? ClientId { get; set; }
        public string? RestrictedRegionNumber { get; set; }
    }
}
