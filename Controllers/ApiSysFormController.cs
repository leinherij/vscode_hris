using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiSysFormController : Controller
    {
        private readonly SysFormRI _sysformR;
 
        public ApiSysFormController(SysFormRI sysformR)
        {
            _sysformR = sysformR;
        }
        
        [Route("api/sysform/list")]
        public IEnumerable<SysForm> GetAll()
        {
            return _sysformR.GetAll();          
        }
        
        [Route("api/sysform/list/{id}")]
        public IEnumerable<SysForm> Get(Int32 id)
        {
            return _sysformR.Get(id);
        }   
                 
        [Route("api/sysform/add")]  
        public void Post([FromBody]SysForm sysformadd)
        {      
            _sysformR.Post(sysformadd);
        }
        
        [Route("api/sysform/update/{id}")]
        public void Put(Int32 id, [FromBody]SysForm sysformupdate)
        {        
            _sysformR.Put(id, sysformupdate);
        }
        
        [Route("api/sysform/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _sysformR.Delete(id);
        }
        
    }
}