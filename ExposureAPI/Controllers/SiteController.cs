using System;
using System.Linq;
using System.Threading.Tasks;
using ExposureAPI.Models;
using ExposureAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ExposureAPI.Controllers
{
    public class SiteController : Controller
    {
        private readonly SiteContext _service;
        private readonly ContentSectionContext _contentSectionService; 
        public SiteController(SiteContext service,  ContentSectionContext  contentService)
        {
            _contentSectionService = contentService; 
            _service = service; 
        }
        // GET
        [Route("/sites")]
        public IActionResult Index()
        {
            return
                View(_service.Sites);
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
        public async Task<ActionResult> Update(Site site)
        {
            _service.Update(site);
            await _service.SaveChangesAsync();
            return Redirect($"/site/show/{site.SiteId}");
        }    
        // POST
        [HttpPost("/site/create")]
        public async Task<ActionResult> Create(Site site)
        {
            site.UUID = Guid.NewGuid(); 
            _service.Sites.Add(site);
            await  _service.SaveChangesAsync();  
            return Redirect($"/site/show/{site.SiteId}");
        }
        [Route("/site/show/{id}")]
        public async Task<IActionResult> show(int id)
        {
            var site = _service.Sites.First(s => s.SiteId == id);
            var contentSections = _contentSectionService.ContentSections
                .Where(cs => cs.SiteId == id);
            
            return 
            View(new SiteShow(site,contentSections));
        }

        [HttpPost("/site/{siteid}/section/{uuid}/update")]
        public async Task<ActionResult> UpdateSection()
        {
            string content   = HttpContext.Request.Form["Content"];
            string uuid = HttpContext.Request.Form["uuid"];
            
            var section = _contentSectionService.ContentSections.
                First(cs => cs.UUID ==  Guid.Parse(uuid));
            
            section.Content = content; 
            await _contentSectionService.AddAsync(section);
            
            return Redirect($"/site/show/{section.SiteId}");
        }
        
        
        [HttpPost("/site/{siteid}/section/create")]
        public async Task<ActionResult> CreateSection(int siteid )
        {   
            string content   = HttpContext.Request.Form["Content"];
            
            var section = new ContentSection {
                Content = content,
                SiteId = siteid, 
                UUID = Guid.NewGuid()};
            
            await _contentSectionService.AddAsync(section);
            await _contentSectionService.SaveChangesAsync();
            
            return Redirect($"/site/show/{siteid}");
        }

        [HttpGet("/site/{siteId}/section/delete/{uuid}")]
        public async Task<ActionResult> DeleteSection(int siteId, Guid uuid)
        {
            var deleted_section = _contentSectionService.ContentSections.First(cs => cs.UUID == uuid);
            
            _contentSectionService.ContentSections.Remove(deleted_section);
            await _contentSectionService.SaveChangesAsync(); 
            return Redirect($"/site/show/{siteId}");
        }

    }
}