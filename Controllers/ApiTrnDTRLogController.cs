using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiTrnDTRLogController : Controller
    {
        private readonly TrnDTRLogRI _trndtrlogR;
 
        public ApiTrnDTRLogController(TrnDTRLogRI trndtrlogR)
        {
            _trndtrlogR = trndtrlogR;
        }
        
        [Route("api/trndtrlog/list")]
        public IEnumerable<TrnDTRLog> GetAll()
        {
            return _trndtrlogR.GetAll();          
        }
        
        [Route("api/trndtrlog/list/{id}")]
        public IEnumerable<TrnDTRLog> Get(Int32 id)
        {
            return _trndtrlogR.Get(id);
        }   
                 
        [Route("api/trndtrlog/add")]  
        public void Post([FromBody]TrnDTRLog value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _trndtrlogR.Post(value);
  
        }
        
        [Route("api/trndtrlog/update/{id}")]
        public void Put(Int32 id, [FromBody]TrnDTRLog t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _trndtrlogR.Put(id, t);
        }
        
        [Route("api/trndtrlog/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _trndtrlogR.Delete(id);
        }
        
    }
}