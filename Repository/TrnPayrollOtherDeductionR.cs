using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class TrnPayrollOtherDeductionR : TrnPayrollOtherDeductionRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public TrnPayrollOtherDeductionR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("TrnPayrollOtherDeductionRI");          
        }
        
        public List<TrnPayrollOtherDeduction> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.TrnPayrollOtherDeductions.ToList();
        }
        
        public IEnumerable<TrnPayrollOtherDeduction> Get(Int32 id)
        {
            var list = from m in _context.TrnPayrollOtherDeductions select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<TrnPayrollOtherDeduction>)list;
        }
        
        public void Post(TrnPayrollOtherDeduction trnpayrollotherdeduction )
        {
             
             _context.TrnPayrollOtherDeductions.Add(trnpayrollotherdeduction);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]TrnPayrollOtherDeduction trnpayrollotherdeduction)
        {
            _context.TrnPayrollOtherDeductions.Update(trnpayrollotherdeduction);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.TrnPayrollOtherDeductions.First(t => t.id == id);
            _context.TrnPayrollOtherDeductions.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}