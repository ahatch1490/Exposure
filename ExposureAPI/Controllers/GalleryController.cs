using System.Linq;
using ExposureAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExposureAPI.Controllers
{

    public class GalleryController : Controller
    {
        private readonly GalleryContext _context; 
        
        public  GalleryController(GalleryContext context)
        {
            _context = context; 
        }
        // GET
        [HttpGet("/site/{siteId}/Gallery")]
        public IActionResult Index(int siteid)
        {
            return
                View(_context.Galleries.First(g => g.SiteId == siteid)); 
        }

        [HttpPost("/site/{siteId}/Gallery")]
        public IActionResult Create()
        {
            return View(); 
        } 

        [HttpGet("/site/{siteId}/Gallery/{galleryid}")]
        public IActionResult Show(int siteId, int galleryId)
        {
            return View(); 
        }

        [HttpPost("/site/{siteId}/Gallery/{galleryId}/image/save")]
        public void SaveImage(int siteId, int galleryId)
        {
             
        }
    }
}