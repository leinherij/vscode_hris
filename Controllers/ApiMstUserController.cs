using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiMstUserController : Controller
    {
        private readonly MstUserRI _mstuserR;
 
        public ApiMstUserController(MstUserRI mstuserR)
        {
            _mstuserR = mstuserR;
        }
        
        [Route("api/user/list")]
        public IEnumerable<MstUser> GetAll()
        {
            return _mstuserR.GetAll();          
        }
        
        [Route("api/user/list/{id}")]
        public IEnumerable<MstUser> Get(Int32 id)
        {
            return _mstuserR.Get(id);
        }   
                 
        [Route("api/user/add")]  
        public void Post([FromBody]MstUser value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _mstuserR.Post(value);
  
        }
        
        [Route("api/user/update/{id}")]
        public void Put(Int32 id, [FromBody]MstUser t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _mstuserR.Put(id, t);
        }
        
        [Route("api/user/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstuserR.Delete(id);
        }
        
    }
}