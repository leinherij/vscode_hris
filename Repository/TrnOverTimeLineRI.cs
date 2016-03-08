using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface TrnOverTimeLineRI
    {
        void Delete(Int32 id);
        IEnumerable<TrnOverTimeLine> Get(Int32 id);
        List<TrnOverTimeLine> GetAll();   
        void Post(TrnOverTimeLine trnovertimeline);
        void Put(Int32 id, [FromBody] TrnOverTimeLine trnovertimeline);
    }
}