using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiMstPositionController : Controller
    {
        private readonly MstPositionRI _mstpositionR;
 
        public ApiMstPositionController(MstPositionRI mstpositionR)
        {
            _mstpositionR = mstpositionR;
        }
        
        [Route("api/position/list")]
        public IEnumerable<MstPosition> GetAll()
        {
            return _mstpositionR.GetAll();          
        }
        
        [Route("api/position/list/{id}")]
        public IEnumerable<MstPosition> Get(Int32 id)
        {
            return _mstpositionR.Get(id);
        }   
                 
        [Route("api/position/add")]  
        public void Post([FromBody]MstPosition value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _mstpositionR.Post(value);
  
        }
        
        [Route("api/position/update/{id}")]
        public void Put(Int32 id, [FromBody]MstPosition t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _mstpositionR.Put(id, t);
        }
        
        [Route("api/position/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstpositionR.Delete(id);
        }
        
    }
}