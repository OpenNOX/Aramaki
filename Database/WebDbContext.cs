using Aramaki.Entities;
using Microsoft.EntityFrameworkCore;

namespace Aramaki.Database
{
    public class WebDbContext : DbContext
    {
        public WebDbContext(DbContextOptions<WebDbContext> options) : base(options)
        {
        }

        public DbSet<Schema> Schemas { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Field> Fields { get; set; }
    }
}
