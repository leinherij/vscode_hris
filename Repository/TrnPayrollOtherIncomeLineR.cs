using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class TrnPayrollOtherIncomeLineR : TrnPayrollOtherIncomeLineRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public TrnPayrollOtherIncomeLineR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("TrnPayrollOtherIncomeLineRI");          
        }
        
        public List<TrnPayrollOtherIncomeLine> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.TrnPayrollOtherIncomeLines.ToList();
        }
        
        public IEnumerable<TrnPayrollOtherIncomeLine> Get(Int32 id)
        {
            var list = from m in _context.TrnPayrollOtherIncomeLines select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<TrnPayrollOtherIncomeLine>)list;
        }
        
        public void Post(TrnPayrollOtherIncomeLine trnpayrollotherincomeline )
        {
             
             _context.TrnPayrollOtherIncomeLines.Add(trnpayrollotherincomeline);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]TrnPayrollOtherIncomeLine trnpayrollotherincomeline)
        {
            _context.TrnPayrollOtherIncomeLines.Update(trnpayrollotherincomeline);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.TrnPayrollOtherIncomeLines.First(t => t.id == id);
            _context.TrnPayrollOtherIncomeLines.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}