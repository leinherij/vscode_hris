using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstTableWTaxSemiMonthlyRI
    {
        void Delete(Int32 id);
        IEnumerable<MstTableWTaxSemiMonthly> Get(Int32 id);
        List<MstTableWTaxSemiMonthly> GetAll();   
        void Post(MstTableWTaxSemiMonthly msttablewtaxsemimonthly);
        void Put(Int32 id, [FromBody] MstTableWTaxSemiMonthly msttablewtaxsemimonthly);
    }
}