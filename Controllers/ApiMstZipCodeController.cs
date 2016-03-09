using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiMstZipCodeController : Controller
    {
        private readonly MstZipCodeRI _mstzipcodeR;
 
        public ApiMstZipCodeController(MstZipCodeRI mstzipcodeR)
        {
            _mstzipcodeR = mstzipcodeR;
        }
        
        [Route("api/zipcode/list")]
        public IEnumerable<MstZipCode> GetAll()
        {
            return _mstzipcodeR.GetAll();          
        }
        
        [Route("api/zipcode/list/{id}")]
        public IEnumerable<MstZipCode> Get(Int32 id)
        {
            return _mstzipcodeR.Get(id);
        }   
                 
        [Route("api/zipcode/add")]  
        public void Post([FromBody]MstZipCode value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _mstzipcodeR.Post(value);
  
        }
        
        [Route("api/zipcode/update/{id}")]
        public void Put(Int32 id, [FromBody]MstZipCode t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _mstzipcodeR.Put(id, t);
        }
        
        [Route("api/zipcode/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstzipcodeR.Delete(id);
        }
        
    }
}