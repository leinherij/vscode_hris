using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
<<<<<<< HEAD
using System;
=======
>>>>>>> cc76c7c9e166eeaeaa17c8c34d6e8c7557942b14
namespace HRISVSC.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
<<<<<<< HEAD

        
=======
>>>>>>> cc76c7c9e166eeaeaa17c8c34d6e8c7557942b14
    }
}
