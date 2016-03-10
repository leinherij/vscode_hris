using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{     
    public class ApiMstBranchController : Controller
    {
        private readonly MstBranchRI _mstbranchR;
 
        public ApiMstBranchController(MstBranchRI mstbranchR)
        {
            _mstbranchR = mstbranchR;
        }
        
        [Route("api/branch/list")]
        public IEnumerable<MstBranch> GetAll()
        {
            return _mstbranchR.GetAll();          
        }
        
        [Route("api/branch/list/{id}")]
        public IEnumerable<MstBranch> Get(Int32 id)
        {
            return _mstbranchR.Get(id);
        }    
          
        [Route("api/branch/add")]  
        public void Post([FromBody]MstBranch mstbranchadd)
        {     
            _mstbranchR.Post(mstbranchadd);
        }
        
        [Route("api/branch/update/{id}")]
        public void Put(Int32 id, [FromBody]MstBranch mstbranchupdate)
        {            
            _mstbranchR.Put(id, mstbranchupdate);
        }
        
        [Route("api/branch/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstbranchR.Delete(id);
        }
        
    }
}