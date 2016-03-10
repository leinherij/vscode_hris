using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiTrnLeaveApplicationController : Controller
    {
        private readonly TrnLeaveApplicationRI _trnleaveapplicationR;
 
        public ApiTrnLeaveApplicationController(TrnLeaveApplicationRI trnleaveapplicationR)
        {
            _trnleaveapplicationR = trnleaveapplicationR;
        }
        
        [Route("api/trnleaveapplication/list")]
        public IEnumerable<TrnLeaveApplication> GetAll()
        {
            return _trnleaveapplicationR.GetAll();          
        }
        
        [Route("api/trnleaveapplication/list/{id}")]
        public IEnumerable<TrnLeaveApplication> Get(Int32 id)
        {
            return _trnleaveapplicationR.Get(id);
        }   
                 
        [Route("api/trnleaveapplication/add")]  
        public void Post([FromBody]TrnLeaveApplication trnleaveapplicationadd)
        {        
            _trnleaveapplicationR.Post(trnleaveapplicationadd);
        }
        
        [Route("api/trnleaveapplication/update/{id}")]
        public void Put(Int32 id, [FromBody]TrnLeaveApplication trnleaveapplicationupdate)
        {      
            _trnleaveapplicationR.Put(id, trnleaveapplicationupdate);
        }
        
        [Route("api/trnleaveapplication/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _trnleaveapplicationR.Delete(id);
        }
        
    }
}