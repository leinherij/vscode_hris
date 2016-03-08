using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstEmployeeLoanRI
    {
        void Delete(Int32 id);
        IEnumerable<MstEmployeeLoan> Get(Int32 id);
        List<MstEmployeeLoan> GetAll();   
        void Post(MstEmployeeLoan mstemployeeloan);
        void Put(Int32 id, [FromBody] MstEmployeeLoan mstemployeeloan);
    }
}