using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface SysFormRI
    {
        void Delete(Int32 id);
        IEnumerable<SysForm> Get(Int32 id);
        List<SysForm> GetAll();   
        void Post(SysForm sysform);
        void Put(Int32 id, [FromBody] SysForm sysform);
    }
}