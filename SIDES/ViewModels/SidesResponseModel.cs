using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SIDES.Services.UI_SIDES.DTO;

namespace SIDES.ViewModels
{
    public class SidesResponseModel
    {
        [Key]
        public int RequestForSeparationId { get; set; }
        public string ClaimNumber { get; set; }
        public Decimal? SSN { get; set; }

        [MaxLength(9)]
        public string FEIN { get; set; }

        [MaxLength(30)]
        public string ClaimantFirstName { get; set; }

        [MaxLength(30)]
        public string ClaimantLastName { get; set; }

        [MaxLength(100)]

        public string EmployerName { get; set; } //need to check the fein type

        [NotMapped]
        public DateOnly RequestDate { get; set; }//need to check the fein type

        [NotMapped]
        public DateOnly ResponseDueDate { get; set; }   //need to check the fein type

        public string Status { get; set; }


        public DateOnly ClaimEffectiveDate { get; set; }

        [MaxLength(2)]
        public string RequestingStateAbbreviation { get; set; }

        public string ClaimantOtherLastName { get; set; }

        [MaxLength(20)]
        public string StateEmployerAccountNbr { get; set; }

        //commented for now
        //   public GoToNextPageEnum? goToNextPageenum { get; set; }

        //Currresponse fields

        public int EmployerSepReasonCode { get; set; }

        [MaxLength(50)]
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string RecordStatus { get; set; }

        public ClaimantUIOffice ClaimantUIOffice { get; set; }



        // [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "only alphabet are allowed")]

        

        public string CorrectedEmployerName { get; set; }


        
      // [RegularExpression(@"^[0-9]*$", ErrorMessage = "SEIN must be numeric")]
        public string CorrectedStateEmployerAccountNbr { get; set; }

        
       // [RegularExpression(@"^[0-9]*$", ErrorMessage = "FEIN must be numeric")]
        public string CorrectedFEIN { get; set; }

       // public GoToNextPageEnum GoToNextpage { get; set; }

        public SidesRequestModel sidesRequest { get; set; }



    }
}
