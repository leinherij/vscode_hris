using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface TrnLastWithholdingTaxLineRI
    {
        void Delete(Int32 id);
        IEnumerable<TrnLastWithholdingTaxLine> Get(Int32 id);
        List<TrnLastWithholdingTaxLine> GetAll();   
        void Post(TrnLastWithholdingTaxLine trnlastwithholdingtaxline);
        void Put(Int32 id, [FromBody] TrnLastWithholdingTaxLine trnlastwithholdingtaxline);
    }
}