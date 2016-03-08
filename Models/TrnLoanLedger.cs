using System;

namespace HRISVSC.Models
{
    public class TrnLoanLedger
    {
        public Int32 id { get; set; }
        public Int32 periodId { get; set; }
        public Int32 employeeId { get; set; }
        public DateTime date { get; set; }
        public Int32 employeeLoanId { get; set; }
        public Decimal debit { get; set; }
        public Decimal credit { get; set; }
        public Int32 payrollOtherDeductionId { get; set; }
    }
}
