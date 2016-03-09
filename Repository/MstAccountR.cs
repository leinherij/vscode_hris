using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstAccountR : MstAccountRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstAccountR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstAccountRI");          
        }
        
        public List<MstAccount> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstAccounts.ToList();
        }
        
        public IEnumerable<MstAccount> Get(Int32 id)
        {
            var list = from m in _context.MstAccounts select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstAccount>)list;
        }

        public void Post(MstAccount mstaccount )
        {            
             _context.MstAccounts.Add(mstaccount);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstAccount mstaccount)
        {
            _context.MstAccounts.Update(mstaccount);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstAccounts.First(t => t.id == id);
            _context.MstAccounts.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}