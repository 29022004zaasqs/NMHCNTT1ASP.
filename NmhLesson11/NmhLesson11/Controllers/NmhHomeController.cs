using System.Web.Mvc;
namespace NmhLesson11.Controllers
{
    public class NmhHomeController : Controller
    {
        public ActionResult NmhIndex()
        {
            return View();
        }

        public ActionResult NmhAbout()
        {
            ViewBag.Title = "Nguyen Minh Hiep";
            return View();
        }

        public ActionResult NmhContact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}
