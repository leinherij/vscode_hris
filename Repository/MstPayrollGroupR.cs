using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstPayrollGroupR : MstPayrollGroupRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstPayrollGroupR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstPayrollGroupRI");          
        }
        
        public List<MstPayrollGroup> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstPayrollGroups.ToList();
        }
        
        public IEnumerable<MstPayrollGroup> Get(Int32 id)
        {
            var list = from m in _context.MstPayrollGroups select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstPayrollGroup>)list;
        }
        
        public void Post(MstPayrollGroup mstpayrollgroup )
        {
             
             _context.MstPayrollGroups.Add(mstpayrollgroup);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstPayrollGroup mstpayrollgroup)
        {
            _context.MstPayrollGroups.Update(mstpayrollgroup);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstPayrollGroups.First(t => t.id == id);
            _context.MstPayrollGroups.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}