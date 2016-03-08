using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstTableWTaxYearlyR: MstTableWTaxYearlyRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstTableWTaxYearlyR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstTableWTaxYearlyRI");          
        }
        
        public List<MstTableWTaxYearly> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstTableWTaxYearlys.ToList();
        }
        
        public IEnumerable<MstTableWTaxYearly> Get(Int32 id)
        {
            var list = from m in _context.MstTableWTaxYearlys select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstTableWTaxYearly>)list;
        }
        
        public void Post(MstTableWTaxYearly msttablewtaxyearly )
        {
             
             _context.MstTableWTaxYearlys.Add(msttablewtaxyearly);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstTableWTaxYearly msttablewtaxyearly)
        {
            _context.MstTableWTaxYearlys.Update(msttablewtaxyearly);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstTableWTaxYearlys.First(t => t.id == id);
            _context.MstTableWTaxYearlys.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}