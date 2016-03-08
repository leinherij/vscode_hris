using System;

namespace HRISVSC.Models
{
    public class MstTableSSS
    {
        public Int32 id { get; set; }       
        public Decimal amountStart { get; set; }
        public Decimal amountEnd { get; set; }
        public Decimal employerContribution { get; set; }
        public Decimal employeeContribution { get; set; }
        public Decimal employerEC { get; set; }
        public Decimal employeeEC { get; set; }
    }
}
