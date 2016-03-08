using System;

namespace HRISVSC.Models
{
    public class MstEmployeeLoan
    {
        public Int32 id { get; set; }
        public Int32 employeeId { get; set; }
        public Int32 otherDeductionId { get; set; }
        public Int32 loanNumber { get; set; }
        public Decimal loanAmount { get; set; }
        public Decimal monthlyAmortization { get; set; }
        public Int32 numberOfMonths { get; set; }
        public DateTime dateStart { get; set; }
        public Decimal totalPayment { get; set; }
        public Decimal balance { get; set; }
        public Boolean isPaid { get; set; }
        public Int32 entryUserId { get; set; }
        public DateTime entryDateTime { get; set; }
        public Int32 updateUserId { get; set; }
        public DateTime updateDateTime { get; set; }
        public Boolean isLocked { get; set; }
        public String remarks { get; set; }

    }
}
