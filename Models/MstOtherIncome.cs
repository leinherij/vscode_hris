using System;

namespace HRISVSC.Models
{
    public class MstOtherIncome
    {
        public Int32 id { get; set; }
        public String otherIncome { get; set; }
        public Boolean taxable { get; set; }
        public Decimal taxCeiling { get; set; }
        public Boolean includeMandatory { get; set; }
        public Int32 accountId { get; set; }
        public Decimal amount { get; set; }

    }
}
