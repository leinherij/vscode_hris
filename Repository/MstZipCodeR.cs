using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstZipCodeR: MstZipCodeRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstZipCodeR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstZipCodeRI");          
        }
        
        public List<MstZipCode> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstZipCodes.ToList();
        }
        
        public IEnumerable<MstZipCode> Get(Int32 id)
        {
            var list = from m in _context.MstZipCodes select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstZipCode>)list;
        }
        
        public void Post(MstZipCode mstzipcode )
        {
             
             _context.MstZipCodes.Add(mstzipcode);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstZipCode mstzipcode)
        {
            _context.MstZipCodes.Update(mstzipcode);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstZipCodes.First(t => t.id == id);
            _context.MstZipCodes.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}