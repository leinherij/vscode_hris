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
        public void Post([FromBody]MstUser mstuseradd)
        {       
            _mstuserR.Post(mstuseradd);
        }
        
        [Route("api/user/update/{id}")]
        public void Put(Int32 id, [FromBody]MstUser mstuserupdate)
        {
            _mstuserR.Put(id, mstuserupdate);
        }
        
        [Route("api/user/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstuserR.Delete(id);
        }
        
    }
}