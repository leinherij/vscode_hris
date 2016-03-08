using System;

namespace HRISVSC.Models
{
    public class TrnLeaveLedger
    {
        public Int32 id { get; set; }
        public Int32 periodId { get; set; }
        public Int32 employeeId { get; set; }
        public DateTime date { get; set; }
        public Int32 leaveId { get; set; }
        public String leaveType { get; set; }
        public Decimal debit { get; set; }
        public Decimal credit { get; set; }
        public Int32 leaveApplicationId { get; set; }
    }
}
