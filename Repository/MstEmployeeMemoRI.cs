using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstEmployeeMemoRI
    {
        void Delete(Int32 id);
        IEnumerable<MstEmployeeMemo> Get(Int32 id);
        List<MstEmployeeMemo> GetAll();   
        void Post(MstEmployeeMemo mstemployeememo);
        void Put(Int32 id, [FromBody] MstEmployeeMemo mstemployeememo);
    }
}