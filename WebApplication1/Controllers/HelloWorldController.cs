using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HelloWorldController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Welcome()
        {

            ViewBag.msg = "This is the Welcome action method...";
            return View();
        }
    }
}
