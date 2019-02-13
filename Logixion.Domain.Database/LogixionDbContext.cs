using System.Data.Entity;
using Logixion.Domain.Entities;

namespace Logixion.Domain.Database
{
    public class LogixionDbContext:DbContext
    {
        public LogixionDbContext() : base("DefaultConnection")
        {
        }
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
