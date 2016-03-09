using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class TrnLastWithholdingTaxR : TrnLastWithholdingTaxRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public TrnLastWithholdingTaxR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("TrnLastWithholdingTaxRI");          
        }
        
        public List<TrnLastWithholdingTax> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.TrnLastWithholdingTaxs.ToList();
        }
        
        public IEnumerable<TrnLastWithholdingTax> Get(Int32 id)
        {
            var list = from m in _context.TrnLastWithholdingTaxs select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<TrnLastWithholdingTax>)list;
        }
        
        public void Post(TrnLastWithholdingTax trnlastwithholdingtax )
        {
             
             _context.TrnLastWithholdingTaxs.Add(trnlastwithholdingtax);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]TrnLastWithholdingTax trnlastwithholdingtax)
        {
            _context.TrnLastWithholdingTaxs.Update(trnlastwithholdingtax);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.TrnLastWithholdingTaxs.First(t => t.id == id);
            _context.TrnLastWithholdingTaxs.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}