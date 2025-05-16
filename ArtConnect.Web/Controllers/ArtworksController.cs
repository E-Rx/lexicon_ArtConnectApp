using ArtConnect.Web.Models;
using ArtConnect.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArtConnect.Web.Controllers
{
    public class ArtworkController : Controller
    {
        private readonly ArtworkService _artworkService;

        public ArtworkController(ArtworkService artworkService)
        {
            _artworkService = artworkService;
        }

        // Affiche la liste des œuvres
        public IActionResult Index()
        {
            var artworks = _artworkService.GetAllArtworks();
            return View(artworks);
        }

        // Affiche le formulaire de création
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Traite le formulaire de création
        [HttpPost]
        public IActionResult Create(ArtworkViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var newArtwork = new Artwork
            {
                Title = viewModel.Title,
                Artist = viewModel.Artist,
                Year = viewModel.Year,
                Style = viewModel.Style,
                Description = viewModel.Description,
                ImageUrl = viewModel.ImageUrl,
                Contributor = viewModel.Contributor
            };

            _artworkService.AddArtwork(newArtwork);
            return RedirectToAction(nameof(Index));
        }
    }
}
