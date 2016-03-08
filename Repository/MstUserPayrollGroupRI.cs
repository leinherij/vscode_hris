using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstUserPayrollGroupRI
    {
        void Delete(Int32 id);
        IEnumerable<MstUserPayrollGroup> Get(Int32 id);
        List<MstUserPayrollGroup> GetAll();   
        void Post(MstUserPayrollGroup mstuserpayrollgroup);
        void Put(Int32 id, [FromBody] MstUserPayrollGroup mstuserpayrollgroup);
    }
}