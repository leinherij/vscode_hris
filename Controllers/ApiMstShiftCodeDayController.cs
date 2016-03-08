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
        public void Post([FromBody]MstShiftCodeDay value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _mstshiftcodedayR.Post(value);
  
        }
        
        [Route("api/shiftcodeday/update/{id}")]
        public void Put(Int32 id, [FromBody]MstShiftCodeDay t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _mstshiftcodedayR.Put(id, t);
        }
        
        [Route("api/shiftcodeday/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstshiftcodedayR.Delete(id);
        }
        
    }
}