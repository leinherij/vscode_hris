using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstUserRI
    {
        void Delete(Int32 id);
        IEnumerable<MstUser> Get(Int32 id);
        List<MstUser> GetAll();   
        void Post(MstUser mstuser);
        void Put(Int32 id, [FromBody] MstUser mstuser);
    }
}