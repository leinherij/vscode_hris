using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class TrnChangeShiftLineR : TrnChangeShiftLineRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public TrnChangeShiftLineR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("TrnChangeShiftLineRI");          
        }
        
        public List<TrnChangeShiftLine> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.TrnChangeShiftLines.ToList();
        }
        
        public IEnumerable<TrnChangeShiftLine> Get(Int32 id)
        {
            var list = from m in _context.TrnChangeShiftLines select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<TrnChangeShiftLine>)list;
        }
        
        public void Post(TrnChangeShiftLine trnchangeshiftline )
        {
             
             _context.TrnChangeShiftLines.Add(trnchangeshiftline);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]TrnChangeShiftLine trnchangeshiftline)
        {
            _context.TrnChangeShiftLines.Update(trnchangeshiftline);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.TrnChangeShiftLines.First(t => t.id == id);
            _context.TrnChangeShiftLines.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}