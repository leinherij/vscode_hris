using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface TrnOverTimeRI
    {
        void Delete(Int32 id);
        IEnumerable<TrnOverTime> Get(Int32 id);
        List<TrnOverTime> GetAll();   
        void Post(TrnOverTime trnovertime);
        void Put(Int32 id, [FromBody] TrnOverTime trnovertime);
    }
}