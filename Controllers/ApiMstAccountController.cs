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
        public void Post([FromBody]MstAccount mstaccountadd)
        {
            _mstaccountR.Post(mstaccountadd);
        }
        
        [Route("api/account/update/{id}")]
        public void Put(Int32 id, [FromBody]MstAccount mstaccountupdate)
        {           
            _mstaccountR.Put(id, mstaccountupdate);
        }
        
        [Route("api/account/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstaccountR.Delete(id);
        }
        
    }
}