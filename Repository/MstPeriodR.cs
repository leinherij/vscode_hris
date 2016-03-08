using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstPeriodR : MstPeriodRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstPeriodR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstPeriodRI");          
        }
        
        public List<MstPeriod> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstPeriods.ToList();
        }
        
        public IEnumerable<MstPeriod> Get(Int32 id)
        {
            var list = from m in _context.MstPeriods select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstPeriod>)list;
        }
        
        public void Post(MstPeriod mstperiod )
        {
             
             _context.MstPeriods.Add(mstperiod);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstPeriod mstperiod)
        {
            _context.MstPeriods.Update(mstperiod);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstPeriods.First(t => t.id == id);
            _context.MstPeriods.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}