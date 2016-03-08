using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstPositionR : MstPositionRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstPositionR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstPositionRI");          
        }
        
        public List<MstPosition> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstPositions.ToList();
        }
        
        public IEnumerable<MstPosition> Get(Int32 id)
        {
            var list = from m in _context.MstPositions select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstPosition>)list;
        }
        
        public void Post(MstPosition mstposition )
        {
             
             _context.MstPositions.Add(mstposition);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstPosition mstposition)
        {
            _context.MstPositions.Update(mstposition);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstPositions.First(t => t.id == id);
            _context.MstPositions.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}