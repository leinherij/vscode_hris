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
        public void Post([FromBody]TrnLastWithholdingTaxLine value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _trnlastwithholdingtaxlineR.Post(value);
  
        }
        
        [Route("api/trnlastwithholdingtaxline/update/{id}")]
        public void Put(Int32 id, [FromBody]TrnLastWithholdingTaxLine t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _trnlastwithholdingtaxlineR.Put(id, t);
        }
        
        [Route("api/trnlastwithholdingtaxline/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _trnlastwithholdingtaxlineR.Delete(id);
        }
        
    }
}