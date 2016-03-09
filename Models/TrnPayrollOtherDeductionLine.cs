using System;

namespace HRISVSC.Models
{
    public class TrnPayrollOtherDeductionLine
    {
        public Int32 id { get; set; }
        public Int32 payrollOtherDeductionId { get; set; }
        public Int32 employeeId { get; set; }
        public Int32 otherDeductionId { get; set; }
        public Int32 employeeLoanId { get; set; }
        public Decimal amount { get; set; }
    }
}
