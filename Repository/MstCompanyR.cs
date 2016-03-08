using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstCompanyR : MstCompanyRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstCompanyR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstCompanyRI");          
        }
        
        public List<MstCompany> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstCompanys.ToList();
        }
        
        public IEnumerable<MstCompany> Get(Int32 id)
        {
            var list = from m in _context.MstCompanys select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstCompany>)list;
        }
        
        public void Post(MstCompany mstcompany )
        {
             
             _context.MstCompanys.Add(mstcompany);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstCompany mstcompany)
        {
            _context.MstCompanys.Update(mstcompany);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstCompanys.First(t => t.id == id);
            _context.MstCompanys.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}