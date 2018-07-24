using System.Collections.Generic;
using System.Xml.Serialization;

namespace ExposureAPI.Resources.GoodReads
{
    [XmlRoot("GoodreadsResponse"), XmlType("GoodreadsResponse")]    
    public class GoodreadsResponse
    {
        [XmlArray("reviews")] 
        public List<Review> Reviews { get; set; }
    }
}