using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstTableWTaxSemiMonthlyR: MstTableWTaxSemiMonthlyRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstTableWTaxSemiMonthlyR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstTableWTaxSemiMonthlyRI");          
        }
        
        public List<MstTableWTaxSemiMonthly> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstTableWTaxSemiMonthlys.ToList();
        }
        
        public IEnumerable<MstTableWTaxSemiMonthly> Get(Int32 id)
        {
            var list = from m in _context.MstTableWTaxSemiMonthlys select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstTableWTaxSemiMonthly>)list;
        }
        
        public void Post(MstTableWTaxSemiMonthly msttablewtaxsemimonthly )
        {
             
             _context.MstTableWTaxSemiMonthlys.Add(msttablewtaxsemimonthly);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstTableWTaxSemiMonthly msttablewtaxsemimonthly)
        {
            _context.MstTableWTaxSemiMonthlys.Update(msttablewtaxsemimonthly);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstTableWTaxSemiMonthlys.First(t => t.id == id);
            _context.MstTableWTaxSemiMonthlys.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}