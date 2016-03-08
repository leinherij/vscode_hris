using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstLeaveR : MstLeaveRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstLeaveR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstLeaveRI");          
        }
        
        public List<MstLeave> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstLeaves.ToList();
        }
        
        public IEnumerable<MstLeave> Get(Int32 id)
        {
            var list = from m in _context.MstLeaves select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstLeave>)list;
        }
        
        public void Post(MstLeave mstleave )
        {
             
             _context.MstLeaves.Add(mstleave);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstLeave mstleave)
        {
            _context.MstLeaves.Update(mstleave);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstLeaves.First(t => t.id == id);
            _context.MstLeaves.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}