using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace ExposureAPI.Models
{
    public class GalleryContext : DbContext
    {
        public GalleryContext(DbContextOptions<GalleryContext> options) : base(options) { }
        public DbSet<Gallery> Galleries { get; set; }  

        
        protected override void OnModelCreating(ModelBuilder  modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
        
    }
}