using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;
namespace HRISVSC.Repository
{   
    public interface MstAccountIFRepository
    {
        void Delete(int id);
        MstAccount Get(int id);
        List<MstAccount> GetAll();   
        void Post(MstAccount mstaccount);
        void Put(int id, [FromBody] MstAccount mstaccount);
    }
}