using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiTrnLeaveLedgerController : Controller
    {
        private readonly TrnLeaveLedgerRI _trnleaveledgerR;
 
        public ApiTrnLeaveLedgerController(TrnLeaveLedgerRI trnleaveledgerR)
        {
            _trnleaveledgerR = trnleaveledgerR;
        }
        
        [Route("api/trnleaveledger/list")]
        public IEnumerable<TrnLeaveLedger> GetAll()
        {
            return _trnleaveledgerR.GetAll();          
        }
        
        [Route("api/trnleaveledger/list/{id}")]
        public IEnumerable<TrnLeaveLedger> Get(Int32 id)
        {
            return _trnleaveledgerR.Get(id);
        }   
                 
        [Route("api/trnleaveledger/add")]  
        public void Post([FromBody]TrnLeaveLedger trnleaveledgeradd)
        {        
            _trnleaveledgerR.Post(trnleaveledgeradd);
        }
        
        [Route("api/trnleaveledger/update/{id}")]
        public void Put(Int32 id, [FromBody]TrnLeaveLedger trnleaveledgerupdate)
        {       
            _trnleaveledgerR.Put(id, trnleaveledgerupdate);
        }
        
        [Route("api/trnleaveledger/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _trnleaveledgerR.Delete(id);
        }
        
    }
}