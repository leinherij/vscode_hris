using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiTrnLastWithholdingTaxController : Controller
    {
        private readonly TrnLastWithholdingTaxRI _trnlastwithholdingtaxR;
 
        public ApiTrnLastWithholdingTaxController(TrnLastWithholdingTaxRI trnlastwithholdingtaxR)
        {
            _trnlastwithholdingtaxR = trnlastwithholdingtaxR;
        }
        
        [Route("api/trnlastwithholdingtax/list")]
        public IEnumerable<TrnLastWithholdingTax> GetAll()
        {
            return _trnlastwithholdingtaxR.GetAll();          
        }
        
        [Route("api/trnlastwithholdingtax/list/{id}")]
        public IEnumerable<TrnLastWithholdingTax> Get(Int32 id)
        {
            return _trnlastwithholdingtaxR.Get(id);
        }   
                 
        [Route("api/trnlastwithholdingtax/add")]  
        public void Post([FromBody]TrnLastWithholdingTax trnlastwithholdingtaxadd)
        {          
            _trnlastwithholdingtaxR.Post(trnlastwithholdingtaxadd);
        }
        
        [Route("api/trnlastwithholdingtax/update/{id}")]
        public void Put(Int32 id, [FromBody]TrnLastWithholdingTax trnlastwithholdingtaxupdate)
        {           
            _trnlastwithholdingtaxR.Put(id, trnlastwithholdingtaxupdate);
        }
        
        [Route("api/trnlastwithholdingtax/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _trnlastwithholdingtaxR.Delete(id);
        }
        
    }
}