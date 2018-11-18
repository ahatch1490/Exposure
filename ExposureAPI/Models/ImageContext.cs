using Microsoft.EntityFrameworkCore;

namespace ExposureAPI.Models
{
    public class ImageContext: DbContext
    {
        public ImageContext(DbContextOptions<ImageContext> options) : base(options) { }
        public DbSet<Image> Images { get; set;}  
        protected override void OnModelCreating(ModelBuilder  modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public")
                .Entity<Image>()
                .HasOne(i => i.Gallery)
                .WithMany(g => g.Images);
            base.OnModelCreating(modelBuilder);
        }
        
    }
}