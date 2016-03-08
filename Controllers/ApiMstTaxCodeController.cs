using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiMstTaxCodeController : Controller
    {
        private readonly MstTaxCodeRI _msttaxcodeR;
 
        public ApiMstTaxCodeController(MstTaxCodeRI msttaxcodeR)
        {
            _msttaxcodeR = msttaxcodeR;
        }
        
        [Route("api/taxcode/list")]
        public IEnumerable<MstTaxCode> GetAll()
        {
            return _msttaxcodeR.GetAll();          
        }
        
        [Route("api/taxcode/list/{id}")]
        public IEnumerable<MstTaxCode> Get(Int32 id)
        {
            return _msttaxcodeR.Get(id);
        }   
                 
        [Route("api/taxcode/add")]  
        public void Post([FromBody]MstTaxCode value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _msttaxcodeR.Post(value);
  
        }
        
        [Route("api/taxcode/update/{id}")]
        public void Put(Int32 id, [FromBody]MstTaxCode t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _msttaxcodeR.Put(id, t);
        }
        
        [Route("api/taxcode/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _msttaxcodeR.Delete(id);
        }
        
    }
}