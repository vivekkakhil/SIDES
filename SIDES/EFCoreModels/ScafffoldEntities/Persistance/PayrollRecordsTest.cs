using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class PayrollRecordsTest
    {
        public int PayrollRecordId { get; set; }
        public int? ClientId { get; set; }
        public string? Fein { get; set; }
        public string? Space1 { get; set; }
        public string? Ssn { get; set; }
        public string? Lname { get; set; }
        public string? Finitial { get; set; }
        public string? State { get; set; }
        public string? LocCode { get; set; }
        public string? PayFreqCode { get; set; }
        public string? PayTypeCode { get; set; }
        public int? PayrollDate { get; set; }
        public decimal? Wages { get; set; }
        public string? Nww { get; set; }
        public string? Hours { get; set; }
        public string? Tm { get; set; }
        public string? SepCode { get; set; }
        public int? LastDay { get; set; }
        public int? FirstDay { get; set; }
        public short? Pryear { get; set; }
        public string? FileName { get; set; }
        public DateTime? DateStamp { get; set; }
    }
}
