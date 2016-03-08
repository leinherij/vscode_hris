using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstPositionRI
    {
        void Delete(Int32 id);
        IEnumerable<MstPosition> Get(Int32 id);
        List<MstPosition> GetAll();   
        void Post(MstPosition mstposition);
        void Put(Int32 id, [FromBody] MstPosition mstposition);
    }
}