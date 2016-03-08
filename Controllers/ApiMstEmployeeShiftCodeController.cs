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
        public void Post([FromBody]MstEmployeeShiftCode value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _mstemployeeshiftcodeR.Post(value);
  
        }
        
        [Route("api/employeeshiftcode/update/{id}")]
        public void Put(Int32 id, [FromBody]MstEmployeeShiftCode t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _mstemployeeshiftcodeR.Put(id, t);
        }
        
        [Route("api/employeeshiftcode/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstemployeeshiftcodeR.Delete(id);
        }
        
    }
}