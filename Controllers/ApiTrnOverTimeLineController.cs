using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiTrnOverTimeLineController : Controller
    {
        private readonly TrnOverTimeLineRI _trnovertimelineR;
 
        public ApiTrnOverTimeLineController(TrnOverTimeLineRI trnovertimelineR)
        {
            _trnovertimelineR = trnovertimelineR;
        }
        
        [Route("api/trnovertimeline/list")]
        public IEnumerable<TrnOverTimeLine> GetAll()
        {
            return _trnovertimelineR.GetAll();          
        }
        
        [Route("api/trnovertimeline/list/{id}")]
        public IEnumerable<TrnOverTimeLine> Get(Int32 id)
        {
            return _trnovertimelineR.Get(id);
        }   
                 
        [Route("api/trnovertimeline/add")]  
        public void Post([FromBody]TrnOverTimeLine trnovertimelineadd)
        {         
             _trnovertimelineR.Post(trnovertimelineadd);
        }
        
        [Route("api/trnovertimeline/update/{id}")]
        public void Put(Int32 id, [FromBody]TrnOverTimeLine trnovertimelineupdate)
        {        
            _trnovertimelineR.Put(id, trnovertimelineupdate);
        }
        
        [Route("api/trnovertimeline/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _trnovertimelineR.Delete(id);
        }
        
    }
}