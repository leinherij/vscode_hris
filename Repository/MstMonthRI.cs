using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstMonthRI
    {
        void Delete(Int32 id);
        IEnumerable<MstMonth> Get(Int32 id);
        List<MstMonth> GetAll();   
        void Post(MstMonth mstmonth);
        void Put(Int32 id, [FromBody] MstMonth mstmonth);
    }
}