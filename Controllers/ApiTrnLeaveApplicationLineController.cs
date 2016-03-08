using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiTrnLeaveApplicationLineController : Controller
    {
        private readonly TrnLeaveApplicationLineRI _trnleaveapplicationlineR;
 
        public ApiTrnLeaveApplicationLineController(TrnLeaveApplicationLineRI trnleaveapplicationlineR)
        {
            _trnleaveapplicationlineR = trnleaveapplicationlineR;
        }
        
        [Route("api/trnleaveapplicationline/list")]
        public IEnumerable<TrnLeaveApplicationLine> GetAll()
        {
            return _trnleaveapplicationlineR.GetAll();          
        }
        
        [Route("api/trnleaveapplicationline/list/{id}")]
        public IEnumerable<TrnLeaveApplicationLine> Get(Int32 id)
        {
            return _trnleaveapplicationlineR.Get(id);
        }   
                 
        [Route("api/trnleaveapplicationline/add")]  
        public void Post([FromBody]TrnLeaveApplicationLine value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _trnleaveapplicationlineR.Post(value);
  
        }
        
        [Route("api/trnleaveapplicationline/update/{id}")]
        public void Put(Int32 id, [FromBody]TrnLeaveApplicationLine t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _trnleaveapplicationlineR.Put(id, t);
        }
        
        [Route("api/trnleaveapplicationline/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _trnleaveapplicationlineR.Delete(id);
        }
        
    }
}