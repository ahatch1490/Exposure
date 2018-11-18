using Microsoft.EntityFrameworkCore;


namespace ExposureAPI.Models
{
    public class GalleryContext : DbContext
    {
        public GalleryContext(DbContextOptions<GalleryContext> options) : base(options) { }
        public DbSet<Gallery> Galleries { get; set; }  
        public DbSet<Image> Images { get; set; }  
        
        protected override void OnModelCreating(ModelBuilder  modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.Entity<Image>(entity =>
                entity.HasOne(i => i.Gallery)
                    .WithMany(g => g.Images)
                    .HasForeignKey(g => g.GalleryId)
                );
                    
//            modelBuilder.Entity<Gallery>(entity =>
//            {
//                entity.HasMany(g => g.Images)
//                    .WithOne(i => i.Gallery)
//                    .HasForeignKey(g => g.GalleryId);
//            }); 


        }
        
    }
}