using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstDepartmentRI
    {
        void Delete(Int32 id);
        IEnumerable<MstDepartment> Get(Int32 id);
        List<MstDepartment> GetAll();   
        void Post(MstDepartment mstdepartment);
        void Put(Int32 id, [FromBody] MstDepartment mstdepartment);
    }
}