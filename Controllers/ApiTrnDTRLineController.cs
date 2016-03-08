using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiTrnDTRLineController : Controller
    {
        private readonly TrnDTRLineRI _trndtrlineR;
 
        public ApiTrnDTRLineController(TrnDTRLineRI trndtrlineR)
        {
            _trndtrlineR = trndtrlineR;
        }
        
        [Route("api/trndtrline/list")]
        public IEnumerable<TrnDTRLine> GetAll()
        {
            return _trndtrlineR.GetAll();          
        }
        
        [Route("api/trndtrline/list/{id}")]
        public IEnumerable<TrnDTRLine> Get(Int32 id)
        {
            return _trndtrlineR.Get(id);
        }   
                 
        [Route("api/trndtrline/add")]  
        public void Post([FromBody]TrnDTRLine value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _trndtrlineR.Post(value);
  
        }
        
        [Route("api/trndtrline/update/{id}")]
        public void Put(Int32 id, [FromBody]TrnDTRLine t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _trndtrlineR.Put(id, t);
        }
        
        [Route("api/trndtrline/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _trndtrlineR.Delete(id);
        }
        
    }
}