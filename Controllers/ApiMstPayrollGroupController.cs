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
        public void Post([FromBody]MstPayrollGroup mstpayrollgroupadd)
        {       
            _mstpayrollgroupR.Post(mstpayrollgroupadd);
        }
        
        [Route("api/payrollgroup/update/{id}")]
        public void Put(Int32 id, [FromBody]MstPayrollGroup mstpayrollgroupupdate)
        {          
            _mstpayrollgroupR.Put(id, mstpayrollgroupupdate);
        }
        
        [Route("api/payrollgroup/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstpayrollgroupR.Delete(id);
        }
        
    }
}