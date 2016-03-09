using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstUserPayrollGroupR: MstUserPayrollGroupRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstUserPayrollGroupR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstUserPayrollGroupRI");          
        }
        
        public List<MstUserPayrollGroup> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstUserPayrollGroups.ToList();
        }
        
        public IEnumerable<MstUserPayrollGroup> Get(Int32 id)
        {
            var list = from m in _context.MstUserPayrollGroups select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstUserPayrollGroup>)list;
        }
        
        public void Post(MstUserPayrollGroup mstuserpayrollgroup )
        {
             
             _context.MstUserPayrollGroups.Add(mstuserpayrollgroup);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstUserPayrollGroup mstuserpayrollgroup)
        {
            _context.MstUserPayrollGroups.Update(mstuserpayrollgroup);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstUserPayrollGroups.First(t => t.id == id);
            _context.MstUserPayrollGroups.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}