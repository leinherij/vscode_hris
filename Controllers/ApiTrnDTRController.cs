using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiTrnDTRController : Controller
    {
        private readonly TrnDTRRI _trndtrR;
 
        public ApiTrnDTRController(TrnDTRRI trndtrR)
        {
            _trndtrR = trndtrR;
        }
        
        [Route("api/trndtr/list")]
        public IEnumerable<TrnDTR> GetAll()
        {
            return _trndtrR.GetAll();          
        }
        
        [Route("api/trndtr/list/{id}")]
        public IEnumerable<TrnDTR> Get(Int32 id)
        {
            return _trndtrR.Get(id);
        }   
                 
        [Route("api/trndtr/add")]  
        public void Post([FromBody]TrnDTR value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _trndtrR.Post(value);
  
        }
        
        [Route("api/trndtr/update/{id}")]
        public void Put(Int32 id, [FromBody]TrnDTR t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _trndtrR.Put(id, t);
        }
        
        [Route("api/trndtr/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _trndtrR.Delete(id);
        }
        
    }
}