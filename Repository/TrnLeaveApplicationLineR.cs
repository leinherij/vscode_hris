using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class TrnLeaveApplicationLineR : TrnLeaveApplicationLineRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public TrnLeaveApplicationLineR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("TrnLeaveApplicationLineRI");          
        }
        
        public List<TrnLeaveApplicationLine> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.TrnLeaveApplicationLines.ToList();
        }
        
        public IEnumerable<TrnLeaveApplicationLine> Get(Int32 id)
        {
            var list = from m in _context.TrnLeaveApplicationLines select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<TrnLeaveApplicationLine>)list;
        }
        
        public void Post(TrnLeaveApplicationLine trnleaveapplicationline )
        {
             
             _context.TrnLeaveApplicationLines.Add(trnleaveapplicationline);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]TrnLeaveApplicationLine trnleaveapplicationline)
        {
            _context.TrnLeaveApplicationLines.Update(trnleaveapplicationline);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.TrnLeaveApplicationLines.First(t => t.id == id);
            _context.TrnLeaveApplicationLines.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}