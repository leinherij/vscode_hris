using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiTrnChangeShiftLineController : Controller
    {
        private readonly TrnChangeShiftLineRI _trnchangeshiftlineR;
 
        public ApiTrnChangeShiftLineController(TrnChangeShiftLineRI trnchangeshiftlineR)
        {
            _trnchangeshiftlineR = trnchangeshiftlineR;
        }
        
        [Route("api/trnchangeshiftline/list")]
        public IEnumerable<TrnChangeShiftLine> GetAll()
        {
            return _trnchangeshiftlineR.GetAll();          
        }
        
        [Route("api/trnchangeshiftline/list/{id}")]
        public IEnumerable<TrnChangeShiftLine> Get(Int32 id)
        {
            return _trnchangeshiftlineR.Get(id);
        }   
                 
        [Route("api/trnchangeshiftline/add")]  
        public void Post([FromBody]TrnChangeShiftLine value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _trnchangeshiftlineR.Post(value);
  
        }
        
        [Route("api/trnchangeshiftline/update/{id}")]
        public void Put(Int32 id, [FromBody]TrnChangeShiftLine t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _trnchangeshiftlineR.Put(id, t);
        }
        
        [Route("api/trnchangeshiftline/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _trnchangeshiftlineR.Delete(id);
        }
        
    }
}