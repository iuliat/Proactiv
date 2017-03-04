using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Proactiv.Models;

namespace Proactiv.Controllers
{
    public class TopicsModels1Controller : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TopicsModels1
        public async Task<ActionResult> Index()
        {
            return View(await db.TopicsModels.ToListAsync());
        }

        // GET: TopicsModels1/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TopicsModels topicsModels = await db.TopicsModels.FindAsync(id);
            if (topicsModels == null)
            {
                return HttpNotFound();
            }
            return View(topicsModels);
        }

        // GET: TopicsModels1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TopicsModels1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "TopicID,TopicTitle,TopicDescription,TopicTag")] TopicsModels topicsModels)
        {
            if (ModelState.IsValid)
            {
                db.TopicsModels.Add(topicsModels);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(topicsModels);
        }

        // GET: TopicsModels1/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TopicsModels topicsModels = await db.TopicsModels.FindAsync(id);
            if (topicsModels == null)
            {
                return HttpNotFound();
            }
            return View(topicsModels);
        }

        // POST: TopicsModels1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "TopicID,TopicTitle,TopicDescription,TopicTag")] TopicsModels topicsModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(topicsModels).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(topicsModels);
        }

        // GET: TopicsModels1/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TopicsModels topicsModels = await db.TopicsModels.FindAsync(id);
            if (topicsModels == null)
            {
                return HttpNotFound();
            }
            return View(topicsModels);
        }

        // POST: TopicsModels1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            TopicsModels topicsModels = await db.TopicsModels.FindAsync(id);
            db.TopicsModels.Remove(topicsModels);
            await db.SaveChangesAsync();
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
