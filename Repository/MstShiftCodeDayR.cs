using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstShiftCodeDayR : MstShiftCodeDayRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstShiftCodeDayR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstShiftCodeDayRI");          
        }
        
        public List<MstShiftCodeDay> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstShiftCodeDays.ToList();
        }
        
        public IEnumerable<MstShiftCodeDay> Get(Int32 id)
        {
            var list = from m in _context.MstShiftCodeDays select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstShiftCodeDay>)list;
        }
        
        public void Post(MstShiftCodeDay mstshiftcodeday )
        {
             
             _context.MstShiftCodeDays.Add(mstshiftcodeday);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstShiftCodeDay mstshiftcodeday)
        {
            _context.MstShiftCodeDays.Update(mstshiftcodeday);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstShiftCodeDays.First(t => t.id == id);
            _context.MstShiftCodeDays.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}