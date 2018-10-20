using System;
using ExposureAPI.Models;
using Microsoft.AspNetCore.Mvc;
namespace ExposureAPI.Controllers
{
    public class SectionController :Controller
    {

        private ContentSectionService _contentSectionService; 
        public SectionController(SiteService service, ContentSectionService contentService)
        {
            _contentSectionService = contentService; 
        }
        
//        [HttpPost("/section/delete/{uuid}")]
//        public ActionResult DeleteSection(Guid uuid)
//        {
//            _contentSectionService.DeleteContentSection(uuid);
//            throw new E
//        }
    }
}