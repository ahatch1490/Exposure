using Microsoft.AspNetCore.Mvc;

namespace ExposureAPI.Views.Shared.Components
{
    public class ScriptViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke( string className)
        {
            return View("Script", className);
        }
    }
}