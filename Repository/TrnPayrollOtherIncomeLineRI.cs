using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface TrnPayrollOtherIncomeLineRI
    {
        void Delete(Int32 id);
        IEnumerable<TrnPayrollOtherIncomeLine> Get(Int32 id);
        List<TrnPayrollOtherIncomeLine> GetAll();   
        void Post(TrnPayrollOtherIncomeLine trnpayrollotherincomeline);
        void Put(Int32 id, [FromBody] TrnPayrollOtherIncomeLine trnpayrollotherincomeline);
    }
}