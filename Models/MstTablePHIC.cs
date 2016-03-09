using System;

namespace HRISVSC.Models
{
    public class MstTablePHIC
    {
        public Int32 id { get; set; }       
        public Decimal amountStart { get; set; }
        public Decimal amountEnd { get; set; }
        public Int32 salaryBracket { get; set; }
        public Decimal employerContribution { get; set; }
        public Decimal employeeContribution { get; set; }
    }
}
