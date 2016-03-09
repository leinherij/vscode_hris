using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface TrnLeaveLedgerRI
    {
        void Delete(Int32 id);
        IEnumerable<TrnLeaveLedger> Get(Int32 id);
        List<TrnLeaveLedger> GetAll();   
        void Post(TrnLeaveLedger trnleaveledger);
        void Put(Int32 id, [FromBody] TrnLeaveLedger trnleaveledger);
    }
}