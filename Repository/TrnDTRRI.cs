using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface TrnDTRRI
    {
        void Delete(Int32 id);
        IEnumerable<TrnDTR> Get(Int32 id);
        List<TrnDTR> GetAll();   
        void Post(TrnDTR trndtr);
        void Put(Int32 id, [FromBody] TrnDTR trndtr);
    }
}