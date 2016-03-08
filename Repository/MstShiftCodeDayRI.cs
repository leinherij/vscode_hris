using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstShiftCodeDayRI
    {
        void Delete(Int32 id);
        IEnumerable<MstShiftCodeDay> Get(Int32 id);
        List<MstShiftCodeDay> GetAll();   
        void Post(MstShiftCodeDay mstshiftcodeday);
        void Put(Int32 id, [FromBody] MstShiftCodeDay mstshiftcodeday);
    }
}