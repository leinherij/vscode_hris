using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstMonthR : MstMonthRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstMonthR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstMonthRI");          
        }
        
        public List<MstMonth> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstMonths.ToList();
        }
        
        public IEnumerable<MstMonth> Get(Int32 id)
        {
            var list = from m in _context.MstMonths select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstMonth>)list;
        }
        
        public void Post(MstMonth mstmonth )
        {
             
             _context.MstMonths.Add(mstmonth);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstMonth mstmonth)
        {
            _context.MstMonths.Update(mstmonth);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstMonths.First(t => t.id == id);
            _context.MstMonths.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}