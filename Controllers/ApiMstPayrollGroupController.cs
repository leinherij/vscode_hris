using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiMstPayrollGroupController : Controller
    {
        private readonly MstPayrollGroupRI _mstpayrollgroupR;
 
        public ApiMstPayrollGroupController(MstPayrollGroupRI mstpayrollgroupR)
        {
            _mstpayrollgroupR = mstpayrollgroupR;
        }
        
        [Route("api/payrollgroup/list")]
        public IEnumerable<MstPayrollGroup> GetAll()
        {
            return _mstpayrollgroupR.GetAll();          
        }
        
        [Route("api/payrollgroup/list/{id}")]
        public IEnumerable<MstPayrollGroup> Get(Int32 id)
        {
            return _mstpayrollgroupR.Get(id);
        }   
                 
        [Route("api/payrollgroup/add")]  
        public void Post([FromBody]MstPayrollGroup value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _mstpayrollgroupR.Post(value);
  
        }
        
        [Route("api/payrollgroup/update/{id}")]
        public void Put(Int32 id, [FromBody]MstPayrollGroup t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _mstpayrollgroupR.Put(id, t);
        }
        
        [Route("api/payrollgroup/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstpayrollgroupR.Delete(id);
        }
        
    }
}