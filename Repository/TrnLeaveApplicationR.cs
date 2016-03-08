using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class TrnLeaveApplicationR : TrnLeaveApplicationRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public TrnLeaveApplicationR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("TrnLeaveApplicationRI");          
        }
        
        public List<TrnLeaveApplication> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.TrnLeaveApplications.ToList();
        }
        
        public IEnumerable<TrnLeaveApplication> Get(Int32 id)
        {
            var list = from m in _context.TrnLeaveApplications select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<TrnLeaveApplication>)list;
        }
        
        public void Post(TrnLeaveApplication trnleaveapplication )
        {
             
             _context.TrnLeaveApplications.Add(trnleaveapplication);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]TrnLeaveApplication trnleaveapplication)
        {
            _context.TrnLeaveApplications.Update(trnleaveapplication);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.TrnLeaveApplications.First(t => t.id == id);
            _context.TrnLeaveApplications.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}