using FluentAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FluentAPI.DataAccess
{
    public class DbConnect:DbContext
    {
        public DbConnect(DbContextOptions<DbConnect> options) : base(options) { }

        public DbSet<Homes> homes { get; set; }
        public DbSet<Propiska> propiska { get; set; }   
        public DbSet<Users> users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetCallingAssembly());
        }
    }
}
