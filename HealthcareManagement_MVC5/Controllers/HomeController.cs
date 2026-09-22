using System.Web.Mvc;

namespace HealthcareManagement_MVC5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Healthcare Management System";
            return View();
        }
    }
}
