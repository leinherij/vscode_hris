using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstUserFormR: MstUserFormRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstUserFormR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstUserFormRI");          
        }
        
        public List<MstUserForm> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstUserForms.ToList();
        }
        
        public IEnumerable<MstUserForm> Get(Int32 id)
        {
            var list = from m in _context.MstUserForms select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstUserForm>)list;
        }
        
        public void Post(MstUserForm mstuserform )
        {
             
             _context.MstUserForms.Add(mstuserform);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstUserForm mstuserform)
        {
            _context.MstUserForms.Update(mstuserform);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstUserForms.First(t => t.id == id);
            _context.MstUserForms.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}