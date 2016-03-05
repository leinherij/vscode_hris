using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;
namespace HRISVSC.Repository
{   
    public interface MstEmployeeIFRepository
    {
        void Delete(int id);
        MstEmployee Get(int id);
        List<MstEmployee> GetAll();   
        void Post(MstEmployee employee);
        void Put(int id, [FromBody] MstEmployee employee);
    }
}