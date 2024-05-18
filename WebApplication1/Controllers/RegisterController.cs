using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class RegisterController : Controller
    {
        // dependency injections
        private readonly DatabaseContext _context;
        public RegisterController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // Reading
        [HttpGet]
        public IActionResult List()
        {
            var models = _context.Register.ToList();
            return View(models);
        }

        //creating
        [HttpGet]
        public IActionResult Create( )
        {

            RegisterModel model = new RegisterModel();  
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                _context.Register.Add(model);
                _context.SaveChanges();
                ViewBag.Register = "Successfully registered";
                return RedirectToAction("List");
            }
            return View(model);
        }

        //updating
        [HttpGet]
        public IActionResult Update(int id)
        {
            var model = _context.Register.Find(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                _context.Register.Update(model);
                _context.SaveChanges();
                ViewBag.Register = "Successfully updated";
               
            }
            return View(model);
            
        }

        //deleting 
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = _context.Register.Find(id);
            if (data != null)
            {
                _context.Register.Remove(data);
                _context.SaveChanges();
                ViewBag.Register = "Successfully deleted";
                return RedirectToAction("List");
            }
            return NotFound();
        }

    }
}
