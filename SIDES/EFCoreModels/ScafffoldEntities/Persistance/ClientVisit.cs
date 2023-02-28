using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class ClientVisit
    {
        public int ClientVisitId { get; set; }
        public int? ClientId { get; set; }
        public string? Employee { get; set; }
        public string? Service { get; set; }
        public string? Report { get; set; }
        public DateTime? VisitDate { get; set; }
        public string? Attendees { get; set; }
        public string? Notes { get; set; }
    }
}
