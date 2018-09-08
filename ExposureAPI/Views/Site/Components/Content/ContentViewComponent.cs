using ExposureAPI.Models;
using Microsoft.AspNetCore.Mvc;


namespace Components
{
    public class ContentViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke( ContentSection section)
        {
            return View("Section", section);
        }
    }
}