using Microsoft.EntityFrameworkCore;
using Travel_Desk_Application.Models;

namespace Travel_Desk_Application.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(new Role
            {
                RoleId = 1,
                RoleName = "Admin",
                CreatedBy = 1,
                CreatedOn = DateTime.Now,
                IsActive = true
            });

            // Configure the one-to-many relationship
            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId);
        }
    }
}
