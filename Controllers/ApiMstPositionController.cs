using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiMstPositionController : Controller
    {
        private readonly MstPositionRI _mstpositionR;
 
        public ApiMstPositionController(MstPositionRI mstpositionR)
        {
            _mstpositionR = mstpositionR;
        }
        
        [Route("api/position/list")]
        public IEnumerable<MstPosition> GetAll()
        {
            return _mstpositionR.GetAll();          
        }
        
        [Route("api/position/list/{id}")]
        public IEnumerable<MstPosition> Get(Int32 id)
        {
            return _mstpositionR.Get(id);
        }   
                 
        [Route("api/position/add")]  
        public void Post([FromBody]MstPosition mstpositionadd)
        {         
            _mstpositionR.Post(mstpositionadd);  
        }
        
        [Route("api/position/update/{id}")]
        public void Put(Int32 id, [FromBody]MstPosition mstpositionupdate)
        {                 
            _mstpositionR.Put(id, mstpositionupdate);
        }
        
        [Route("api/position/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstpositionR.Delete(id);
        }
        
    }
}