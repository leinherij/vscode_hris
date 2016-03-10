using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiTrnOverTimeController : Controller
    {
        private readonly TrnOverTimeRI _trnovertimeR;
 
        public ApiTrnOverTimeController(TrnOverTimeRI trnovertimeR)
        {
            _trnovertimeR = trnovertimeR;
        }
        
        [Route("api/trnovertime/list")]
        public IEnumerable<TrnOverTime> GetAll()
        {
            return _trnovertimeR.GetAll();          
        }
        
        [Route("api/trnovertime/list/{id}")]
        public IEnumerable<TrnOverTime> Get(Int32 id)
        {
            return _trnovertimeR.Get(id);
        }   
                 
        [Route("api/trnovertime/add")]  
        public void Post([FromBody]TrnOverTime trnovertimeadd)
        {     
            _trnovertimeR.Post(trnovertimeadd);
        }
        
        [Route("api/trnovertime/update/{id}")]
        public void Put(Int32 id, [FromBody]TrnOverTime trnovertimeupdate)
        {      
            _trnovertimeR.Put(id, trnovertimeupdate);
        }
        
        [Route("api/trnovertime/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _trnovertimeR.Delete(id);
        }
        
    }
}