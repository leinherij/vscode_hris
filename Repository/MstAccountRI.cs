using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstAccountRI
    {
        void Delete(Int32 id);
        IEnumerable<MstAccount> Get(Int32 id);
        List<MstAccount> GetAll();   
        void Post(MstAccount mstaccount);
        void Put(Int32 id, [FromBody] MstAccount mstaccount);
    }
}