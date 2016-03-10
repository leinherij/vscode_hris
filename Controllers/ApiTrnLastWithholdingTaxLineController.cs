using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiTrnLastWithholdingTaxLineController : Controller
    {
        private readonly TrnLastWithholdingTaxLineRI _trnlastwithholdingtaxlineR;
 
        public ApiTrnLastWithholdingTaxLineController(TrnLastWithholdingTaxLineRI trnlastwithholdingtaxlineR)
        {
            _trnlastwithholdingtaxlineR = trnlastwithholdingtaxlineR;
        }
        
        [Route("api/trnlastwithholdingtaxline/list")]
        public IEnumerable<TrnLastWithholdingTaxLine> GetAll()
        {
            return _trnlastwithholdingtaxlineR.GetAll();          
        }
        
        [Route("api/trnlastwithholdingtaxline/list/{id}")]
        public IEnumerable<TrnLastWithholdingTaxLine> Get(Int32 id)
        {
            return _trnlastwithholdingtaxlineR.Get(id);
        }   
                 
        [Route("api/trnlastwithholdingtaxline/add")]  
        public void Post([FromBody]TrnLastWithholdingTaxLine trnlastwithholdingtaxlineadd)
        {     
             _trnlastwithholdingtaxlineR.Post(trnlastwithholdingtaxlineadd);
        }
        
        [Route("api/trnlastwithholdingtaxline/update/{id}")]
        public void Put(Int32 id, [FromBody]TrnLastWithholdingTaxLine trnlastwithholdingtaxlineupdate)
        {          
            _trnlastwithholdingtaxlineR.Put(id, trnlastwithholdingtaxlineupdate);
        }
        
        [Route("api/trnlastwithholdingtaxline/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _trnlastwithholdingtaxlineR.Delete(id);
        }
        
    }
}