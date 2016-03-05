using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;
namespace HRISVSC.Repository
{
    public class MstAccountRepository : MstAccountIFRepository
    {
        private readonly SoftwareDbContext _context;

        private readonly ILogger _logger;

        public MstAccountRepository(SoftwareDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstAccountIFRepository");          
        }
        public List<MstAccount> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstAccounts.ToList();
        }
        public MstAccount Get(int id)
        {
            return _context.MstAccounts.First(t => t.id == id);
        }
        [HttpPost]
        public void Post(MstAccount mstaccount )
        {
             
             _context.MstAccounts.Add(mstaccount);
            _context.SaveChanges();
        }

        public void Put(int id, [FromBody]MstAccount mstaccount)
        {
            _context.MstAccounts.Update(mstaccount);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _context.MstAccounts.First(t => t.id == id);
            _context.MstAccounts.Remove(entity);
            _context.SaveChanges();
        }
        
    }

}