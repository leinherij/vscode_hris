using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface TrnPayrollOtherDeductionRI
    {
        void Delete(Int32 id);
        IEnumerable<TrnPayrollOtherDeduction> Get(Int32 id);
        List<TrnPayrollOtherDeduction> GetAll();   
        void Post(TrnPayrollOtherDeduction trnpayrollotherdeduction);
        void Put(Int32 id, [FromBody] TrnPayrollOtherDeduction trnpayrollotherdeduction);
    }
}