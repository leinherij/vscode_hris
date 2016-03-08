using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class TrnOverTimeR : TrnOverTimeRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public TrnOverTimeR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("TrnOverTimeRI");          
        }
        
        public List<TrnOverTime> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.TrnOverTimes.ToList();
        }
        
        public IEnumerable<TrnOverTime> Get(Int32 id)
        {
            var list = from m in _context.TrnOverTimes select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<TrnOverTime>)list;
        }
        
        public void Post(TrnOverTime trnovertime )
        {
             
             _context.TrnOverTimes.Add(trnovertime);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]TrnOverTime trnovertime)
        {
            _context.TrnOverTimes.Update(trnovertime);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.TrnOverTimes.First(t => t.id == id);
            _context.TrnOverTimes.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}