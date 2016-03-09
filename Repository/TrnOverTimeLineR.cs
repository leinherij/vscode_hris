using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class TrnOverTimeLineR : TrnOverTimeLineRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public TrnOverTimeLineR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("TrnOverTimeLineRI");          
        }
        
        public List<TrnOverTimeLine> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.TrnOverTimeLines.ToList();
        }
        
        public IEnumerable<TrnOverTimeLine> Get(Int32 id)
        {
            var list = from m in _context.TrnOverTimeLines select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<TrnOverTimeLine>)list;
        }
        
        public void Post(TrnOverTimeLine trnovertimeline )
        {
             
             _context.TrnOverTimeLines.Add(trnovertimeline);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]TrnOverTimeLine trnovertimeline)
        {
            _context.TrnOverTimeLines.Update(trnovertimeline);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.TrnOverTimeLines.First(t => t.id == id);
            _context.TrnOverTimeLines.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}