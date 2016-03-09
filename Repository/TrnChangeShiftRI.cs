using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface TrnChangeShiftRI
    {
        void Delete(Int32 id);
        IEnumerable<TrnChangeShift> Get(Int32 id);
        List<TrnChangeShift> GetAll();   
        void Post(TrnChangeShift trnchangeshift);
        void Put(Int32 id, [FromBody] TrnChangeShift trnchangeshift);
    }
}