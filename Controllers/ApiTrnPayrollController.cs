using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiTrnPayrollController : Controller
    {
        private readonly TrnPayrollRI _trnpayrollR;
 
        public ApiTrnPayrollController(TrnPayrollRI trnpayrollR)
        {
            _trnpayrollR = trnpayrollR;
        }
        
        [Route("api/trnpayroll/list")]
        public IEnumerable<TrnPayroll> GetAll()
        {
            return _trnpayrollR.GetAll();          
        }
        
        [Route("api/trnpayroll/list/{id}")]
        public IEnumerable<TrnPayroll> Get(Int32 id)
        {
            return _trnpayrollR.Get(id);
        }   
                 
        [Route("api/trnpayroll/add")]  
        public void Post([FromBody]TrnPayroll value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _trnpayrollR.Post(value);
  
        }
        
        [Route("api/trnpayroll/update/{id}")]
        public void Put(Int32 id, [FromBody]TrnPayroll t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _trnpayrollR.Put(id, t);
        }
        
        [Route("api/trnpayroll/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _trnpayrollR.Delete(id);
        }
        
    }
}