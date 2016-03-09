using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiMstOtherDeductionController : Controller
    {
        private readonly MstOtherDeductionRI _mstotherdeductionR;
 
        public ApiMstOtherDeductionController(MstOtherDeductionRI mstotherdeductionR)
        {
            _mstotherdeductionR = mstotherdeductionR;
        }
        
        [Route("api/otherdeduction/list")]
        public IEnumerable<MstOtherDeduction> GetAll()
        {
            return _mstotherdeductionR.GetAll();          
        }
        
        [Route("api/otherdeduction/list/{id}")]
        public IEnumerable<MstOtherDeduction> Get(Int32 id)
        {
            return _mstotherdeductionR.Get(id);
        }   
                 
        [Route("api/otherdeduction/add")]  
        public void Post([FromBody]MstOtherDeduction value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _mstotherdeductionR.Post(value);
  
        }
        
        [Route("api/otherdeduction/update/{id}")]
        public void Put(Int32 id, [FromBody]MstOtherDeduction t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _mstotherdeductionR.Put(id, t);
        }
        
        [Route("api/otherdeduction/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstotherdeductionR.Delete(id);
        }
        
    }
}