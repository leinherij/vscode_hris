using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstEmployeeShiftCodeR : MstEmployeeShiftCodeRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstEmployeeShiftCodeR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstEmployeeShiftCodeRI");          
        }
        
        public List<MstEmployeeShiftCode> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstEmployeeShiftCodes.ToList();
        }
        
        public IEnumerable<MstEmployeeShiftCode> Get(Int32 id)
        {
            var list = from m in _context.MstEmployeeShiftCodes select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstEmployeeShiftCode>)list;
        }
        
        public void Post(MstEmployeeShiftCode mstemployeeshiftcode )
        {
             
             _context.MstEmployeeShiftCodes.Add(mstemployeeshiftcode);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstEmployeeShiftCode mstemployeeshiftcode)
        {
            _context.MstEmployeeShiftCodes.Update(mstemployeeshiftcode);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstEmployeeShiftCodes.First(t => t.id == id);
            _context.MstEmployeeShiftCodes.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}