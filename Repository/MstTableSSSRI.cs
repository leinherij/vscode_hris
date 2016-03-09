using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstTableSSSRI
    {
        void Delete(Int32 id);
        IEnumerable<MstTableSSS> Get(Int32 id);
        List<MstTableSSS> GetAll();   
        void Post(MstTableSSS msttablesss);
        void Put(Int32 id, [FromBody] MstTableSSS msttablesss);
    }
}