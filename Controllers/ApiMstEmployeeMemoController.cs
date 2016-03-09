using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiMstEmployeeMemoController : Controller
    {
        private readonly MstEmployeeMemoRI _mstemployeememoR;
 
        public ApiMstEmployeeMemoController(MstEmployeeMemoRI mstemployeememoR)
        {
            _mstemployeememoR = mstemployeememoR;
        }
        
        [Route("api/employeememo/list")]
        public IEnumerable<MstEmployeeMemo> GetAll()
        {
            return _mstemployeememoR.GetAll();          
        }
        
        [Route("api/employeememo/list/{id}")]
        public IEnumerable<MstEmployeeMemo> Get(Int32 id)
        {
            return _mstemployeememoR.Get(id);
        }   
                 
        [Route("api/employeememo/add")]  
        public void Post([FromBody]MstEmployeeMemo value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _mstemployeememoR.Post(value);
  
        }
        
        [Route("api/employeememo/update/{id}")]
        public void Put(Int32 id, [FromBody]MstEmployeeMemo t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _mstemployeememoR.Put(id, t);
        }
        
        [Route("api/employeememo/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstemployeememoR.Delete(id);
        }
        
    }
}