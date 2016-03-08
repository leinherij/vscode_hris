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
        public void Post([FromBody]MstCompany value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _mstcompanyR.Post(value);
  
        }
        
        [Route("api/company/update/{id}")]
        public void Put(Int32 id, [FromBody]MstCompany t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _mstcompanyR.Put(id, t);
        }
        
        [Route("api/company/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstcompanyR.Delete(id);
        }
        
    }
}