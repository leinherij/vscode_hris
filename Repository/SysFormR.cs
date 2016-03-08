using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class SysFormR: SysFormRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public SysFormR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("SysFormRI");          
        }
        
        public List<SysForm> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.SysForms.ToList();
        }
        
        public IEnumerable<SysForm> Get(Int32 id)
        {
            var list = from m in _context.SysForms select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<SysForm>)list;
        }
        
        public void Post(SysForm sysform )
        {
             
             _context.SysForms.Add(sysform);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]SysForm sysform)
        {
            _context.SysForms.Update(sysform);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.SysForms.First(t => t.id == id);
            _context.SysForms.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}