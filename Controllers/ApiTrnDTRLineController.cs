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
        public void Post([FromBody]TrnDTRLine trndtrlineadd)
        {         
            _trndtrlineR.Post(trndtrlineadd);
        }
        
        [Route("api/trndtrline/update/{id}")]
        public void Put(Int32 id, [FromBody]TrnDTRLine trndtrlineupdate)
        {   
            _trndtrlineR.Put(id, trndtrlineupdate);
        }
        
        [Route("api/trndtrline/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _trndtrlineR.Delete(id);
        }
        
    }
}