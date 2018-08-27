using ExposureAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExposureAPI.Controllers
{
    public class SiteController : Controller
    {
        private SiteService _service;
        public SiteController(SiteService service)
        {
            _service = service; 
        }
        // GET
        [Route("/")]
        public IActionResult Index()
        {
                  
            return
            View(_service.GetSites());
        }
    }
}