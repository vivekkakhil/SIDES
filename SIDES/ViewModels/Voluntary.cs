using Microsoft.AspNetCore.Mvc.Rendering;

namespace SIDES.ViewModels
{
    public class Voluntary
    {
        public SidesRequestModel sidesRequest { get; set; }

        public SidesResponseModel sidesResponse { get; set; }
       /// <summary>
       /// 
       /// </summary>
        public List<SelectListItem> SIDES_VOLUNTARYSEPARATION { get; set; }

        public List<SelectListItem> SIDES_HIRINGAGREEMENTCHANGES { get; set; }
       //
        public string HiringAgreementChangesComments {get;set;}

        public string ClaimantActionstoAvoidQuitInd { get;set;}

        public string ActionTakenComments { get;set;}

        public string ContinuingWorkAvailableInd { get; set; }

        public string NotWorkingAvailableHoursReason { get; set; }





    }
}
