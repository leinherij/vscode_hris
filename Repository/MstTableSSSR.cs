using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstTableSSSR : MstTableSSSRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstTableSSSR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstTableSSSRI");          
        }
        
        public List<MstTableSSS> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstTableSSSs.ToList();
        }
        
        public IEnumerable<MstTableSSS> Get(Int32 id)
        {
            var list = from m in _context.MstTableSSSs select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstTableSSS>)list;
        }
        
        public void Post(MstTableSSS msttablesss )
        {
             
             _context.MstTableSSSs.Add(msttablesss);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstTableSSS msttablesss)
        {
            _context.MstTableSSSs.Update(msttablesss);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstTableSSSs.First(t => t.id == id);
            _context.MstTableSSSs.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}