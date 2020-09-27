using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        /*public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            var customers = new List<Customer>()
            {
                new Customer { Name = "Customer1"},
                new Customer { Name = "Customer2" }
            };
            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }*/

        public ActionResult Edit(int id)
        {
            return Content("id=" +id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(string.Format("pageIndex={0}&sortby={1}", pageIndex, sortBy));
        }
        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
        public ActionResult MovieList()
        {
            VidlyEntities db = new VidlyEntities();
            List<movie> movies = db.movies.ToList<movie>();
            return View(movies);
        }
        [HttpGet]
        public ActionResult CreateMovie(MovieModel movie)
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateMovie(MovieModel movie)
        {
            VidlyEntities db = new VidlyEntities();

        }
    }
}