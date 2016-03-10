using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiMstTableWTaxYearlyController : Controller
    {
        private readonly MstTableWTaxYearlyRI _msttablewtaxyearlyR;
 
        public ApiMstTableWTaxYearlyController(MstTableWTaxYearlyRI msttablewtaxyearlyR)
        {
            _msttablewtaxyearlyR = msttablewtaxyearlyR;
        }
        
        [Route("api/tablewtaxyearly/list")]
        public IEnumerable<MstTableWTaxYearly> GetAll()
        {
            return _msttablewtaxyearlyR.GetAll();          
        }
        
        [Route("api/tablewtaxyearly/list/{id}")]
        public IEnumerable<MstTableWTaxYearly> Get(Int32 id)
        {
            return _msttablewtaxyearlyR.Get(id);
        }   
                 
        [Route("api/tablewtaxyearly/add")]  
        public void Post([FromBody]MstTableWTaxYearly msttablewtaxyearlyadd)
        {         
            _msttablewtaxyearlyR.Post(msttablewtaxyearlyadd);
        }
        
        [Route("api/tablewtaxyearly/update/{id}")]
        public void Put(Int32 id, [FromBody]MstTableWTaxYearly msttablewtaxyearlyupdate)
        {        
            _msttablewtaxyearlyR.Put(id, msttablewtaxyearlyupdate);
        }
        
        [Route("api/tablewtaxyearly/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _msttablewtaxyearlyR.Delete(id);
        }
        
    }
}