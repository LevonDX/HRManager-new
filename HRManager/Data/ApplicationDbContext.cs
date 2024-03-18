using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HRManager.Data
{
    public class ApplicationDbContext : IdentityDbContext<HRManagerUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<HRManagerUser> HRManagerUser { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}
