using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{     
    public class ApiMstDayTypeDayController : Controller
    {
        private readonly MstDayTypeDayRI _mstdaytypedayR;
 
        public ApiMstDayTypeDayController(MstDayTypeDayRI mstdaytypedayR)
        {
            _mstdaytypedayR = mstdaytypedayR;
        }
        
        [Route("api/daytypeday/list")]
        public IEnumerable<MstDayTypeDay> GetAll()
        {
            return _mstdaytypedayR.GetAll();          
        }
        
        [Route("api/daytypeday/list/{id}")]
        public IEnumerable<MstDayTypeDay> Get(Int32 id)
        {
            return _mstdaytypedayR.Get(id);
        }    
          
        [Route("api/daytypeday/add")]  
        public void Post([FromBody]MstDayTypeDay mstdaytypedayadd)
        {
            _mstdaytypedayR.Post(mstdaytypedayadd);
        }
        
        [Route("api/daytypeday/update/{id}")]
        public void Put(Int32 id, [FromBody]MstDayTypeDay mstdaytypedayupdate)
        {
            _mstdaytypedayR.Put(id, mstdaytypedayupdate);
        }
        
        [Route("api/daytypeday/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstdaytypedayR.Delete(id);
        }
        
    }
}