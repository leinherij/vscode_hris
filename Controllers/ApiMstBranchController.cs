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
        public void Post([FromBody]MstBranch value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _mstbranchR.Post(value);
  
        }
        
        [Route("api/branch/update/{id}")]
        public void Put(Int32 id, [FromBody]MstBranch t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _mstbranchR.Put(id, t);
        }
        
        [Route("api/branch/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstbranchR.Delete(id);
        }
        
    }
}