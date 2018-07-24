using System.Collections.Generic;
using System.Xml.Serialization;

namespace ExposureAPI.Resources.GoodReads
{
    
    [XmlType("book")]
    public class Book
    {
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }
        [XmlElement("title")]
        public string Title { get; set; }
        [XmlElement("authors")]
        public List<Author> Authors { get; set; }
        [XmlElement("link")]
        public  string Link { get; set; }
       
    }
}