using ASP.NET.MVC_VideoRental_App.Models;
using ASP.NET.MVC_VideoRental_App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET.MVC_VideoRental_App.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name ="Shrek"
            };

            var customers = new List<Customer>()
            {
                new Customer() { Name ="John"},
                new Customer() { Name ="George"},
                new Customer(){ Name ="Justin"}
            };
            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }



        //public ActionResult Edit(int? id)
        //{
        //    if(id == null)
        //    {
        //        id = 0;
        //    }
        //    return Content("id= " + id);
        //}

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //    {
        //        pageIndex = 1;
        //    }
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //    {
        //        sortBy = "Name";
        //    }
        //    return Content(String.Format("pageIndex={0}& sortBy={1}", pageIndex,sortBy));
        //}

        //[Route("movies/released/{year:regex(\\d{4}):range(2000,2022)}")]
        //public ActionResult ByReleaseDate(int? year)
        //{
        //    if (!year.HasValue)
        //    {
        //        year = 2022;
        //    }
        //    return Content(String.Format("Released by {0}",year));
        //}
    }
}