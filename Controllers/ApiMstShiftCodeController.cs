using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiMstShiftCodeController : Controller
    {
        private readonly MstShiftCodeRI _mstshiftcodeR;
 
        public ApiMstShiftCodeController(MstShiftCodeRI mstshiftcodeR)
        {
            _mstshiftcodeR = mstshiftcodeR;
        }
        
        [Route("api/shiftcode/list")]
        public IEnumerable<MstShiftCode> GetAll()
        {
            return _mstshiftcodeR.GetAll();          
        }
        
        [Route("api/shiftcode/list/{id}")]
        public IEnumerable<MstShiftCode> Get(Int32 id)
        {
            return _mstshiftcodeR.Get(id);
        }   
                 
        [Route("api/shiftcode/add")]  
        public void Post([FromBody]MstShiftCode mstshiftcodeadd)
        {         
            _mstshiftcodeR.Post(mstshiftcodeadd); 
        }
        
        [Route("api/shiftcode/update/{id}")]
        public void Put(Int32 id, [FromBody]MstShiftCode mstshiftcodeupdate)
        {        
            _mstshiftcodeR.Put(id, mstshiftcodeupdate);
        }
        
        [Route("api/shiftcode/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstshiftcodeR.Delete(id);
        }
        
    }
}