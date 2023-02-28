using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class Tax
    {
        public Tax()
        {
            TaxChargeHistories = new HashSet<TaxChargeHistory>();
            TaxNotes = new HashSet<TaxNote>();
            TaxRateHistories = new HashSet<TaxRateHistory>();
            TaxablePayRolls = new HashSet<TaxablePayRoll>();
        }

        public int TaxId { get; set; }
        public int ClientId { get; set; }
        public string? StateId { get; set; }
        public DateTime? PoatoClient { get; set; }
        public DateTime? PoatoState { get; set; }
        public DateTime? AckByState { get; set; }
        public string? Poanotes { get; set; }
        public int? FinanceMethodType { get; set; }
        public bool? IsReserveRatio { get; set; }
        public bool? IsBenefitCharge { get; set; }
        public bool? IsVoluntaryState { get; set; }
        public DateTime? DateOfElection { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? InsertedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Client Client { get; set; } = null!;
        public virtual ICollection<TaxChargeHistory> TaxChargeHistories { get; set; }
        public virtual ICollection<TaxNote> TaxNotes { get; set; }
        public virtual ICollection<TaxRateHistory> TaxRateHistories { get; set; }
        public virtual ICollection<TaxablePayRoll> TaxablePayRolls { get; set; }
    }
}
