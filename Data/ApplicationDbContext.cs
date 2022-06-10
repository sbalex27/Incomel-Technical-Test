using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Incomel_Technical_Test.Models;

namespace Incomel_Technical_Test.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Incomel_Technical_Test.Models.Employee>? Employee { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>()
                    .Property(b => b.CreatedAt)
                    .HasDefaultValueSql("getdate()");
            base.OnModelCreating(builder);
        }
    }
}