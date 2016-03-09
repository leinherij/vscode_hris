using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstReligionR : MstReligionRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstReligionR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstReligionRI");          
        }
        
        public List<MstReligion> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstReligions.ToList();
        }
        
        public IEnumerable<MstReligion> Get(Int32 id)
        {
            var list = from m in _context.MstReligions select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstReligion>)list;
        }
        
        public void Post(MstReligion mstreligion )
        {
             
             _context.MstReligions.Add(mstreligion);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstReligion mstreligion)
        {
            _context.MstReligions.Update(mstreligion);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstReligions.First(t => t.id == id);
            _context.MstReligions.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}