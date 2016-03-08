using System;

namespace HRISVSC.Models
{
    public class TrnPayrollOtherIncomeLine
    {
        public Int32 id { get; set; }
        public Int32 payrollOtherIncomeid { get; set; }
        public Int32 employeeId { get; set; }
        public Int32 otherincomeId { get; set; }
        public Decimal amount { get; set; }
    }
}
