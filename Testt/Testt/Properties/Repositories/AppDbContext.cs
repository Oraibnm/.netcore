using Microsoft.EntityFrameworkCore;
using Testt.Controllers.Model;
using Testt.Model;

namespace Testt.Properties.Repositories
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>(Entry =>
            //{
            //    Entry.HasMany<Post>().WithOne(p => p.User)
            //   .HasForeignKey(p => p.UserId)
            //   .OnDelete(DeleteBehavior.Restrict);
            //});
        }

        public DbSet<User> users { get; set; }
        public DbSet<Post> posts { get; set; }
    }
}
