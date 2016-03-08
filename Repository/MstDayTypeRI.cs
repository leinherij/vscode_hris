using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstDayTypeRI
    {
        void Delete(Int32 id);
        IEnumerable<MstDayType> Get(Int32 id);
        List<MstDayType> GetAll();   
        void Post(MstDayType mstdaytype);
        void Put(Int32 id, [FromBody] MstDayType mstdaytype);
    }
}