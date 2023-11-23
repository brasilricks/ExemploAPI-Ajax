using System.Web.Mvc;

namespace testeProg.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DetalhesJS(int id)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}