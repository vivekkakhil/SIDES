using System.ComponentModel.DataAnnotations;

namespace SIDES.Enums
{
    public enum GoToNextPageEnum
    {
       
            Request = 0,

            [Display(Name = "Claimant and employer identification")]
            Claimantandemployeridentification = 1,

            [Display(Name = "Claimant Information")]
            ClaimantInformation = 2,

            [Display(Name = "Reason for Separation")]
            ReasonforSeparation = 3,

            [Display(Name = " Claimant Remuneration")]
            ClaimantRemuneration = 4,

            [Display(Name = "Claimant Discharge Details")]
            ClaimantDischargeDetails = 5,

            [Display(Name = " Prior Incident")]
            PriorIncident = 6,
            [Display(Name = "Voluntary Quit")]
            VoluntaryQuitv = 7,

            Attachments = 8,
            Preparer = 9
        
    }
}
