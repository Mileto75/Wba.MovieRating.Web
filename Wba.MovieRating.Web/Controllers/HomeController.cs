using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Wba.MovieRating.Web.Data;
using Wba.MovieRating.Web.Models;
using Wba.MovieRating.Web.ViewModels;

namespace Wba.MovieRating.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly MovieDbContext _movieDbContext;

        public HomeController(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;//inject dbcontext
        }

        public IActionResult Index()
        {
            //implement a list of movies
            //1. configure dependency injection
            //2. implement a view model
            //3. get data from database(list of movies)
            HomeIndexViewModel homeIndexViewModel 
                = new HomeIndexViewModel();
            //4. put movies in viewmodel
            homeIndexViewModel.MovieTitles
                = new List<MovieShowInfoViewModel>();
            foreach (var movie in _movieDbContext.Movies)
            {
                homeIndexViewModel.MovieTitles.Add
                    (new MovieShowInfoViewModel
                    {
                        MovieId = movie?.Id,
                        MovieTitle= movie?.Title
                    });
            }
            //5. pass to the view
            //6. View shows movie to user
            return View(homeIndexViewModel);
        }


        //Maak een directorController
        //met een index methode


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
