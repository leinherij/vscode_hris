using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiMstEmployeeShiftCodeController : Controller
    {
        private readonly MstEmployeeShiftCodeRI _mstemployeeshiftcodeR;
 
        public ApiMstEmployeeShiftCodeController(MstEmployeeShiftCodeRI mstemployeeshiftcodeR)
        {
            _mstemployeeshiftcodeR = mstemployeeshiftcodeR;
        }
        
        [Route("api/employeeshiftcode/list")]
        public IEnumerable<MstEmployeeShiftCode> GetAll()
        {
            return _mstemployeeshiftcodeR.GetAll();          
        }
        
        [Route("api/employeeshiftcode/list/{id}")]
        public IEnumerable<MstEmployeeShiftCode> Get(Int32 id)
        {
            return _mstemployeeshiftcodeR.Get(id);
        }   
                 
        [Route("api/employeeshiftcode/add")]  
        public void Post([FromBody]MstEmployeeShiftCode mstemployeeshiftcodeadd)
        {
            _mstemployeeshiftcodeR.Post(mstemployeeshiftcodeadd);
        }
        
        [Route("api/employeeshiftcode/update/{id}")]
        public void Put(Int32 id, [FromBody]MstEmployeeShiftCode mstemployeeshiftcodeupdate)
        {           
            _mstemployeeshiftcodeR.Put(id, mstemployeeshiftcodeupdate);
        }
        
        [Route("api/employeeshiftcode/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstemployeeshiftcodeR.Delete(id);
        }
        
    }
}