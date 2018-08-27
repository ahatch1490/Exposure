using System;
using System.Net; 
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using System.Xml.Xsl;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace ExposureAPI.Resources.GoodReads
{
    [XmlType("review")]
    public class Review
    {
        [XmlElement("rating")]
        public string Rating { get; set; }

        private string _body;

        [XmlElement("body")]
        public string Body
        {
            get { return _body; }
            set { _body = WebUtility.HtmlDecode(value); }
        }

        [XmlElement("book")]
        public Book Book { get; set; }  
    }
}