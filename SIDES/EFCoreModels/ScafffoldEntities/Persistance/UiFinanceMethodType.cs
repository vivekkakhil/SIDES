using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class UiFinanceMethodType
    {
        public byte UifinanceMethodTypeId { get; set; }
        public string UifinanceMethodType1 { get; set; } = null!;
        public string? Description { get; set; }
    }
}
