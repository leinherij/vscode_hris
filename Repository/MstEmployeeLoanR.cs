using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstEmployeeLoanR : MstEmployeeLoanRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstEmployeeLoanR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstEmployeeLoanIRepository");          
        }
        
        public List<MstEmployeeLoan> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstEmployeeLoans.ToList();
        }
        
        public IEnumerable<MstEmployeeLoan> Get(Int32 id)
        {
            var list = from m in _context.MstEmployeeLoans select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstEmployeeLoan>)list;
        }
        
        public void Post(MstEmployeeLoan mstemployeeloan )
        {
             
             _context.MstEmployeeLoans.Add(mstemployeeloan);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstEmployeeLoan mstemployeeloan)
        {
            _context.MstEmployeeLoans.Update(mstemployeeloan);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstEmployeeLoans.First(t => t.id == id);
            _context.MstEmployeeLoans.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}