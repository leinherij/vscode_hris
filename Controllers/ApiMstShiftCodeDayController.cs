using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiMstShiftCodeDayController : Controller
    {
        private readonly MstShiftCodeDayRI _mstshiftcodedayR;
 
        public ApiMstShiftCodeDayController(MstShiftCodeDayRI mstshiftcodedayR)
        {
            _mstshiftcodedayR = mstshiftcodedayR;
        }
        
        [Route("api/shiftcodeday/list")]
        public IEnumerable<MstShiftCodeDay> GetAll()
        {
            return _mstshiftcodedayR.GetAll();          
        }
        
        [Route("api/shiftcodeday/list/{id}")]
        public IEnumerable<MstShiftCodeDay> Get(Int32 id)
        {
            return _mstshiftcodedayR.Get(id);
        }   
                 
        [Route("api/shiftcodeday/add")]  
        public void Post([FromBody]MstShiftCodeDay mstshiftcodedayadd)
        {     
            _mstshiftcodedayR.Post(mstshiftcodedayadd);
        }
        
        [Route("api/shiftcodeday/update/{id}")]
        public void Put(Int32 id, [FromBody]MstShiftCodeDay mstshiftcodedayupdate)
        {         
            _mstshiftcodedayR.Put(id, mstshiftcodedayupdate);
        }
        
        [Route("api/shiftcodeday/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstshiftcodedayR.Delete(id);
        }
        
    }
}