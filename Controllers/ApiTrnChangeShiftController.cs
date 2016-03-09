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
        public void Post([FromBody]TrnChangeShift value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _trnchangeshiftR.Post(value);
  
        }
        
        [Route("api/trnchangeshift/update/{id}")]
        public void Put(Int32 id, [FromBody]TrnChangeShift t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _trnchangeshiftR.Put(id, t);
        }
        
        [Route("api/trnchangeshift/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _trnchangeshiftR.Delete(id);
        }
        
    }
}