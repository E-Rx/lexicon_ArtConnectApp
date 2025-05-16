using ArtConnect.Web.Models;
using ArtConnect.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArtConnect.Web.Controllers
{
    public class ArtworkController : Controller
    {
      private static ArtworkService artworkService = new ArtworkService();

      // Index action to display all artworks
      [HttpGet("")]
        public IActionResult Index()
        {
            var artworks = artworkService.GetAllArtworks();
            return View(artworks);
        }

        // Create action to display the form for adding a new artwork
        [HttpGet("create")]
        public IActionResult Create()
        {
            return View();
        }

        // Post action to handle the form submission for adding a new artwork
        [HttpPost("create")]
        public IActionResult Create(Artwork artwork)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var newArtwork = new Artwork
            {
                Title = artwork.Title,
                Artist = artwork.Artist,
                Year = artwork.Year,
                Style = artwork.Style,
                Description = artwork.Description,
                ImageUrl = artwork.ImageUrl,
                Contributor = artwork.Contributor
            };

            artworkService.AddArtwork(newArtwork);
            return RedirectToAction(nameof(Index));
        }
    }
}
