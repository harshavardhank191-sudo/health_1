using System.Web.Mvc;

namespace InsuranceManagement_MVC5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Insurance Management System";
            return View();
        }
    }
}
