using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class SidesRequestforseparation
    {
        public SidesRequestforseparation()
        {
            SidesTparesponses = new HashSet<SidesTparesponse>();
        }

        public int RequestForSeparationId { get; set; }
        public int ClaimId { get; set; }
        public string StateRequestRecordGuid { get; set; } = null!;
        public string BrokerRecordTransactionNumber { get; set; } = null!;
        public int? TypeOfEmployerCodeId { get; set; }
        public int TypeOfClaimCodeId { get; set; }
        public DateTime BenefitYearBeginDate { get; set; }
        public string? ClaimantOtherLastName { get; set; }
        public string? ClaimantMiddleInitial { get; set; }
        public string? ClaimantSuffix { get; set; }
        public string? ClaimantJobTitle { get; set; }
        public int WagesWeeksNeededCodeId { get; set; }
        public DateTime? WagesNeededBeginDate { get; set; }
        public DateTime? WagesNeededEndDate { get; set; }
        public int ClaimantSepReasonCodeId { get; set; }
        public string? ClaimantSepReasonCommentsId { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime ResponseDueDate { get; set; }
        public string? FormNumber { get; set; }
        public decimal? Ssn { get; set; }
        public DateTime? ClaimEffectiveDate { get; set; }
        public string? ClaimNumber { get; set; }
        public string? StateEmployerAccountNbr { get; set; }
        public string? EmployerName { get; set; }
        public string? Fein { get; set; }
        public string? RequestingStateAbbreviation { get; set; }
        public string? ClaimantLastName { get; set; }
        public string? ClaimantFirstName { get; set; }
        public DateTime? ClaimantReportedFirstDayofWork { get; set; }
        public DateTime? ClaimantReportedLastDayofWork { get; set; }
        public string? Status { get; set; }
        public int Id { get; set; }
        public string? RecordStatus { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? UiofficeId { get; set; }

        public virtual ICollection<SidesTparesponse> SidesTparesponses { get; set; }
    }
}
