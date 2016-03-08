using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class TrnLeaveLedgerR : TrnLeaveLedgerRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public TrnLeaveLedgerR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("TrnLeaveLedgerRI");          
        }
        
        public List<TrnLeaveLedger> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.TrnLeaveLedgers.ToList();
        }
        
        public IEnumerable<TrnLeaveLedger> Get(Int32 id)
        {
            var list = from m in _context.TrnLeaveLedgers select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<TrnLeaveLedger>)list;
        }
        
        public void Post(TrnLeaveLedger trnleaveledger )
        {
             
             _context.TrnLeaveLedgers.Add(trnleaveledger);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]TrnLeaveLedger trnleaveledger)
        {
            _context.TrnLeaveLedgers.Update(trnleaveledger);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.TrnLeaveLedgers.First(t => t.id == id);
            _context.TrnLeaveLedgers.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}