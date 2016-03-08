using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstPayrollTypeR : MstPayrollTypeRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstPayrollTypeR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstPayrollTypeRI");          
        }
        
        public List<MstPayrollType> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstPayrollTypes.ToList();
        }
        
        public IEnumerable<MstPayrollType> Get(Int32 id)
        {
            var list = from m in _context.MstPayrollTypes select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstPayrollType>)list;
        }
        
        public void Post(MstPayrollType mstpayrolltype )
        {
             
             _context.MstPayrollTypes.Add(mstpayrolltype);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstPayrollType mstpayrolltype)
        {
            _context.MstPayrollTypes.Update(mstpayrolltype);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstPayrollTypes.First(t => t.id == id);
            _context.MstPayrollTypes.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}