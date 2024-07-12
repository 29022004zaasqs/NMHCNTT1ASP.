using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NmhLesson11.Models;

namespace NmhLesson11.Controllers
{
    public class NmhTaiKhoansController : Controller
    {
        private NmhLesson11DbaEntities db = new NmhLesson11DbaEntities();

        // GET: NmhTaiKhoans
        public ActionResult NmhIndex()
        {
            // Get information from session
            //ViewBag["TaiKhoan"] = "";
            if (Session["NmhMember"] != null)
            {
                ViewBag.nmhTaiKhoan = ((NmhTaiKhoan)Session["NmhMember"]).NmhFullName;
            }
            return View();
        }

        public ActionResult NmhAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult NmhContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
