using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface TrnPayrollOtherDeductionLineRI
    {
        void Delete(Int32 id);
        IEnumerable<TrnPayrollOtherDeductionLine> Get(Int32 id);
        List<TrnPayrollOtherDeductionLine> GetAll();   
        void Post(TrnPayrollOtherDeductionLine trnpayrollotherdeductionline);
        void Put(Int32 id, [FromBody] TrnPayrollOtherDeductionLine trnpayrollotherdeductionline);
    }
}