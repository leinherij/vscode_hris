using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstDayTypeR : MstDayTypeRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstDayTypeR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstDayTypeRI");          
        }
        
        public List<MstDayType> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstDayTypes.ToList();
        }
        
        public IEnumerable<MstDayType> Get(Int32 id)
        {
            var list = from m in _context.MstDayTypes select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstDayType>)list;
        }
        
        public void Post(MstDayType mstdaytype )
        {
             
             _context.MstDayTypes.Add(mstdaytype);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstDayType mstdaytype)
        {
            _context.MstDayTypes.Update(mstdaytype);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstDayTypes.First(t => t.id == id);
            _context.MstDayTypes.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}