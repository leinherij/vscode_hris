using System;

namespace HRISVSC.Models
{
    public class MstOtherDeduction
    {
        public Int32 id { get; set; }
        public String otherDeduction { get; set; }
        public Boolean loanType { get; set; }
        public Int32 accountId { get; set; }
        public Decimal amount { get; set; }

    }
}
