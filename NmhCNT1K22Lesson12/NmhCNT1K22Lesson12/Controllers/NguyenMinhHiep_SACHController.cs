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
    public class NguyenMinhHiep_SACHController : Controller
    {
        private NguyenMinhHiep_20123212Entities db = new NguyenMinhHiep_20123212Entities();

        // GET: NguyenMinhHiep_SACH
        public ActionResult NmhIndex()
        {
            var nguyenMinhHiep_SACH = db.NguyenMinhHiep_SACH.Include(n => n.NguyenMinhHiep_TACGIA);
            return View(nguyenMinhHiep_SACH.ToList());
        }

        // GET: NguyenMinhHiep_SACH/NmhDetails/5
        public ActionResult NmhDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NguyenMinhHiep_SACH nguyenMinhHiep_SACH = db.NguyenMinhHiep_SACH.Find(id);
            if (nguyenMinhHiep_SACH == null)
            {
                return HttpNotFound();
            }
            return View(nguyenMinhHiep_SACH);
        }

        // GET: NguyenMinhHiep_SACH/NmhCreate
        public ActionResult NmhCreate()
        {
            ViewBag.NguyenMinhHiep_MaTG = new SelectList(db.NguyenMinhHiep_TACGIA, "NguyenMinhHiep_MaTG", "NguyenMinhHiep_TenTacGia");
            return View();
        }

        // POST: NguyenMinhHiep_SACH/NmhCreate
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more NmhDetails see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NmhCreate([Bind(Include = "NguyenMinhHiep_MaSach,NguyenMinhHiep_TenSach,NguyenMinhHiep_SoTrang,NguyenMinhHiep_NamXB,NguyenMinhHiep_MaTG,NguyenMinhHiep_TrangThai")] NguyenMinhHiep_SACH nguyenMinhHiep_SACH)
        {
            if (ModelState.IsValid)
            {
                db.NguyenMinhHiep_SACH.Add(nguyenMinhHiep_SACH);
                db.SaveChanges();
                return RedirectToAction("NmhIndex");
            }

            ViewBag.NguyenMinhHiep_MaTG = new SelectList(db.NguyenMinhHiep_TACGIA, "NguyenMinhHiep_MaTG", "NguyenMinhHiep_TenTacGia", nguyenMinhHiep_SACH.NguyenMinhHiep_MaTG);
            return View(nguyenMinhHiep_SACH);
        }

        // GET: NguyenMinhHiep_SACH/NmhEdit/5
        public ActionResult NmhEdit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NguyenMinhHiep_SACH nguyenMinhHiep_SACH = db.NguyenMinhHiep_SACH.Find(id);
            if (nguyenMinhHiep_SACH == null)
            {
                return HttpNotFound();
            }
            ViewBag.NguyenMinhHiep_MaTG = new SelectList(db.NguyenMinhHiep_TACGIA, "NguyenMinhHiep_MaTG", "NguyenMinhHiep_TenTacGia", nguyenMinhHiep_SACH.NguyenMinhHiep_MaTG);
            return View(nguyenMinhHiep_SACH);
        }

        // POST: NguyenMinhHiep_SACH/NmhEdit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more NmhDetails see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NmhEdit([Bind(Include = "NguyenMinhHiep_MaSach,NguyenMinhHiep_TenSach,NguyenMinhHiep_SoTrang,NguyenMinhHiep_NamXB,NguyenMinhHiep_MaTG,NguyenMinhHiep_TrangThai")] NguyenMinhHiep_SACH nguyenMinhHiep_SACH)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nguyenMinhHiep_SACH).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NmhIndex");
            }
            ViewBag.NguyenMinhHiep_MaTG = new SelectList(db.NguyenMinhHiep_TACGIA, "NguyenMinhHiep_MaTG", "NguyenMinhHiep_TenTacGia", nguyenMinhHiep_SACH.NguyenMinhHiep_MaTG);
            return View(nguyenMinhHiep_SACH);
        }

        // GET: NguyenMinhHiep_SACH/NmhDelete/5
        public ActionResult NmhDelete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NguyenMinhHiep_SACH nguyenMinhHiep_SACH = db.NguyenMinhHiep_SACH.Find(id);
            if (nguyenMinhHiep_SACH == null)
            {
                return HttpNotFound();
            }
            return View(nguyenMinhHiep_SACH);
        }

        // POST: NguyenMinhHiep_SACH/NmhDelete/5
        [HttpPost, ActionName("NmhDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult NmhDeleteConfirmed(int id)
        {
            NguyenMinhHiep_SACH nguyenMinhHiep_SACH = db.NguyenMinhHiep_SACH.Find(id);
            db.NguyenMinhHiep_SACH.Remove(nguyenMinhHiep_SACH);
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
