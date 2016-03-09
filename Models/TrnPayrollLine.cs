using System;

namespace HRISVSC.Models
{
    public class TrnPayrollLine
    {
        public Int32 id { get; set; }
        public Int32 payrollId { get; set; }
        public Int32 employeeId { get; set; }
        public Int32 payrollTypeId { get; set; }
        public Int32 taxCodeId { get; set; }
        public Decimal totalRegularWorkingHours { get; set; }
        public Decimal totalLegalHolidayWorkingHours { get; set; }
        public Decimal totalSpecialHolidayWorkingHours { get; set; }
        public Decimal totalRegularRestdayHours { get; set; }
        public Decimal totalLegalHolidayRestdayHours { get; set; }
        public Decimal totalSpecialHolidayRestdayHours { get; set; }
        public Decimal totalRegularOvertimeHours { get; set; }
        public Decimal totalLegalHolidayOvertimeHours { get; set; }
        public Decimal totalSpecialHolidayOvertimeHours { get; set; }
        public Decimal totalRegularNightHours { get; set; }
        public Decimal totalLegalHolidayNightHours { get; set; }
        public Decimal totalSpecialHolidayNightHours { get; set; }
        public Decimal totalRegularNightOvertimeHours { get; set; }
        public Decimal totalLegalHolidayNightOvertimeHours { get; set; }
        public Decimal totalSpecialHolidayNightOvertimeHours { get; set; }
        public Decimal totalTardyLateHours { get; set; }
        public Decimal totalTardyUndertimeHours { get; set; }
        public Decimal totalRegularWorkingAmount { get; set; }
        public Decimal totalLegalHolidayWorkingAmount { get; set; }
        public Decimal totalSpecialHolidayWorkingAmount { get; set; }
        public Decimal totalRegularRestdayAmount { get; set; }
        public Decimal totalLegalHolidayRestdayAmount { get; set; }
        public Decimal totalSpecialHolidayRestdayAmount { get; set; }
        public Decimal totalRegularOvertimeAmount { get; set; }
        public Decimal totalLegalHolidayOvertimeAmount { get; set; }
        public Decimal totalSpecialHolidayOvertimeAmount { get; set; }
        public Decimal totalRegularNightAmount { get; set; }
        public Decimal totalLegalHolidayNightAmount { get; set; }
        public Decimal totalSpecialHolidayNightAmount { get; set; }
        public Decimal totalRegularNightOvertimeAmount { get; set; }
        public Decimal totalLegalHolidayNightOvertimeAmount { get; set; }
        public Decimal totalSpecialHolidayNightOvertimeAmount { get; set; }
        public Decimal totalSalaryAmount { get; set; }
        public Decimal totalTardyAmount { get; set; }
        public Decimal totalAbsentAmount { get; set; }
        public Decimal totalNetSalaryAmount { get; set; }
        public Decimal totalOtherIncomeTaxable { get; set; }
        public Decimal grossIncome { get; set; }
        public Decimal totalOtherIncomeNonTaxable { get; set; }
        public Decimal grossIncomeWithNonTaxable { get; set; }
        public Decimal sssContribution { get; set; }
        public Decimal sssECContribution { get; set; }
        public Decimal phicContribution { get; set; }
        public Decimal hdmfContribution { get; set; }
        public Decimal tax { get; set; }
        public Decimal totalOtherDeduction { get; set; }
        public Decimal netIncome { get; set; }
        public Decimal sssContributionEmployer { get; set; }
        public Decimal sssECContributionEmployer { get; set; }
        public Decimal phicContributionEmployer { get; set; }
        public Decimal hdmfContributionEmployer { get; set; }
        public Int32 accountId { get; set; }
    }
}
