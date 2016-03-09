using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{     
    public class ApiMstCitizenshipController : Controller
    {
        private readonly MstCitizenshipRI _mstcitizenshipR;
 
        public ApiMstCitizenshipController(MstCitizenshipRI mstcitizenshipR)
        {
            _mstcitizenshipR = mstcitizenshipR;
        }
        
        [Route("api/citizenship/list")]
        public IEnumerable<MstCitizenship> GetAll()
        {
            return _mstcitizenshipR.GetAll();          
        }
        
        [Route("api/citizenship/list/{id}")]
        public IEnumerable<MstCitizenship> Get(Int32 id)
        {
            return _mstcitizenshipR.Get(id);
        }    
          
        [Route("api/citizenship/add")]  
        public void Post([FromBody]MstCitizenship value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _mstcitizenshipR.Post(value);
  
        }
        
        [Route("api/citizenship/update/{id}")]
        public void Put(Int32 id, [FromBody]MstCitizenship t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _mstcitizenshipR.Put(id, t);
        }
        
        [Route("api/citizenship/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstcitizenshipR.Delete(id);
        }
        
    }
}