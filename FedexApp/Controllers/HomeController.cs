
using System.Web.Mvc;
using FedexApp.MealAndGreeting;

namespace FedexApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string meal)
        {
            ViewBag.Greeting = new Greeter().Greet();
            ViewBag.Meal = meal;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Meal(string time)
        {
            var meal = new Meal().GetMeal(time);
            return RedirectToAction("Index", "Home", new { meal });
        }
    }
}