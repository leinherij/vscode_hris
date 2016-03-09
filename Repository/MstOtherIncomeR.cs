using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstOtherIncomeR : MstOtherIncomeRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstOtherIncomeR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstOtherIncomeRI");          
        }
        
        public List<MstOtherIncome> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstOtherIncomes.ToList();
        }
        
        public IEnumerable<MstOtherIncome> Get(Int32 id)
        {
            var list = from m in _context.MstOtherIncomes select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstOtherIncome>)list;
        }
        
        public void Post(MstOtherIncome mstotherincome )
        {
             
             _context.MstOtherIncomes.Add(mstotherincome);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstOtherIncome mstotherincome)
        {
            _context.MstOtherIncomes.Update(mstotherincome);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstOtherIncomes.First(t => t.id == id);
            _context.MstOtherIncomes.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}