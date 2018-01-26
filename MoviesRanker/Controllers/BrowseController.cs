using AutoMapper;
using MoviesRanker.Models;
using MoviesRanker.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MoviesRanker.Controllers
{
    public class BrowseController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        // GET: Browse
        public async Task<ActionResult> Index()
        {
            List<Movie> movies = await db.Movies.ToListAsync();
            List<MovieVM> movieVMs = new List<MovieVM>();

            foreach (var movie in movies)
            {
                MovieVM movieVM = new MovieVM();
                Mapper.Map(movie, movieVM);
                movieVMs.Add(movieVM);
            }

            return View(movieVMs);
        }

        //Dispose
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