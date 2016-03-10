using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiMstMandatoryTableController : Controller
    {
        private readonly MstMandatoryTableRI _mstmandatoryR;
 
        public ApiMstMandatoryTableController(MstMandatoryTableRI mstmandatoryR)
        {
            _mstmandatoryR = mstmandatoryR;
        }
        
        [Route("api/mandatorytable/list")]
        public IEnumerable<MstMandatoryTable> GetAll()
        {
            return _mstmandatoryR.GetAll();          
        }
        
        [Route("api/mandatorytable/list/{id}")]
        public IEnumerable<MstMandatoryTable> Get(Int32 id)
        {
            return _mstmandatoryR.Get(id);
        }   
                 
        [Route("api/mandatorytable/add")]  
        public void Post([FromBody]MstMandatoryTable mstmandatoryadd)
        {
            _mstmandatoryR.Post(mstmandatoryadd);  
        }
        
        [Route("api/mandatorytable/update/{id}")]
        public void Put(Int32 id, [FromBody]MstMandatoryTable mstmandatoryupdate)
        {   
            _mstmandatoryR.Put(id, mstmandatoryupdate);
        }
        
        [Route("api/mandatorytable/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstmandatoryR.Delete(id);
        }
        
    }
}