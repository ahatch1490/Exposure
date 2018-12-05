using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ExposureAPI.Controllers
{
    [Route("Account")]
    public class AccountController :Controller 
    {
        [Route("~/")]
        public IActionResult Login()
        {
            return View(); 
        }
        [HttpPost("Create")]
        public ActionResult Create()
        {
           return Redirect("/sites"); 
        }
    }
}