using System;

namespace HRISVSC.Models
{
    public class MstTableHDMF
    {
        public Int32 id { get; set; }       
        public Decimal amountStart { get; set; }
        public Decimal amountEnd { get; set; }
        public Decimal employerPercentage { get; set; }
        public Decimal employeePercentage { get; set; }
        public Decimal employerValue { get; set; }
        public Decimal employeeValue { get; set; }
    }
}
