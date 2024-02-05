using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using ProMan_Project.Data;
using ProMan_Project.Models;

namespace ProMan_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProMan_ProjectDbContext context1;
        public HomeController(ProMan_ProjectDbContext context)
        {
            context1 = context; 
        }
        public IActionResult Index()
        {
            Home? home = context1.Home.FirstOrDefault();
            return View(home);
        }
    }
}
