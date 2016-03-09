using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class TrnDTRLogR : TrnDTRLogRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public TrnDTRLogR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("TrnDTRLogRI");          
        }
        
        public List<TrnDTRLog> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.TrnDTRLogs.ToList();
        }
        
        public IEnumerable<TrnDTRLog> Get(Int32 id)
        {
            var list = from m in _context.TrnDTRLogs select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<TrnDTRLog>)list;
        }
        
        public void Post(TrnDTRLog trndtrlog )
        {
             
             _context.TrnDTRLogs.Add(trndtrlog);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]TrnDTRLog trndtrlog)
        {
            _context.TrnDTRLogs.Update(trndtrlog);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.TrnDTRLogs.First(t => t.id == id);
            _context.TrnDTRLogs.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}