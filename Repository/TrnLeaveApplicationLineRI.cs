using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface TrnLeaveApplicationLineRI
    {
        void Delete(Int32 id);
        IEnumerable<TrnLeaveApplicationLine> Get(Int32 id);
        List<TrnLeaveApplicationLine> GetAll();   
        void Post(TrnLeaveApplicationLine trnleaveapplicationline);
        void Put(Int32 id, [FromBody] TrnLeaveApplicationLine trnleaveapplicationline);
    }
}