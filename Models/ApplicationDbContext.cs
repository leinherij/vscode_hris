using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
<<<<<<< HEAD

=======
<<<<<<< HEAD
using System;
=======
>>>>>>> cc76c7c9e166eeaeaa17c8c34d6e8c7557942b14
>>>>>>> 02e37b1cf57e6ffaa015359be3427b4e3c1a9c76
namespace HRISVSC.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<MstAccount> MstAccounts { get; set; }
        public DbSet<MstBranch> MstBranchs { get; set; }
        public DbSet<MstCitizenship> MstCitizenships { get; set; }
        public DbSet<MstCompany> MstCompanys { get; set; }
        public DbSet<MstDayType> MstDayTypes { get; set; }
        public DbSet<MstDayTypeDay> MstDayTypeDays { get; set; }
        public DbSet<MstDepartment> MstDepartments { get; set; }
        public DbSet<MstDivision> MstDivisions { get; set; }
        public DbSet<MstEmployee> MstEmployees { get; set; }
        public DbSet<MstEmployeeLoan> MstEmployeeLoans { get; set; }
        public DbSet<MstEmployeeMemo> MstEmployeeMemos { get; set; }
        public DbSet<MstEmployeeShiftCode> MstEmployeeShiftCodes { get; set; }
        public DbSet<MstLeave> MstLeaves { get; set; }
        public DbSet<MstMandatoryTable> MstMandatoryTables { get; set; }
        public DbSet<MstMonth> MstMonths { get; set; }
        public DbSet<MstOtherDeduction> MstOtherDeductions { get; set; }
        public DbSet<MstOtherIncome> MstOtherIncomes { get; set; }
        public DbSet<MstPayrollGroup> MstPayrollGroups { get; set; }
        public DbSet<MstPayrollType> MstPayrollTypes { get; set; }
        public DbSet<MstPeriod> MstPeriods { get; set; }
        public DbSet<MstPosition> MstPositions { get; set; }
        public DbSet<MstReligion> MstReligions { get; set; }
        public DbSet<MstShiftCode> MstShiftCodes { get; set; }
        public DbSet<MstShiftCodeDay> MstShiftCodeDays { get; set; }
        public DbSet<MstTableHDMF> MstTableHDMFs { get; set; }
        public DbSet<MstTablePHIC> MstTablePHICs { get; set; }
        public DbSet<MstTableSSS> MstTableSSSs { get; set; }
        public DbSet<MstTableWTaxMonthly> MstTableWTaxMonthlys { get; set; }
        public DbSet<MstTableWTaxSemiMonthly> MstTableWTaxSemiMonthlys { get; set; }
        public DbSet<MstTableWTaxYearly> MstTableWTaxYearlys { get; set; }
        public DbSet<MstTaxCode> MstTaxCodes { get; set; }
        public DbSet<MstUser> MstUsers { get; set; }
        public DbSet<MstUserForm> MstUserForms { get; set; }
        public DbSet<MstUserPayrollGroup> MstUserPayrollGroups { get; set; }
        public DbSet<MstZipCode> MstZipCodes { get; set; }
        public DbSet<SysForm> SysForms { get; set; }
        public DbSet<TrnChangeShift> TrnChangeShifts { get; set; }
        public DbSet<TrnChangeShiftLine> TrnChangeShiftLines { get; set; }
        public DbSet<TrnDTR> TrnDTRs { get; set; }
        public DbSet<TrnDTRLine> TrnDTRLines { get; set; }
        public DbSet<TrnDTRLog> TrnDTRLogs { get; set; }
        public DbSet<TrnLastWithholdingTax> TrnLastWithholdingTaxs { get; set; }
        public DbSet<TrnLastWithholdingTaxLine> TrnLastWithholdingTaxLines { get; set; }
        public DbSet<TrnLeaveApplication> TrnLeaveApplications { get; set; }
        public DbSet<TrnLeaveApplicationLine> TrnLeaveApplicationLines { get; set; }
        public DbSet<TrnLeaveLedger> TrnLeaveLedgers { get; set; }
        public DbSet<TrnLoanLedger> TrnLoanLedgers { get; set; }
        public DbSet<TrnOverTime> TrnOverTimes { get; set; }
        public DbSet<TrnOverTimeLine> TrnOverTimeLines { get; set; }
        public DbSet<TrnPayroll> TrnPayrolls { get; set; }
        public DbSet<TrnPayrollLine> TrnPayrollLines { get; set; }
        public DbSet<TrnPayrollOtherDeduction> TrnPayrollOtherDeductions { get; set; }
        public DbSet<TrnPayrollOtherDeductionLine> TrnPayrollOtherDeductionLines { get; set; }
        public DbSet<TrnPayrollOtherIncome> TrnPayrollOtherIncomes { get; set; }
        public DbSet<TrnPayrollOtherIncomeLine> TrnPayrollOtherIncomeLines { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<MstAccount>().HasKey(m => m.id);
            builder.Entity<MstBranch>().HasKey(m => m.id); 
            builder.Entity<MstCitizenship>().HasKey(m => m.id);
            builder.Entity<MstCompany>().HasKey(m => m.id);
            builder.Entity<MstDayType>().HasKey(m => m.id);
            builder.Entity<MstDayTypeDay>().HasKey(m => m.id);
            builder.Entity<MstDepartment>().HasKey(m => m.id);
            builder.Entity<MstDivision>().HasKey(m => m.id);
            builder.Entity<MstEmployee>().HasKey(m => m.id); 
            builder.Entity<MstEmployeeLoan>().HasKey(m => m.id); 
            builder.Entity<MstEmployeeMemo>().HasKey(m => m.id);
            builder.Entity<MstEmployeeShiftCode>().HasKey(m => m.id);
            builder.Entity<MstLeave>().HasKey(m => m.id);
            builder.Entity<MstMandatoryTable>().HasKey(m => m.id);
            builder.Entity<MstMonth>().HasKey(m => m.id);
            builder.Entity<MstOtherDeduction>().HasKey(m => m.id);
            builder.Entity<MstOtherIncome>().HasKey(m => m.id);
            builder.Entity<MstPayrollGroup>().HasKey(m => m.id);
            builder.Entity<MstPayrollType>().HasKey(m => m.id);
            builder.Entity<MstPeriod>().HasKey(m => m.id);
            builder.Entity<MstPosition>().HasKey(m => m.id);
            builder.Entity<MstReligion>().HasKey(m => m.id);
            builder.Entity<MstShiftCode>().HasKey(m => m.id);
            builder.Entity<MstShiftCodeDay>().HasKey(m => m.id);
            builder.Entity<MstTableHDMF>().HasKey(m => m.id);
            builder.Entity<MstTablePHIC>().HasKey(m => m.id);
            builder.Entity<MstTableSSS>().HasKey(m => m.id);
            builder.Entity<MstTableWTaxMonthly>().HasKey(m => m.id);
            builder.Entity<MstTableWTaxSemiMonthly>().HasKey(m => m.id);
            builder.Entity<MstTableWTaxYearly>().HasKey(m => m.id);
            builder.Entity<MstTaxCode>().HasKey(m => m.id);
            builder.Entity<MstUser>().HasKey(m => m.id);
            builder.Entity<MstUserForm>().HasKey(m => m.id);
            builder.Entity<MstUserPayrollGroup>().HasKey(m => m.id);
            builder.Entity<MstZipCode>().HasKey(m => m.id);
            builder.Entity<SysForm>().HasKey(m => m.id);
            builder.Entity<TrnChangeShift>().HasKey(m => m.id);
            builder.Entity<TrnChangeShiftLine>().HasKey(m => m.id);
            builder.Entity<TrnDTR>().HasKey(m => m.id);
            builder.Entity<TrnDTRLine>().HasKey(m => m.id);
            builder.Entity<TrnDTRLog>().HasKey(m => m.id);
            builder.Entity<TrnLastWithholdingTax>().HasKey(m => m.id);
            builder.Entity<TrnLastWithholdingTaxLine>().HasKey(m => m.id);
            builder.Entity<TrnLeaveApplication>().HasKey(m => m.id);
            builder.Entity<TrnLeaveApplicationLine>().HasKey(m => m.id);
            builder.Entity<TrnLeaveLedger>().HasKey(m => m.id);
            builder.Entity<TrnLoanLedger>().HasKey(m => m.id);
            builder.Entity<TrnOverTime>().HasKey(m => m.id);
            builder.Entity<TrnOverTimeLine>().HasKey(m => m.id);
            builder.Entity<TrnPayroll>().HasKey(m => m.id);
            builder.Entity<TrnPayrollLine>().HasKey(m => m.id);
            builder.Entity<TrnPayrollOtherDeduction>().HasKey(m => m.id);
            builder.Entity<TrnPayrollOtherDeductionLine>().HasKey(m => m.id);
            builder.Entity<TrnPayrollOtherIncome>().HasKey(m => m.id);
            builder.Entity<TrnPayrollOtherIncomeLine>().HasKey(m => m.id);
            base.OnModelCreating(builder);
        }
<<<<<<< HEAD

        
=======
>>>>>>> cc76c7c9e166eeaeaa17c8c34d6e8c7557942b14
    }
}
