using Microsoft.EntityFrameworkCore;
using WebApplication5.Data.Entity;
namespace WebApplication5.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        public DbSet<Film> Films { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Country> Countries { get; set; }       


    }
}
