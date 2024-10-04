using Microsoft.EntityFrameworkCore;


namespace PortofolioWebsite.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        // The database will be read only
        // public DbSet<ServerModel> Servers { get; set; }
        // public DbSet<PlayerCountHistoryModel> PlayerCountHistories { get; set; }
    }
}
