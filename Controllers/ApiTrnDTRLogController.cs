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
        public void Post([FromBody]TrnDTRLog trndtrlogadd)
        {         
            _trndtrlogR.Post(trndtrlogadd);
        }
        
        [Route("api/trndtrlog/update/{id}")]
        public void Put(Int32 id, [FromBody]TrnDTRLog trndtrlogupdate)
        {          
            _trndtrlogR.Put(id, trndtrlogupdate);
        }
        
        [Route("api/trndtrlog/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _trndtrlogR.Delete(id);
        }
        
    }
}