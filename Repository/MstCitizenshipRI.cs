using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstCitizenshipRI
    {
        void Delete(Int32 id);
        IEnumerable<MstCitizenship> Get(Int32 id);
        List<MstCitizenship> GetAll();   
        void Post(MstCitizenship mstcitizenship);
        void Put(Int32 id, [FromBody] MstCitizenship mstcitizenship);
    }
}