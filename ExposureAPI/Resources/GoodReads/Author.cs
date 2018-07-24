using System.Xml.Serialization;

namespace ExposureAPI.Resources.GoodReads
{
    [XmlType("author")]
    public class Author
    {
        [XmlElement("name")]
        public string Name { get;set; }
    }
}