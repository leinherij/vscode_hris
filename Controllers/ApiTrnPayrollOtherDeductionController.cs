using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiTrnPayrollOtherDeductionController : Controller
    {
        private readonly TrnPayrollOtherDeductionRI _trnpayrollotherdeductionR;
 
        public ApiTrnPayrollOtherDeductionController(TrnPayrollOtherDeductionRI trnpayrollotherdeductionR)
        {
            _trnpayrollotherdeductionR = trnpayrollotherdeductionR;
        }
        
        [Route("api/trnpayrollotherdeduction/list")]
        public IEnumerable<TrnPayrollOtherDeduction> GetAll()
        {
            return _trnpayrollotherdeductionR.GetAll();          
        }
        
        [Route("api/trnpayrollotherdeduction/list/{id}")]
        public IEnumerable<TrnPayrollOtherDeduction> Get(Int32 id)
        {
            return _trnpayrollotherdeductionR.Get(id);
        }   
                 
        [Route("api/trnpayrollotherdeduction/add")]  
        public void Post([FromBody]TrnPayrollOtherDeduction value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _trnpayrollotherdeductionR.Post(value);
  
        }
        
        [Route("api/trnpayrollotherdeduction/update/{id}")]
        public void Put(Int32 id, [FromBody]TrnPayrollOtherDeduction t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _trnpayrollotherdeductionR.Put(id, t);
        }
        
        [Route("api/trnpayrollotherdeduction/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _trnpayrollotherdeductionR.Delete(id);
        }
        
    }
}