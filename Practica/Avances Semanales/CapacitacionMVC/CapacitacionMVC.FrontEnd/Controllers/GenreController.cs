using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CapacitacionMVC.FrontEnd.Models;

namespace CapacitacionMVC.FrontEnd.Controllers
{
    public class GenreController : Controller
    {
        //
        // GET: /Genre/
        public ActionResult Index()
        {
            var genres = new GenresViewModel();
            genres.Genres = CreateGenres();
            return View(genres);
        }

        [HttpPost]
        public ActionResult Search(GenresViewModel genreVM)
        {
            genreVM.Genres = string.IsNullOrWhiteSpace(genreVM.NameFilter)
                ? CreateGenres()
                : CreateGenres().Where(x => x == genreVM.NameFilter).ToList();

            return View("Index", genreVM);
        }

        private List<string> CreateGenres()
        {
            return new List<string>
            {
                "Drama", "Comedia", "Terror"
            };
        } 

	}
}