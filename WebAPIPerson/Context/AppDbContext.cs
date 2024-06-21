using Microsoft.EntityFrameworkCore;
using WebAPIPerson.Models;

namespace WebAPIPerson.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Person> Persons { get; set; }
    }
}
