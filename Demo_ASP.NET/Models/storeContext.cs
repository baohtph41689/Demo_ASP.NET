using Microsoft.EntityFrameworkCore;

namespace Demo_ASP.NET.Models
{
    public class storeContext : DbContext
    {

        public storeContext(DbContextOptions<storeContext> opt) : base(opt)
        { }
        public DbSet<product> Products { get; set; }
        public DbSet<category>? Categories { get; set; }
    }
}
