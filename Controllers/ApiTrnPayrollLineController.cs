using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiTrnPayrollLineController : Controller
    {
        private readonly TrnPayrollLineRI _trnpayrolllineR;
 
        public ApiTrnPayrollLineController(TrnPayrollLineRI trnpayrolllineR)
        {
            _trnpayrolllineR = trnpayrolllineR;
        }
        
        [Route("api/trnpayrollline/list")]
        public IEnumerable<TrnPayrollLine> GetAll()
        {
            return _trnpayrolllineR.GetAll();          
        }
        
        [Route("api/trnpayrollline/list/{id}")]
        public IEnumerable<TrnPayrollLine> Get(Int32 id)
        {
            return _trnpayrolllineR.Get(id);
        }   
                 
        [Route("api/trnpayrollline/add")]  
        public void Post([FromBody]TrnPayrollLine value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _trnpayrolllineR.Post(value);
  
        }
        
        [Route("api/trnpayrollline/update/{id}")]
        public void Put(Int32 id, [FromBody]TrnPayrollLine t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _trnpayrolllineR.Put(id, t);
        }
        
        [Route("api/trnpayrollline/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _trnpayrolllineR.Delete(id);
        }
        
    }
}