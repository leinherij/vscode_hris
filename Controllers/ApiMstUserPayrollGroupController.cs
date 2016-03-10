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
        public void Post([FromBody]MstUserPayrollGroup mstuserpayrollgroupadd)
        {          
            _mstuserpayrollgroupR.Post(mstuserpayrollgroupadd);
        }
        
        [Route("api/userpayrollgroup/update/{id}")]
        public void Put(Int32 id, [FromBody]MstUserPayrollGroup mstuserpayrollgroupupdate)
        {         
            _mstuserpayrollgroupR.Put(id, mstuserpayrollgroupupdate);
        }
        
        [Route("api/userpayrollgroup/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstuserpayrollgroupR.Delete(id);
        }
        
    }
}