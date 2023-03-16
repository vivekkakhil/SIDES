using SIDES.Services.UI_SIDES.DTO;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SIDES.ViewModels
{
    //public class SidesRequestModel
    //{
       
    //    public List<SidesRequests> Requests { get; set; }
    //    public int CurrentPageIndex { get; set; }
    //    public int PageCount { get; set; }
    //}

    public class SidesRequestModel
    {
        [Key]
        public int RequestForSeparationId { get; set; }

        public string ? ClaimNumber { get; set; }


        public decimal SSN { get; set; }

        [MaxLength(9)]
        public string? FEIN { get; set; }

        [MaxLength(30)]
        public string? ClaimantFirstName { get; set; }

        [MaxLength(30)]
        public string? ClaimantLastName { get; set; }

        [MaxLength(100)]
        public string? EmployerName { get; set; }

       
        public DateOnly RequestDate { get; set; }

       
        public DateOnly ResponseDueDate { get; set; }


        public string? Status { get; set; }

        public DateOnly? ClaimEffectiveDate { get; set; }

        public string? RecordStatus { get; set; }
    }




}
