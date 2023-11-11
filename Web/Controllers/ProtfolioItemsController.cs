using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Web.Models;

namespace Web.Controllers
{
    public class ProtfolioItemsController : Controller
    {
        private readonly IUnitOfWork<ProtfolioItem> protfolio;

        public ProtfolioItemsController(IUnitOfWork<ProtfolioItem> protfolio)
        {
            this.protfolio = protfolio;
        }

        // GET: ProtfolioItemsController
        public ActionResult Index(int pg = 1)
        {
            var result = protfolio.Entity.GetAll().ToList();

            const int pageSize = 5;
            if (pg < 1)
                pg = 1;

            int recsCount = result.Count;
            var pager = new Pager(recsCount, pg, pageSize);
            int recSkip = (pg - 1) * pageSize;

            var data = result.Skip(recSkip).Take(pager.PageSize).ToList();

            this.ViewBag.Pager = pager;

            return View(data);
        }

        // GET: ProtfolioItemsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProtfolioItemsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProtfolioItemsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProtfolioItemsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProtfolioItemsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProtfolioItemsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProtfolioItemsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
