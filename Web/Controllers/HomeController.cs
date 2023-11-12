using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Web.ViewModels;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork<Ownier> ownier;
        private readonly IUnitOfWork<ProtfolioItem> protfolio;
        private readonly IHostingEnvironment hostingEnvironment;

        public HomeController(IUnitOfWork<Ownier> ownier, IUnitOfWork<ProtfolioItem> protfolio, IHostingEnvironment hostingEnvironment)
        {
            this.ownier = ownier;
            this.protfolio = protfolio;
            this.hostingEnvironment = hostingEnvironment;
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

        public IActionResult ViewCV(int id)
        {
            try
            {
                string path = Path.Combine(hostingEnvironment.WebRootPath + "/Resume/Ahmed Khojali's Resume.pdf");
                return File(path, "application/pdf");
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }
    }
}
