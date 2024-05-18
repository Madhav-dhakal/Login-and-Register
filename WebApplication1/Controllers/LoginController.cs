using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {

        private readonly DatabaseContext _context;
        public LoginController(DatabaseContext context)
        {
            _context = context;
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _context.Login.FindAsync(model.Email, model.Password);

                if (user != null && user.Password == model.Password)
                {

                    return RedirectToAction("Index");
                }
                else
                {

                    ModelState.AddModelError("", "Invalid email or password.");
                }
            }


           return View();
        }
    }
}
       
    
