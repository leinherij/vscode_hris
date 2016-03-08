using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class TrnLastWithholdingTaxLineR : TrnLastWithholdingTaxLineRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public TrnLastWithholdingTaxLineR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("TrnLastWithholdingTaxLineRI");          
        }
        
        public List<TrnLastWithholdingTaxLine> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.TrnLastWithholdingTaxLines.ToList();
        }
        
        public IEnumerable<TrnLastWithholdingTaxLine> Get(Int32 id)
        {
            var list = from m in _context.TrnLastWithholdingTaxLines select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<TrnLastWithholdingTaxLine>)list;
        }
        
        public void Post(TrnLastWithholdingTaxLine trnlastwithholdingtaxline )
        {
             
             _context.TrnLastWithholdingTaxLines.Add(trnlastwithholdingtaxline);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]TrnLastWithholdingTaxLine trnlastwithholdingtaxline)
        {
            _context.TrnLastWithholdingTaxLines.Update(trnlastwithholdingtaxline);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.TrnLastWithholdingTaxLines.First(t => t.id == id);
            _context.TrnLastWithholdingTaxLines.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}