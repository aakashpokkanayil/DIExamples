using Microsoft.AspNetCore.Mvc;
using Services;

namespace DIExamples.Controllers
{
    public class HomeController : Controller
    {
        private readonly CltiesService citiesService;
        public HomeController()
        {
            citiesService= new CltiesService();
        }
        [Route("/")]
        public IActionResult Index()
        {
            var cities=citiesService.GetCities();
            return View(cities);
        }
    }
}
