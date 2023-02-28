using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class C2
    {
        public int ClientId { get; set; }
        public string ClientNumber { get; set; } = null!;
        public int CompanyNameId { get; set; }
        public string? Dba { get; set; }
        public string? Address { get; set; }
        public string? MailingAddress { get; set; }
        public string? MainPhone { get; set; }
        public string? TollFreePhone { get; set; }
        public string? MainFax { get; set; }
        public string? Website { get; set; }
        public string? Siccode { get; set; }
        public string? ContractDate { get; set; }
        public byte? HearingsPerDiemId { get; set; }
        public string? InPersonRate { get; set; }
        public string? PhoneRate { get; set; }
        public string? OtherRate { get; set; }
        public string? RateNotes { get; set; }
        public byte? UifinanceMethodTypeId { get; set; }
        public short? NumberOfEmployees { get; set; }
        public short? UcaaccountExecutiveId { get; set; }
        public short? UcaclaimsExaminerId { get; set; }
        public short? UcahearingCoordinatorId { get; set; }
        public short? UcataxAuditorId { get; set; }
        public string? InitialInstructions { get; set; }
        public string? HearingInstructions { get; set; }
        public string? BoardInstructions { get; set; }
        public byte? ReportFreqId { get; set; }
        public string? ReportNotes { get; set; }
        public string? DrivingDirections { get; set; }
        public bool? Status { get; set; }
        public string? ClosingInstructions { get; set; }
    }
}
