using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiMstReligionController : Controller
    {
        private readonly MstReligionRI _mstreligionR;
 
        public ApiMstReligionController(MstReligionRI mstreligionR)
        {
            _mstreligionR = mstreligionR;
        }
        
        [Route("api/religion/list")]
        public IEnumerable<MstReligion> GetAll()
        {
            return _mstreligionR.GetAll();          
        }
        
        [Route("api/religion/list/{id}")]
        public IEnumerable<MstReligion> Get(Int32 id)
        {
            return _mstreligionR.Get(id);
        }   
                 
        [Route("api/religion/add")]  
        public void Post([FromBody]MstReligion value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _mstreligionR.Post(value);
  
        }
        
        [Route("api/religion/update/{id}")]
        public void Put(Int32 id, [FromBody]MstReligion t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _mstreligionR.Put(id, t);
        }
        
        [Route("api/religion/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstreligionR.Delete(id);
        }
        
    }
}