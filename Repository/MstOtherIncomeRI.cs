using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstOtherIncomeRI
    {
        void Delete(Int32 id);
        IEnumerable<MstOtherIncome> Get(Int32 id);
        List<MstOtherIncome> GetAll();   
        void Post(MstOtherIncome mstotherincome);
        void Put(Int32 id, [FromBody] MstOtherIncome mstotherincome);
    }
}