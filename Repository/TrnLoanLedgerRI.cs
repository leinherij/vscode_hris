using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface TrnLoanLedgerRI
    {
        void Delete(Int32 id);
        IEnumerable<TrnLoanLedger> Get(Int32 id);
        List<TrnLoanLedger> GetAll();   
        void Post(TrnLoanLedger trnloanledger);
        void Put(Int32 id, [FromBody] TrnLoanLedger trnloanledger);
    }
}