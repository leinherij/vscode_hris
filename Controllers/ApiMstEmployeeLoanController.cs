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
        public void Post([FromBody]MstEmployeeLoan mstemployeeloanadd)
        {       
            _mstemployeeloanR.Post(mstemployeeloanadd);  
        }
        
        [Route("api/employeeloan/update/{id}")]
        public void Put(Int32 id, [FromBody]MstEmployeeLoan mstemployeeloanupdate)
        { 
            _mstemployeeloanR.Put(id, mstemployeeloanupdate);
        }
        
        [Route("api/employeeloan/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstemployeeloanR.Delete(id);
        }
        
    }
}