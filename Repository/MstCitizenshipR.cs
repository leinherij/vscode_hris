using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstCitizenshipR : MstCitizenshipRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstCitizenshipR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstCitizenshipRI");          
        }
        
        public List<MstCitizenship> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstCitizenships.ToList();
        }
        
        public IEnumerable<MstCitizenship> Get(Int32 id)
        {
            var list = from m in _context.MstCitizenships select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstCitizenship>)list;
        }
        
        public void Post(MstCitizenship mstcitizenship )
        {
             
             _context.MstCitizenships.Add(mstcitizenship);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstCitizenship mstcitizenship)
        {
            _context.MstCitizenships.Update(mstcitizenship);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstCitizenships.First(t => t.id == id);
            _context.MstCitizenships.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}