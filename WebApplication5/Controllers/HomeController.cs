using Microsoft.AspNetCore.Mvc;
using WebApplication5.ViewModels.Films;
using WebApplication5.Services.Interfaces;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }       
    }
}
