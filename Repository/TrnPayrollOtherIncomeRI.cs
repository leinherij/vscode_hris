using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface TrnPayrollOtherIncomeRI
    {
        void Delete(Int32 id);
        IEnumerable<TrnPayrollOtherIncome> Get(Int32 id);
        List<TrnPayrollOtherIncome> GetAll();   
        void Post(TrnPayrollOtherIncome trnpayrollotherincome);
        void Put(Int32 id, [FromBody] TrnPayrollOtherIncome trnpayrollotherincome);
    }
}