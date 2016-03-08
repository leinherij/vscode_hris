using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstPayrollGroupRI
    {
        void Delete(Int32 id);
        IEnumerable<MstPayrollGroup> Get(Int32 id);
        List<MstPayrollGroup> GetAll();   
        void Post(MstPayrollGroup mstpayrollgroup);
        void Put(Int32 id, [FromBody] MstPayrollGroup mstpayrollgroup);
    }
}