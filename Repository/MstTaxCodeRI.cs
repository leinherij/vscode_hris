using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstTaxCodeRI
    {
        void Delete(Int32 id);
        IEnumerable<MstTaxCode> Get(Int32 id);
        List<MstTaxCode> GetAll();   
        void Post(MstTaxCode msttaxcode);
        void Put(Int32 id, [FromBody] MstTaxCode msttaxcode);
    }
}