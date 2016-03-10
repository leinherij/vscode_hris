using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{     
    public class ApiMstDayTypeController : Controller
    {
        private readonly MstDayTypeRI _mstdaytypeR;
 
        public ApiMstDayTypeController(MstDayTypeRI mstdaytypeR)
        {
            _mstdaytypeR = mstdaytypeR;
        }
        
        [Route("api/daytype/list")]
        public IEnumerable<MstDayType> GetAll()
        {
            return _mstdaytypeR.GetAll();          
        }
        
        [Route("api/daytype/list/{id}")]
        public IEnumerable<MstDayType> Get(Int32 id)
        {
            return _mstdaytypeR.Get(id);
        }    
          
        [Route("api/daytype/add")]  
        public void Post([FromBody]MstDayType mstdaytypeadd)
        {            
            _mstdaytypeR.Post(mstdaytypeadd);
        }
        
        [Route("api/daytype/update/{id}")]
        public void Put(Int32 id, [FromBody]MstDayType mstdaytypeupdate)
        {       
            _mstdaytypeR.Put(id, mstdaytypeupdate);
        }
        
        [Route("api/daytype/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstdaytypeR.Delete(id);
        }
        
    }
}