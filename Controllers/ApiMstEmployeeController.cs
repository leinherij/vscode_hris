using System.Collections.Generic;
using HRISVSC.Models;
using HRISVSC.Repository;
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{
     
    public class ApiMstEmployeeController : Controller
    {
        private readonly MstEmployeeIFRepository _mstemployeeRepository;
 
        public ApiMstEmployeeController(MstEmployeeIFRepository mstemployeeRepository)
        {
            _mstemployeeRepository = mstemployeeRepository;
        }
        [Route("api/employee/list")]
        [HttpGet]
        public IEnumerable<MstEmployee> GetAll()
        {
            return _mstemployeeRepository.GetAll();          
        }
        [HttpGet("{id}")]
        public MstEmployee Get(int id)
        {
            return _mstemployeeRepository.Get(id);
        }           
        [Route("api/employee/add")]  
        [HttpPost]
        public void Post([FromBody]MstEmployee value)
        {
        //    MstEmployee user = new MstEmployee()
        //     {
        //         name = value.name,
        //         address = value.address,
        //         gender = value.gender,
        //         age = value.age
        //     };
        //     value = user;           
             _mstemployeeRepository.Post(value);
  
        }
        [Route("api/employee/update/{id}")]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]MstEmployee t)
        {
            // MstEmployee user = new MstEmployee()
            // {
            //     name = t.name,
            //     address = t.address,
            //     gender = t.gender,
            //     age = t.age
            // };
            // t = user;           
            _mstemployeeRepository.Put(id, t);
        }
        
        [Route("api/employee/delete/{id}")]  
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _mstemployeeRepository.Delete(id);
        }
    }
}