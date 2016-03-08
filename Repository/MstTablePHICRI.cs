using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstTablePHICRI
    {
        void Delete(Int32 id);
        IEnumerable<MstTablePHIC> Get(Int32 id);
        List<MstTablePHIC> GetAll();   
        void Post(MstTablePHIC msttablephic);
        void Put(Int32 id, [FromBody] MstTablePHIC msttablephic);
    }
}