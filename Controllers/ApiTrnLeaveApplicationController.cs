using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiTrnLeaveApplicationController : Controller
    {
        private readonly TrnLeaveApplicationRI _trnleaveapplicationR;
 
        public ApiTrnLeaveApplicationController(TrnLeaveApplicationRI trnleaveapplicationR)
        {
            _trnleaveapplicationR = trnleaveapplicationR;
        }
        
        [Route("api/trnleaveapplication/list")]
        public IEnumerable<TrnLeaveApplication> GetAll()
        {
            return _trnleaveapplicationR.GetAll();          
        }
        
        [Route("api/trnleaveapplication/list/{id}")]
        public IEnumerable<TrnLeaveApplication> Get(Int32 id)
        {
            return _trnleaveapplicationR.Get(id);
        }   
                 
        [Route("api/trnleaveapplication/add")]  
        public void Post([FromBody]TrnLeaveApplication value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _trnleaveapplicationR.Post(value);
  
        }
        
        [Route("api/trnleaveapplication/update/{id}")]
        public void Put(Int32 id, [FromBody]TrnLeaveApplication t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _trnleaveapplicationR.Put(id, t);
        }
        
        [Route("api/trnleaveapplication/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _trnleaveapplicationR.Delete(id);
        }
        
    }
}