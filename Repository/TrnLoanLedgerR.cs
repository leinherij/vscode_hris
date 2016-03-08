using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class TrnLoanLedgerR : TrnLoanLedgerRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public TrnLoanLedgerR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("TrnLoanLedgerRI");          
        }
        
        public List<TrnLoanLedger> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.TrnLoanLedgers.ToList();
        }
        
        public IEnumerable<TrnLoanLedger> Get(Int32 id)
        {
            var list = from m in _context.TrnLoanLedgers select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<TrnLoanLedger>)list;
        }
        
        public void Post(TrnLoanLedger trnloanledger )
        {
             
             _context.TrnLoanLedgers.Add(trnloanledger);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]TrnLoanLedger trnloanledger)
        {
            _context.TrnLoanLedgers.Update(trnloanledger);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.TrnLoanLedgers.First(t => t.id == id);
            _context.TrnLoanLedgers.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}