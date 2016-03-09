using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstEmployeeShiftCodeRI
    {
        void Delete(Int32 id);
        IEnumerable<MstEmployeeShiftCode> Get(Int32 id);
        List<MstEmployeeShiftCode> GetAll();   
        void Post(MstEmployeeShiftCode mstemployeeshiftcode);
        void Put(Int32 id, [FromBody] MstEmployeeShiftCode mstemployeeshiftcode);
    }
}