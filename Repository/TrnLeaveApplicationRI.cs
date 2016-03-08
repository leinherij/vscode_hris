using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface TrnLeaveApplicationRI
    {
        void Delete(Int32 id);
        IEnumerable<TrnLeaveApplication> Get(Int32 id);
        List<TrnLeaveApplication> GetAll();   
        void Post(TrnLeaveApplication trnleaveapplication);
        void Put(Int32 id, [FromBody] TrnLeaveApplication trnleaveapplication);
    }
}