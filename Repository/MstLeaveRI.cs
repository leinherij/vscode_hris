using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstLeaveRI
    {
        void Delete(Int32 id);
        IEnumerable<MstLeave> Get(Int32 id);
        List<MstLeave> GetAll();   
        void Post(MstLeave mstleave);
        void Put(Int32 id, [FromBody] MstLeave mstleave);
    }
}