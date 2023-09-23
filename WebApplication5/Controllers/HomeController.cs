using Microsoft.AspNetCore.Mvc;
using WebApplication5.ViewModels.Films;
using WebApplication5.Services.Interfaces;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

         }
        public IActionResult Index()
        {
            return View();
        }
        

        public IActionResult AddFilm(FilmsAddEdit model)
        {
            return View(model);
        }

    }
}
