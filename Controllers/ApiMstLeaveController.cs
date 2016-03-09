using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiMstLeaveController : Controller
    {
        private readonly MstLeaveRI _mstleaveR;
 
        public ApiMstLeaveController(MstLeaveRI mstleaveR)
        {
            _mstleaveR = mstleaveR;
        }
        
        [Route("api/leave/list")]
        public IEnumerable<MstLeave> GetAll()
        {
            return _mstleaveR.GetAll();          
        }
        
        [Route("api/leave/list/{id}")]
        public IEnumerable<MstLeave> Get(Int32 id)
        {
            return _mstleaveR.Get(id);
        }   
                 
        [Route("api/leave/add")]  
        public void Post([FromBody]MstLeave value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _mstleaveR.Post(value);
  
        }
        
        [Route("api/leave/update/{id}")]
        public void Put(Int32 id, [FromBody]MstLeave t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _mstleaveR.Put(id, t);
        }
        
        [Route("api/leave/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstleaveR.Delete(id);
        }
        
    }
}