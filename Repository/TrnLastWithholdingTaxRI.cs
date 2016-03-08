using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface TrnLastWithholdingTaxRI
    {
        void Delete(Int32 id);
        IEnumerable<TrnLastWithholdingTax> Get(Int32 id);
        List<TrnLastWithholdingTax> GetAll();   
        void Post(TrnLastWithholdingTax trnlastwithholdingtax);
        void Put(Int32 id, [FromBody] TrnLastWithholdingTax trnlastwithholdingtax);
    }
}