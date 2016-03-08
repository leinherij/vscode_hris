using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstMandatoryTableR : MstMandatoryTableRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstMandatoryTableR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstMandatoryTableRI");          
        }
        
        public List<MstMandatoryTable> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstMandatoryTables.ToList();
        }
        
        public IEnumerable<MstMandatoryTable> Get(Int32 id)
        {
            var list = from m in _context.MstMandatoryTables select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstMandatoryTable>)list;
        }
        
        public void Post(MstMandatoryTable mstmandatorytable )
        {
             
             _context.MstMandatoryTables.Add(mstmandatorytable);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstMandatoryTable mstmandatorytable)
        {
            _context.MstMandatoryTables.Update(mstmandatorytable);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstMandatoryTables.First(t => t.id == id);
            _context.MstMandatoryTables.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}