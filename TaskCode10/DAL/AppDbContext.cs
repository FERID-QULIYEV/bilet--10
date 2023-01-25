using Microsoft.EntityFrameworkCore;
using TaskCode10.Models;
using TaskCode10.Models.Base;

namespace TaskCode10.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {
                
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Pozition> Pozitions { get; set; }
    }
}
