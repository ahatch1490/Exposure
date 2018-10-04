using System;
using ExposureAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExposureAPI.Views.Shared.Components
{
    public class ScriptViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke( string className = null)
        {
            if (String.IsNullOrWhiteSpace(className))
            {
                var controller = ViewContext.RouteData.Values["Controller"].ToString();
                var action = ViewContext.RouteData.Values["Action"].ToString();

                return View("Script", controller.Titlize() + action.Titlize());
            }
            else {   return View("Script", className);}
         
        }
    }
}