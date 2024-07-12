using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NmhCNT1K22Lesson12.Models;

namespace NmhCNT1K22Lesson12.Controllers
{
    public class NguyenMinhHiep_TACGIAController : Controller
    {
        private NguyenMinhHiep_20123212Entities db = new NguyenMinhHiep_20123212Entities();

        // GET: NguyenMinhHiep_TACGIA
        public ActionResult NmhIndex()
        {
            return View(db.NguyenMinhHiep_TACGIA.ToList());
        }

        // GET: NguyenMinhHiep_TACGIA/NmhDetails/5
        public ActionResult NmhDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NguyenMinhHiep_TACGIA nguyenMinhHiep_TACGIA = db.NguyenMinhHiep_TACGIA.Find(id);
            if (nguyenMinhHiep_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(nguyenMinhHiep_TACGIA);
        }

        // GET: NguyenMinhHiep_TACGIA/NmhCreate
        public ActionResult NmhCreate()
        {
            return View();
        }

        // POST: NguyenMinhHiep_TACGIA/NmhCreate
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more NmhDetails see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NmhCreate([Bind(Include = "NguyenMinhHiep_MaTG,NguyenMinhHiep_TenTacGia")] NguyenMinhHiep_TACGIA nguyenMinhHiep_TACGIA)
        {
            if (ModelState.IsValid)
            {
                db.NguyenMinhHiep_TACGIA.Add(nguyenMinhHiep_TACGIA);
                db.SaveChanges();
                return RedirectToAction("NmhIndex");
            }

            return View(nguyenMinhHiep_TACGIA);
        }

        // GET: NguyenMinhHiep_TACGIA/NmhEdit/5
        public ActionResult NmhEdit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NguyenMinhHiep_TACGIA nguyenMinhHiep_TACGIA = db.NguyenMinhHiep_TACGIA.Find(id);
            if (nguyenMinhHiep_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(nguyenMinhHiep_TACGIA);
        }

        // POST: NguyenMinhHiep_TACGIA/NmhEdit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more NmhDetails see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NmhEdit([Bind(Include = "NguyenMinhHiep_MaTG,NguyenMinhHiep_TenTacGia")] NguyenMinhHiep_TACGIA nguyenMinhHiep_TACGIA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nguyenMinhHiep_TACGIA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NmhIndex");
            }
            return View(nguyenMinhHiep_TACGIA);
        }

        // GET: NguyenMinhHiep_TACGIA/NmhDelete/5
        public ActionResult NmhDelete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NguyenMinhHiep_TACGIA nguyenMinhHiep_TACGIA = db.NguyenMinhHiep_TACGIA.Find(id);
            if (nguyenMinhHiep_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(nguyenMinhHiep_TACGIA);
        }

        // POST: NguyenMinhHiep_TACGIA/NmhDelete/5
        [HttpPost, ActionName("NmhDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult NmhDeleteConfirmed(int id)
        {
            NguyenMinhHiep_TACGIA nguyenMinhHiep_TACGIA = db.NguyenMinhHiep_TACGIA.Find(id);
            db.NguyenMinhHiep_TACGIA.Remove(nguyenMinhHiep_TACGIA);
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
