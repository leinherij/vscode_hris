using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiMstTableHDMFController : Controller
    {
        private readonly MstTableHDMFRI _msttablehdmfR;
 
        public ApiMstTableHDMFController(MstTableHDMFRI msttablehdmfR)
        {
            _msttablehdmfR = msttablehdmfR;
        }
        
        [Route("api/tablehdmf/list")]
        public IEnumerable<MstTableHDMF> GetAll()
        {
            return _msttablehdmfR.GetAll();          
        }
        
        [Route("api/tablehdmf/list/{id}")]
        public IEnumerable<MstTableHDMF> Get(Int32 id)
        {
            return _msttablehdmfR.Get(id);
        }   
                 
        [Route("api/tablehdmf/add")]  
        public void Post([FromBody]MstTableHDMF value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _msttablehdmfR.Post(value);
  
        }
        
        [Route("api/tablehdmf/update/{id}")]
        public void Put(Int32 id, [FromBody]MstTableHDMF t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _msttablehdmfR.Put(id, t);
        }
        
        [Route("api/tablehdmf/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _msttablehdmfR.Delete(id);
        }
        
    }
}