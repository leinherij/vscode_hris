using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class TrnPayrollR : TrnPayrollRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public TrnPayrollR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("TrnPayrollRI");          
        }
        
        public List<TrnPayroll> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.TrnPayrolls.ToList();
        }
        
        public IEnumerable<TrnPayroll> Get(Int32 id)
        {
            var list = from m in _context.TrnPayrolls select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<TrnPayroll>)list;
        }
        
        public void Post(TrnPayroll trnpayroll )
        {
             
             _context.TrnPayrolls.Add(trnpayroll);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]TrnPayroll trnpayroll)
        {
            _context.TrnPayrolls.Update(trnpayroll);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.TrnPayrolls.First(t => t.id == id);
            _context.TrnPayrolls.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}