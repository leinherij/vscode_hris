using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{     
    public class ApiMstDepartmentController : Controller
    {
        private readonly MstDepartmentRI _mstdepartmentR;
 
        public ApiMstDepartmentController(MstDepartmentRI mstdepartmentR)
        {
            _mstdepartmentR = mstdepartmentR;
        }
        
        [Route("api/department/list")]
        public IEnumerable<MstDepartment> GetAll()
        {
            return _mstdepartmentR.GetAll();          
        }
        
        [Route("api/department/list/{id}")]
        public IEnumerable<MstDepartment> Get(Int32 id)
        {
            return _mstdepartmentR.Get(id);
        }    
          
        [Route("api/department/add")]  
        public void Post([FromBody]MstDepartment mstdepartmentadd)
        {
            _mstdepartmentR.Post(mstdepartmentadd);            
        }
        
        [Route("api/department/update/{id}")]
        public void Put(Int32 id, [FromBody]MstDepartment mstdepartmentupdate)
        {               
            _mstdepartmentR.Put(id, mstdepartmentupdate);
        }
        
        [Route("api/department/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstdepartmentR.Delete(id);
        }
        
    }
}