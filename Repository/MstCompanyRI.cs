using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstCompanyRI
    {
        void Delete(Int32 id);
        IEnumerable<MstCompany> Get(Int32 id);
        List<MstCompany> GetAll();   
        void Post(MstCompany mstcompany);
        void Put(Int32 id, [FromBody] MstCompany mstcompany);
    }
}