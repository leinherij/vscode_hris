using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface TrnPayrollLineRI
    {
        void Delete(Int32 id);
        IEnumerable<TrnPayrollLine> Get(Int32 id);
        List<TrnPayrollLine> GetAll();   
        void Post(TrnPayrollLine trnpayrollline);
        void Put(Int32 id, [FromBody] TrnPayrollLine trnpayrollline);
    }
}