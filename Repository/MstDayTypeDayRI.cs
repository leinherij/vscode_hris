using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstDayTypeDayRI
    {
        void Delete(Int32 id);
        IEnumerable<MstDayTypeDay> Get(Int32 id);
        List<MstDayTypeDay> GetAll();   
        void Post(MstDayTypeDay mstdaytypeday);
        void Put(Int32 id, [FromBody] MstDayTypeDay mstdaytypeday);
    }
}