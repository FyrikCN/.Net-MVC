using FidlyAdvanced.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FidlyAdvanced.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie { Id = 1, Name = "Aladdin" },
                new Movie { Id = 2, Name = "Ne Zha" }
            };
            return View(movies);
        }
    }
}