using System;
using System.Collections.Generic;
using System.Reflection;

namespace ExposureAPI.Models
{
    public class Gallery
    {
        public int GalleryId { get; set; }
        public int SiteId { get; set; }
        public Guid Uuid { get; set; }
        public List<Image> Images { get; set; } 
        

    }
}