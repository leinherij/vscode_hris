using System;
using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{    
    public class ApiMstPeriodController : Controller
    {
        private readonly MstPeriodRI _mstperiodR;
 
        public ApiMstPeriodController(MstPeriodRI mstperiodR)
        {
            _mstperiodR = mstperiodR;
        }
        
        [Route("api/period/list")]
        public IEnumerable<MstPeriod> GetAll()
        {
            return _mstperiodR.GetAll();          
        }
        
        [Route("api/period/list/{id}")]
        public IEnumerable<MstPeriod> Get(Int32 id)
        {
            return _mstperiodR.Get(id);
        }   
                 
        [Route("api/period/add")]  
        public void Post([FromBody]MstPeriod value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _mstperiodR.Post(value);
  
        }
        
        [Route("api/period/update/{id}")]
        public void Put(Int32 id, [FromBody]MstPeriod t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _mstperiodR.Put(id, t);
        }
        
        [Route("api/period/delete/{id}")]  
        public void Delete(Int32 id)
        {
            _mstperiodR.Delete(id);
        }
        
    }
}