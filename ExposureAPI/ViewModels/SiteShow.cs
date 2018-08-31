using System.Collections.Generic;
using ExposureAPI.Models;
using Microsoft.AspNetCore.Server.Kestrel.Transport.Libuv.Internal.Networking;

namespace ExposureAPI.ViewModels
{
    public class SiteShow
    {
//        private ContentSectionService _contentSectionService { get; set; }
//        private SiteService _siteService { get; set; }

        public  Site Site { get;  }
        public IEnumerable<ContentSection> ContentSections { get;  }

   
        
//        public SiteShow(ContentSectionService contentSectionService, SiteService siteService)
//        {
//            _contentSectionService = contentSectionService;
//            _siteService = siteService; 
//        }

        public SiteShow(Site site, IEnumerable<ContentSection> sections)
        {
            Site = site;
            ContentSections = sections; 
        }
        

    }
}