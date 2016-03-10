using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiMstLeaveController : Controller
    {
        private readonly MstLeaveRI _mstleaveR;
 
        public ApiMstLeaveController(MstLeaveRI mstleaveR)
        {
            _mstleaveR = mstleaveR;
        }
        
        [Route("api/leave/list")]
        public IEnumerable<MstLeave> GetAll()
        {
            return _mstleaveR.GetAll();          
        }
        
        [Route("api/leave/list/{id}")]
        public IEnumerable<MstLeave> Get(Int32 id)
        {
            return _mstleaveR.Get(id);
        }   
                 
        [Route("api/leave/add")]  
        public void Post([FromBody]MstLeave mstleaveadd)
        {       
            _mstleaveR.Post(mstleaveadd);
        }
        
        [Route("api/leave/update/{id}")]
        public void Put(Int32 id, [FromBody]MstLeave mstleaveupdate)
        {
            _mstleaveR.Put(id, mstleaveupdate);
        }
        
        [Route("api/leave/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstleaveR.Delete(id);
        }
        
    }
}