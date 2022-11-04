using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace DataAccessLayer.DataAccess // rename to Contexts
{
    public class Context : IdentityDbContext<IdentityUser>
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { 
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
       

        protected override void OnModelCreating(ModelBuilder builder)
        {
           // builder.Entity<Category>().Property(c => c.Name).
            base.OnModelCreating(builder);
        }
    }
}
