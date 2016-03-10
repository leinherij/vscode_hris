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
        public void Post([FromBody]MstEmployeeMemo mstemployeememoadd)
        {      
            _mstemployeememoR.Post(mstemployeememoadd);
        }
        
        [Route("api/employeememo/update/{id}")]
        public void Put(Int32 id, [FromBody]MstEmployeeMemo mstemployeememoupdate)
        {
            _mstemployeememoR.Put(id, mstemployeememoupdate);
        }
        
        [Route("api/employeememo/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstemployeememoR.Delete(id);
        }
        
    }
}