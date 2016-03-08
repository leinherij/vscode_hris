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
        public void Post([FromBody]MstDivision value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _mstdivisionR.Post(value);
  
        }
        
        [Route("api/division/update/{id}")]
        public void Put(Int32 id, [FromBody]MstDivision t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _mstdivisionR.Put(id, t);
        }
        
        [Route("api/division/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstdivisionR.Delete(id);
        }
        
    }
}