using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstPayrollTypeRI
    {
        void Delete(Int32 id);
        IEnumerable<MstPayrollType> Get(Int32 id);
        List<MstPayrollType> GetAll();   
        void Post(MstPayrollType mstpayrolltype);
        void Put(Int32 id, [FromBody] MstPayrollType mstpayrolltype);
    }
}