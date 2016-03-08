using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstShiftCodeR : MstShiftCodeRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstShiftCodeR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstShiftCodeRI");          
        }
        
        public List<MstShiftCode> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstShiftCodes.ToList();
        }
        
        public IEnumerable<MstShiftCode> Get(Int32 id)
        {
            var list = from m in _context.MstShiftCodes select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstShiftCode>)list;
        }
        
        public void Post(MstShiftCode mstshiftcode )
        {
             
             _context.MstShiftCodes.Add(mstshiftcode);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstShiftCode mstshiftcode)
        {
            _context.MstShiftCodes.Update(mstshiftcode);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstShiftCodes.First(t => t.id == id);
            _context.MstShiftCodes.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}