using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ExposureAPI.Models;
using Microsoft.AspNetCore.Http;
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
        public IActionResult Index(int siteId)
        {
            var galleries = _context.Galleries.Where(g => g.SiteId == siteId);
            if (galleries.Count() == 1)
            {
                
                Redirect($"/site/{siteId}/Gallery/{galleries.First().GalleryId}");
            
            }
      
            return
                View(galleries.ToList());

        }
        
        // GET
        [HttpPost("/Gallery/{galleryId}/process")]
        public IActionResult Process(IFormFile file)
        {
            var filePath = Path.GetTempFileName();
            if (file.Length > 0)
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                     Task.Run(()=> file.CopyToAsync(stream));
                }
            }
           return Ok(new {filePath});
            
        }
        
//        public async Task<IActionResult> Post(List<IFormFile> files)
//        {
//            long size = files.Sum(f => f.Length);
//
//            // full path to file in temp location
//            var filePath = Path.GetTempFileName();
//
//            foreach (var formFile in files)
//            {
//                if (formFile.Length > 0)
//                {
//                    using (var stream = new FileStream(filePath, FileMode.Create))
//                    {
//                        await formFile.CopyToAsync(stream);
//                    }
//                }
//            }
//
//            // process uploaded files
//            // Don't rely on or trust the FileName property without validation.
//
//            return Ok(new { count = files.Count, size, filePath});
//        }


        [HttpPost("/site/{siteId}/Gallery")]
        public IActionResult Create()
        {
            return View(); 
        } 

        [HttpGet("/site/{siteId}/Gallery/{galleryid}")]
        public IActionResult Show(int siteId, int galleryId)
        {
            return View(_context.Galleries.First(g => g.SiteId == siteId)); 
        }

    }
}