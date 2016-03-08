using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HRISVSC.Models;

namespace HRISVSC.Repository
{   
    public interface MstZipCodeRI
    {
        void Delete(Int32 id);
        IEnumerable<MstZipCode> Get(Int32 id);
        List<MstZipCode> GetAll();   
        void Post(MstZipCode mstzipcode);
        void Put(Int32 id, [FromBody] MstZipCode mstzipcode);
    }
}