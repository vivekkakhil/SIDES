﻿using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class SidesWorkingallavailablehour
    {
        public int WorkingAllAvailableHrsId { get; set; }
        public string? WorkingAllAvailableHrsCode { get; set; }
        public string? WorkingAllAvailableHrsDesc { get; set; }
        public int? Id { get; set; }
        public string? RecordStatus { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Status { get; set; }
    }
}
