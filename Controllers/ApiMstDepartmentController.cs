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
        public void Post([FromBody]MstDepartment value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _mstdepartmentR.Post(value);
  
        }
        
        [Route("api/department/update/{id}")]
        public void Put(Int32 id, [FromBody]MstDepartment t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _mstdepartmentR.Put(id, t);
        }
        
        [Route("api/department/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstdepartmentR.Delete(id);
        }
        
    }
}