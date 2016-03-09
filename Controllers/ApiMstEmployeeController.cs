using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiMstEmployeeController : Controller
    {
        private readonly MstEmployeeRI _mstemployeeR;
 
        public ApiMstEmployeeController(MstEmployeeRI mstemployeeR)
        {
            _mstemployeeR = mstemployeeR;
        }
        
        [Route("api/employee/list")]
        public IEnumerable<MstEmployee> GetAll()
        {
            return _mstemployeeR.GetAll();          
        }
        
        [Route("api/employee/list/{id}")]
        public IEnumerable<MstEmployee> Get(Int32 id)
        {
            return _mstemployeeR.Get(id);
        }   
                 
        [Route("api/employee/add")]  
        public void Post([FromBody]MstEmployee value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _mstemployeeR.Post(value);
  
        }
        
        [Route("api/employee/update/{id}")]
        public void Put(Int32 id, [FromBody]MstEmployee t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _mstemployeeR.Put(id, t);
        }
        
        [Route("api/employee/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstemployeeR.Delete(id);
        }
        
    }
}