using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class TrnDTRR : TrnDTRRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public TrnDTRR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("TrnDTRRI");          
        }
        
        public List<TrnDTR> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.TrnDTRs.ToList();
        }
        
        public IEnumerable<TrnDTR> Get(Int32 id)
        {
            var list = from m in _context.TrnDTRs select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<TrnDTR>)list;
        }
        
        public void Post(TrnDTR trndtr )
        {
             
             _context.TrnDTRs.Add(trndtr);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]TrnDTR trndtr)
        {
            _context.TrnDTRs.Update(trndtr);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.TrnDTRs.First(t => t.id == id);
            _context.TrnDTRs.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}