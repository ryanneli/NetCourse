using API.Domain.Entities;
using API.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Course> Course { get; set; }
        public DbSet<Group> Group { get; set; }

        public DbSet<Registration> Registration { get; set; }

        public DbSet<Score> Score { get; set; }

        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext))
        }

    }
}