using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiMstPeriodController : Controller
    {
        private readonly MstPeriodRI _mstperiodR;
 
        public ApiMstPeriodController(MstPeriodRI mstperiodR)
        {
            _mstperiodR = mstperiodR;
        }
        
        [Route("api/period/list")]
        public IEnumerable<MstPeriod> GetAll()
        {
            return _mstperiodR.GetAll();          
        }
        
        [Route("api/period/list/{id}")]
        public IEnumerable<MstPeriod> Get(Int32 id)
        {
            return _mstperiodR.Get(id);
        }   
                 
        [Route("api/period/add")]  
        public void Post([FromBody]MstPeriod mstperiodadd)
        {         
             _mstperiodR.Post(mstperiodadd);
        }
        
        [Route("api/period/update/{id}")]
        public void Put(Int32 id, [FromBody]MstPeriod mstperiodupdate)
        {  
            _mstperiodR.Put(id, mstperiodupdate);
        }
        
        [Route("api/period/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstperiodR.Delete(id);
        }
        
    }
}