using System.Web.Http.Cors;
using System.Web.Mvc;

namespace MyToDoAPI.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "Access-Control-Allow-Origin:*", methods: "*")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
