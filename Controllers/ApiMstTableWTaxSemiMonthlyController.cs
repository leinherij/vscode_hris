using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiMstTableWTaxSemiMonthlyController : Controller
    {
        private readonly MstTableWTaxSemiMonthlyRI _msttablewtaxsemimonthlyR;
 
        public ApiMstTableWTaxSemiMonthlyController(MstTableWTaxSemiMonthlyRI msttablewtaxsemimonthlyR)
        {
            _msttablewtaxsemimonthlyR = msttablewtaxsemimonthlyR;
        }
        
        [Route("api/tablewtaxsemimonthly/list")]
        public IEnumerable<MstTableWTaxSemiMonthly> GetAll()
        {
            return _msttablewtaxsemimonthlyR.GetAll();          
        }
        
        [Route("api/tablewtaxsemimonthly/list/{id}")]
        public IEnumerable<MstTableWTaxSemiMonthly> Get(Int32 id)
        {
            return _msttablewtaxsemimonthlyR.Get(id);
        }   
                 
        [Route("api/tablewtaxsemimonthly/add")]  
        public void Post([FromBody]MstTableWTaxSemiMonthly value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _msttablewtaxsemimonthlyR.Post(value);
  
        }
        
        [Route("api/tablewtaxsemimonthly/update/{id}")]
        public void Put(Int32 id, [FromBody]MstTableWTaxSemiMonthly t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _msttablewtaxsemimonthlyR.Put(id, t);
        }
        
        [Route("api/tablewtaxsemimonthly/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _msttablewtaxsemimonthlyR.Delete(id);
        }
        
    }
}