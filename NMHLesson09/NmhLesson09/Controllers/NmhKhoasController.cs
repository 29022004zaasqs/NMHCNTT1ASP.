using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NmhLesson09.Models;

namespace NmhLesson09.Controllers
{
    public class NmhKhoasController : Controller
    {
        private NmhK22CNT1Lesson09Entities db = new NmhK22CNT1Lesson09Entities();

        // GET: NmhKhoas
        public ActionResult NmhIndex()
        {
            return View(db.NmhKhoa.ToList());
        }

        // GET: NmhKhoas/Details/5
        public ActionResult NmhDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NmhKhoa nmhKhoa = db.NmhKhoa.Find(id);
            if (nmhKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nmhKhoa);
        }

        // GET: NmhKhoas/NmhCreate
        public ActionResult NmhCreate()
        {
            return View();
        }

        // POST: NmhKhoas/NmhCreate
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NmhCreate([Bind(Include = "NmhMaKH,NmhTenKH,NmhTrangThai")] NmhKhoa nmhKhoa)
        {
            if (ModelState.IsValid)
            {
                db.NmhKhoa.Add(nmhKhoa);
                db.SaveChanges();
                return RedirectToAction("NmhIndex");
            }

            return View(nmhKhoa);
        }

        // GET: NmhKhoas/NmhEdit/5
        public ActionResult NmhEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NmhKhoa nmhKhoa = db.NmhKhoa.Find(id);
            if (nmhKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nmhKhoa);
        }

        // POST: NmhKhoas/NmhEdit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NmhEdit([Bind(Include = "NmhMaKH,NmhTenKH,NmhTrangThai")] NmhKhoa nmhKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nmhKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NmhIndex");
            }
            return View(nmhKhoa);
        }

        // GET: NmhKhoas/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NmhKhoa nmhKhoa = db.NmhKhoa.Find(id);
            if (nmhKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nmhKhoa);
        }

        // POST: NmhKhoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NmhKhoa nmhKhoa = db.NmhKhoa.Find(id);
            db.NmhKhoa.Remove(nmhKhoa);
            db.SaveChanges();
            return RedirectToAction("NmhIndex");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
