using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiTrnPayrollOtherIncomeLineController : Controller
    {
        private readonly TrnPayrollOtherIncomeLineRI _trnpayrollotherincomelineR;
 
        public ApiTrnPayrollOtherIncomeLineController(TrnPayrollOtherIncomeLineRI trnpayrollotherincomelineR)
        {
            _trnpayrollotherincomelineR = trnpayrollotherincomelineR;
        }
        
        [Route("api/trnpayrollotherincomeline/list")]
        public IEnumerable<TrnPayrollOtherIncomeLine> GetAll()
        {
            return _trnpayrollotherincomelineR.GetAll();          
        }
        
        [Route("api/trnpayrollotherincomeline/list/{id}")]
        public IEnumerable<TrnPayrollOtherIncomeLine> Get(Int32 id)
        {
            return _trnpayrollotherincomelineR.Get(id);
        }   
                 
        [Route("api/trnpayrollotherincomeline/add")]  
        public void Post([FromBody]TrnPayrollOtherIncomeLine trnpayrollotherincomelineadd)
        {          
            _trnpayrollotherincomelineR.Post(trnpayrollotherincomelineadd);
        }
        
        [Route("api/trnpayrollotherincomeline/update/{id}")]
        public void Put(Int32 id, [FromBody]TrnPayrollOtherIncomeLine trnpayrollotherincomelineupdate)
        {       
            _trnpayrollotherincomelineR.Put(id, trnpayrollotherincomelineupdate);
        }
        
        [Route("api/trnpayrollotherincomeline/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _trnpayrollotherincomelineR.Delete(id);
        }
        
    }
}