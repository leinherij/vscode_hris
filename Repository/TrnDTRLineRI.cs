using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface TrnDTRLineRI
    {
        void Delete(Int32 id);
        IEnumerable<TrnDTRLine> Get(Int32 id);
        List<TrnDTRLine> GetAll();   
        void Post(TrnDTRLine trndtrline);
        void Put(Int32 id, [FromBody] TrnDTRLine trndtrline);
    }
}