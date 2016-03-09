using System;

namespace HRISVSC.Models
{
    public class MstTaxCode
    {
        public Int32 id { get; set; }           
        public String taxCode { get; set; }
        public Decimal exemptionAmount { get; set; }
        public Decimal dependentAmount { get; set; }
    }
}
