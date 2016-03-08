using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class TrnPayrollLineR : TrnPayrollLineRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public TrnPayrollLineR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("TrnPayrollLineRI");          
        }
        
        public List<TrnPayrollLine> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.TrnPayrollLines.ToList();
        }
        
        public IEnumerable<TrnPayrollLine> Get(Int32 id)
        {
            var list = from m in _context.TrnPayrollLines select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<TrnPayrollLine>)list;
        }
        
        public void Post(TrnPayrollLine trnpayrollline )
        {
             
             _context.TrnPayrollLines.Add(trnpayrollline);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]TrnPayrollLine trnpayrollline)
        {
            _context.TrnPayrollLines.Update(trnpayrollline);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.TrnPayrollLines.First(t => t.id == id);
            _context.TrnPayrollLines.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}