using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{     
    public class ApiMstDivisionController : Controller
    {
        private readonly MstDivisionRI _mstdivisionR;
 
        public ApiMstDivisionController(MstDivisionRI mstdivisionR)
        {
            _mstdivisionR = mstdivisionR;
        }
        
        [Route("api/division/list")]
        public IEnumerable<MstDivision> GetAll()
        {
            return _mstdivisionR.GetAll();          
        }
        
        [Route("api/division/list/{id}")]
        public IEnumerable<MstDivision> Get(Int32 id)
        {
            return _mstdivisionR.Get(id);
        }    
          
        [Route("api/division/add")]  
        public void Post([FromBody]MstDivision mstdivisionadd)
        {    
            _mstdivisionR.Post(mstdivisionadd);
        }
        
        [Route("api/division/update/{id}")]
        public void Put(Int32 id, [FromBody]MstDivision mstdivisionupdate)
        {
            _mstdivisionR.Put(id, mstdivisionupdate);
        }
        
        [Route("api/division/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstdivisionR.Delete(id);
        }
        
    }
}