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
        public void Post([FromBody]TrnPayrollOtherDeduction trnpayrollotherdeductionadd)
        {       
            _trnpayrollotherdeductionR.Post(trnpayrollotherdeductionadd);
        }
        
        [Route("api/trnpayrollotherdeduction/update/{id}")]
        public void Put(Int32 id, [FromBody]TrnPayrollOtherDeduction trnpayrollotherdeductionupdate)
        {       
            _trnpayrollotherdeductionR.Put(id, trnpayrollotherdeductionupdate);
        }
        
        [Route("api/trnpayrollotherdeduction/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _trnpayrollotherdeductionR.Delete(id);
        }
        
    }
}