using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiMstEmployeeLoanController : Controller
    {
        private readonly MstEmployeeLoanRI _mstemployeeloanR;
 
        public ApiMstEmployeeLoanController(MstEmployeeLoanRI mstemployeeloanR)
        {
            _mstemployeeloanR = mstemployeeloanR;
        }
        
        [Route("api/employeeloan/list")]
        public IEnumerable<MstEmployeeLoan> GetAll()
        {
            return _mstemployeeloanR.GetAll();          
        }
        
        [Route("api/employeeloan/list/{id}")]
        public IEnumerable<MstEmployeeLoan> Get(Int32 id)
        {
            return _mstemployeeloanR.Get(id);
        }   
                 
        [Route("api/employeeloan/add")]  
        public void Post([FromBody]MstEmployeeLoan value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _mstemployeeloanR.Post(value);
  
        }
        
        [Route("api/employeeloan/update/{id}")]
        public void Put(Int32 id, [FromBody]MstEmployeeLoan t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _mstemployeeloanR.Put(id, t);
        }
        
        [Route("api/employeeloan/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstemployeeloanR.Delete(id);
        }
        
    }
}