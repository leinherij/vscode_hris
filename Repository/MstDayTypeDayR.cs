using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstDayTypeDayR : MstDayTypeDayRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstDayTypeDayR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstDayTypeDayIRepository");          
        }
        
        public List<MstDayTypeDay> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstDayTypeDays.ToList();
        }
        
        public IEnumerable<MstDayTypeDay> Get(Int32 id)
        {
            var list = from m in _context.MstDayTypeDays select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstDayTypeDay>)list;
        }
        
        public void Post(MstDayTypeDay mstdaytypeday)
        {
             
             _context.MstDayTypeDays.Add(mstdaytypeday);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstDayTypeDay mstdaytypeday)
        {
            _context.MstDayTypeDays.Update(mstdaytypeday);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstDayTypeDays.First(t => t.id == id);
            _context.MstDayTypeDays.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}