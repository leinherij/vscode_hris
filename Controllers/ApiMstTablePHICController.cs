using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiMstTablePHICController : Controller
    {
        private readonly MstTablePHICRI _msttablephicR;
 
        public ApiMstTablePHICController(MstTablePHICRI msttablephicR)
        {
            _msttablephicR = msttablephicR;
        }
        
        [Route("api/tablephic/list")]
        public IEnumerable<MstTablePHIC> GetAll()
        {
            return _msttablephicR.GetAll();          
        }
        
        [Route("api/tablephic/list/{id}")]
        public IEnumerable<MstTablePHIC> Get(Int32 id)
        {
            return _msttablephicR.Get(id);
        }   
                 
        [Route("api/tablephic/add")]  
        public void Post([FromBody]MstTablePHIC value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _msttablephicR.Post(value);
  
        }
        
        [Route("api/tablephic/update/{id}")]
        public void Put(Int32 id, [FromBody]MstTablePHIC t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _msttablephicR.Put(id, t);
        }
        
        [Route("api/tablephic/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _msttablephicR.Delete(id);
        }
        
    }
}