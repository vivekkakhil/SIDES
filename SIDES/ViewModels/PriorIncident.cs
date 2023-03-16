namespace SIDES.ViewModels
{
    public class PriorIncident
    {
        
        public SidesRequestModel SidesRequest { get; set; } 

        public SidesResponseModel SidesResponse { get; set; }
        public string? PriorIncidentDate { get; set; }
        public string? PriorIncidentReason { get; set; }

        public string? PriorIncidentWarningInd { get; set; }

        public string? PriorIncidentWarningDate { get; set; }

        public string? PriorIncidentWarningDescription { get; set; }

        public string? DischargeReasonComments { get; set; }
    }
}
