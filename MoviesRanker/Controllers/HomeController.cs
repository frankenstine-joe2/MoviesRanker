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
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public async Task<ActionResult> Index()
        {
            //List<Movie> movies = await db.Movies.ToListAsync();
            //List<MovieVM> movieVMs = new List<MovieVM>();

            //foreach (var movie in movies)
            //{
            //    MovieVM movieVM = new MovieVM();
            //    Mapper.Map(movie, movieVM);
            //    movieVMs.Add(movieVM);
            //}

            return View();
        }


        //public async Task<ActionResult> Browse()
        //{
        //    List<Movie> movies = await db.Movies.ToListAsync();
        //    List<MovieVM> movieVMs = new List<MovieVM>();

        //    foreach (var movie in movies)
        //    {
        //        MovieVM movieVM = new MovieVM();
        //        Mapper.Map(movie, movieVM);
        //        movieVMs.Add(movieVM);
        //    }

        //    return View(movieVMs);
        //}

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

        //public async Task<ActionResult> Movies()
        //{
        //    List<Movie> movies = await db.Movies.ToListAsync();
        //    List<MovieVM> movieVMs = new List<MovieVM>();

        //    foreach (var movie in movies)
        //    {
        //        MovieVM movieVM = new MovieVM();
        //        Mapper.Map(movie, movieVM);
        //        movieVMs.Add(movieVM);
        //    }

        //    return View(movieVMs);
        //}

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