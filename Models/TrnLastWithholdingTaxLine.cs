using System;

namespace HRISVSC.Models
{
    public class TrnLastWithholdingTaxLine
    {
        public Int32 id { get; set; }
        public Int32 lastWithholdingTaxId { get; set; }
        public Int32 employeeId { get; set; }
        public Int32 taxCodeId { get; set; }
        public Decimal totalNetSalaryAmount { get; set; }
        public Decimal totalOtherIncomeTaxable { get; set; }
        public Decimal totalSSSContribution { get; set; }
        public Decimal totalSSSECContribution { get; set; }
        public Decimal totalPHICContribution { get; set; }
        public Decimal totalHDMFContribution { get; set; }
        public Decimal totalOtherDeductionTaxable { get; set; }
        public Decimal exemption { get; set; }
        public Decimal tax { get; set; }
        public Decimal taxWithheld { get; set; }
        public Decimal lastTax { get; set; }
        
        
    }
}
