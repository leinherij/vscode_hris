using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class TrnDTRLineR : TrnDTRLineRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public TrnDTRLineR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("TrnDTRLineRI");          
        }
        
        public List<TrnDTRLine> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.TrnDTRLines.ToList();
        }
        
        public IEnumerable<TrnDTRLine> Get(Int32 id)
        {
            var list = from m in _context.TrnDTRLines select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<TrnDTRLine>)list;
        }
        
        public void Post(TrnDTRLine trndtrline )
        {
             
             _context.TrnDTRLines.Add(trndtrline);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]TrnDTRLine trndtrline)
        {
            _context.TrnDTRLines.Update(trndtrline);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.TrnDTRLines.First(t => t.id == id);
            _context.TrnDTRLines.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}