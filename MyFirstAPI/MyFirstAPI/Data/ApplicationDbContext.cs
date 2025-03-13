using Microsoft.EntityFrameworkCore;
using MyFirstAPI.Models.Entities;

namespace MyFirstAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
