using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstTableWTaxMonthlyR: MstTableWTaxMonthlyRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstTableWTaxMonthlyR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstTableWTaxMonthlyRI");          
        }
        
        public List<MstTableWTaxMonthly> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstTableWTaxMonthlys.ToList();
        }
        
        public IEnumerable<MstTableWTaxMonthly> Get(Int32 id)
        {
            var list = from m in _context.MstTableWTaxMonthlys select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstTableWTaxMonthly>)list;
        }
        
        public void Post(MstTableWTaxMonthly msttablewtaxmonthly )
        {
             
             _context.MstTableWTaxMonthlys.Add(msttablewtaxmonthly);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstTableWTaxMonthly msttablewtaxmonthly)
        {
            _context.MstTableWTaxMonthlys.Update(msttablewtaxmonthly);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstTableWTaxMonthlys.First(t => t.id == id);
            _context.MstTableWTaxMonthlys.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}