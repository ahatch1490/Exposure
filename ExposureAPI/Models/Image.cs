using System;
using Microsoft.Net.Http.Headers;

namespace ExposureAPI.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public string Title { get; set; }
        public Guid Uuid { get; set; }
        public string Path { get; set; } 
        public int GalleryId { get; set; }
        public Gallery Gallery {get; set; }
    }
}