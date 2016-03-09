using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstEmployeeMemoR : MstEmployeeMemoRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstEmployeeMemoR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstEmployeeMemoRI");          
        }
        
        public List<MstEmployeeMemo> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstEmployeeMemos.ToList();
        }
        
        public IEnumerable<MstEmployeeMemo> Get(Int32 id)
        {
            var list = from m in _context.MstEmployeeMemos select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstEmployeeMemo>)list;
        }
        
        public void Post(MstEmployeeMemo mstemployeeloan )
        {
             
             _context.MstEmployeeMemos.Add(mstemployeeloan);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstEmployeeMemo mstemployeeloan)
        {
            _context.MstEmployeeMemos.Update(mstemployeeloan);
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