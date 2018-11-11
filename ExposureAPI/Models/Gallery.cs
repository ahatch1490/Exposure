using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

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
        public List<Image> Images { get; set; } 
        
    }
}