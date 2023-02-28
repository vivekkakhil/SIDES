using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class MailLog
    {
        public int Logid { get; set; }
        public string? Subject { get; set; }
        public string? Body { get; set; }
        public DateTime? Timestamp { get; set; }
    }
}
