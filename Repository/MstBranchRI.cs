using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstBranchRI
    {
        void Delete(Int32 id);
        IEnumerable<MstBranch> Get(Int32 id);
        List<MstBranch> GetAll();   
        void Post(MstBranch mstbranch);
        void Put(Int32 id, [FromBody] MstBranch mstbranch);
    }
}