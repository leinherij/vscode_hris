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
        public void Post([FromBody]MstShiftCode value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _mstshiftcodeR.Post(value);
  
        }
        
        [Route("api/shiftcode/update/{id}")]
        public void Put(Int32 id, [FromBody]MstShiftCode t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _mstshiftcodeR.Put(id, t);
        }
        
        [Route("api/shiftcode/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstshiftcodeR.Delete(id);
        }
        
    }
}