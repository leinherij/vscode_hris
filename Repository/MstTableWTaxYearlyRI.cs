using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstTableWTaxYearlyRI
    {
        void Delete(Int32 id);
        IEnumerable<MstTableWTaxYearly> Get(Int32 id);
        List<MstTableWTaxYearly> GetAll();   
        void Post(MstTableWTaxYearly msttablewtaxyearly);
        void Put(Int32 id, [FromBody] MstTableWTaxYearly msttablewtaxyearly);
    }
}