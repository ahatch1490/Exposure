using System.Collections.Generic;
using ExposureAPI.Models;
using Microsoft.AspNetCore.Server.Kestrel.Transport.Libuv.Internal.Networking;

namespace ExposureAPI.ViewModels
{
    public class SiteShow
    {
        public  Site Site { get;  }
        public IEnumerable<ContentSection> ContentSections { get;  }

        public SiteShow(Site site, IEnumerable<ContentSection> sections)
        {
            Site = site;
            ContentSections = sections; 
        }
        
        
    }
}