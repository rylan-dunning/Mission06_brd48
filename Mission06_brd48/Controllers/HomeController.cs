using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission06_brd48.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_brd48.Controllers
{
    public class HomeController : Controller
    {
        private MovieFormContext daContext { get; set; }

        //Constructor
        public HomeController(MovieFormContext someName)
        {
            daContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            ViewBag.Categories = daContext.Categories.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult MovieForm(FormResponse fr)
        {
            if (ModelState.IsValid)
            {
                daContext.Add(fr);
                daContext.SaveChanges();

                return View("Confirmation", fr);
            }
            else //if invalid
            {
                ViewBag.Categories = daContext.Categories.ToList();
                return View();
            }
        }

        public IActionResult Podcast()
        {
            return View();
        }

        public IActionResult MovieList()
        {
            var applications = daContext.responses
                .Include(x => x.Category)
                .Where (x => x.Edited == false)
                .OrderBy(x => x.MovieTitle)
                .ToList();

            return View(applications);
        }

        [HttpGet]
        public IActionResult Edit (int movieid)
        {
            ViewBag.Categories = daContext.Categories.ToList();

            var theform = daContext.responses.Single(x => x.MovieId == movieid);

            return View("MovieForm", theform);
        }

        [HttpPost]
        public IActionResult Edit (FormResponse yarr)
        {
            daContext.Update(yarr);
            daContext.SaveChanges();

            return RedirectToAction("MovieList");

        }
        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var movie = daContext.responses.Single(x => x.MovieId == movieid);

            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(FormResponse fr)
        {
            daContext.responses.Remove(fr);
            daContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
