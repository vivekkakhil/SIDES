﻿using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class CompReportDetail
    {
        public int? ClientId { get; set; }
        public string? ClientNumber { get; set; }
        public string? CompanyName { get; set; }
        public int? ClaimId { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Ssn { get; set; }
        public decimal? PotentialBenefitCharge { get; set; }
        public decimal? LiabilityRemoved { get; set; }
        public string? CostCenterNumber { get; set; }
        public string? CostCenterDescription { get; set; }
        public string? RegionNumber { get; set; }
        public string? RegionDescription { get; set; }
        public string? DistrictNumber { get; set; }
        public string? DistrictDescription { get; set; }
        public string? ClaimDate { get; set; }
        public string? Byedate { get; set; }
        public string? HireDate { get; set; }
        public string? LastDayWorked { get; set; }
        public string? SeparationCode { get; set; }
        public string? SepCodeDescr { get; set; }
        public string? SeparationReason { get; set; }
        public string? CurClaimStatus { get; set; }
        public string? HearingDate { get; set; }
        public string? HearingDecision { get; set; }
        public string? BoardAppealDate { get; set; }
        public string? BoardDecision { get; set; }
        public decimal? TotalBenCharges { get; set; }
        public DateTime? BenChargesPaidDate { get; set; }
        public decimal? RemainingBenCharges { get; set; }
    }
}
