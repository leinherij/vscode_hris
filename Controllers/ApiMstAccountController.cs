using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{
     
    public class ApiMstAccountController : Controller
    {
        private readonly MstAccountIFRepository _mstaccountRepository;
 
        public ApiMstAccountController(MstAccountIFRepository mstaccountRepository)
        {
            _mstaccountRepository = mstaccountRepository;
        }
        [Route("api/account/list")]
        [HttpGet]
        public IEnumerable<MstAccount> GetAll()
        {
            return _mstaccountRepository.GetAll();          
        }
        [HttpGet("{id}")]
        public MstAccount Get(int id)
        {
            return _mstaccountRepository.Get(id);
        }           
        [Route("api/account/add")]  
        [HttpPost]
        public void Post([FromBody]MstAccount value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _mstaccountRepository.Post(value);
  
        }
        [Route("api/account/update/{id}")]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]MstAccount t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _mstaccountRepository.Put(id, t);
        }
        
        [Route("api/account/delete/{id}")]  
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _mstaccountRepository.Delete(id);
        }
    }
}