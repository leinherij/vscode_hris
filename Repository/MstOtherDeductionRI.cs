using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstOtherDeductionRI
    {
        void Delete(Int32 id);
        IEnumerable<MstOtherDeduction> Get(Int32 id);
        List<MstOtherDeduction> GetAll();   
        void Post(MstOtherDeduction mstotherdeduction);
        void Put(Int32 id, [FromBody] MstOtherDeduction mstotherdeduction);
    }
}