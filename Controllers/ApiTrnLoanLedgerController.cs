using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiTrnLoanLedgerController : Controller
    {
        private readonly TrnLoanLedgerRI _trnloanledgerR;
 
        public ApiTrnLoanLedgerController(TrnLoanLedgerRI trnloanledgerR)
        {
            _trnloanledgerR = trnloanledgerR;
        }
        
        [Route("api/trnloanledger/list")]
        public IEnumerable<TrnLoanLedger> GetAll()
        {
            return _trnloanledgerR.GetAll();          
        }
        
        [Route("api/trnloanledger/list/{id}")]
        public IEnumerable<TrnLoanLedger> Get(Int32 id)
        {
            return _trnloanledgerR.Get(id);
        }   
                 
        [Route("api/trnloanledger/add")]  
        public void Post([FromBody]TrnLoanLedger value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _trnloanledgerR.Post(value);
  
        }
        
        [Route("api/trnloanledger/update/{id}")]
        public void Put(Int32 id, [FromBody]TrnLoanLedger t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _trnloanledgerR.Put(id, t);
        }
        
        [Route("api/trnloanledger/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _trnloanledgerR.Delete(id);
        }
        
    }
}