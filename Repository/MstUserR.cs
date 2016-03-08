using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstUserR: MstUserRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstUserR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstUserRI");          
        }
        
        public List<MstUser> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstUsers.ToList();
        }
        
        public IEnumerable<MstUser> Get(Int32 id)
        {
            var list = from m in _context.MstUsers select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstUser>)list;
        }
        
        public void Post(MstUser mstuser )
        {
             
             _context.MstUsers.Add(mstuser);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstUser mstuser)
        {
            _context.MstUsers.Update(mstuser);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstUsers.First(t => t.id == id);
            _context.MstUsers.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}