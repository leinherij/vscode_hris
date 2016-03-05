using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
namespace HRISVSC.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
