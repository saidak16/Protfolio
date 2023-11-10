using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Web.ViewModels;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork<Ownier> ownier;
        private readonly IUnitOfWork<ProtfolioItem> protfolio;

        public HomeController(IUnitOfWork<Ownier> ownier, IUnitOfWork<ProtfolioItem> protfolio)
        {
            this.ownier = ownier;
            this.protfolio = protfolio;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ownier = ownier.Entity.GetAll().First(),
                protfolioItems = protfolio.Entity.GetAll().ToList()
            };

            return View(homeViewModel);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
