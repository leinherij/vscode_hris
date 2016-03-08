using System;

namespace HRISVSC.Models
{
    public class MstTableWTaxSemiMonthly
    {
        public Int32 id { get; set; }    
        public Int32 taxCodeId { get; set; }    
        public Decimal taxCodeValue { get; set; }
        public Decimal amount { get; set; }
        public Decimal tax { get; set; }
        public Decimal percentage { get; set; }
    }
}
