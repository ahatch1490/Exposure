using Microsoft.EntityFrameworkCore;
namespace ExposureAPI.Models
{
    public class ContentSectionContext :DbContext
    {
        public ContentSectionContext(DbContextOptions<ContentSectionContext> options) : base(options) { }
        public DbSet<ContentSection> ContentSections { get; set; }  

        
        protected override void OnModelCreating(ModelBuilder  modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
    }
}