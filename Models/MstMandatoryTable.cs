using System;

namespace HRISVSC.Models
{
    public class MstMandatoryTable
    {
        public Int32 id { get; set; }
        public String mandatoryDeduction { get; set; }
        public Decimal amountStart { get; set; }
        public Decimal amountEnd { get; set; }
        public Decimal rate { get; set; }

    }
}
