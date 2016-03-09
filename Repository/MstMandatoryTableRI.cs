using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstMandatoryTableRI
    {
        void Delete(Int32 id);
        IEnumerable<MstMandatoryTable> Get(Int32 id);
        List<MstMandatoryTable> GetAll();   
        void Post(MstMandatoryTable mstmandatorytable);
        void Put(Int32 id, [FromBody] MstMandatoryTable mstmandatorytable);
    }
}