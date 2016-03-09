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
        public void Post([FromBody]TrnLeaveLedger value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _trnleaveledgerR.Post(value);
  
        }
        
        [Route("api/trnleaveledger/update/{id}")]
        public void Put(Int32 id, [FromBody]TrnLeaveLedger t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _trnleaveledgerR.Put(id, t);
        }
        
        [Route("api/trnleaveledger/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _trnleaveledgerR.Delete(id);
        }
        
    }
}