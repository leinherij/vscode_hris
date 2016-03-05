using System.Collections.Generic;
using System.Linq;
using HRISVSC.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;
namespace HRISVSC.Repository
{
    public class MstEmployeeRepository : MstEmployeeIFRepository
    {
        private readonly SoftwareDbContext _context;

        private readonly ILogger _logger;

        public MstEmployeeRepository(SoftwareDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("MstEmployeeIFRepository");          
        }
        public List<MstEmployee> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.MstEmployees.ToList();
        }
        public MstEmployee Get(int id)
        {
            return _context.MstEmployees.First(t => t.id == id);
        }
        [HttpPost]
        public void Post(MstEmployee employee )
        {
             
             _context.MstEmployees.Add(employee);
            _context.SaveChanges();
        }

        public void Put(int id, [FromBody]MstEmployee employee)
        {
            _context.MstEmployees.Update(employee);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _context.MstEmployees.First(t => t.id == id);
            _context.MstEmployees.Remove(entity);
            _context.SaveChanges();
        }
        
    }

}