using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstPeriodRI
    {
        void Delete(Int32 id);
        IEnumerable<MstPeriod> Get(Int32 id);
        List<MstPeriod> GetAll();   
        void Post(MstPeriod mstperiod);
        void Put(Int32 id, [FromBody] MstPeriod mstperiod);
    }
}