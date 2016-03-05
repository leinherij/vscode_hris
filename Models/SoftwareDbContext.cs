using Microsoft.Data.Entity;
namespace HRISVSC.Models
{
    public class SoftwareDbContext : DbContext
    {
        public DbSet<MstEmployee> MstEmployees { get; set; }
        public DbSet<MstAccount> MstAccounts { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        { 
            builder.Entity<MstEmployee>().HasKey(m => m.id); 
            builder.Entity<MstAccount>().HasKey(m => m.id);
            base.OnModelCreating(builder); 
        } 
    } 
}
