using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieDbContext _context;

        public MovieController()
        {
            _context = new MovieDbContext();
            // Ensure database is created and seeded
            _context.Database.Initialize(force: false);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

        // GET: Movie
        public ActionResult Index()
        {
            var availableMovies = _context.Movies.Where(m => m.IsAvailable).ToList();
            return View(availableMovies);
        }

        // GET: Movie/Rented
        public ActionResult Rented()
        {
            var rentedMovies = _context.Movies.Where(m => !m.IsAvailable).ToList();
            return View(rentedMovies);
        }

        // GET: Movie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movie/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AddMovieViewModel model)
        {
            if (ModelState.IsValid)
            {
                var movie = new Movie
                {
                    Title = model.Title,
                    Description = model.Description,
                    RentalPrice = model.RentalPrice,
                    ReleaseYear = model.ReleaseYear,
                    Genre = model.Genre,
                    Duration = model.Duration,
                    IsAvailable = true
                };

                _context.Movies.Add(movie);
                _context.SaveChanges();

                TempData["Message"] = $"Movie '{movie.Title}' has been added successfully!";
                return RedirectToAction("Index");
            }

            return View(model);
        }

        // GET: Movie/Rent/5
        public ActionResult Rent(int id)
        {
            var movie = _context.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }

            if (!movie.IsAvailable)
            {
                TempData["Message"] = "Sorry, this movie is not available for rent.";
                return RedirectToAction("Index");
            }

            movie.IsAvailable = false;
            _context.SaveChanges();
            TempData["Message"] = $"You have successfully rented {movie.Title}!";
            return RedirectToAction("Index");
        }

        // GET: Movie/Return/5
        public ActionResult Return(int id)
        {
            var movie = _context.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }

            movie.IsAvailable = true;
            _context.SaveChanges();
            TempData["Message"] = $"Thank you for returning {movie.Title}!";
            return RedirectToAction("Rented");
        }
    }
} 