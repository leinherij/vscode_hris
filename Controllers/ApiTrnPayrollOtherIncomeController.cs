using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiTrnPayrollOtherIncomeController : Controller
    {
        private readonly TrnPayrollOtherIncomeRI _trnpayrollotherincomeR;
 
        public ApiTrnPayrollOtherIncomeController(TrnPayrollOtherIncomeRI trnpayrollotherincomeR)
        {
            _trnpayrollotherincomeR = trnpayrollotherincomeR;
        }
        
        [Route("api/trnpayrollotherincome/list")]
        public IEnumerable<TrnPayrollOtherIncome> GetAll()
        {
            return _trnpayrollotherincomeR.GetAll();          
        }
        
        [Route("api/trnpayrollotherincome/list/{id}")]
        public IEnumerable<TrnPayrollOtherIncome> Get(Int32 id)
        {
            return _trnpayrollotherincomeR.Get(id);
        }   
                 
        [Route("api/trnpayrollotherincome/add")]  
        public void Post([FromBody]TrnPayrollOtherIncome trnpayrollotherincomeadd)
        {         
            _trnpayrollotherincomeR.Post(trnpayrollotherincomeadd);
        }
        
        [Route("api/trnpayrollotherincome/update/{id}")]
        public void Put(Int32 id, [FromBody]TrnPayrollOtherIncome trnpayrollotherincomeupdate)
        {       
            _trnpayrollotherincomeR.Put(id, trnpayrollotherincomeupdate);
        }
        
        [Route("api/trnpayrollotherincome/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _trnpayrollotherincomeR.Delete(id);
        }
        
    }
}