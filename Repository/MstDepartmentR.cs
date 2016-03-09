using System;
using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace HRISVSC.Repository
{
    public class MstDepartmentR : MstDepartmentRI
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        public MstDepartmentR(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstDayTypeIRepository");          
        }
        
        public List<MstDepartment> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstDepartments.ToList();
        }
        
        public IEnumerable<MstDepartment> Get(Int32 id)
        {
            var list = from m in _context.MstDepartments select m;
            list = list.Where(t => t.id == id);
            return (IEnumerable<MstDepartment>)list;
        }
        
        public void Post(MstDepartment mstdepartment )
        {
             
             _context.MstDepartments.Add(mstdepartment);
            _context.SaveChanges();
        }

        public void Put(Int32 id, [FromBody]MstDepartment mstdepartment)
        {
            _context.MstDepartments.Update(mstdepartment);
            _context.SaveChanges();
        }

        public void Delete(Int32 id)
        {
            var entity = _context.MstDepartments.First(t => t.id == id);
            _context.MstDepartments.Remove(entity);
            _context.SaveChanges();
        }
        
    }
}