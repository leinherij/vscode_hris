using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiMstUserPayrollGroupController : Controller
    {
        private readonly MstUserPayrollGroupRI _mstuserpayrollgroupR;
 
        public ApiMstUserPayrollGroupController(MstUserPayrollGroupRI mstuserpayrollgroupR)
        {
            _mstuserpayrollgroupR = mstuserpayrollgroupR;
        }
        
        [Route("api/userpayrollgroup/list")]
        public IEnumerable<MstUserPayrollGroup> GetAll()
        {
            return _mstuserpayrollgroupR.GetAll();          
        }
        
        [Route("api/userpayrollgroup/list/{id}")]
        public IEnumerable<MstUserPayrollGroup> Get(Int32 id)
        {
            return _mstuserpayrollgroupR.Get(id);
        }   
                 
        [Route("api/userpayrollgroup/add")]  
        public void Post([FromBody]MstUserPayrollGroup value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _mstuserpayrollgroupR.Post(value);
  
        }
        
        [Route("api/userpayrollgroup/update/{id}")]
        public void Put(Int32 id, [FromBody]MstUserPayrollGroup t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _mstuserpayrollgroupR.Put(id, t);
        }
        
        [Route("api/userpayrollgroup/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstuserpayrollgroupR.Delete(id);
        }
        
    }
}