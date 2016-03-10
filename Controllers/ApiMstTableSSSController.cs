using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiMstTableSSSController : Controller
    {
        private readonly MstTableSSSRI _msttablesssR;
 
        public ApiMstTableSSSController(MstTableSSSRI msttablesssR)
        {
            _msttablesssR = msttablesssR;
        }
        
        [Route("api/tablesss/list")]
        public IEnumerable<MstTableSSS> GetAll()
        {
            return _msttablesssR.GetAll();          
        }
        
        [Route("api/tablesss/list/{id}")]
        public IEnumerable<MstTableSSS> Get(Int32 id)
        {
            return _msttablesssR.Get(id);
        }   
                 
        [Route("api/tablesss/add")]  
        public void Post([FromBody]MstTableSSS msttablesssadd)
        {      
            _msttablesssR.Post(msttablesssadd); 
        }
        
        [Route("api/tablesss/update/{id}")]
        public void Put(Int32 id, [FromBody]MstTableSSS msttablesssupdate)
        {        
            _msttablesssR.Put(id, msttablesssupdate);
        }
        
        [Route("api/tablesss/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _msttablesssR.Delete(id);
        }
        
    }
}