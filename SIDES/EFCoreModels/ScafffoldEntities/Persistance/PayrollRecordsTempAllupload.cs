using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class PayrollRecordsTempAllupload
    {
        public int? ClientId { get; set; }
        public string? Fein { get; set; }
        public string? Ssn { get; set; }
        public string? Mname { get; set; }
        public string? Lname { get; set; }
        public string? EmpTitle { get; set; }
        public string? DateOfBirth { get; set; }
        public string? EmpStatus { get; set; }
        public string? State { get; set; }
        public string? MrhireDate { get; set; }
        public string? OsepDate { get; set; }
        public string? JobTitle { get; set; }
        public string? CurrentSupervisor { get; set; }
        public string? EmployeeId { get; set; }
        public string? EmpAddress1 { get; set; }
        public string? EmpAddress2 { get; set; }
        public string? EmpCity { get; set; }
        public string? EmpState { get; set; }
        public string? EmpZipCode { get; set; }
        public string? EmpPhone { get; set; }
        public string? Tm { get; set; }
        public string? LastDay { get; set; }
        public string? PayFreqCode { get; set; }
        public string? PayTypeCode { get; set; }
        public string? Hours { get; set; }
        public string? ActionReason { get; set; }
        public string? DeptDesc { get; set; }
        public int? CoreRptId { get; set; }
        public string? CoreRpt { get; set; }
        public int? BuCode { get; set; }
        public string? BusinessUnitDesc { get; set; }
        public int? SlCode { get; set; }
        public string? SupervisorLevelDesc { get; set; }
        public string? FileName { get; set; }
        public string? LocCode { get; set; }
        public string? SepCode { get; set; }
        public string? PayrollDate { get; set; }
        public string? Finitial { get; set; }
        public decimal? Wages { get; set; }
    }
}
