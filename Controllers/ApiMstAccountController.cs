using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{     
    public class ApiMstAccountController : Controller
    {
        private readonly MstAccountRI _mstaccountR;
 
        public ApiMstAccountController(MstAccountRI mstaccountR)
        {
            _mstaccountR = mstaccountR;
        }
        
        [Route("api/account/list")]
        public IEnumerable<MstAccount> GetAll()
        {
            return _mstaccountR.GetAll();          
        }
        
        [Route("api/account/list/{id}")]
        public IEnumerable<MstAccount> Get(Int32 id)
        {
            return _mstaccountR.Get(id);
        }    
          
        [Route("api/account/add")]  
        public void Post([FromBody]MstAccount value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _mstaccountR.Post(value);
  
        }
        
        [Route("api/account/update/{id}")]
        public void Put(Int32 id, [FromBody]MstAccount t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _mstaccountR.Put(id, t);
        }
        
        [Route("api/account/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstaccountR.Delete(id);
        }
        
    }
}