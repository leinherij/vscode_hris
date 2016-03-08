using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstReligionRI
    {
        void Delete(Int32 id);
        IEnumerable<MstReligion> Get(Int32 id);
        List<MstReligion> GetAll();   
        void Post(MstReligion mstreligion);
        void Put(Int32 id, [FromBody] MstReligion mstreligion);
    }
}