using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiTrnPayrollOtherDeductionLineController : Controller
    {
        private readonly TrnPayrollOtherDeductionLineRI _trnpayrollotherdeductionlineR;
 
        public ApiTrnPayrollOtherDeductionLineController(TrnPayrollOtherDeductionLineRI trnpayrollotherdeductionlineR)
        {
            _trnpayrollotherdeductionlineR = trnpayrollotherdeductionlineR;
        }
        
        [Route("api/trnpayrollotherdeductionline/list")]
        public IEnumerable<TrnPayrollOtherDeductionLine> GetAll()
        {
            return _trnpayrollotherdeductionlineR.GetAll();          
        }
        
        [Route("api/trnpayrollotherdeductionline/list/{id}")]
        public IEnumerable<TrnPayrollOtherDeductionLine> Get(Int32 id)
        {
            return _trnpayrollotherdeductionlineR.Get(id);
        }   
                 
        [Route("api/trnpayrollotherdeductionline/add")]  
        public void Post([FromBody]TrnPayrollOtherDeductionLine value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _trnpayrollotherdeductionlineR.Post(value);
  
        }
        
        [Route("api/trnpayrollotherdeductionline/update/{id}")]
        public void Put(Int32 id, [FromBody]TrnPayrollOtherDeductionLine t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _trnpayrollotherdeductionlineR.Put(id, t);
        }
        
        [Route("api/trnpayrollotherdeductionline/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _trnpayrollotherdeductionlineR.Delete(id);
        }
        
    }
}