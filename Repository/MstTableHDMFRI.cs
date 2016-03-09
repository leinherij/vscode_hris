using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstTableHDMFRI
    {
        void Delete(Int32 id);
        IEnumerable<MstTableHDMF> Get(Int32 id);
        List<MstTableHDMF> GetAll();   
        void Post(MstTableHDMF msttablehdmf);
        void Put(Int32 id, [FromBody] MstTableHDMF msttablehdmf);
    }
}