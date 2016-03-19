using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstEmployeeR : MstEmployeeRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstEmployeeR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstEmployeeIRepository");          
        }
        
        public List<MstEmployee> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstEmployees.ToList();
        }
        
        public IEnumerable<MstEmployee> Get(Int32 payrollGroupId)
        {
            var list = from m in _context.MstEmployees select m;
            list = list.Where(t => t.payrollGroupId == payrollGroupId);
            return (IEnumerable<MstEmployee>)list;
        }
        
        public void Post(MstEmployee mstemployee)
        {
             
             _context.MstEmployees.Add(mstemployee);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstEmployee mstemployee)
        {
            _context.MstEmployees.Update(mstemployee);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstEmployees.First(t => t.id == id);
            _context.MstEmployees.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}