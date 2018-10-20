using Microsoft.AspNetCore.Mvc;

namespace ExposureAPI.Controllers
{
    public class GalleryController : Controller
    {
        // GET
        [HttpGet("/site/{siteId}/Gallery")]
        public IActionResult Index(int siteid)
        {
            return
            View();
        }
    }
}