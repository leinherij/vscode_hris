using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstEmployeeRI
    {
        void Delete(Int32 id);
        IEnumerable<MstEmployee> Get(Int32 payrollGroupId);
        List<MstEmployee> GetAll();   
        void Post(MstEmployee mstemployee);
        void Put(Int32 id, [FromBody] MstEmployee mstemployee);
    }
}