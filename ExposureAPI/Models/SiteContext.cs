using Microsoft.EntityFrameworkCore;
namespace ExposureAPI.Models
{
    public class SiteContext :DbContext
    {
        public SiteContext(DbContextOptions<SiteContext> options) : base(options) { }
        public DbSet<Site> Sites { get; set; }  

        
        protected override void OnModelCreating(ModelBuilder  modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
    }
}