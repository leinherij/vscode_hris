using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstDivisionR : MstDivisionRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstDivisionR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstDivisionRI");          
        }
        
        public List<MstDivision> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstDivisions.ToList();
        }
        
        public IEnumerable<MstDivision> Get(Int32 id)
        {
            var list = from m in _context.MstDivisions select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstDivision>)list;
        }
        
        public void Post(MstDivision mstdivision )
        {
             
             _context.MstDivisions.Add(mstdivision);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstDivision mstdivision)
        {
            _context.MstDivisions.Update(mstdivision);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstDivisions.First(t => t.id == id);
            _context.MstDivisions.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}