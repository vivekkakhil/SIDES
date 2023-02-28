using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class Sepcode
    {
        public int Id { get; set; }
        public string? SepCodeNo { get; set; }
        public string? SepDisplayCode { get; set; }
        public int? CompanyId { get; set; }
    }
}
