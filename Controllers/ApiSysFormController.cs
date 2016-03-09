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
        public void Post([FromBody]SysForm value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _sysformR.Post(value);
  
        }
        
        [Route("api/sysform/update/{id}")]
        public void Put(Int32 id, [FromBody]SysForm t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _sysformR.Put(id, t);
        }
        
        [Route("api/sysform/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _sysformR.Delete(id);
        }
        
    }
}