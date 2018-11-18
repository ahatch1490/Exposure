using System;
using System.Collections.Generic;

namespace ExposureAPI.Models
{
    public class Gallery
    {
        public Gallery()
        {
           Images = new List<Image>();
        }
        public int GalleryId { get; set; }
        public int SiteId { get; set; }
        public Guid UUID { get; set; }
        public string Title { get; set; }
        public ICollection<Image> Images { get; set; } 
        
    }
}