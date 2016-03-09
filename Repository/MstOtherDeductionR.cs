using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstOtherDeductionR : MstOtherDeductionRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstOtherDeductionR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstOtherDeductionRI");          
        }
        
        public List<MstOtherDeduction> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstOtherDeductions.ToList();
        }
        
        public IEnumerable<MstOtherDeduction> Get(Int32 id)
        {
            var list = from m in _context.MstOtherDeductions select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstOtherDeduction>)list;
        }
        
        public void Post(MstOtherDeduction mstotherdeduction )
        {
             
             _context.MstOtherDeductions.Add(mstotherdeduction);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstOtherDeduction mstotherdeduction)
        {
            _context.MstOtherDeductions.Update(mstotherdeduction);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstOtherDeductions.First(t => t.id == id);
            _context.MstOtherDeductions.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}