using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ExposureAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

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
      
            return  View(galleries.ToList());

        }
        
        // GET
        [Consumes("multipart/form-data")]
        [HttpPost("/site/{siteId}/Gallery/{galleryId}/process")]
        public IActionResult Process(int galleryid, IFormFile filepond)
        {

            var gallery = _context.Galleries.First(g => g.GalleryId == galleryid);
            var id = Guid.NewGuid().ToString();
            if (filepond.Length > 0)
            {
            
                if( ! Directory.Exists(Path.GetTempPath() + $"/{id}/"))
                {
                    Directory.CreateDirectory(Path.GetTempPath() + $"/{id}/"); 
                }
                
                var filePath =  Path.Combine(Path.GetTempPath()+$"/{id}/",filepond.FileName );
                
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    filepond.CopyTo(stream);
                }



                var root_path = $"wwwroot/images/{gallery.SiteId}/{gallery.GalleryId}/";
                var di = Directory.CreateDirectory(root_path);
                
                var uuid = Guid.NewGuid().ToString();
                var ext = Path.GetExtension(filepond.FileName);  
                var path = $"{root_path}/{uuid}{ext}";
                
                System.IO.File.Copy(Path.GetTempPath()+$"/{id}/" +filepond.FileName , path  );

                var image = new Image
                {
                    Gallery =  gallery,
                    Path = path.Replace("wwwroot",""),
                    Uuid = Guid.Parse(uuid)  
                };

                try
                {
                    _context.Entry(gallery).State = EntityState.Modified;
                    gallery.Images.Add(image);
                    _context.Update(gallery);
                    _context.SaveChanges();

                }
                catch (Exception e)
                {
                    var message = e.Message;
                    throw e; 
                }




            }

           
            Response.ContentType = "text/plain";
            return Ok(id);
            
        }
        
        public async Task<IActionResult> Post(List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);

            // full path to file in temp locatixon
            var filePath = Path.GetTempFileName();

            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }

            // process uploaded files
            // Don't rely on or trust the FileName property without validation.

            return Ok(new { count = files.Count, size, filePath});
        }


        [HttpPost("/site/{siteId}/Gallery")]
        public IActionResult Create()
        {
            return View(); 
        } 

        [HttpGet("/site/{siteId}/Gallery/{galleryid}")]
        public IActionResult Show(int siteId, int galleryId)
        {
            var gallery = _context.Galleries.Include(g => g.Images).First(g => g.SiteId == siteId);
            return View(gallery); 
        }
        
        [HttpGet("/Gallery/image/destroy/{imageId}")]
        public void Destroy(int imageId)
        {
            var image = _context.Images.Include(i => i.Gallery).First(i => i.ImageId == imageId);
            var gallery = image.Gallery; 
            _context.Images.Remove(image);
            _context.SaveChanges(); 
            Response.Redirect($"/site/{gallery.SiteId}/Gallery/{gallery.GalleryId}");
        } 
        
       
    }
}