using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface TrnPayrollRI
    {
        void Delete(Int32 id);
        IEnumerable<TrnPayroll> Get(Int32 id);
        List<TrnPayroll> GetAll();   
        void Post(TrnPayroll trnpayroll);
        void Put(Int32 id, [FromBody] TrnPayroll trnpayroll);
    }
}