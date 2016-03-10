using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiTrnChangeShiftController : Controller
    {
        private readonly TrnChangeShiftRI _trnchangeshiftR;
 
        public ApiTrnChangeShiftController(TrnChangeShiftRI trnchangeshiftR)
        {
            _trnchangeshiftR = trnchangeshiftR;
        }
        
        [Route("api/trnchangeshift/list")]
        public IEnumerable<TrnChangeShift> GetAll()
        {
            return _trnchangeshiftR.GetAll();          
        }
        
        [Route("api/trnchangeshift/list/{id}")]
        public IEnumerable<TrnChangeShift> Get(Int32 id)
        {
            return _trnchangeshiftR.Get(id);
        }   
                 
        [Route("api/trnchangeshift/add")]  
        public void Post([FromBody]TrnChangeShift trnchangeshiftadd)
        {         
            _trnchangeshiftR.Post(trnchangeshiftadd);
        }
        
        [Route("api/trnchangeshift/update/{id}")]
        public void Put(Int32 id, [FromBody]TrnChangeShift trnchangeshiftupdate)
        {       
            _trnchangeshiftR.Put(id, trnchangeshiftupdate);
        }
        
        [Route("api/trnchangeshift/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _trnchangeshiftR.Delete(id);
        }
        
    }
}