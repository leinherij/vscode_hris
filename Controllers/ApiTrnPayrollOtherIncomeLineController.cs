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
        public void Post([FromBody]TrnPayrollOtherIncomeLine value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _trnpayrollotherincomelineR.Post(value);
  
        }
        
        [Route("api/trnpayrollotherincomeline/update/{id}")]
        public void Put(Int32 id, [FromBody]TrnPayrollOtherIncomeLine t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _trnpayrollotherincomelineR.Put(id, t);
        }
        
        [Route("api/trnpayrollotherincomeline/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _trnpayrollotherincomelineR.Delete(id);
        }
        
    }
}