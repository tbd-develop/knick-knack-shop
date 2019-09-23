using Microsoft.EntityFrameworkCore;
using models;

namespace persistence.DataContext
{
    public class ApplicationContext : DbContext
    {
        public DbSet<KnickKnack> KnickKnacks { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
    }
}