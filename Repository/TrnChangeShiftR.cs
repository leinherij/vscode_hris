using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class TrnChangeShiftR : TrnChangeShiftRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public TrnChangeShiftR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("TrnChangeShiftRI");          
        }
        
        public List<TrnChangeShift> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.TrnChangeShifts.ToList();
        }
        
        public IEnumerable<TrnChangeShift> Get(Int32 id)
        {
            var list = from m in _context.TrnChangeShifts select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<TrnChangeShift>)list;
        }
        
        public void Post(TrnChangeShift trnchangeshift )
        {
             
             _context.TrnChangeShifts.Add(trnchangeshift);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]TrnChangeShift trnchangeshift)
        {
            _context.TrnChangeShifts.Update(trnchangeshift);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.TrnChangeShifts.First(t => t.id == id);
            _context.TrnChangeShifts.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}