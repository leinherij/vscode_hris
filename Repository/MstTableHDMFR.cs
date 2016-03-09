using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstTableHDMFR : MstTableHDMFRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstTableHDMFR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstTableHDMFRI");          
        }
        
        public List<MstTableHDMF> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstTableHDMFs.ToList();
        }
        
        public IEnumerable<MstTableHDMF> Get(Int32 id)
        {
            var list = from m in _context.MstTableHDMFs select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstTableHDMF>)list;
        }
        
        public void Post(MstTableHDMF msttablehdmf )
        {
             
             _context.MstTableHDMFs.Add(msttablehdmf);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstTableHDMF msttablehdmf)
        {
            _context.MstTableHDMFs.Update(msttablehdmf);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstTableHDMFs.First(t => t.id == id);
            _context.MstTableHDMFs.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}