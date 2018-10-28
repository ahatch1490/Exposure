using System;

namespace ExposureAPI.Models
{
    public class ContentSection
    {
        public int ContentSectionId { get; set; }
        public Guid UUID { get; set; }
        public string Content { get; set; }
        public int SiteId { get; set; }

    }
}