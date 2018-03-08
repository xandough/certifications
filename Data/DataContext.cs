using Certifications.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Certifications.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Server> Servers { get; set; }
        public DbSet<ServerType> ServerTypes { get; set; }
    }
}