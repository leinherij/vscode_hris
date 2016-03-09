using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface TrnDTRLogRI
    {
        void Delete(Int32 id);
        IEnumerable<TrnDTRLog> Get(Int32 id);
        List<TrnDTRLog> GetAll();   
        void Post(TrnDTRLog trndtrlog);
        void Put(Int32 id, [FromBody] TrnDTRLog trndtrlog);
    }
}