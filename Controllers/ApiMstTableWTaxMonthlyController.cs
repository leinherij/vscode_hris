using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiMstTableWTaxMonthlyController : Controller
    {
        private readonly MstTableWTaxMonthlyRI _msttablewtaxmonthlyR;
 
        public ApiMstTableWTaxMonthlyController(MstTableWTaxMonthlyRI msttablewtaxmonthlyR)
        {
            _msttablewtaxmonthlyR = msttablewtaxmonthlyR;
        }
        
        [Route("api/tablewtaxmonthly/list")]
        public IEnumerable<MstTableWTaxMonthly> GetAll()
        {
            return _msttablewtaxmonthlyR.GetAll();          
        }
        
        [Route("api/tablewtaxmonthly/list/{id}")]
        public IEnumerable<MstTableWTaxMonthly> Get(Int32 id)
        {
            return _msttablewtaxmonthlyR.Get(id);
        }   
                 
        [Route("api/tablewtaxmonthly/add")]  
        public void Post([FromBody]MstTableWTaxMonthly msttablewtaxmonthlyadd)
        {          
            _msttablewtaxmonthlyR.Post(msttablewtaxmonthlyadd);
        }
        
        [Route("api/tablewtaxmonthly/update/{id}")]
        public void Put(Int32 id, [FromBody]MstTableWTaxMonthly msttablewtaxmonthlyupdate)
        {         
            _msttablewtaxmonthlyR.Put(id, msttablewtaxmonthlyupdate);
        }
        
        [Route("api/tablewtaxmonthly/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _msttablewtaxmonthlyR.Delete(id);
        }
        
    }
}