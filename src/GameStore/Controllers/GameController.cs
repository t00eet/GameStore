using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameStore.Models;

namespace GameStore.Controllers
{
    public class GameController : Controller
    {
        private GameContext db = new GameContext();

        //
        // GET: /Game/

        public ActionResult Index()
        {
            return View(db.Games.ToList());
        }

        [HttpPost]
        public ActionResult Index(String query = "")
        {
            var searchResults = db.Games.Where(g => g.Title.Contains(query)).ToList();
            return View(searchResults);
        }

        public ActionResult Admin()
        {
            return View(db.Games.ToList());
        }

        [HttpPost]
        public ActionResult Admin(String filter = "")
        {
            return View(db.Games.ToList());
        }

        // GET: /Game/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Game/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Game game)
        {
            if (ModelState.IsValid)
            {
                db.Games.Add(game);
                db.SaveChanges();
                return RedirectToAction("Admin");
            }

            return View(game);
        }

        //
        // GET: /Game/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Game game = db.Games.Find(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        //
        // POST: /Game/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Game game)
        {
            if (ModelState.IsValid)
            {
                db.Entry(game).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Admin");
            }
            return View(game);
        }

        //
        // GET: /Game/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Game game = db.Games.Find(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        //
        // POST: /Game/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Game game = db.Games.Find(id);
            db.Games.Remove(game);
            db.SaveChanges();
            return RedirectToAction("Admin");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}