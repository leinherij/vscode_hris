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
        public void Post([FromBody]MstOtherIncome mstotherincomeadd)
        {     
            _mstotherincomeR.Post(mstotherincomeadd);
        }
        
        [Route("api/otherincome/update/{id}")]
        public void Put(Int32 id, [FromBody]MstOtherIncome mstotherincomeupdate)
        {      
            _mstotherincomeR.Put(id, mstotherincomeupdate);
        }
        
        [Route("api/otherincome/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstotherincomeR.Delete(id);
        }
        
    }
}