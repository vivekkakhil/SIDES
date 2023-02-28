using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class Uioffice
    {
        public int UiofficeId { get; set; }
        public string? UiofficeName { get; set; }
        public string? UiofficePhone { get; set; }
        public string? UiofficeFax { get; set; }
    }
}
