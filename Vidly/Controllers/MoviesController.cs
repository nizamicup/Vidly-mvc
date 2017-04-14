using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Randome()
        {
            var movie = new Movie { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer{Name="Customer1"},
                new Customer{Name="Customer2"}
            };

            var viewModel = new RandomeMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }

        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie{Name="Shrek!"},
                new Movie{Name="King Arthur"}
            };
            return View(movies);
        }
    }
}