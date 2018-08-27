using Microsoft.AspNetCore.Mvc;

namespace ExposureAPI.Controllers
{
    public class BlogController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return
            View();
        }
    }
}