using ExposureAPI.Models;
using ExposureAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ExposureAPI.Controllers
{
    public class SiteController : Controller
    {
        private SiteService _service;
        private ContentSectionService _contentSectionService; 
        public SiteController(SiteService service, ContentSectionService contentService)
        {
            _contentSectionService = contentService; 
            _service = service; 
        }
        // GET
        [Route("/")]
        public IActionResult Index()
        {
                  
            return
            View(_service.GetSites());
        }

        // GET
        [Route("/site/new")]
        public IActionResult New()
        {
            return
            View(new Site());
        }
        //POST
        [HttpPost("/site/update")]
        public ActionResult Update(Site site)
        {
            _service.Update(site);
            return Redirect($"/site/show/{site.SiteId}");
        }    
        // POST
        [HttpPost("/site/create")]
        public ActionResult Create(Site site)
        {
            site = _service.InserSite(site);
            return Redirect($"/site/show/{site.SiteId}");
        }
        
        [Route("/site/show/{id}")]
        public IActionResult show(int id)
        {
            var site = _service.GetSite(id);
            var contentSections = _contentSectionService.GetSiteContentSections(id); 
            return 
            View(new SiteShow(site,contentSections));
        }
        
    }
}