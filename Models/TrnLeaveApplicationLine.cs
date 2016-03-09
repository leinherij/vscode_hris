using System;

namespace HRISVSC.Models
{
    public class TrnLeaveApplicationLine
    {
        public Int32 id { get; set; }
        public Int32 leaveApplicationId { get; set; }
        public Int32 employeeId { get; set; }
        public Int32 leaveId { get; set; }
        public DateTime date { get; set; }
        public Decimal numberOfHours { get; set; }
        public Boolean withPay { get; set; }
        public Boolean debitToLedger { get; set; }
        public String remarks { get; set; }
    }
}
