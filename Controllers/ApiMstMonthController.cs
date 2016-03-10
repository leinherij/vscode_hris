using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiMstMonthController : Controller
    {
        private readonly MstMonthRI _mstmonthR;
 
        public ApiMstMonthController(MstMonthRI mstmonthR)
        {
            _mstmonthR = mstmonthR;
        }
        
        [Route("api/month/list")]
        public IEnumerable<MstMonth> GetAll()
        {
            return _mstmonthR.GetAll();          
        }
        
        [Route("api/month/list/{id}")]
        public IEnumerable<MstMonth> Get(Int32 id)
        {
            return _mstmonthR.Get(id);
        }   
                 
        [Route("api/month/add")]  
        public void Post([FromBody]MstMonth mstmonthadd)
        {
            _mstmonthR.Post(mstmonthadd);
        }
        
        [Route("api/month/update/{id}")]
        public void Put(Int32 id, [FromBody]MstMonth mstmonthupdate)
        {
            _mstmonthR.Put(id, mstmonthupdate);
        }
        
        [Route("api/month/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstmonthR.Delete(id);
        }
        
    }
}