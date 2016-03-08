using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstDivisionRI
    {
        void Delete(Int32 id);
        IEnumerable<MstDivision> Get(Int32 id);
        List<MstDivision> GetAll();   
        void Post(MstDivision mstdivision);
        void Put(Int32 id, [FromBody] MstDivision mstdivision);
    }
}