using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCFriend.Models;

namespace MVCFriend.Controllers
{
    public class MatiasTorricoFriendsController : Controller
    {
        private DataContext db = new DataContext();

        // GET: MatiasTorricoFriends
        public ActionResult Index()
        {
            return View(db.MatiasTorricoFriends.ToList());
        }

        // GET: MatiasTorricoFriends/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MatiasTorricoFriend matiasTorricoFriend = db.MatiasTorricoFriends.Find(id);
            if (matiasTorricoFriend == null)
            {
                return HttpNotFound();
            }
            return View(matiasTorricoFriend);
        }

        // GET: MatiasTorricoFriends/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MatiasTorricoFriends/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FriendId,Name,Type,Nickname,Birthdate")] MatiasTorricoFriend matiasTorricoFriend)
        {
            if (ModelState.IsValid)
            {
                db.MatiasTorricoFriends.Add(matiasTorricoFriend);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(matiasTorricoFriend);
        }

        // GET: MatiasTorricoFriends/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MatiasTorricoFriend matiasTorricoFriend = db.MatiasTorricoFriends.Find(id);
            if (matiasTorricoFriend == null)
            {
                return HttpNotFound();
            }
            return View(matiasTorricoFriend);
        }

        // POST: MatiasTorricoFriends/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FriendId,Name,Type,Nickname,Birthdate")] MatiasTorricoFriend matiasTorricoFriend)
        {
            if (ModelState.IsValid)
            {
                db.Entry(matiasTorricoFriend).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(matiasTorricoFriend);
        }

        // GET: MatiasTorricoFriends/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MatiasTorricoFriend matiasTorricoFriend = db.MatiasTorricoFriends.Find(id);
            if (matiasTorricoFriend == null)
            {
                return HttpNotFound();
            }
            return View(matiasTorricoFriend);
        }

        // POST: MatiasTorricoFriends/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MatiasTorricoFriend matiasTorricoFriend = db.MatiasTorricoFriends.Find(id);
            db.MatiasTorricoFriends.Remove(matiasTorricoFriend);
            db.SaveChanges();
            return RedirectToAction("Index");
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
