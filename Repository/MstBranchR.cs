using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstBranchR : MstBranchRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstBranchR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstBranchRI");          
        }
        
        public List<MstBranch> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstBranchs.ToList();
        }
        
        public IEnumerable<MstBranch> Get(Int32 id)
        {
            var list = from m in _context.MstBranchs select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstBranch>)list;
        }
        
        public void Post(MstBranch mstbranch )
        {
             
             _context.MstBranchs.Add(mstbranch);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstBranch mstbranch)
        {
            _context.MstBranchs.Update(mstbranch);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstBranchs.First(t => t.id == id);
            _context.MstBranchs.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}