using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiMstOtherIncomeController : Controller
    {
        private readonly MstOtherIncomeRI _mstotherincomeR;
 
        public ApiMstOtherIncomeController(MstOtherIncomeRI mstotherincomeR)
        {
            _mstotherincomeR = mstotherincomeR;
        }
        
        [Route("api/otherincome/list")]
        public IEnumerable<MstOtherIncome> GetAll()
        {
            return _mstotherincomeR.GetAll();          
        }
        
        [Route("api/otherincome/list/{id}")]
        public IEnumerable<MstOtherIncome> Get(Int32 id)
        {
            return _mstotherincomeR.Get(id);
        }   
                 
        [Route("api/otherincome/add")]  
        public void Post([FromBody]MstOtherIncome value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _mstotherincomeR.Post(value);
  
        }
        
        [Route("api/otherincome/update/{id}")]
        public void Put(Int32 id, [FromBody]MstOtherIncome t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _mstotherincomeR.Put(id, t);
        }
        
        [Route("api/otherincome/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstotherincomeR.Delete(id);
        }
        
    }
}