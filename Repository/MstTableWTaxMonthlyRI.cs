using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstTableWTaxMonthlyRI
    {
        void Delete(Int32 id);
        IEnumerable<MstTableWTaxMonthly> Get(Int32 id);
        List<MstTableWTaxMonthly> GetAll();   
        void Post(MstTableWTaxMonthly msttablewtaxmonthly);
        void Put(Int32 id, [FromBody] MstTableWTaxMonthly msttablewtaxmonthly);
    }
}