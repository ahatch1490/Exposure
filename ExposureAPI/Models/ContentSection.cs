using System;

namespace ExposureAPI.Models
{
    public class ContentSection
    {
        public int ContentSectionId { get; set; }
        public Guid Uuid { get; set; }
        public string Content { get; set; }
        public int SiteId { get; set; }

    }
}