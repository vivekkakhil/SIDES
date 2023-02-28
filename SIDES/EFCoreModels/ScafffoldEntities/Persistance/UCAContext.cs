using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SIDES.Services;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class UCAContext : DbContext
    {
       

        public UCAContext(DbContextOptions<UCAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AaCharge> AaCharges { get; set; } = null!;
        public virtual DbSet<AaChargesFinal> AaChargesFinals { get; set; } = null!;
        public virtual DbSet<AbCharge> AbCharges { get; set; } = null!;
        public virtual DbSet<AbChargesFinal> AbChargesFinals { get; set; } = null!;
        public virtual DbSet<ActionItem> ActionItems { get; set; } = null!;
        public virtual DbSet<Adjudicator> Adjudicators { get; set; } = null!;
        public virtual DbSet<AdjudicatorBackupBeforeNotesChange> AdjudicatorBackupBeforeNotesChanges { get; set; } = null!;
        public virtual DbSet<Appellant> Appellants { get; set; } = null!;
        public virtual DbSet<AspnetApplication> AspnetApplications { get; set; } = null!;
        public virtual DbSet<AspnetMembership> AspnetMemberships { get; set; } = null!;
        public virtual DbSet<AspnetPath> AspnetPaths { get; set; } = null!;
        public virtual DbSet<AspnetPersonalizationAllUser> AspnetPersonalizationAllUsers { get; set; } = null!;
        public virtual DbSet<AspnetPersonalizationPerUser> AspnetPersonalizationPerUsers { get; set; } = null!;
        public virtual DbSet<AspnetProfile> AspnetProfiles { get; set; } = null!;
        public virtual DbSet<AspnetRole> AspnetRoles { get; set; } = null!;
        public virtual DbSet<AspnetSchemaVersion> AspnetSchemaVersions { get; set; } = null!;
        public virtual DbSet<AspnetUser> AspnetUsers { get; set; } = null!;
        public virtual DbSet<AspnetWebEventEvent> AspnetWebEventEvents { get; set; } = null!;
        public virtual DbSet<BadRecord> BadRecords { get; set; } = null!;
        public virtual DbSet<BenefitCharge> BenefitCharges { get; set; } = null!;
        public virtual DbSet<C2> C2s { get; set; } = null!;
        public virtual DbSet<CcComplete> CcCompletes { get; set; } = null!;
        public virtual DbSet<CcnameConvert> CcnameConverts { get; set; } = null!;
        public virtual DbSet<Ccw1> Ccw1s { get; set; } = null!;
        public virtual DbSet<Ccw2> Ccw2s { get; set; } = null!;
        public virtual DbSet<ChargeSummary> ChargeSummaries { get; set; } = null!;
        public virtual DbSet<Claim> Claims { get; set; } = null!;
        public virtual DbSet<ClaimNote> ClaimNotes { get; set; } = null!;
        public virtual DbSet<ClaimType> ClaimTypes { get; set; } = null!;
        public virtual DbSet<ClaimsDeleted> ClaimsDeleteds { get; set; } = null!;
        public virtual DbSet<ClaimsDocument> ClaimsDocuments { get; set; } = null!;
        public virtual DbSet<ClaimsM> ClaimsMs { get; set; } = null!;
        public virtual DbSet<ClaimsMa> ClaimsMas { get; set; } = null!;
        public virtual DbSet<ClaimsMsOld> ClaimsMsOlds { get; set; } = null!;
        public virtual DbSet<ClaimsNotesDetail> ClaimsNotesDetails { get; set; } = null!;
        public virtual DbSet<ClaimsPersonnel> ClaimsPersonnel { get; set; } = null!;
        public virtual DbSet<ClaimsZz> ClaimsZzs { get; set; } = null!;
        public virtual DbSet<CliemtsTemp> CliemtsTemps { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<ClientAnalyst> ClientAnalysts { get; set; } = null!;
        public virtual DbSet<ClientContact> ClientContacts { get; set; } = null!;
        public virtual DbSet<ClientContactType> ClientContactTypes { get; set; } = null!;
        public virtual DbSet<ClientCurrentinvoicetype> ClientCurrentinvoicetypes { get; set; } = null!;
        public virtual DbSet<ClientDba> ClientDbas { get; set; } = null!;
        public virtual DbSet<ClientDocument> ClientDocuments { get; set; } = null!;
        public virtual DbSet<ClientVisit> ClientVisits { get; set; } = null!;
        public virtual DbSet<CoAirCc> CoAirCcs { get; set; } = null!;
        public virtual DbSet<CompReportDetail> CompReportDetails { get; set; } = null!;
        public virtual DbSet<CompReportDetailCompany> CompReportDetailCompanies { get; set; } = null!;
        public virtual DbSet<CompReportDetailCompliance> CompReportDetailCompliances { get; set; } = null!;
        public virtual DbSet<CompReportDetailSeparation> CompReportDetailSeparations { get; set; } = null!;
        public virtual DbSet<CompReportDetailStaging> CompReportDetailStagings { get; set; } = null!;
        public virtual DbSet<CompReportDetailStaging2> CompReportDetailStaging2s { get; set; } = null!;
        public virtual DbSet<CompReportDetailStaging3> CompReportDetailStaging3s { get; set; } = null!;
        public virtual DbSet<CompReportSummary> CompReportSummaries { get; set; } = null!;
        public virtual DbSet<CompanyName> CompanyNames { get; set; } = null!;
        public virtual DbSet<CompanyNamesBu> CompanyNamesBus { get; set; } = null!;
        public virtual DbSet<CostCenter> CostCenters { get; set; } = null!;
        public virtual DbSet<CostCentersBu> CostCentersBus { get; set; } = null!;
        public virtual DbSet<Costc1> Costc1s { get; set; } = null!;
        public virtual DbSet<Costc2> Costc2s { get; set; } = null!;
        public virtual DbSet<CurClaimStatus> CurClaimStatuses { get; set; } = null!;
        public virtual DbSet<Decision> Decisions { get; set; } = null!;
        public virtual DbSet<District> Districts { get; set; } = null!;
        public virtual DbSet<Dtproperty> Dtproperties { get; set; } = null!;
        public virtual DbSet<EmailId> EmailIds { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Employer> Employers { get; set; } = null!;
        public virtual DbSet<FriedkinCostCenter> FriedkinCostCenters { get; set; } = null!;
        public virtual DbSet<FruityPebbel> FruityPebbels { get; set; } = null!;
        public virtual DbSet<HearingsPerDiem> HearingsPerDiems { get; set; } = null!;
        public virtual DbSet<LengthofEmployment> LengthofEmployments { get; set; } = null!;
        public virtual DbSet<Letter> Letters { get; set; } = null!;
        public virtual DbSet<MailLog> MailLogs { get; set; } = null!;
        public virtual DbSet<MainCc> MainCcs { get; set; } = null!;
        public virtual DbSet<MainDistrict> MainDistricts { get; set; } = null!;
        public virtual DbSet<MainRegion> MainRegions { get; set; } = null!;
        public virtual DbSet<MsClaimsDeleted> MsClaimsDeleteds { get; set; } = null!;
        public virtual DbSet<NewRegion> NewRegions { get; set; } = null!;
        public virtual DbSet<PayrollClient> PayrollClients { get; set; } = null!;
        public virtual DbSet<PayrollClients11172014> PayrollClients11172014s { get; set; } = null!;
        public virtual DbSet<PayrollRecord> PayrollRecords { get; set; } = null!;
        public virtual DbSet<PayrollRecordsTemp> PayrollRecordsTemps { get; set; } = null!;
        public virtual DbSet<PayrollRecordsTemp1> PayrollRecordsTemp1s { get; set; } = null!;
        public virtual DbSet<PayrollRecordsTempAllupload> PayrollRecordsTempAlluploads { get; set; } = null!;
        public virtual DbSet<PayrollRecordsTempAlluploadtest> PayrollRecordsTempAlluploadtests { get; set; } = null!;
        public virtual DbSet<PayrollRecordsTest> PayrollRecordsTests { get; set; } = null!;
        public virtual DbSet<PrFile> PrFiles { get; set; } = null!;
        public virtual DbSet<PrImport> PrImports { get; set; } = null!;
        public virtual DbSet<Question> Questions { get; set; } = null!;
        public virtual DbSet<QuestionAnswer> QuestionAnswers { get; set; } = null!;
        public virtual DbSet<ReasonForSeparation> ReasonForSeparations { get; set; } = null!;
        public virtual DbSet<Region> Regions { get; set; } = null!;
        public virtual DbSet<ReportDetail> ReportDetails { get; set; } = null!;
        public virtual DbSet<ReportDetailCompliance> ReportDetailCompliances { get; set; } = null!;
        public virtual DbSet<ReportDetailComplianceWhg> ReportDetailComplianceWhgs { get; set; } = null!;
        public virtual DbSet<ReportDetailCostcenter> ReportDetailCostcenters { get; set; } = null!;
        public virtual DbSet<ReportDetailCostcentersWhg> ReportDetailCostcentersWhgs { get; set; } = null!;
        public virtual DbSet<ReportDetailSeparation> ReportDetailSeparations { get; set; } = null!;
        public virtual DbSet<ReportDetailSeparationWhg> ReportDetailSeparationWhgs { get; set; } = null!;
        public virtual DbSet<ReportDetailStaging> ReportDetailStagings { get; set; } = null!;
        public virtual DbSet<ReportDetailStaging2> ReportDetailStaging2s { get; set; } = null!;
        public virtual DbSet<ReportDetailStaging2Whg> ReportDetailStaging2Whgs { get; set; } = null!;
        public virtual DbSet<ReportDetailStaging3> ReportDetailStaging3s { get; set; } = null!;
        public virtual DbSet<ReportDetailStaging3Whg> ReportDetailStaging3Whgs { get; set; } = null!;
        public virtual DbSet<ReportDetailStagingWhg> ReportDetailStagingWhgs { get; set; } = null!;
        public virtual DbSet<ReportDetailWhg> ReportDetailWhgs { get; set; } = null!;
        public virtual DbSet<ReportFrequency> ReportFrequencies { get; set; } = null!;
        public virtual DbSet<ReportSummary> ReportSummaries { get; set; } = null!;
        public virtual DbSet<ReportSummaryWhg> ReportSummaryWhgs { get; set; } = null!;
        public virtual DbSet<Representative> Representatives { get; set; } = null!;
        public virtual DbSet<SeparationCode> SeparationCodes { get; set; } = null!;
        public virtual DbSet<SeparationReason> SeparationReasons { get; set; } = null!;
        public virtual DbSet<Sepcode> Sepcodes { get; set; } = null!;
        public virtual DbSet<Sheet1> Sheet1s { get; set; } = null!;
        public virtual DbSet<Sheet1b> Sheet1bs { get; set; } = null!;
        public virtual DbSet<Sheet1c> Sheet1cs { get; set; } = null!;
        public virtual DbSet<SidesAmendedresponse> SidesAmendedresponses { get; set; } = null!;
        public virtual DbSet<SidesAttachmentcode> SidesAttachmentcodes { get; set; } = null!;
        public virtual DbSet<SidesClaimantsepreasoncode> SidesClaimantsepreasoncodes { get; set; } = null!;
        public virtual DbSet<SidesDischargepolicyaware> SidesDischargepolicyawares { get; set; } = null!;
        public virtual DbSet<SidesDischargereasoncode> SidesDischargereasoncodes { get; set; } = null!;
        public virtual DbSet<SidesEmpseparationreasoncode> SidesEmpseparationreasoncodes { get; set; } = null!;
        public virtual DbSet<SidesHiringagreementchange> SidesHiringagreementchanges { get; set; } = null!;
        public virtual DbSet<SidesLabordisputetype> SidesLabordisputetypes { get; set; } = null!;
        public virtual DbSet<SidesPreparertype> SidesPreparertypes { get; set; } = null!;
        public virtual DbSet<SidesRemuneration> SidesRemunerations { get; set; } = null!;
        public virtual DbSet<SidesRemunerationfrequency> SidesRemunerationfrequencies { get; set; } = null!;
        public virtual DbSet<SidesRequestforseparation> SidesRequestforseparations { get; set; } = null!;
        public virtual DbSet<SidesRequestforseparationattachment> SidesRequestforseparationattachments { get; set; } = null!;
        public virtual DbSet<SidesTparesponse> SidesTparesponses { get; set; } = null!;
        public virtual DbSet<SidesTparesponseattachment> SidesTparesponseattachments { get; set; } = null!;
        public virtual DbSet<SidesTypeofclaimcode> SidesTypeofclaimcodes { get; set; } = null!;
        public virtual DbSet<SidesTypeofempcode> SidesTypeofempcodes { get; set; } = null!;
        public virtual DbSet<SidesVoluntaryseparation> SidesVoluntaryseparations { get; set; } = null!;
        public virtual DbSet<SidesWagesavailability> SidesWagesavailabilities { get; set; } = null!;
        public virtual DbSet<SidesWagesweeksneededcode> SidesWagesweeksneededcodes { get; set; } = null!;
        public virtual DbSet<SidesWeeksavailable> SidesWeeksavailables { get; set; } = null!;
        public virtual DbSet<SidesWorkingallavailablehour> SidesWorkingallavailablehours { get; set; } = null!;
        public virtual DbSet<Ssnskipped> Ssnskippeds { get; set; } = null!;
        public virtual DbSet<Ssnskipped2> Ssnskipped2s { get; set; } = null!;
        public virtual DbSet<StateCode> StateCodes { get; set; } = null!;
        public virtual DbSet<StateIdNumber> StateIdNumbers { get; set; } = null!;
        public virtual DbSet<Status> Statuses { get; set; } = null!;
        public virtual DbSet<Tax> Taxes { get; set; } = null!;
        public virtual DbSet<TaxChargeHistory> TaxChargeHistories { get; set; } = null!;
        public virtual DbSet<TaxNote> TaxNotes { get; set; } = null!;
        public virtual DbSet<TaxRateHistory> TaxRateHistories { get; set; } = null!;
        public virtual DbSet<TaxablePayRoll> TaxablePayRolls { get; set; } = null!;
        public virtual DbSet<UiFinanceMethodType> UiFinanceMethodTypes { get; set; } = null!;
        public virtual DbSet<Uioffice> Uioffices { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserDetail> UserDetails { get; set; } = null!;
        public virtual DbSet<VwAspnetApplication> VwAspnetApplications { get; set; } = null!;
        public virtual DbSet<VwAspnetMembershipUser> VwAspnetMembershipUsers { get; set; } = null!;
        public virtual DbSet<VwAspnetProfile> VwAspnetProfiles { get; set; } = null!;
        public virtual DbSet<VwAspnetRole> VwAspnetRoles { get; set; } = null!;
        public virtual DbSet<VwAspnetUser> VwAspnetUsers { get; set; } = null!;
        public virtual DbSet<VwAspnetUsersInRole> VwAspnetUsersInRoles { get; set; } = null!;
        public virtual DbSet<VwAspnetWebPartStatePath> VwAspnetWebPartStatePaths { get; set; } = null!;
        public virtual DbSet<VwAspnetWebPartStateShared> VwAspnetWebPartStateShareds { get; set; } = null!;
        public virtual DbSet<VwAspnetWebPartStateUser> VwAspnetWebPartStateUsers { get; set; } = null!;
        public virtual DbSet<VwClaimsThatViolateBoardRule> VwClaimsThatViolateBoardRules { get; set; } = null!;
        public virtual DbSet<VwClientInfoForPayrollDatum> VwClientInfoForPayrollData { get; set; } = null!;
        public virtual DbSet<VwLongestCostCenterName> VwLongestCostCenterNames { get; set; } = null!;
        public virtual DbSet<VwLongestDistrictName> VwLongestDistrictNames { get; set; } = null!;
        public virtual DbSet<VwLongestRegionName> VwLongestRegionNames { get; set; } = null!;
        public virtual DbSet<VwMainstayCc> VwMainstayCcs { get; set; } = null!;
        public virtual DbSet<VwMaxNoteLength> VwMaxNoteLengths { get; set; } = null!;
        public virtual DbSet<VwPayrollRecordsForJoin> VwPayrollRecordsForJoins { get; set; } = null!;
        public virtual DbSet<VwPayrollUploadSummary> VwPayrollUploadSummaries { get; set; } = null!;
        public virtual DbSet<VwSui> VwSuis { get; set; } = null!;
        public virtual DbSet<VwSuisearch> VwSuisearches { get; set; } = null!;
        public virtual DbSet<ZzMainClaim> ZzMainClaims { get; set; } = null!;
        public virtual DbSet<ZzPendingToWonClaim> ZzPendingToWonClaims { get; set; } = null!;

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=192.168.1.116;Database=UCA;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AaCharge>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AA_CHARGES");

                entity.Property(e => e.ClaimDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");

                entity.Property(e => e.CurrentCh)
                    .HasColumnType("smallmoney")
                    .HasColumnName("CurrentCH");

                entity.Property(e => e.Decision)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Potential).HasColumnType("smallmoney");

                entity.Property(e => e.Remaining).HasColumnType("smallmoney");

                entity.Property(e => e.SeparationReason)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ssn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SSN");

                entity.Property(e => e.Total).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<AaChargesFinal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AA_CHARGES_FINAL");

                entity.Property(e => e.ClaimDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");

                entity.Property(e => e.Current).HasColumnType("smallmoney");

                entity.Property(e => e.Decision)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Potential).HasColumnType("smallmoney");

                entity.Property(e => e.Remaining).HasColumnType("smallmoney");

                entity.Property(e => e.SeparationReason)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ssn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SSN");

                entity.Property(e => e.Total).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<AbCharge>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AB_CHARGES");

                entity.Property(e => e.Ccoffice)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CCOffice");

                entity.Property(e => e.ClaimDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");

                entity.Property(e => e.Current).HasColumnType("money");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Potential).HasColumnType("money");

                entity.Property(e => e.Remaining).HasColumnType("money");

                entity.Property(e => e.SeparationReason)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ssn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SSN");

                entity.Property(e => e.Sui)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUI");

                entity.Property(e => e.Suioffice)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUIOffice");

                entity.Property(e => e.Suistate)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SUIState")
                    .IsFixedLength();

                entity.Property(e => e.SuistateCcoffice)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SUIStateCCOffice");

                entity.Property(e => e.Total).HasColumnType("money");
            });

            modelBuilder.Entity<AbChargesFinal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AB_CHARGES_FINAL");

                entity.Property(e => e.Ccoffice)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CCOffice");

                entity.Property(e => e.ClaimDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");

                entity.Property(e => e.Current).HasColumnType("money");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Potential).HasColumnType("money");

                entity.Property(e => e.Remaining).HasColumnType("money");

                entity.Property(e => e.SeparationReason)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ssn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SSN");

                entity.Property(e => e.Sui)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUI");

                entity.Property(e => e.Suioffice)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUIOffice");

                entity.Property(e => e.Suistate)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SUIState")
                    .IsFixedLength();

                entity.Property(e => e.SuistateCcoffice)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SUIStateCCOffice");

                entity.Property(e => e.Total).HasColumnType("money");
            });

            modelBuilder.Entity<ActionItem>(entity =>
            {
                entity.ToTable("ACTION_ITEMS");

                entity.Property(e => e.ActionItemId).HasColumnName("ActionItemID");

                entity.Property(e => e.ActionItem1)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("ActionItem")
                    .IsFixedLength();

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientVisitId).HasColumnName("ClientVisitID");

                entity.Property(e => e.Completed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DueDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Adjudicator>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Adjudicator");

                entity.Property(e => e.AdjDt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AdjDT");

                entity.Property(e => e.AdjFax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdjName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AdjTele)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdjudicatorId).ValueGeneratedOnAdd();

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.Doc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Notes)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Ssn)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("SSN")
                    .IsFixedLength();
            });

            modelBuilder.Entity<AdjudicatorBackupBeforeNotesChange>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Adjudicator_Backup_BeforeNotesChange");

                entity.Property(e => e.AdjDt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AdjDT");

                entity.Property(e => e.AdjFax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdjName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AdjTele)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.Doc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ssn)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("SSN")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Appellant>(entity =>
            {
                entity.ToTable("APPELLANT");

                entity.Property(e => e.AppellantId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppellantID");

                entity.Property(e => e.Appellant1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Appellant")
                    .IsFixedLength();

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AspnetApplication>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PK__aspnet_Applicati__7F8BD5E2")
                    .IsClustered(false);

                entity.ToTable("aspnet_Applications");

                entity.HasIndex(e => e.LoweredApplicationName, "UQ__aspnet_Applicati__007FFA1B")
                    .IsUnique();

                entity.HasIndex(e => e.ApplicationName, "UQ__aspnet_Applicati__01741E54")
                    .IsUnique();

                entity.HasIndex(e => e.LoweredApplicationName, "aspnet_Applications_Index")
                    .IsClustered();

                entity.Property(e => e.ApplicationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationName).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspnetMembership>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_Membershi__1486F2C8")
                    .IsClustered(false);

                entity.ToTable("aspnet_Membership");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredEmail }, "aspnet_Membership_index")
                    .IsClustered();

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserYn).HasColumnName("CreateUserYN");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.ExecutiveMenuYn).HasColumnName("ExecutiveMenuYN");

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.FaxNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName).HasMaxLength(25);

                entity.Property(e => e.JobTitle).HasMaxLength(50);

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastName).HasMaxLength(25);

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredEmail).HasMaxLength(256);

                entity.Property(e => e.MobilePin)
                    .HasMaxLength(16)
                    .HasColumnName("MobilePIN");

                entity.Property(e => e.Password).HasMaxLength(128);

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.PasswordSalt).HasMaxLength(128);

                entity.Property(e => e.TelephoneNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ViewAllSidesSi).HasColumnName("ViewAllSidesSI");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetMemberships)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__Appli__157B1701");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetMembership)
                    .HasForeignKey<AspnetMembership>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__UserI__166F3B3A");
            });

            modelBuilder.Entity<AspnetPath>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .HasName("PK__aspnet_Paths__461E4E5C")
                    .IsClustered(false);

                entity.ToTable("aspnet_Paths");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredPath }, "aspnet_Paths_index")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.PathId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LoweredPath).HasMaxLength(256);

                entity.Property(e => e.Path).HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetPaths)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pa__Appli__40306ADC");
            });

            modelBuilder.Entity<AspnetPersonalizationAllUser>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .HasName("PK__aspnet_Personali__4BD727B2");

                entity.ToTable("aspnet_PersonalizationAllUsers");

                entity.Property(e => e.PathId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PageSettings).HasColumnType("image");

                entity.HasOne(d => d.Path)
                    .WithOne(p => p.AspnetPersonalizationAllUser)
                    .HasForeignKey<AspnetPersonalizationAllUser>(d => d.PathId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pe__PathI__41248F15");
            });

            modelBuilder.Entity<AspnetPersonalizationPerUser>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__aspnet_Personali__4EB3945D")
                    .IsClustered(false);

                entity.ToTable("aspnet_PersonalizationPerUser");

                entity.HasIndex(e => new { e.PathId, e.UserId }, "aspnet_PersonalizationPerUser_index1")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.UserId, e.PathId }, "aspnet_PersonalizationPerUser_ncindex2")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PageSettings).HasColumnType("image");

                entity.HasOne(d => d.Path)
                    .WithMany(p => p.AspnetPersonalizationPerUsers)
                    .HasForeignKey(d => d.PathId)
                    .HasConstraintName("FK__aspnet_Pe__PathI__4218B34E");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspnetPersonalizationPerUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__aspnet_Pe__UserI__430CD787");
            });

            modelBuilder.Entity<AspnetProfile>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_Profile__29820FAE");

                entity.ToTable("aspnet_Profile");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PropertyNames).HasColumnType("ntext");

                entity.Property(e => e.PropertyValuesBinary).HasColumnType("image");

                entity.Property(e => e.PropertyValuesString).HasColumnType("ntext");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetProfile)
                    .HasForeignKey<AspnetProfile>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pr__UserI__2A7633E7");
            });

            modelBuilder.Entity<AspnetRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__aspnet_Roles__330B79E8")
                    .IsClustered(false);

                entity.ToTable("aspnet_Roles");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredRoleName }, "aspnet_Roles_index1")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.RoleId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName).HasMaxLength(256);

                entity.Property(e => e.RoleName).HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetRoles)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Ro__Appli__33FF9E21");
            });

            modelBuilder.Entity<AspnetSchemaVersion>(entity =>
            {
                entity.HasKey(e => new { e.Feature, e.CompatibleSchemaVersion })
                    .HasName("PK__aspnet_SchemaVer__0A096455");

                entity.ToTable("aspnet_SchemaVersions");

                entity.Property(e => e.Feature).HasMaxLength(128);

                entity.Property(e => e.CompatibleSchemaVersion).HasMaxLength(128);
            });

            modelBuilder.Entity<AspnetUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_Users__04508AFF")
                    .IsClustered(false);

                entity.ToTable("aspnet_Users");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredUserName }, "aspnet_Users_Index")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.ApplicationId, e.LastActivityDate }, "aspnet_Users_Index2");

                entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName).HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetUsers)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__Appli__0544AF38");

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "AspnetUsersInRole",
                        l => l.HasOne<AspnetRole>().WithMany().HasForeignKey("RoleId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__aspnet_Us__RoleI__38C4533E"),
                        r => r.HasOne<AspnetUser>().WithMany().HasForeignKey("UserId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__aspnet_Us__UserI__37D02F05"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId").HasName("PK__aspnet_UsersInRo__36DC0ACC");

                            j.ToTable("aspnet_UsersInRoles");

                            j.HasIndex(new[] { "RoleId" }, "aspnet_UsersInRoles_index");
                        });
            });

            modelBuilder.Entity<AspnetWebEventEvent>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK__aspnet_WebEvent___60D24498");

                entity.ToTable("aspnet_WebEvent_Events");

                entity.Property(e => e.EventId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ApplicationPath).HasMaxLength(256);

                entity.Property(e => e.ApplicationVirtualPath).HasMaxLength(256);

                entity.Property(e => e.Details).HasColumnType("ntext");

                entity.Property(e => e.EventOccurrence).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.EventSequence).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.EventTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.EventType).HasMaxLength(256);

                entity.Property(e => e.ExceptionType).HasMaxLength(256);

                entity.Property(e => e.MachineName).HasMaxLength(256);

                entity.Property(e => e.Message).HasMaxLength(1024);

                entity.Property(e => e.RequestUrl).HasMaxLength(1024);
            });

            modelBuilder.Entity<BadRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BadRecord");

                entity.Property(e => e.BadSsn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BadSSN")
                    .IsFixedLength();
            });

            modelBuilder.Entity<BenefitCharge>(entity =>
            {
                entity.HasKey(e => e.BenefitChargesId);

                entity.ToTable("BENEFIT_CHARGES");

                entity.Property(e => e.BenefitChargesId).HasColumnName("BenefitChargesID");

                entity.Property(e => e.Charges).HasColumnType("smallmoney");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.DateOfCharge).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodEndingDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<C2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("C2");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BoardInstructions)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ClientID");

                entity.Property(e => e.ClientNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClosingInstructions)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyNameId).HasColumnName("CompanyNameID");

                entity.Property(e => e.ContractDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dba)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DBA");

                entity.Property(e => e.DrivingDirections)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HearingInstructions)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.HearingsPerDiemId).HasColumnName("HearingsPerDiemID");

                entity.Property(e => e.InPersonRate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InitialInstructions)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.MailingAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MainFax)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MainPhone)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OtherRate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PhoneRate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RateNotes)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReportFreqId).HasColumnName("ReportFreqID");

                entity.Property(e => e.ReportNotes)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Siccode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SICCode")
                    .IsFixedLength();

                entity.Property(e => e.TollFreePhone)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UcaaccountExecutiveId).HasColumnName("UCAAccountExecutiveID");

                entity.Property(e => e.UcaclaimsExaminerId).HasColumnName("UCAClaimsExaminerID");

                entity.Property(e => e.UcahearingCoordinatorId).HasColumnName("UCAHearingCoordinatorID");

                entity.Property(e => e.UcataxAuditorId).HasColumnName("UCATaxAuditorID");

                entity.Property(e => e.UifinanceMethodTypeId).HasColumnName("UIFinanceMethodTypeID");

                entity.Property(e => e.Website)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CcComplete>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CC_Complete");

                entity.Property(e => e.CostCenterDescription)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");

                entity.Property(e => e.CostCenterNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictDescription)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DistrictId).HasColumnName("DistrictID");

                entity.Property(e => e.DistrictNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.RegCc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RegCC");

                entity.Property(e => e.RegionDescription)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.RegionNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CcnameConvert>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CCNameConvert");

                entity.Property(e => e.Ccid).HasColumnName("CCID");

                entity.Property(e => e.NewCcnumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NewCCNumber");
            });

            modelBuilder.Entity<Ccw1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CCW1");

                entity.Property(e => e.Ccid).HasColumnName("CCID");

                entity.Property(e => e.Claimid).HasColumnName("claimid");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Location)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("location");

                entity.Property(e => e.Ssn)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("SSN")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Ccw2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CCW2");

                entity.Property(e => e.Ccname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CCName");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Location)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("location");

                entity.Property(e => e.Reg)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Regid).HasColumnName("regid");
            });

            modelBuilder.Entity<ChargeSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ChargeSummary");

                entity.Property(e => e.TotalCurrent)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TotalPotential)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TotalRemaining)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TotaltoDate)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Claim>(entity =>
            {
                entity.ToTable("CLAIMS");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.BoardAppealDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.BoardAppellantId).HasColumnName("BoardAppellantID");

                entity.Property(e => e.BoardDecisionDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.BoardDecisionId)
                    .HasColumnName("BoardDecisionID")
                    .HasDefaultValueSql("((100))");

                entity.Property(e => e.BoardRepId).HasColumnName("BoardRepID");

                entity.Property(e => e.Bye)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("BYE")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.ClaimDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.ClaimState)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimTypeId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ClaimTypeID")
                    .IsFixedLength();

                entity.Property(e => e.ClaimantId).HasColumnName("ClaimantID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')")
                    .IsFixedLength();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CurClaimStatusId).HasColumnName("CurClaimStatusID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HearingAppellantId).HasColumnName("HearingAppellantID");

                entity.Property(e => e.HearingDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.HearingDecisionDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.HearingDecisionId)
                    .HasColumnName("HearingDecisionID")
                    .HasDefaultValueSql("((100))");

                entity.Property(e => e.HearingRepId).HasColumnName("HearingRepID");

                entity.Property(e => e.HireDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.InitialDecisionDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.InitialDecisionId)
                    .HasColumnName("InitialDecisionID")
                    .HasDefaultValueSql("((100))");

                entity.Property(e => e.LastDayWorked)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PotentialBenefitCharge).HasColumnType("money");

                entity.Property(e => e.ProtestOfChargesDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Protestable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RevisedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')")
                    .IsFixedLength();

                entity.Property(e => e.RevisedDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SeparationCodeId).HasColumnName("SeparationCodeID");

                entity.Property(e => e.SeparationReasonId).HasColumnName("SeparationReasonID");

                entity.Property(e => e.Ssn)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("SSN")
                    .IsFixedLength();

                entity.Property(e => e.StateIdnumbersId).HasColumnName("StateIDNumbersID");
            });

            modelBuilder.Entity<ClaimNote>(entity =>
            {
                entity.HasKey(e => e.ClaimNotesId);

                entity.ToTable("CLAIM_NOTES");

                entity.Property(e => e.ClaimNotesId).HasColumnName("ClaimNotesID");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.ClaimNote1)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("ClaimNote");

                entity.Property(e => e.DateOfEntry).HasColumnType("smalldatetime");

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('XX')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<ClaimType>(entity =>
            {
                entity.ToTable("CLAIM_TYPES");

                entity.Property(e => e.ClaimTypeId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ClaimTypeID")
                    .IsFixedLength();

                entity.Property(e => e.ClaimType1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ClaimType")
                    .IsFixedLength();

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ClaimsDeleted>(entity =>
            {
                entity.HasKey(e => e.ClaimId)
                    .HasName("PK_CLAIMS_DELETED_1");

                entity.ToTable("CLAIMS_DELETED");

                entity.Property(e => e.ClaimId)
                    .ValueGeneratedNever()
                    .HasColumnName("ClaimID");

                entity.Property(e => e.BoardAppealDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BoardAppellantId).HasColumnName("BoardAppellantID");

                entity.Property(e => e.BoardDecisionDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BoardDecisionId).HasColumnName("BoardDecisionID");

                entity.Property(e => e.BoardRepId).HasColumnName("BoardRepID");

                entity.Property(e => e.Bye)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("BYE")
                    .IsFixedLength();

                entity.Property(e => e.ClaimDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimNumber)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimState)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimTypeId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ClaimTypeID")
                    .IsFixedLength();

                entity.Property(e => e.ClaimantId).HasColumnName("ClaimantID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");

                entity.Property(e => e.CurClaimStatusId).HasColumnName("CurClaimStatusID");

                entity.Property(e => e.DelDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DelReason)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HearingAppellantId).HasColumnName("HearingAppellantID");

                entity.Property(e => e.HearingDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HearingDecisionDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HearingDecisionId).HasColumnName("HearingDecisionID");

                entity.Property(e => e.HearingRepId).HasColumnName("HearingRepID");

                entity.Property(e => e.HireDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InitialDecisionDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InitialDecisionId).HasColumnName("InitialDecisionID");

                entity.Property(e => e.LastDayWorked)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PotentialBenefitCharge).HasColumnType("money");

                entity.Property(e => e.ProtestOfChargesDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SeparationCodeId).HasColumnName("SeparationCodeID");

                entity.Property(e => e.SeparationReasonId).HasColumnName("SeparationReasonID");

                entity.Property(e => e.Ssn)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("SSN")
                    .IsFixedLength();

                entity.Property(e => e.StateIdnumbersId).HasColumnName("StateIDNumbersID");
            });

            modelBuilder.Entity<ClaimsDocument>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ClaimsDocument");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfEntry).HasColumnType("datetime");

                entity.Property(e => e.Docid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DOCId");

                entity.Property(e => e.SiteUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClaimsM>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CLAIMS_MS");

                entity.Property(e => e.BoardDecisionId).HasColumnName("BoardDecisionID");

                entity.Property(e => e.BoardRepId).HasColumnName("BoardRepID");

                entity.Property(e => e.Bye)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("BYE")
                    .IsFixedLength();

                entity.Property(e => e.ClaimDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.ClaimState)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimTypeId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ClaimTypeID")
                    .IsFixedLength();

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CostCenter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CurClaimStatusId).HasColumnName("CurClaimStatusID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FixNeeded)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HearingDecisionId).HasColumnName("HearingDecisionID");

                entity.Property(e => e.HearingRepId).HasColumnName("HearingRepID");

                entity.Property(e => e.InitialDecisionId).HasColumnName("InitialDecisionID");

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PeriodEndingDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PotentialBenefitCharge).HasColumnType("money");

                entity.Property(e => e.RevisedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RevisedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SeparationCodeId).HasColumnName("SeparationCodeID");

                entity.Property(e => e.SeparationReasonId).HasColumnName("SeparationReasonID");

                entity.Property(e => e.Ssn)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("SSN")
                    .IsFixedLength();

                entity.Property(e => e.StateIdnumbersId).HasColumnName("StateIDNumbersID");

                entity.Property(e => e.TotalBenefitCharges).HasColumnType("money");

                entity.Property(e => e.TotalCredits).HasColumnType("money");
            });

            modelBuilder.Entity<ClaimsMa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CLAIMS_MA");

                entity.Property(e => e.ClaimDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.CostCenter)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Fixneeded)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Ssn)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("SSN");

                entity.Property(e => e.TotalBenefitCharges).HasColumnType("money");

                entity.Property(e => e.TotalCredits).HasColumnType("money");
            });

            modelBuilder.Entity<ClaimsMsOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CLAIMS_MS_OLD");

                entity.Property(e => e.BoardDecisionId).HasColumnName("BoardDecisionID");

                entity.Property(e => e.BoardRepId).HasColumnName("BoardRepID");

                entity.Property(e => e.Bye)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("BYE")
                    .IsFixedLength();

                entity.Property(e => e.ClaimDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.ClaimState)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimTypeId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ClaimTypeID")
                    .IsFixedLength();

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CostCenter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CurClaimStatusId).HasColumnName("CurClaimStatusID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HearingDecisionId).HasColumnName("HearingDecisionID");

                entity.Property(e => e.HearingRepId).HasColumnName("HearingRepID");

                entity.Property(e => e.InitialDecisionId).HasColumnName("InitialDecisionID");

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PeriodEndingDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PotentialBenefitCharge).HasColumnType("money");

                entity.Property(e => e.RevisedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RevisedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SeparationCodeId).HasColumnName("SeparationCodeID");

                entity.Property(e => e.SeparationReasonId).HasColumnName("SeparationReasonID");

                entity.Property(e => e.Ssn)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("SSN")
                    .IsFixedLength();

                entity.Property(e => e.StateIdnumbersId).HasColumnName("StateIDNumbersID");

                entity.Property(e => e.TotalBenefitCharges).HasColumnType("money");

                entity.Property(e => e.TotalCredits).HasColumnType("money");
            });

            modelBuilder.Entity<ClaimsNotesDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Claims_Notes_Details");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfEntry).HasColumnType("smalldatetime");

                entity.Property(e => e.NotesId).ValueGeneratedOnAdd();

                entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<ClaimsPersonnel>(entity =>
            {
                entity.ToTable("CLAIMS_PERSONNEL");

                entity.Property(e => e.ClaimsPersonnelId).HasColumnName("ClaimsPersonnelID");

                entity.Property(e => e.AnalystEmailId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AnalystEmailID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeeStatus)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Notes)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClaimsZz>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CLAIMS_ZZ");

                entity.Property(e => e.ClaimDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ssn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SSN");

                entity.Property(e => e.TotalCredits).HasColumnType("money");
            });

            modelBuilder.Entity<CliemtsTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CLIEMTS_temp");

                entity.Property(e => e.ClientId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ClientID");

                entity.Property(e => e.ContractDate)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("CLIENTS");

                entity.HasIndex(e => e.ClientNumber, "ClientNumber1")
                    .IsUnique();

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.AnalystId).HasColumnName("AnalystID");

                entity.Property(e => e.BoardInstructions)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Board Instructions:')");

                entity.Property(e => e.ClientNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClosingInstructions)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Close-out Instructions:')");

                entity.Property(e => e.CompanyNameId).HasColumnName("CompanyNameID");

                entity.Property(e => e.ContractDate)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.Dba)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DBA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DrivingDirections)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Driving Directions:')");

                entity.Property(e => e.HearingInstructions)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Hearing Instructions:')");

                entity.Property(e => e.HearingsPerDiemId)
                    .HasColumnName("HearingsPerDiemID")
                    .HasDefaultValueSql("(100)");

                entity.Property(e => e.InPersonRate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.InitialInstructions)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Initial Instructions:')");

                entity.Property(e => e.MailingAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MainFax)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.MainPhone)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.NumberOfEmployees).HasDefaultValueSql("(0)");

                entity.Property(e => e.OtherRate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.PhoneRate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.RateNotes)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ReportFreqId)
                    .HasColumnName("ReportFreqID")
                    .HasDefaultValueSql("(100)");

                entity.Property(e => e.ReportNotes)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Siccode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SICCode")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.Status).HasDefaultValueSql("(1)");

                entity.Property(e => e.TollFreePhone)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.UcaaccountExecutiveId)
                    .HasColumnName("UCAAccountExecutiveID")
                    .HasDefaultValueSql("(500)");

                entity.Property(e => e.UcaclaimsExaminerId)
                    .HasColumnName("UCAClaimsExaminerID")
                    .HasDefaultValueSql("(500)");

                entity.Property(e => e.UcahearingCoordinatorId)
                    .HasColumnName("UCAHearingCoordinatorID")
                    .HasDefaultValueSql("(500)");

                entity.Property(e => e.UcataxAuditorId)
                    .HasColumnName("UCATaxAuditorID")
                    .HasDefaultValueSql("(500)");

                entity.Property(e => e.UifinanceMethodTypeId)
                    .HasColumnName("UIFinanceMethodTypeID")
                    .HasDefaultValueSql("(100)");

                entity.Property(e => e.Website)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.HasOne(d => d.CompanyName)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.CompanyNameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLIENTS_COMPANY_NAMES");
            });

            modelBuilder.Entity<ClientAnalyst>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Client_Analysts");

                entity.Property(e => e.AnalystId).HasColumnName("AnalystID");

                entity.Property(e => e.ClientAnalystId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ClientAnalystID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");
            });

            modelBuilder.Entity<ClientContact>(entity =>
            {
                entity.ToTable("CLIENT_CONTACTS");

                entity.Property(e => e.ClientContactId).HasColumnName("ClientContactID");

                entity.Property(e => e.Address)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ClientContactTypeId).HasColumnName("ClientContactTypeID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ContactName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MailingAddress)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Phone2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Title)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.ClientContactType)
                    .WithMany(p => p.ClientContacts)
                    .HasForeignKey(d => d.ClientContactTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLIENT_CONTACTS_CLIENT_CONTACT_TYPES");
            });

            modelBuilder.Entity<ClientContactType>(entity =>
            {
                entity.ToTable("CLIENT_CONTACT_TYPES");

                entity.Property(e => e.ClientContactTypeId).HasColumnName("ClientContactTypeID");

                entity.Property(e => e.ClientContactType1)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ClientContactType")
                    .IsFixedLength();

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<ClientCurrentinvoicetype>(entity =>
            {
                entity.HasKey(e => e.CurrentInvoiceTypeId);

                entity.ToTable("CLIENT_CURRENTINVOICETYPES");

                entity.Property(e => e.CurrentInvoiceType).HasMaxLength(100);
            });

            modelBuilder.Entity<ClientDba>(entity =>
            {
                entity.ToTable("CLIENT_DBA");

                entity.Property(e => e.ClientDbaid).HasColumnName("ClientDBAID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Dba)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DBA")
                    .IsFixedLength();

                entity.Property(e => e.Notes)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<ClientDocument>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.UploadId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("UploadID");

                entity.Property(e => e.UploadfileName).HasMaxLength(500);
            });

            modelBuilder.Entity<ClientVisit>(entity =>
            {
                entity.ToTable("CLIENT_VISITS");

                entity.Property(e => e.ClientVisitId).HasColumnName("ClientVisitID");

                entity.Property(e => e.Attendees)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Employee)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Notes)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Report)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Service)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VisitDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<CoAirCc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CoAirCC");

                entity.Property(e => e.ContactName)
                    .HasMaxLength(60)
                    .HasColumnName("Contact Name");

                entity.Property(e => e.ContactNameEe)
                    .HasMaxLength(60)
                    .HasColumnName("Contact Name EE#");

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(60)
                    .HasColumnName("Contact Number");

                entity.Property(e => e.CostCenter)
                    .HasMaxLength(60)
                    .HasColumnName("COST CENTER");

                entity.Property(e => e.EMail)
                    .HasMaxLength(60)
                    .HasColumnName("E-Mail");

                entity.Property(e => e.F9).HasMaxLength(60);

                entity.Property(e => e.L1l2)
                    .HasMaxLength(60)
                    .HasColumnName("L1L2");

                entity.Property(e => e.Loc)
                    .HasMaxLength(60)
                    .HasColumnName("LOC");

                entity.Property(e => e.PartDesc)
                    .HasMaxLength(60)
                    .HasColumnName("part desc");
            });

            modelBuilder.Entity<CompReportDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("COMP_REPORT_DETAIL");

                entity.Property(e => e.BenChargesPaidDate).HasColumnType("smalldatetime");

                entity.Property(e => e.BoardAppealDate)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BoardDecision)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Byedate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("BYEDate")
                    .IsFixedLength();

                entity.Property(e => e.ClaimDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CostCenterDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CostCenterNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CurClaimStatus)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DistrictDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DistrictNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HearingDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HearingDecision)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HireDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastDayWorked)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LiabilityRemoved).HasColumnType("money");

                entity.Property(e => e.PotentialBenefitCharge).HasColumnType("money");

                entity.Property(e => e.RegionDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegionNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RemainingBenCharges).HasColumnType("money");

                entity.Property(e => e.SepCodeDescr)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.SeparationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SeparationReason)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ssn)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("SSN")
                    .IsFixedLength();

                entity.Property(e => e.TotalBenCharges).HasColumnType("money");
            });

            modelBuilder.Entity<CompReportDetailCompany>(entity =>
            {
                entity.ToTable("COMP_REPORT_DETAIL_COMPANY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LiabilityRemaining).HasColumnType("money");

                entity.Property(e => e.LiabilityRemoved).HasColumnType("money");

                entity.Property(e => e.PotentialLiability).HasColumnType("money");

                entity.Property(e => e.TotalChargesToDate).HasColumnType("money");
            });

            modelBuilder.Entity<CompReportDetailCompliance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("COMP_REPORT_DETAIL_COMPLIANCE");

                entity.Property(e => e.Category)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PotentialLiability).HasColumnType("money");

                entity.Property(e => e.TotalCharges).HasColumnType("money");
            });

            modelBuilder.Entity<CompReportDetailSeparation>(entity =>
            {
                entity.ToTable("COMP_REPORT_DETAIL_SEPARATION");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LiabilityRemaining).HasColumnType("money");

                entity.Property(e => e.LiabilityRemoved).HasColumnType("money");

                entity.Property(e => e.PotentialLiability).HasColumnType("money");

                entity.Property(e => e.SeparationCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SeparationReason)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TotalChargesToDate).HasColumnType("money");
            });

            modelBuilder.Entity<CompReportDetailStaging>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("COMP_REPORT_DETAIL_STAGING");

                entity.Property(e => e.BenChargesPaidDate).HasColumnType("smalldatetime");

                entity.Property(e => e.BoardAppealDate)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BoardDecision)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Byedate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("BYEDate")
                    .IsFixedLength();

                entity.Property(e => e.ClaimDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CostCenterDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CostCenterNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CurClaimStatus)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DistrictDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DistrictNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HearingDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HearingDecision)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HireDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastDayWorked)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LiabilityRemoved).HasColumnType("money");

                entity.Property(e => e.PotentialBenefitCharge).HasColumnType("money");

                entity.Property(e => e.RegionDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegionNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RemainingBenCharges).HasColumnType("money");

                entity.Property(e => e.SepCodeDescr)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.SeparationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SeparationReason)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ssn)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("SSN")
                    .IsFixedLength();

                entity.Property(e => e.TotalBenCharges).HasColumnType("money");
            });

            modelBuilder.Entity<CompReportDetailStaging2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("COMP_REPORT_DETAIL_STAGING_2");

                entity.Property(e => e.BoardAppealDate)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.CurClaimStatus)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HearingDate)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LiabilityRemaining).HasColumnType("money");

                entity.Property(e => e.LiabilityRemoved).HasColumnType("money");

                entity.Property(e => e.PotentialLiability).HasColumnType("money");

                entity.Property(e => e.SeparationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SeparationReason)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TotalChargesToDate).HasColumnType("money");
            });

            modelBuilder.Entity<CompReportDetailStaging3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("COMP_REPORT_DETAIL_STAGING_3");

                entity.Property(e => e.BoardAppealDate)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CurClaimStatus)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HearingDate)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LiabilityRemaining).HasColumnType("money");

                entity.Property(e => e.LiabilityRemoved).HasColumnType("money");

                entity.Property(e => e.PotentialLiability).HasColumnType("money");

                entity.Property(e => e.TotalChargesToDate).HasColumnType("money");
            });

            modelBuilder.Entity<CompReportSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("COMP_REPORT_SUMMARY");

                entity.Property(e => e.Client)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FromDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LiabilityRemaining).HasColumnType("money");

                entity.Property(e => e.LiabilityRemoved).HasColumnType("money");

                entity.Property(e => e.PendingToProtestable).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.PotentialLiability).HasColumnType("money");

                entity.Property(e => e.ProtestableToTotal).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.ToDate).HasColumnType("smalldatetime");

                entity.Property(e => e.TotalCharges).HasColumnType("money");

                entity.Property(e => e.TotalCredits).HasColumnType("money");

                entity.Property(e => e.WinRatioProtestable).HasColumnType("decimal(6, 2)");
            });

            modelBuilder.Entity<CompanyName>(entity =>
            {
                entity.ToTable("COMPANY_NAMES");

                entity.HasIndex(e => e.CompanyName1, "IX_COMPANY_NAMES")
                    .IsUnique();

                entity.Property(e => e.CompanyNameId).HasColumnName("CompanyNameID");

                entity.Property(e => e.CompanyName1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CompanyName")
                    .IsFixedLength();

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CompanyNamesBu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("COMPANY_NAMES_BU");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CompanyNameId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CompanyNameID");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CostCenter>(entity =>
            {
                entity.ToTable("COST_CENTERS");

                entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");

                entity.Property(e => e.Address)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CostCenterDescription)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CostCenterNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fax)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Notes)
                    .HasMaxLength(600)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.CostCenters)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK_COST_CENTERS_REGIONS");
            });

            modelBuilder.Entity<CostCentersBu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("COST_CENTERS_BU");

                entity.Property(e => e.Address)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CostCenterDescription)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CostCenterId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CostCenterID");

                entity.Property(e => e.CostCenterNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fax)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Notes)
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegionId).HasColumnName("RegionID");
            });

            modelBuilder.Entity<Costc1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("COSTC1");

                entity.Property(e => e.C1)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.C2)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.C3)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CostCenterDescription)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");

                entity.Property(e => e.RegCc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RegCC");
            });

            modelBuilder.Entity<Costc2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("COSTC2");

                entity.Property(e => e.C1)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.C2)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.C3)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CostCenterDescription)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");

                entity.Property(e => e.RegCc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RegCC");
            });

            modelBuilder.Entity<CurClaimStatus>(entity =>
            {
                entity.ToTable("CUR_CLAIM_STATUS");

                entity.Property(e => e.CurClaimStatusId).HasColumnName("CurClaimStatusID");

                entity.Property(e => e.CurClaimStatus1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CurClaimStatus")
                    .IsFixedLength();

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Decision>(entity =>
            {
                entity.ToTable("DECISIONS");

                entity.Property(e => e.DecisionId).HasColumnName("DecisionID");

                entity.Property(e => e.Decision1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Decision")
                    .IsFixedLength();

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.ToTable("DISTRICTS");

                entity.Property(e => e.DistrictId).HasColumnName("DistrictID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.DistrictDescription)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('No Description for this District')")
                    .IsFixedLength();

                entity.Property(e => e.DistrictNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Notes)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dtproperty>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Property })
                    .HasName("pk_dtproperties");

                entity.ToTable("dtproperties");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Property)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("property");

                entity.Property(e => e.Lvalue)
                    .HasColumnType("image")
                    .HasColumnName("lvalue");

                entity.Property(e => e.Objectid).HasColumnName("objectid");

                entity.Property(e => e.Uvalue)
                    .HasMaxLength(255)
                    .HasColumnName("uvalue");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("value");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<EmailId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EmailId");

                entity.Property(e => e.AnalystEmailId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AnalystEmailID");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasIndex(e => e.UserName, "UK_Employees_UserName")
                    .IsUnique();

                entity.Property(e => e.AttemptCompletedDate).HasColumnType("datetime");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailDate).HasColumnType("datetime");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeUnique).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LetterDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employer)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.EmployerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employees_Employers");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employees_Status");
            });

            modelBuilder.Entity<Employer>(entity =>
            {
                entity.HasIndex(e => e.UserName, "UK_Employers_UserName")
                    .IsUnique();

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployerUnique).HasDefaultValueSql("(newid())");

                entity.Property(e => e.FeeStructure)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Fee Structure");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Procedure)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasDefaultValueSql("((2))");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Employers)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employers_Status");
            });

            modelBuilder.Entity<FriedkinCostCenter>(entity =>
            {
                entity.HasKey(e => e.CostCenterId);

                entity.ToTable("FriedkinCostCenter");

                entity.Property(e => e.CostCenterName).HasMaxLength(500);
            });

            modelBuilder.Entity<FruityPebbel>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.First)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Last)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.New)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ssn)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SSN");
            });

            modelBuilder.Entity<HearingsPerDiem>(entity =>
            {
                entity.ToTable("HEARINGS_PER_DIEM");

                entity.Property(e => e.HearingsPerDiemId).HasColumnName("HearingsPerDiemID");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HearingsPerDiem1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("HearingsPerDiem")
                    .IsFixedLength();
            });

            modelBuilder.Entity<LengthofEmployment>(entity =>
            {
                entity.ToTable("LengthofEmployment");

                entity.Property(e => e.LengthofEmploymentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Letter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LETTERS");

                entity.Property(e => e.Addr1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Addr2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DateCreated).HasColumnType("smalldatetime");

                entity.Property(e => e.Fax)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LetterDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LetterId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("LetterID");

                entity.Property(e => e.LetterText)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.LetterType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MailTo)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<MailLog>(entity =>
            {
                entity.HasKey(e => e.Logid);

                entity.ToTable("MailLog");

                entity.Property(e => e.Logid).HasColumnName("logid");

                entity.Property(e => e.Body)
                    .HasColumnType("ntext")
                    .HasColumnName("body");

                entity.Property(e => e.Subject)
                    .HasMaxLength(200)
                    .HasColumnName("subject");

                entity.Property(e => e.Timestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("timestamp");
            });

            modelBuilder.Entity<MainCc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MAIN_CC");

                entity.Property(e => e.Address)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CostCenterDescription)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CostCenterId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CostCenterID");

                entity.Property(e => e.CostCenterNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fax)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Notes)
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegionId).HasColumnName("RegionID");
            });

            modelBuilder.Entity<MainDistrict>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MAIN_Districts");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.DistrictDescription)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DistrictId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DistrictID");

                entity.Property(e => e.DistrictNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Notes)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MainRegion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MAIN_Regions");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.DistrictId).HasColumnName("DistrictID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.RegionDescription)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegionId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RegionID");

                entity.Property(e => e.RegionNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<MsClaimsDeleted>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MS_CLAIMS_DELETED");

                entity.Property(e => e.BoardAppealDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BoardAppellantId).HasColumnName("BoardAppellantID");

                entity.Property(e => e.BoardDecisionDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BoardDecisionId).HasColumnName("BoardDecisionID");

                entity.Property(e => e.BoardRepId).HasColumnName("BoardRepID");

                entity.Property(e => e.Bye)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("BYE")
                    .IsFixedLength();

                entity.Property(e => e.ClaimDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.ClaimState)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimTypeId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ClaimTypeID")
                    .IsFixedLength();

                entity.Property(e => e.ClaimantId).HasColumnName("ClaimantID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CurClaimStatusId).HasColumnName("CurClaimStatusID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HearingAppellantId).HasColumnName("HearingAppellantID");

                entity.Property(e => e.HearingDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HearingDecisionDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HearingDecisionId).HasColumnName("HearingDecisionID");

                entity.Property(e => e.HearingRepId).HasColumnName("HearingRepID");

                entity.Property(e => e.HireDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InitialDecisionDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InitialDecisionId).HasColumnName("InitialDecisionID");

                entity.Property(e => e.LastDayWorked)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PotentialBenefitCharge).HasColumnType("money");

                entity.Property(e => e.ProtestOfChargesDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RevisedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RevisedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SeparationCodeId).HasColumnName("SeparationCodeID");

                entity.Property(e => e.SeparationReasonId).HasColumnName("SeparationReasonID");

                entity.Property(e => e.Ssn)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("SSN")
                    .IsFixedLength();

                entity.Property(e => e.StateIdnumbersId).HasColumnName("StateIDNumbersID");
            });

            modelBuilder.Entity<NewRegion>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ClientId).HasColumnName("clientID");

                entity.Property(e => e.DistrictId).HasColumnName("DistrictID");

                entity.Property(e => e.Reg)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("reg");

                entity.Property(e => e.RegId).HasColumnName("RegID");
            });

            modelBuilder.Entity<PayrollClient>(entity =>
            {
                entity.ToTable("PAYROLL_CLIENTS");

                entity.Property(e => e.PayrollClientId).HasColumnName("PayrollClientID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Folder)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Login)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Notes)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Pwd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PWD")
                    .IsFixedLength();
            });

            modelBuilder.Entity<PayrollClients11172014>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PAYROLL_CLIENTS11172014");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Folder)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Login)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Notes)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PayrollClientId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PayrollClientID");

                entity.Property(e => e.Pwd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PWD")
                    .IsFixedLength();
            });

            modelBuilder.Entity<PayrollRecord>(entity =>
            {
                entity.ToTable("PAYROLL_RECORDS");

                entity.HasIndex(e => e.ClientId, "IX_PAYROLL_RECORDS_ClientID");

                entity.HasIndex(e => e.Ssn, "IX_PAYROLL_RECORDS_SSN");

                entity.Property(e => e.PayrollRecordId).HasColumnName("PayrollRecordID");

                entity.Property(e => e.ActionReason)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ACTION_REASON");

                entity.Property(e => e.BuCode).HasColumnName("BU_Code");

                entity.Property(e => e.BusinessUnitDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Business_Unit_Desc");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CoreRpt)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Core_Rpt");

                entity.Property(e => e.CoreRptId).HasColumnName("Core_Rpt_ID");

                entity.Property(e => e.CostCenterName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentSupervisor)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateStamp)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeptDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Dept_Desc");

                entity.Property(e => e.EmpAddress1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpPhone)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmpState)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EmpStatus)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EmpTitle)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmpZipCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.Fein)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FEIN")
                    .IsFixedLength();

                entity.Property(e => e.FileName).HasMaxLength(50);

                entity.Property(e => e.Finitial)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FInitial")
                    .IsFixedLength();

                entity.Property(e => e.FirstDay)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Hours)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.JobStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.LastDay)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LName");

                entity.Property(e => e.LocCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MName");

                entity.Property(e => e.MrhireDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MRHireDate");

                entity.Property(e => e.Nww)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NWW")
                    .IsFixedLength();

                entity.Property(e => e.OsepDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OSepDate");

                entity.Property(e => e.PayFreqCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PayTypeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PayrollDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pryear).HasColumnName("PRYear");

                entity.Property(e => e.SepCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SlCode).HasColumnName("SL_Code");

                entity.Property(e => e.Space1)
                    .HasMaxLength(23)
                    .IsUnicode(false);

                entity.Property(e => e.Space28)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Ssn)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("SSN")
                    .IsFixedLength();

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SupervisorLevelDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Supervisor_Level_Desc");

                entity.Property(e => e.Tm)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TM")
                    .IsFixedLength();

                entity.Property(e => e.Wages).HasColumnType("money");
            });

            modelBuilder.Entity<PayrollRecordsTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PAYROLL_RECORDS_TEMP");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Fein)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FEIN")
                    .IsFixedLength();

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Finitial)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FInitial")
                    .IsFixedLength();

                entity.Property(e => e.Hours)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Lname)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("LName")
                    .IsFixedLength();

                entity.Property(e => e.LocCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nww)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NWW")
                    .IsFixedLength();

                entity.Property(e => e.PayFreqCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PayTypeCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Pryear).HasColumnName("PRYear");

                entity.Property(e => e.SepCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ssn)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("SSN")
                    .IsFixedLength();

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tm)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TM")
                    .IsFixedLength();

                entity.Property(e => e.Wages).HasColumnType("money");
            });

            modelBuilder.Entity<PayrollRecordsTemp1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PAYROLL_RECORDS_TEMP1");

                entity.Property(e => e.ActionReason)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ACTION_REASON");

                entity.Property(e => e.BuCode).HasColumnName("BU_Code");

                entity.Property(e => e.BusinessUnitDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Business_Unit_Desc");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CoreRpt)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Core_Rpt");

                entity.Property(e => e.CoreRptId).HasColumnName("Core_Rpt_ID");

                entity.Property(e => e.CurrentSupervisor)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DeptDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Dept_Desc");

                entity.Property(e => e.EmpAddress1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpPhone)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmpState)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EmpStatus)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EmpTitle)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmpZipCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.Fein)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FEIN")
                    .IsFixedLength();

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Finitial)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FInitial")
                    .IsFixedLength();

                entity.Property(e => e.Hours)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.LastDay)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("LName");

                entity.Property(e => e.LocCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mname)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("MName")
                    .IsFixedLength();

                entity.Property(e => e.MrhireDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MRHireDate");

                entity.Property(e => e.OsepDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OSepDate");

                entity.Property(e => e.PayFreqCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PayTypeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PayrollDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SepCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SlCode).HasColumnName("SL_Code");

                entity.Property(e => e.Ssn)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("SSN")
                    .IsFixedLength();

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SupervisorLevelDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Supervisor_Level_Desc");

                entity.Property(e => e.Tm)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TM");

                entity.Property(e => e.Wages).HasColumnType("money");
            });

            modelBuilder.Entity<PayrollRecordsTempAllupload>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PAYROLL_RECORDS_TEMP_ALLUPLOAD");

                entity.Property(e => e.ActionReason)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ACTION_REASON");

                entity.Property(e => e.BuCode).HasColumnName("BU_Code");

                entity.Property(e => e.BusinessUnitDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Business_Unit_Desc");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CoreRpt)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Core_Rpt");

                entity.Property(e => e.CoreRptId).HasColumnName("Core_Rpt_ID");

                entity.Property(e => e.CurrentSupervisor)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DeptDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Dept_Desc");

                entity.Property(e => e.EmpAddress1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpPhone)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmpState)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EmpStatus)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EmpTitle)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmpZipCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.Fein)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FEIN")
                    .IsFixedLength();

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Finitial)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FInitial")
                    .IsFixedLength();

                entity.Property(e => e.Hours)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.LastDay)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("LName");

                entity.Property(e => e.LocCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mname)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("MName")
                    .IsFixedLength();

                entity.Property(e => e.MrhireDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MRHireDate");

                entity.Property(e => e.OsepDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OSepDate");

                entity.Property(e => e.PayFreqCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PayTypeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PayrollDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SepCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SlCode).HasColumnName("SL_Code");

                entity.Property(e => e.Ssn)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("SSN")
                    .IsFixedLength();

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SupervisorLevelDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Supervisor_Level_Desc");

                entity.Property(e => e.Tm)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TM");

                entity.Property(e => e.Wages)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PayrollRecordsTempAlluploadtest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PAYROLL_RECORDS_TEMP_ALLUPLOADtest");

                entity.Property(e => e.ActionReason)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ACTION_REASON");

                entity.Property(e => e.BuCode).HasColumnName("BU_Code");

                entity.Property(e => e.BusinessUnitDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Business_Unit_Desc");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CoreRpt)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Core_Rpt");

                entity.Property(e => e.CoreRptId).HasColumnName("Core_Rpt_ID");

                entity.Property(e => e.CurrentSupervisor)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DeptDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Dept_Desc");

                entity.Property(e => e.EmpAddress1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpPhone)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmpState)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EmpStatus)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EmpTitle)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmpZipCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.Fein)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FEIN")
                    .IsFixedLength();

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Finitial)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FInitial")
                    .IsFixedLength();

                entity.Property(e => e.Hours)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.LastDay)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("LName");

                entity.Property(e => e.LocCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mname)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("MName")
                    .IsFixedLength();

                entity.Property(e => e.MrhireDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MRHireDate");

                entity.Property(e => e.OsepDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OSepDate");

                entity.Property(e => e.PayFreqCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PayTypeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PayrollDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SepCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SlCode).HasColumnName("SL_Code");

                entity.Property(e => e.Ssn)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("SSN")
                    .IsFixedLength();

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SupervisorLevelDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Supervisor_Level_Desc");

                entity.Property(e => e.Tm)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TM");

                entity.Property(e => e.Wages)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PayrollRecordsTest>(entity =>
            {
                entity.HasKey(e => e.PayrollRecordId);

                entity.ToTable("PAYROLL_RECORDS_TEST");

                entity.Property(e => e.PayrollRecordId).HasColumnName("PayrollRecordID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.DateStamp)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fein)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FEIN")
                    .IsFixedLength();

                entity.Property(e => e.FileName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Finitial)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FInitial")
                    .IsFixedLength();

                entity.Property(e => e.Hours)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Lname)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("LName")
                    .IsFixedLength();

                entity.Property(e => e.LocCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nww)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NWW")
                    .IsFixedLength();

                entity.Property(e => e.PayFreqCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PayTypeCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Pryear).HasColumnName("PRYear");

                entity.Property(e => e.SepCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Space1)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ssn)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("SSN")
                    .IsFixedLength();

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tm)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TM")
                    .IsFixedLength();

                entity.Property(e => e.Wages).HasColumnType("money");
            });

            modelBuilder.Entity<PrFile>(entity =>
            {
                entity.ToTable("PR_FILES");

                entity.HasIndex(e => e.FileName, "IX_PR_FILES")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PrImport>(entity =>
            {
                entity.ToTable("PR_IMPORT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Filename)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Record).HasMaxLength(1200);
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Question");

                entity.Property(e => e.IsActive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Question1)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Question");

                entity.Property(e => e.QuestionId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<QuestionAnswer>(entity =>
            {
                entity.Property(e => e.Accomplishmentpart)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("accomplishmentpart");

                entity.Property(e => e.Accuratepicture)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("accuratepicture");

                entity.Property(e => e.Achievementsrecognition)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("achievementsrecognition");

                entity.Property(e => e.Achievementsrecognitioncomments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("achievementsrecognitioncomments");

                entity.Property(e => e.AdheredtoPolicy)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AdvancementPotential)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Backtoschool)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("backtoschool");

                entity.Property(e => e.Basesalary)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("basesalary");

                entity.Property(e => e.Basesalarycomments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("basesalarycomments");

                entity.Property(e => e.Benefits)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("benefits");

                entity.Property(e => e.BenefitsOffered)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Benefitscost)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("benefitscost");

                entity.Property(e => e.Benefitscostcomments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("benefitscostcomments");

                entity.Property(e => e.Benefitscoverage)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("benefitscoverage");

                entity.Property(e => e.Benefitscoveragecomments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("benefitscoveragecomments");

                entity.Property(e => e.Bonus)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("bonus");

                entity.Property(e => e.Bonuscomments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("bonuscomments");

                entity.Property(e => e.BranchManagement)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClarityofRoles)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClearDirections)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Clearexpectations)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("clearexpectations");

                entity.Property(e => e.Clearexpectationscomments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("clearexpectationscomments");

                entity.Property(e => e.Coachingmentoring)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("coachingmentoring");

                entity.Property(e => e.Coachingmentoringcomments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("coachingmentoringcomments");

                entity.Property(e => e.Comfortableopinions)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comfortableopinions");

                entity.Property(e => e.CommunicatedDepartment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CommunicatedPolicy)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Communicationdepartment)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("communicationdepartment");

                entity.Property(e => e.Communicationdepartmentcomments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("communicationdepartmentcomments");

                entity.Property(e => e.Communicationinterdepartmental)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("communicationinterdepartmental");

                entity.Property(e => e.Communicationinterdepartmentalcomments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("communicationinterdepartmentalcomments");

                entity.Property(e => e.Communicationwithsupervisors)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("communicationwithsupervisors");

                entity.Property(e => e.Compensation)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("compensation");

                entity.Property(e => e.Compliancehotline)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("compliancehotline");

                entity.Property(e => e.ConcernComments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("concernComments");

                entity.Property(e => e.Conflictswithpeers)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Conflictswithsupervisor)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Corevalues)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerRelationships)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Coworkersfeeling)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("coworkersfeeling");

                entity.Property(e => e.Coworkersfeelingcomments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("coworkersfeelingcomments");

                entity.Property(e => e.Culture)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("culture");

                entity.Property(e => e.Culturecomments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("culturecomments");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Departmentcommunications)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("departmentcommunications");

                entity.Property(e => e.Departmentname)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("departmentname");

                entity.Property(e => e.DirectionoftheAssociation)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Discrepancies)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("discrepancies");

                entity.Property(e => e.DislikeJobComments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Easyresources)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("easyresources");

                entity.Property(e => e.Effectiveskills)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("effectiveskills");

                entity.Property(e => e.EmployeeMorale)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Employerscale)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("employerscale");

                entity.Property(e => e.Employerscalecomment)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("employerscalecomment");

                entity.Property(e => e.Employmentconcerns)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("employmentconcerns");

                entity.Property(e => e.EncouragedFeedback)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Equipmentandresources)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EquitableTreatment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Eventresponsible)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("eventresponsible");

                entity.Property(e => e.Eventresponsiblecomments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("eventresponsiblecomments");

                entity.Property(e => e.Excellentservice)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("excellentservice");

                entity.Property(e => e.Factors)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("factors");

                entity.Property(e => e.FamilyCircumstances)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Followedupconcerns)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("followedupconcerns");

                entity.Property(e => e.Helporganization)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("helporganization");

                entity.Property(e => e.HumanResourcesRepresentative)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Illness)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Immediatesupervisor)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Improvement)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("improvement");

                entity.Property(e => e.InterestingWork)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ishealthcare)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ishealthcare");

                entity.Property(e => e.Issueresolution)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("issueresolution");

                entity.Property(e => e.Issueresolutioncomments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("issueresolutioncomments");

                entity.Property(e => e.Jobtitle)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("jobtitle");

                entity.Property(e => e.Knowledge)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("knowledge");

                entity.Property(e => e.Knowledgecomments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("knowledgecomments");

                entity.Property(e => e.Layoff)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Lengthofemploymentid).HasColumnName("lengthofemploymentid");

                entity.Property(e => e.Levelofcommunication)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("levelofcommunication");

                entity.Property(e => e.LikeJobComments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LimitedAdvancement)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Listensupervisor)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("listensupervisor");

                entity.Property(e => e.Livestoitsvalues)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("livestoitsvalues");

                entity.Property(e => e.Livestoitsvaluescomments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("livestoitsvaluescomments");

                entity.Property(e => e.ManagerDepartment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Manageravailability)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("manageravailability");

                entity.Property(e => e.Manageravailabilitycomments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("manageravailabilitycomments");

                entity.Property(e => e.Managername)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("managername");

                entity.Property(e => e.Maternity)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Mentoring)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("mentoring");

                entity.Property(e => e.Missionandcause)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("missionandcause");

                entity.Property(e => e.Missionandcausecomments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("missionandcausecomments");

                entity.Property(e => e.Moralearea)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Moraleoverall)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Myachievements)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("myachievements");

                entity.Property(e => e.Myskills)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("myskills");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Natureofconcern)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("natureofconcern");

                entity.Property(e => e.NewJob)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NewJobComments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Newposition)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("newposition");

                entity.Property(e => e.Newtechnology)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("newtechnology");

                entity.Property(e => e.Notchallenged)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Opportunityadvancement)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("opportunityadvancement");

                entity.Property(e => e.Opportunityadvancementcomments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("opportunityadvancementcomments");

                entity.Property(e => e.Organizationalsupport)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("organizationalsupport");

                entity.Property(e => e.Orientation)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Pay)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PerformanceFeedback)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PerformanceReviews)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Performanceprocess)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("performanceprocess");

                entity.Property(e => e.Performanceprocesscomments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("performanceprocesscomments");

                entity.Property(e => e.Performancereviewprocess)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Policyapplication)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("policyapplication");

                entity.Property(e => e.Policyapplicationcomments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("policyapplicationcomments");

                entity.Property(e => e.Problememployment)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("problememployment");

                entity.Property(e => e.Problememploymentcomments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("problememploymentcomments");

                entity.Property(e => e.ProfessionalGrowth)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Promotion)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("promotion");

                entity.Property(e => e.Recognizedcontributions)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("recognizedcontributions");

                entity.Property(e => e.Relocating)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("relocating");

                entity.Property(e => e.ResolvedIssues)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RetainemployeeComments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("retainemployeeComments");

                entity.Property(e => e.Retiring)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("retiring");

                entity.Property(e => e.Returningtowork)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("returningtowork");

                entity.Property(e => e.Returningtoworkcomments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("returningtoworkcomments");

                entity.Property(e => e.Salary)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("salary");

                entity.Property(e => e.Salaryreviews)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("salaryreviews");

                entity.Property(e => e.Salaryreviewscomments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("salaryreviewscomments");

                entity.Property(e => e.Sharedconcerns)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("sharedconcerns");

                entity.Property(e => e.Shortercommute)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("shortercommute");

                entity.Property(e => e.Terminationdate)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("terminationdate");

                entity.Property(e => e.Training)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("training");

                entity.Property(e => e.TrainingOpportunities)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Trainingongoing)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("trainingongoing");

                entity.Property(e => e.Trainingongoingcomments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("trainingongoingcomments");

                entity.Property(e => e.TypeOfJobIndustryComments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TypeofWork)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TypeofWorkComments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("typeofWorkComments");

                entity.Property(e => e.Unhappy)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("unhappy");

                entity.Property(e => e.UpperManagementsActions)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ValuedSuggestions)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Whetherresolved)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("whetherresolved");

                entity.Property(e => e.Whynot)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("whynot");

                entity.Property(e => e.WorkHours)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Workenvironment)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("workenvironment");

                entity.Property(e => e.WorkingConditions)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Workload)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Worktogether)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("worktogether");

                entity.Property(e => e.Ymcamissioninvolvement)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("YMCAmissioninvolvement");

                entity.Property(e => e.YourSupervisor)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.QuestionAnswers)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestionAnswers_Employees");

                entity.HasOne(d => d.Lengthofemployment)
                    .WithMany(p => p.QuestionAnswers)
                    .HasForeignKey(d => d.Lengthofemploymentid)
                    .HasConstraintName("FK_QuestionAnswers_LengthofEmployment");

                entity.HasOne(d => d.ReasonForSeparation)
                    .WithMany(p => p.QuestionAnswers)
                    .HasForeignKey(d => d.ReasonForSeparationId)
                    .HasConstraintName("FK_QuestionAnswers_ReasonForSeparation");
            });

            modelBuilder.Entity<ReasonForSeparation>(entity =>
            {
                entity.ToTable("ReasonForSeparation");

                entity.Property(e => e.ReasonName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.ToTable("REGIONS");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.DistrictId).HasColumnName("DistrictID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.RegionDescription)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('No Description for this District')")
                    .IsFixedLength();

                entity.Property(e => e.RegionNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Regions)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_REGIONS_DISTRICTS");
            });

            modelBuilder.Entity<ReportDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REPORT_DETAIL");

                entity.Property(e => e.BenChargesPaidDate).HasColumnType("smalldatetime");

                entity.Property(e => e.BoardAppealDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BoardAppellantId).HasColumnName("BoardAppellantID");

                entity.Property(e => e.BoardDecision)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Byedate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("BYEDate")
                    .IsFixedLength();

                entity.Property(e => e.ClaimDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.ClaimState)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CostCenterDescription)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CostCenterNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CurClaimStatus)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DistrictDescription)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DistrictNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HearingAppellantId).HasColumnName("HearingAppellantID");

                entity.Property(e => e.HearingDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HearingDecision)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HireDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastDayWorked)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LiabilityRemoved).HasColumnType("money");

                entity.Property(e => e.NetBenCharges).HasColumnType("money");

                entity.Property(e => e.PotentialBenefitCharge).HasColumnType("money");

                entity.Property(e => e.RegionDescription)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegionNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RemainingBenCharges).HasColumnType("money");

                entity.Property(e => e.SepCodeDescr)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.SeparationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SeparationReason)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ssn)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("SSN")
                    .IsFixedLength();

                entity.Property(e => e.StateIdnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("StateIDNumber")
                    .IsFixedLength();

                entity.Property(e => e.TotalBenCharges).HasColumnType("money");

                entity.Property(e => e.TotalCredits).HasColumnType("money");
            });

            modelBuilder.Entity<ReportDetailCompliance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REPORT_DETAIL_COMPLIANCE");

                entity.Property(e => e.Category)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PotentialLiability).HasColumnType("money");

                entity.Property(e => e.TotalCharges).HasColumnType("money");
            });

            modelBuilder.Entity<ReportDetailComplianceWhg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REPORT_DETAIL_COMPLIANCE_WHG");

                entity.Property(e => e.Category)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PotentialLiability).HasColumnType("money");

                entity.Property(e => e.TotalCharges).HasColumnType("money");
            });

            modelBuilder.Entity<ReportDetailCostcenter>(entity =>
            {
                entity.ToTable("REPORT_DETAIL_COSTCENTERS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CostCenterDescription)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DistrictDescription)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LiabilityRemaining).HasColumnType("money");

                entity.Property(e => e.LiabilityRemoved).HasColumnType("money");

                entity.Property(e => e.PotentialLiability).HasColumnType("money");

                entity.Property(e => e.RegionDescription)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TotalChargesToDate).HasColumnType("money");
            });

            modelBuilder.Entity<ReportDetailCostcentersWhg>(entity =>
            {
                entity.ToTable("REPORT_DETAIL_COSTCENTERS_WHG");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CostCenterDescription)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DistrictDescription)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LiabilityRemaining).HasColumnType("money");

                entity.Property(e => e.LiabilityRemoved).HasColumnType("money");

                entity.Property(e => e.PotentialLiability).HasColumnType("money");

                entity.Property(e => e.RegionDescription)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TotalChargesToDate).HasColumnType("money");
            });

            modelBuilder.Entity<ReportDetailSeparation>(entity =>
            {
                entity.ToTable("REPORT_DETAIL_SEPARATION");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LiabilityRemaining).HasColumnType("money");

                entity.Property(e => e.LiabilityRemoved).HasColumnType("money");

                entity.Property(e => e.PotentialLiability).HasColumnType("money");

                entity.Property(e => e.SeparationCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SeparationReason)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TotalChargesToDate).HasColumnType("money");
            });

            modelBuilder.Entity<ReportDetailSeparationWhg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REPORT_DETAIL_SEPARATION_WHG");

                entity.Property(e => e.Favorable)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LiabilityRemaining)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LiabilityRemoved)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoOfBoardAppeals)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoOfClaims)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoOfHearings)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NonProtestable)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pending)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PotentialLiability)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SeparationCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SeparationReason)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Suspended)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TotalChargesToDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Unfavorable)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportDetailStaging>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REPORT_DETAIL_STAGING");

                entity.Property(e => e.BenChargesPaidDate).HasColumnType("smalldatetime");

                entity.Property(e => e.BoardAppealDate)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BoardAppellantId).HasColumnName("BoardAppellantID");

                entity.Property(e => e.BoardDecision)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Byedate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("BYEDate")
                    .IsFixedLength();

                entity.Property(e => e.ClaimDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.ClaimState)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CostCenterDescription)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CostCenterNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CurClaimStatus)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DistrictDescription)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DistrictNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HearingAppellantId).HasColumnName("HearingAppellantID");

                entity.Property(e => e.HearingDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HearingDecision)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HireDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastDayWorked)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LiabilityRemoved).HasColumnType("money");

                entity.Property(e => e.NetBenCharges).HasColumnType("money");

                entity.Property(e => e.PotentialBenefitCharge).HasColumnType("money");

                entity.Property(e => e.RegionDescription)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegionNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RemainingBenCharges).HasColumnType("money");

                entity.Property(e => e.SepCodeDescr)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.SeparationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SeparationReason)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ssn)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("SSN")
                    .IsFixedLength();

                entity.Property(e => e.StateIdnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("StateIDNumber")
                    .IsFixedLength();

                entity.Property(e => e.TotalBenCharges).HasColumnType("money");

                entity.Property(e => e.TotalCredits).HasColumnType("money");
            });

            modelBuilder.Entity<ReportDetailStaging2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REPORT_DETAIL_STAGING_2");

                entity.Property(e => e.BoardAppealDate)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.CurClaimStatus)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HearingDate)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LiabilityRemaining).HasColumnType("money");

                entity.Property(e => e.LiabilityRemoved).HasColumnType("money");

                entity.Property(e => e.PotentialLiability).HasColumnType("money");

                entity.Property(e => e.SeparationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SeparationReason)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TotalChargesToDate).HasColumnType("money");
            });

            modelBuilder.Entity<ReportDetailStaging2Whg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REPORT_DETAIL_STAGING_2_WHG");

                entity.Property(e => e.BoardAppealDate)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.CurClaimStatus)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HearingDate)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LiabilityRemaining).HasColumnType("money");

                entity.Property(e => e.LiabilityRemoved).HasColumnType("money");

                entity.Property(e => e.PotentialLiability).HasColumnType("money");

                entity.Property(e => e.SeparationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SeparationReason)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TotalChargesToDate).HasColumnType("money");
            });

            modelBuilder.Entity<ReportDetailStaging3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REPORT_DETAIL_STAGING_3");

                entity.Property(e => e.BoardAppealDate)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.CostCenterDescription)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CurClaimStatus)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DistrictDescription)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HearingDate)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LiabilityRemaining).HasColumnType("money");

                entity.Property(e => e.LiabilityRemoved).HasColumnType("money");

                entity.Property(e => e.PotentialLiability).HasColumnType("money");

                entity.Property(e => e.RegionDescription)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TotalChargesToDate).HasColumnType("money");
            });

            modelBuilder.Entity<ReportDetailStaging3Whg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REPORT_DETAIL_STAGING_3_WHG");

                entity.Property(e => e.BoardAppealDate)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.CostCenterDescription)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CurClaimStatus)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DistrictDescription)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HearingDate)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LiabilityRemaining).HasColumnType("money");

                entity.Property(e => e.LiabilityRemoved).HasColumnType("money");

                entity.Property(e => e.PotentialLiability).HasColumnType("money");

                entity.Property(e => e.RegionDescription)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TotalChargesToDate).HasColumnType("money");
            });

            modelBuilder.Entity<ReportDetailStagingWhg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REPORT_DETAIL_STAGING_WHG");

                entity.Property(e => e.BenChargesPaidDate).HasColumnType("smalldatetime");

                entity.Property(e => e.BoardAppealDate)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BoardAppellantId).HasColumnName("BoardAppellantID");

                entity.Property(e => e.BoardDecision)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Byedate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("BYEDate")
                    .IsFixedLength();

                entity.Property(e => e.ClaimDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.ClaimState)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CostCenterDescription)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CostCenterNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CurClaimStatus)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DistrictDescription)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DistrictNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HearingAppellantId).HasColumnName("HearingAppellantID");

                entity.Property(e => e.HearingDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HearingDecision)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HireDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastDayWorked)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LiabilityRemoved).HasColumnType("money");

                entity.Property(e => e.NetBenCharges).HasColumnType("money");

                entity.Property(e => e.PotentialBenefitCharge).HasColumnType("money");

                entity.Property(e => e.RegionDescription)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegionNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RemainingBenCharges).HasColumnType("money");

                entity.Property(e => e.SepCodeDescr)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.SeparationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SeparationReason)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ssn)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("SSN")
                    .IsFixedLength();

                entity.Property(e => e.StateIdnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("StateIDNumber")
                    .IsFixedLength();

                entity.Property(e => e.TotalBenCharges).HasColumnType("money");

                entity.Property(e => e.TotalCredits).HasColumnType("money");
            });

            modelBuilder.Entity<ReportDetailWhg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REPORT_DETAIL_WHG");

                entity.Property(e => e.BenChargesPaidDate).HasColumnType("smalldatetime");

                entity.Property(e => e.BoardAppealDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BoardAppellantId).HasColumnName("BoardAppellantID");

                entity.Property(e => e.BoardDecision)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Byedate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("BYEDate")
                    .IsFixedLength();

                entity.Property(e => e.ClaimDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.ClaimState)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CostCenterDescription)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CostCenterNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CurClaimStatus)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DistrictDescription)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DistrictNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HearingAppellantId).HasColumnName("HearingAppellantID");

                entity.Property(e => e.HearingDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HearingDecision)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HireDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastDayWorked)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LiabilityRemoved).HasColumnType("money");

                entity.Property(e => e.NetBenCharges).HasColumnType("money");

                entity.Property(e => e.PotentialBenefitCharge).HasColumnType("money");

                entity.Property(e => e.RegionDescription)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegionNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RemainingBenCharges).HasColumnType("money");

                entity.Property(e => e.SepCodeDescr)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.SeparationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SeparationReason)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ssn)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("SSN")
                    .IsFixedLength();

                entity.Property(e => e.StateIdnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("StateIDNumber")
                    .IsFixedLength();

                entity.Property(e => e.TotalBenCharges).HasColumnType("money");

                entity.Property(e => e.TotalCredits).HasColumnType("money");
            });

            modelBuilder.Entity<ReportFrequency>(entity =>
            {
                entity.HasKey(e => e.ReportFreqId);

                entity.ToTable("REPORT_FREQUENCY");

                entity.Property(e => e.ReportFreqId).HasColumnName("ReportFreqID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ReportFreq)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ReportSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REPORT_SUMMARY");

                entity.Property(e => e.BclaimantAppeals).HasColumnName("BClaimantAppeals");

                entity.Property(e => e.Bdfavorable).HasColumnName("BDFavorable");

                entity.Property(e => e.Bdpending).HasColumnName("BDPending");

                entity.Property(e => e.Bdunfavorable).HasColumnName("BDUnfavorable");

                entity.Property(e => e.BemployerAppeals).HasColumnName("BEmployerAppeals");

                entity.Property(e => e.Client)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FromDate).HasColumnType("smalldatetime");

                entity.Property(e => e.HclaimantAppeals).HasColumnName("HClaimantAppeals");

                entity.Property(e => e.Hdfavorable).HasColumnName("HDFavorable");

                entity.Property(e => e.Hdpending).HasColumnName("HDPending");

                entity.Property(e => e.Hdunfavorable).HasColumnName("HDUnfavorable");

                entity.Property(e => e.HemployerAppeals).HasColumnName("HEmployerAppeals");

                entity.Property(e => e.LiabilityRemaining).HasColumnType("money");

                entity.Property(e => e.LiabilityRemoved).HasColumnType("money");

                entity.Property(e => e.PendingToProtestable).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.PotentialLiability).HasColumnType("money");

                entity.Property(e => e.ProtestableToTotal).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.ToDate).HasColumnType("smalldatetime");

                entity.Property(e => e.TotalCharges).HasColumnType("money");

                entity.Property(e => e.TotalCredits).HasColumnType("money");

                entity.Property(e => e.WinRatioProtestable).HasColumnType("decimal(6, 2)");
            });

            modelBuilder.Entity<ReportSummaryWhg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REPORT_SUMMARY_WHG");

                entity.Property(e => e.BclaimantAppeals).HasColumnName("BClaimantAppeals");

                entity.Property(e => e.Bdfavorable).HasColumnName("BDFavorable");

                entity.Property(e => e.Bdpending).HasColumnName("BDPending");

                entity.Property(e => e.Bdunfavorable).HasColumnName("BDUnfavorable");

                entity.Property(e => e.BemployerAppeals).HasColumnName("BEmployerAppeals");

                entity.Property(e => e.Client)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FromDate).HasColumnType("smalldatetime");

                entity.Property(e => e.HclaimantAppeals).HasColumnName("HClaimantAppeals");

                entity.Property(e => e.Hdfavorable).HasColumnName("HDFavorable");

                entity.Property(e => e.Hdpending).HasColumnName("HDPending");

                entity.Property(e => e.Hdunfavorable).HasColumnName("HDUnfavorable");

                entity.Property(e => e.HemployerAppeals).HasColumnName("HEmployerAppeals");

                entity.Property(e => e.LiabilityRemaining).HasColumnType("money");

                entity.Property(e => e.LiabilityRemoved).HasColumnType("money");

                entity.Property(e => e.PendingToProtestable).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.PotentialLiability).HasColumnType("money");

                entity.Property(e => e.ProtestableToTotal).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.ToDate).HasColumnType("smalldatetime");

                entity.Property(e => e.TotalCharges).HasColumnType("money");

                entity.Property(e => e.TotalCredits).HasColumnType("money");

                entity.Property(e => e.WinRatioProtestable).HasColumnType("decimal(6, 2)");
            });

            modelBuilder.Entity<Representative>(entity =>
            {
                entity.ToTable("REPRESENTATIVES");

                entity.Property(e => e.RepresentativeId).HasColumnName("RepresentativeID");

                entity.Property(e => e.Fax)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rate1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rate1Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Rate2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rate2Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Rate3)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rate3Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StateCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SeparationCode>(entity =>
            {
                entity.ToTable("SEPARATION_CODES");

                entity.Property(e => e.SeparationCodeId)
                    .ValueGeneratedNever()
                    .HasColumnName("SeparationCodeID");

                entity.Property(e => e.Description)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.SeparationCode1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SeparationCode")
                    .IsFixedLength();
            });

            modelBuilder.Entity<SeparationReason>(entity =>
            {
                entity.ToTable("SEPARATION_REASONS");

                entity.HasComment("Subset of SEPARATION_CODES.  Each Code will have 1 or more reasons.");

                entity.Property(e => e.SeparationReasonId)
                    .ValueGeneratedNever()
                    .HasColumnName("SeparationReasonID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PossCodes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PossStatusCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SepCodeText)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SeparationCodeId).HasColumnName("SeparationCodeID");

                entity.Property(e => e.SeparationReason1)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("SeparationReason")
                    .IsFixedLength();

                entity.HasOne(d => d.SeparationCode)
                    .WithMany(p => p.SeparationReasons)
                    .HasForeignKey(d => d.SeparationCodeId)
                    .HasConstraintName("FK_SEPARATION_REASONS_SEPARATION_CODES");
            });

            modelBuilder.Entity<Sepcode>(entity =>
            {
                entity.ToTable("SEPCODE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.SepCodeNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SepDisplayCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sheet1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sheet1");

                entity.Property(e => e.Action)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimDate)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Claim Date");

                entity.Property(e => e.ClaimType)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Claim Type");

                entity.Property(e => e.CostCenter)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Cost Center");

                entity.Property(e => e.CostCenterDescription)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Cost Center Description");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("First Name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Last Name");

                entity.Property(e => e.Mark2)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Ssn)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("SSN");

                entity.Property(e => e.TotalBenefitCharges)
                    .HasColumnType("money")
                    .HasColumnName("Total Benefit Charges");

                entity.Property(e => e.TotalCredits)
                    .HasColumnType("money")
                    .HasColumnName("Total Credits");
            });

            modelBuilder.Entity<Sheet1b>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sheet1b");

                entity.Property(e => e.Action)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimDate)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimType)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Claim Type");

                entity.Property(e => e.CostCenter)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CostCenterDescription)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Cost Center Description");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Mark2)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Ssn)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("SSN");

                entity.Property(e => e.TotalBenefitCharges).HasColumnType("money");

                entity.Property(e => e.TotalCredits).HasColumnType("money");
            });

            modelBuilder.Entity<Sheet1c>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sheet1c");

                entity.Property(e => e.Action)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimDate)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimType)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Claim Type");

                entity.Property(e => e.CostCenter)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CostCenterDescription)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Cost Center Description");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Mark2)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Ssn)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("SSN");

                entity.Property(e => e.TotalBenefitCharges).HasColumnType("money");

                entity.Property(e => e.TotalCredits).HasColumnType("money");
            });

            modelBuilder.Entity<SidesAmendedresponse>(entity =>
            {
                entity.HasKey(e => e.AmendedResponseId);

                entity.ToTable("SIDES_AMENDEDRESPONSE");

                entity.Property(e => e.AmendedResponse)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SidesAttachmentcode>(entity =>
            {
                entity.HasKey(e => e.AttachmentCodeId);

                entity.ToTable("SIDES_ATTACHMENTCODE");

                entity.Property(e => e.AttachmentCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SidesClaimantsepreasoncode>(entity =>
            {
                entity.HasKey(e => e.ClaimantSeparationReasonCodeId);

                entity.ToTable("SIDES_CLAIMANTSEPREASONCODE");

                entity.Property(e => e.ClaimantSeparationReasonCode)
                    .HasMaxLength(255)
                    .IsFixedLength();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SidesDischargepolicyaware>(entity =>
            {
                entity.HasKey(e => e.DischargePolicyAwareId);

                entity.ToTable("SIDES_DISCHARGEPOLICYAWARE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DischargePolicyAwareCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DischargePolicyAwareDesc)
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SidesDischargereasoncode>(entity =>
            {
                entity.HasKey(e => e.DischargeReasonCodeId);

                entity.ToTable("SIDES_DISCHARGEREASONCODE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SidesEmpseparationreasoncode>(entity =>
            {
                entity.HasKey(e => e.EmpSeparationReasonCodeId);

                entity.ToTable("SIDES_EMPSEPARATIONREASONCODE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EmpSeparationReasonCode).HasMaxLength(100);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SidesHiringagreementchange>(entity =>
            {
                entity.HasKey(e => e.HiringAgreementChangesId);

                entity.ToTable("SIDES_HIRINGAGREEMENTCHANGES");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.HiringAgreementChanges)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SidesLabordisputetype>(entity =>
            {
                entity.HasKey(e => e.LaborDisputeTypeId);

                entity.ToTable("SIDES_LABORDISPUTETYPES");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LaborDisputeTypeCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LaborDisputeTypeDesc)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SidesPreparertype>(entity =>
            {
                entity.HasKey(e => e.PreparerTypeId);

                entity.ToTable("SIDES_PREPARERTYPE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PreparerType).HasMaxLength(100);

                entity.Property(e => e.PreparerTypeCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SidesRemuneration>(entity =>
            {
                entity.HasKey(e => e.RemunerationId);

                entity.ToTable("SIDES_REMUNERATION");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remuneration).HasMaxLength(250);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SidesRemunerationfrequency>(entity =>
            {
                entity.HasKey(e => e.RemunerationFrequencyId);

                entity.ToTable("SIDES_REMUNERATIONFREQUENCY");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RemunerationFrequency).HasMaxLength(100);

                entity.Property(e => e.RemunerationFrequencyCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SidesRequestforseparation>(entity =>
            {
                entity.HasKey(e => e.RequestForSeparationId);

                entity.ToTable("SIDES_REQUESTFORSEPARATION");

                entity.Property(e => e.BenefitYearBeginDate).HasColumnType("date");

                entity.Property(e => e.BrokerRecordTransactionNumber)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimEffectiveDate).HasColumnType("date");

                entity.Property(e => e.ClaimNumber)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimantFirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimantJobTitle)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimantLastName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimantMiddleInitial)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimantOtherLastName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimantReportedFirstDayofWork).HasColumnType("date");

                entity.Property(e => e.ClaimantReportedLastDayofWork).HasColumnType("date");

                entity.Property(e => e.ClaimantSuffix)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EmployerName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fein)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("FEIN")
                    .IsFixedLength();

                entity.Property(e => e.FormNumber)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RequestDate).HasColumnType("date");

                entity.Property(e => e.RequestingStateAbbreviation)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ResponseDueDate).HasColumnType("date");

                entity.Property(e => e.Ssn)
                    .HasColumnType("numeric(9, 0)")
                    .HasColumnName("SSN");

                entity.Property(e => e.StateEmployerAccountNbr)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StateRequestRecordGuid)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("StateRequestRecordGUID")
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.UiofficeId).HasColumnName("UIOfficeId");

                entity.Property(e => e.WagesNeededBeginDate).HasColumnType("date");

                entity.Property(e => e.WagesNeededEndDate).HasColumnType("date");
            });

            modelBuilder.Entity<SidesRequestforseparationattachment>(entity =>
            {
                entity.HasKey(e => e.AttachmentId);

                entity.ToTable("SIDES_REQUESTFORSEPARATIONATTACHMENT");

                entity.Property(e => e.AttachmentData)
                    .HasMaxLength(7000)
                    .IsFixedLength();

                entity.Property(e => e.AttachmentSize).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOfDocument)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UniqueAttachmentId).HasColumnName("UniqueAttachmentID");
            });

            modelBuilder.Entity<SidesTparesponse>(entity =>
            {
                entity.HasKey(e => e.TparesponseId);

                entity.ToTable("SIDES_TPARESPONSE");

                entity.Property(e => e.TparesponseId).HasColumnName("TPAResponseId");

                entity.Property(e => e.AllocationBeginDate).HasColumnType("date");

                entity.Property(e => e.AllocationEndDate).HasColumnType("date");

                entity.Property(e => e.AverageWeeklyWage).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ClaimantActionstoAvoidQuitInd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimantJobTitle)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaimantNameWorkedAsForEmployer)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContinuingWorkAvailableInd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContributoryorNotContributoryClaimantInd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CorrectedEmployerName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CorrectedFein)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CorrectedFEIN")
                    .IsFixedLength();

                entity.Property(e => e.CorrectedStateEmployerAccountNbr)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateRemunerationIssued).HasColumnType("date");

                entity.Property(e => e.DischargePolicyAwareExplanationCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DischargePolicyAwareInd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EffectiveSeparationDate).HasColumnType("date");

                entity.Property(e => e.EmployerAllocationInd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmployerReportedClaimantFirstDayofWork).HasColumnType("date");

                entity.Property(e => e.EmployerReportedClaimantLastDayofWork).HasColumnType("date");

                entity.Property(e => e.FinalIncidentDate).HasColumnType("date");

                entity.Property(e => e.LaborDisputeTypeInd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MandatoryPension)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MandatoryRetirementInd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OtherSsn)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("OtherSSN")
                    .IsFixedLength();

                entity.Property(e => e.PreparerCompanyName)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PreparerContactName)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PreparerEmailAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreparerFaxNbr)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PreparerTelephoneNumberPlusExt)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PreparerTitle)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PreparerTypeCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PriorIncidentDate).HasColumnType("date");

                entity.Property(e => e.PriorIncidentWarningDate).HasColumnType("date");

                entity.Property(e => e.PriorIncidentWarningInd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RemunerationAmountPerPeriod).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RemunerationPeriodFrequencyCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ReturnToWorkDate).HasColumnType("date");

                entity.Property(e => e.ReturnToWorkInd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SeasonalEmploymentInd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.TotalEarnedWages).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ViolateCompanyPolicyInd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WagesEarnedAfterClaimEffectiveDate).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.WhoDischargedName)
                    .HasMaxLength(60)
                    .IsFixedLength();

                entity.Property(e => e.WhoDischargedTitle)
                    .HasMaxLength(60)
                    .IsFixedLength();

                entity.Property(e => e.WorkingAllAvailableHoursInd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.RequestForSeparation)
                    .WithMany(p => p.SidesTparesponses)
                    .HasForeignKey(d => d.RequestForSeparationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIDES_TPARESPONSE_SIDES_REQUESTFORSEPARATION");
            });

            modelBuilder.Entity<SidesTparesponseattachment>(entity =>
            {
                entity.HasKey(e => e.TparesponseAttachmentId);

                entity.ToTable("SIDES_TPARESPONSEATTACHMENT");

                entity.Property(e => e.TparesponseAttachmentId).HasColumnName("TPAResponseAttachmentId");

                entity.Property(e => e.ContentType)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.TparesponseId).HasColumnName("TPAResponseId");

                entity.Property(e => e.TypeofDocument)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueAttachmentId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UniqueAttachmentID")
                    .IsFixedLength();

                entity.HasOne(d => d.Tparesponse)
                    .WithMany(p => p.SidesTparesponseattachments)
                    .HasForeignKey(d => d.TparesponseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIDES_TPARESPONSEATTACHMENT_SIDES_TPARESPONSE");
            });

            modelBuilder.Entity<SidesTypeofclaimcode>(entity =>
            {
                entity.HasKey(e => e.TypeOfClaimCodeId);

                entity.ToTable("SIDES_TYPEOFCLAIMCODE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOfClaimCode)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SidesTypeofempcode>(entity =>
            {
                entity.HasKey(e => e.TypeOfEmpCodeId);

                entity.ToTable("SIDES_TYPEOFEMPCODE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SidesVoluntaryseparation>(entity =>
            {
                entity.HasKey(e => e.VoluntarySeparationId);

                entity.ToTable("SIDES_VOLUNTARYSEPARATION");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoluntarySeparation).HasMaxLength(250);
            });

            modelBuilder.Entity<SidesWagesavailability>(entity =>
            {
                entity.HasKey(e => e.WagesAvailabilityId);

                entity.ToTable("SIDES_WAGESAVAILABILITY");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WagesAvailabilityDesc).HasMaxLength(100);
            });

            modelBuilder.Entity<SidesWagesweeksneededcode>(entity =>
            {
                entity.HasKey(e => e.WagesWeeksNeededCodeId)
                    .HasName("PK_SIDES_WAGESWEEKSNEEDCODE");

                entity.ToTable("SIDES_WAGESWEEKSNEEDEDCODE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsFixedLength();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WagesWeeksNeededCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SidesWeeksavailable>(entity =>
            {
                entity.HasKey(e => e.WeeksAvailableId);

                entity.ToTable("SIDES_WEEKSAVAILABLE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WeeksAvailableDesc).HasMaxLength(100);
            });

            modelBuilder.Entity<SidesWorkingallavailablehour>(entity =>
            {
                entity.HasKey(e => e.WorkingAllAvailableHrsId);

                entity.ToTable("SIDES_WORKINGALLAVAILABLEHOURS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkingAllAvailableHrsCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.WorkingAllAvailableHrsDesc)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Ssnskipped>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ssnskipped");

                entity.Property(e => e.Ssnvalues).HasColumnName("ssnvalues");
            });

            modelBuilder.Entity<Ssnskipped2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ssnskipped2");

                entity.Property(e => e.Ssnvalues)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ssnvalues")
                    .IsFixedLength();
            });

            modelBuilder.Entity<StateCode>(entity =>
            {
                entity.HasKey(e => e.StateCode1);

                entity.ToTable("STATE_CODES");

                entity.Property(e => e.StateCode1)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("StateCode")
                    .IsFixedLength();

                entity.Property(e => e.StateName)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StateIdNumber>(entity =>
            {
                entity.HasKey(e => e.StateIdnumbersId);

                entity.ToTable("STATE_ID_NUMBERS");

                entity.Property(e => e.StateIdnumbersId).HasColumnName("StateIDNumbersID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CompanyNameId).HasColumnName("CompanyNameID");

                entity.Property(e => e.Fein)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FEIN")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.Notes)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.StateCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('CA')")
                    .IsFixedLength();

                entity.Property(e => e.StateIdnumber1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("StateIDNumber")
                    .IsFixedLength();

                entity.Property(e => e.UnknownSui).HasColumnName("UnknownSUI");

                entity.HasOne(d => d.StateCodeNavigation)
                    .WithMany(p => p.StateIdNumbers)
                    .HasForeignKey(d => d.StateCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STATE_ID_NUMBERS_STATE_CODES");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("Status");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tax>(entity =>
            {
                entity.ToTable("Tax");

                entity.Property(e => e.TaxId).HasColumnName("TaxID");

                entity.Property(e => e.AckByState).HasColumnType("date");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.DateOfElection).HasColumnType("date");

                entity.Property(e => e.InsertedDate).HasColumnType("datetime");

                entity.Property(e => e.Poanotes).HasColumnName("POANotes");

                entity.Property(e => e.PoatoClient)
                    .HasColumnType("date")
                    .HasColumnName("POAToClient");

                entity.Property(e => e.PoatoState)
                    .HasColumnType("date")
                    .HasColumnName("POAToState");

                entity.Property(e => e.StateId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("StateID")
                    .IsFixedLength();

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Taxes)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tax_CLIENTS");
            });

            modelBuilder.Entity<TaxChargeHistory>(entity =>
            {
                entity.HasKey(e => e.ChargeHistoryId);

                entity.ToTable("TaxChargeHistory");

                entity.Property(e => e.ChargeHistoryId).HasColumnName("ChargeHistoryID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InsertedDate).HasColumnType("datetime");

                entity.Property(e => e.TaxId).HasColumnName("TaxID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.TaxChargeHistories)
                    .HasForeignKey(d => d.TaxId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaxChargeHistory_Tax");
            });

            modelBuilder.Entity<TaxNote>(entity =>
            {
                entity.HasKey(e => e.NoteId);

                entity.Property(e => e.NoteId).HasColumnName("NoteID");

                entity.Property(e => e.InsertedDate).HasColumnType("datetime");

                entity.Property(e => e.TaxId).HasColumnName("TaxID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.TaxNotes)
                    .HasForeignKey(d => d.TaxId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaxNotes_Tax");
            });

            modelBuilder.Entity<TaxRateHistory>(entity =>
            {
                entity.HasKey(e => e.RateHistoryId);

                entity.ToTable("TaxRateHistory");

                entity.Property(e => e.RateHistoryId).HasColumnName("RateHistoryID");

                entity.Property(e => e.InsertedDate).HasColumnType("datetime");

                entity.Property(e => e.Percentage).HasMaxLength(50);

                entity.Property(e => e.TaxId).HasColumnName("TaxID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.TaxRateHistories)
                    .HasForeignKey(d => d.TaxId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaxRateHistory_Tax");
            });

            modelBuilder.Entity<TaxablePayRoll>(entity =>
            {
                entity.ToTable("TaxablePayRoll");

                entity.Property(e => e.TaxablePayRollId).HasColumnName("TaxablePayRollID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InsertedDate).HasColumnType("datetime");

                entity.Property(e => e.TaxId).HasColumnName("TaxID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.TaxablePayRolls)
                    .HasForeignKey(d => d.TaxId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaxablePayRoll_Tax");
            });

            modelBuilder.Entity<UiFinanceMethodType>(entity =>
            {
                entity.ToTable("UI_FINANCE_METHOD_TYPE");

                entity.Property(e => e.UifinanceMethodTypeId).HasColumnName("UIFinanceMethodTypeID");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UifinanceMethodType1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UIFinanceMethodType")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Uioffice>(entity =>
            {
                entity.ToTable("UIOffice");

                entity.Property(e => e.UiofficeId).HasColumnName("UIOfficeId");

                entity.Property(e => e.UiofficeFax)
                    .HasMaxLength(10)
                    .HasColumnName("UIOfficeFax")
                    .IsFixedLength();

                entity.Property(e => e.UiofficeName)
                    .HasMaxLength(25)
                    .HasColumnName("UIOfficeName")
                    .IsFixedLength();

                entity.Property(e => e.UiofficePhone)
                    .HasMaxLength(15)
                    .HasColumnName("UIOfficePhone")
                    .IsFixedLength();
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("User");

                entity.Property(e => e.ClientNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Pwd)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RestrictedRegionNumber)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserId).ValueGeneratedOnAdd();

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Ans)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyAdd1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyAdd2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.StateCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserDetailId).ValueGeneratedOnAdd();

                entity.Property(e => e.WorkFax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WorkTelephone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwAspnetApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Applications");

                entity.Property(e => e.ApplicationName).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName).HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetMembershipUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_MembershipUsers");

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredEmail).HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.MobilePin)
                    .HasMaxLength(16)
                    .HasColumnName("MobilePIN");

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetProfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Profiles");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwAspnetRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Roles");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName).HasMaxLength(256);

                entity.Property(e => e.RoleName).HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Users");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName).HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetUsersInRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_UsersInRoles");
            });

            modelBuilder.Entity<VwAspnetWebPartStatePath>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_Paths");

                entity.Property(e => e.LoweredPath).HasMaxLength(256);

                entity.Property(e => e.Path).HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetWebPartStateShared>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_Shared");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwAspnetWebPartStateUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_User");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwClaimsThatViolateBoardRule>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwClaimsThatViolateBoardRules");

                entity.Property(e => e.BoardAppealDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BoardAppellantId).HasColumnName("BoardAppellantID");

                entity.Property(e => e.BoardDecisionId).HasColumnName("BoardDecisionID");

                entity.Property(e => e.ClaimId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ClaimID");
            });

            modelBuilder.Entity<VwClientInfoForPayrollDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwClientInfoForPayrollData");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CompanyNameId).HasColumnName("CompanyNameID");

                entity.Property(e => e.Folder)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Login)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PayrollClientId).HasColumnName("PayrollClientID");

                entity.Property(e => e.Pwd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PWD")
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwLongestCostCenterName>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwLongestCostCenterNames");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CostCenterDescription)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Legnth).HasColumnName("legnth");
            });

            modelBuilder.Entity<VwLongestDistrictName>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwLongestDistrictNames");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.DistrictDescription)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DistrictId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DistrictID");

                entity.Property(e => e.Legnth).HasColumnName("legnth");
            });

            modelBuilder.Entity<VwLongestRegionName>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwLongestRegionName");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Legnth).HasColumnName("legnth");

                entity.Property(e => e.RegionDescription)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegionId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RegionID");
            });

            modelBuilder.Entity<VwMainstayCc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwMainstayCC");

                entity.Property(e => e.Ccid).HasColumnName("CCID");

                entity.Property(e => e.Ccname)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("CCName")
                    .IsFixedLength();

                entity.Property(e => e.Ccnum)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CCNum")
                    .IsFixedLength();

                entity.Property(e => e.ClaimId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ClaimID");

                entity.Property(e => e.DisId).HasColumnName("DisID");

                entity.Property(e => e.DisName)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DisNum)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegId).HasColumnName("RegID");

                entity.Property(e => e.RegName)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegNum)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ssn)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("SSN")
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwMaxNoteLength>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwMaxNoteLength");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.ClaimNote)
                    .HasMaxLength(1200)
                    .IsUnicode(false);

                entity.Property(e => e.Legnth).HasColumnName("legnth");
            });

            modelBuilder.Entity<VwPayrollRecordsForJoin>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwPayrollRecordsForJoin");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.DateStamp).HasColumnType("smalldatetime");

                entity.Property(e => e.Fein)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FEIN")
                    .IsFixedLength();

                entity.Property(e => e.FileName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Finitial)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FInitial")
                    .IsFixedLength();

                entity.Property(e => e.Hours)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.JoinSsn)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("Join_SSN");

                entity.Property(e => e.Lname)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("LName")
                    .IsFixedLength();

                entity.Property(e => e.LocCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nww)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NWW")
                    .IsFixedLength();

                entity.Property(e => e.PayFreqCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PayTypeCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PayrollRecordId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PayrollRecordID");

                entity.Property(e => e.Pryear).HasColumnName("PRYear");

                entity.Property(e => e.SepCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Space1)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ssn)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("SSN")
                    .IsFixedLength();

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tm)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TM")
                    .IsFixedLength();

                entity.Property(e => e.Wages).HasColumnType("money");
            });

            modelBuilder.Entity<VwPayrollUploadSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwPayrollUploadSummary");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DateStamp).HasColumnType("smalldatetime");

                entity.Property(e => e.FileName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwSui>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwSUIs");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClientNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fein)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FEIN")
                    .IsFixedLength();

                entity.Property(e => e.LegalName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Notes)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.StateCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StateIdnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("StateIDNumber")
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwSuisearch>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwSUISearch");

                entity.Property(e => e.Business)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CleanSui)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CleanSUI")
                    .IsFixedLength();

                entity.Property(e => e.Client)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClientNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sui)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUI")
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZzMainClaim>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zzMAIN_CLAIMS");

                entity.Property(e => e.Ccid).HasColumnName("CCID");

                entity.Property(e => e.Ccname)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("CCName")
                    .IsFixedLength();

                entity.Property(e => e.Ccnum)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CCNum")
                    .IsFixedLength();

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.DisId).HasColumnName("DisID");

                entity.Property(e => e.DisName)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DisNum)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegId).HasColumnName("RegID");

                entity.Property(e => e.RegName)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegNum)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ssn)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("SSN")
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZzPendingToWonClaim>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zzPendingToWonClaims");

                entity.Property(e => e.ClaimDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Claimid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("claimid");

                entity.Property(e => e.CurClaimStatusId).HasColumnName("CurClaimStatusID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
