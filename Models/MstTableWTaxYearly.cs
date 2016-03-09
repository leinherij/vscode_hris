using System;

namespace HRISVSC.Models
{
    public class MstTableWTaxYearly
    {
        public Int32 id { get; set; }           
        public Decimal amountStart { get; set; }
        public Decimal amountEnd { get; set; }
        public Decimal percentage { get; set; }
        public Decimal additionalAmount { get; set; }
    }
}
