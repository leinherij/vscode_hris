using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiMstPayrollTypeController : Controller
    {
        private readonly MstPayrollTypeRI _mstpayrolltypeR;
 
        public ApiMstPayrollTypeController(MstPayrollTypeRI mstpayrolltypeR)
        {
            _mstpayrolltypeR = mstpayrolltypeR;
        }
        
        [Route("api/payrolltype/list")]
        public IEnumerable<MstPayrollType> GetAll()
        {
            return _mstpayrolltypeR.GetAll();          
        }
        
        [Route("api/payrolltype/list/{id}")]
        public IEnumerable<MstPayrollType> Get(Int32 id)
        {
            return _mstpayrolltypeR.Get(id);
        }   
                 
        [Route("api/payrolltype/add")]  
        public void Post([FromBody]MstPayrollType value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _mstpayrolltypeR.Post(value);
  
        }
        
        [Route("api/payrolltype/update/{id}")]
        public void Put(Int32 id, [FromBody]MstPayrollType t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _mstpayrolltypeR.Put(id, t);
        }
        
        [Route("api/payrolltype/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstpayrolltypeR.Delete(id);
        }
        
    }
}