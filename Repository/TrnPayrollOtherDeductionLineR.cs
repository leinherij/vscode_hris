using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class TrnPayrollOtherDeductionLineR : TrnPayrollOtherDeductionLineRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public TrnPayrollOtherDeductionLineR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("TrnPayrollOtherDeductionLineRI");          
        }
        
        public List<TrnPayrollOtherDeductionLine> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.TrnPayrollOtherDeductionLines.ToList();
        }
        
        public IEnumerable<TrnPayrollOtherDeductionLine> Get(Int32 id)
        {
            var list = from m in _context.TrnPayrollOtherDeductionLines select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<TrnPayrollOtherDeductionLine>)list;
        }
        
        public void Post(TrnPayrollOtherDeductionLine trnpayrollotherdeductionline )
        {
             
             _context.TrnPayrollOtherDeductionLines.Add(trnpayrollotherdeductionline);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]TrnPayrollOtherDeductionLine trnpayrollotherdeductionline)
        {
            _context.TrnPayrollOtherDeductionLines.Update(trnpayrollotherdeductionline);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.TrnPayrollOtherDeductionLines.First(t => t.id == id);
            _context.TrnPayrollOtherDeductionLines.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}