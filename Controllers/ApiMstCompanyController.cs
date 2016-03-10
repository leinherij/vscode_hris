using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{     
    public class ApiMstCompanyController : Controller
    {
        private readonly MstCompanyRI _mstcompanyR;
 
        public ApiMstCompanyController(MstCompanyRI mstcompanyR)
        {
            _mstcompanyR = mstcompanyR;
        }
        
        [Route("api/company/list")]
        public IEnumerable<MstCompany> GetAll()
        {
            return _mstcompanyR.GetAll();          
        }
        
        [Route("api/company/list/{id}")]
        public IEnumerable<MstCompany> Get(Int32 id)
        {
            return _mstcompanyR.Get(id);
        }    
          
        [Route("api/company/add")]  
        public void Post([FromBody]MstCompany mstcompanyadd)
        {         
            _mstcompanyR.Post(mstcompanyadd);
        }
        
        [Route("api/company/update/{id}")]
        public void Put(Int32 id, [FromBody]MstCompany mstcompanyupdate)
        {                 
            _mstcompanyR.Put(id, mstcompanyupdate);
        }
        
        [Route("api/company/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstcompanyR.Delete(id);
        }
        
    }
}