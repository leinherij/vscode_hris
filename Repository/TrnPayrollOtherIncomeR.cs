using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class TrnPayrollOtherIncomeR : TrnPayrollOtherIncomeRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public TrnPayrollOtherIncomeR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("TrnPayrollOtherIncomeRI");          
        }
        
        public List<TrnPayrollOtherIncome> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.TrnPayrollOtherIncomes.ToList();
        }
        
        public IEnumerable<TrnPayrollOtherIncome> Get(Int32 id)
        {
            var list = from m in _context.TrnPayrollOtherIncomes select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<TrnPayrollOtherIncome>)list;
        }
        
        public void Post(TrnPayrollOtherIncome trnpayrollotherincome )
        {
             
             _context.TrnPayrollOtherIncomes.Add(trnpayrollotherincome);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]TrnPayrollOtherIncome trnpayrollotherincome)
        {
            _context.TrnPayrollOtherIncomes.Update(trnpayrollotherincome);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.TrnPayrollOtherIncomes.First(t => t.id == id);
            _context.TrnPayrollOtherIncomes.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}