using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstTablePHICR : MstTablePHICRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstTablePHICR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstTablePHICRI");          
        }
        
        public List<MstTablePHIC> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstTablePHICs.ToList();
        }
        
        public IEnumerable<MstTablePHIC> Get(Int32 id)
        {
            var list = from m in _context.MstTablePHICs select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstTablePHIC>)list;
        }
        
        public void Post(MstTablePHIC msttablephic )
        {
             
             _context.MstTablePHICs.Add(msttablephic);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstTablePHIC msttablephic)
        {
            _context.MstTablePHICs.Update(msttablephic);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstTablePHICs.First(t => t.id == id);
            _context.MstTablePHICs.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}