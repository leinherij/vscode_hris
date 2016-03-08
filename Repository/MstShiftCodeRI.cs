using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstShiftCodeRI
    {
        void Delete(Int32 id);
        IEnumerable<MstShiftCode> Get(Int32 id);
        List<MstShiftCode> GetAll();   
        void Post(MstShiftCode mstshiftcode);
        void Put(Int32 id, [FromBody] MstShiftCode mstshiftcode);
    }
}