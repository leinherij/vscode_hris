using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface TrnChangeShiftLineRI
    {
        void Delete(Int32 id);
        IEnumerable<TrnChangeShiftLine> Get(Int32 id);
        List<TrnChangeShiftLine> GetAll();   
        void Post(TrnChangeShiftLine trnchangeshiftline);
        void Put(Int32 id, [FromBody] TrnChangeShiftLine trnchangeshiftline);
    }
}