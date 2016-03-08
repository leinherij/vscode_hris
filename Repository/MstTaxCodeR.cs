using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstTaxCodeR: MstTaxCodeRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstTaxCodeR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstTaxCodeRI");          
        }
        
        public List<MstTaxCode> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstTaxCodes.ToList();
        }
        
        public IEnumerable<MstTaxCode> Get(Int32 id)
        {
            var list = from m in _context.MstTaxCodes select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstTaxCode>)list;
        }
        
        public void Post(MstTaxCode msttaxcode )
        {
             
             _context.MstTaxCodes.Add(msttaxcode);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstTaxCode msttaxcode)
        {
            _context.MstTaxCodes.Update(msttaxcode);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstTaxCodes.First(t => t.id == id);
            _context.MstTaxCodes.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}