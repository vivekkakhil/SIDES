﻿using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class VwAspnetProfile
    {
        public Guid UserId { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public int? DataSize { get; set; }
    }
}
