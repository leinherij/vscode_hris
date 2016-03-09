using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiMstUserFormController : Controller
    {
        private readonly MstUserFormRI _mstuserformR;
 
        public ApiMstUserFormController(MstUserFormRI mstuserformR)
        {
            _mstuserformR = mstuserformR;
        }
        
        [Route("api/userform/list")]
        public IEnumerable<MstUserForm> GetAll()
        {
            return _mstuserformR.GetAll();          
        }
        
        [Route("api/userform/list/{id}")]
        public IEnumerable<MstUserForm> Get(Int32 id)
        {
            return _mstuserformR.Get(id);
        }   
                 
        [Route("api/userform/add")]  
        public void Post([FromBody]MstUserForm value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _mstuserformR.Post(value);
  
        }
        
        [Route("api/userform/update/{id}")]
        public void Put(Int32 id, [FromBody]MstUserForm t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _mstuserformR.Put(id, t);
        }
        
        [Route("api/userform/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstuserformR.Delete(id);
        }
        
    }
}