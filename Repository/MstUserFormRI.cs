using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstUserFormRI
    {
        void Delete(Int32 id);
        IEnumerable<MstUserForm> Get(Int32 id);
        List<MstUserForm> GetAll();   
        void Post(MstUserForm mstuserform);
        void Put(Int32 id, [FromBody] MstUserForm mstuserform);
    }
}