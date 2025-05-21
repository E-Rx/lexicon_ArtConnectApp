using ArtConnect.Web.Models;
using ArtConnect.Web.Services;
using Microsoft.AspNetCore.Mvc;
using ArtConnect.Web.Views.Artwork;

namespace ArtConnect.Web.Controllers;

// Controller using primary constructor (C# 12 feature)
public class ArtworkController(ArtworkService artworkService) : Controller
{
  // GET: / => Displays a list of all artworks
  [HttpGet("")]
  public IActionResult Index()
  {
    Artwork[] artworks = artworkService.GetAllArtworks();

    IndexVM vm = new IndexVM
    {
      Artworks = artworks.Select(a => new IndexVM.ArtworkVM
      {
        Id = a.Id,
        Title = a.Title,
        Artist = a.Artist,
        ImageUrl = a.ImageUrl,
        Contributor = a.Contributor
      }).ToArray()
    };

    return View(vm);
  }

  // GET: /create => Displays the form for creating a new artwork
  [HttpGet("create")]
  public IActionResult Create()
  {
    return View();
  }

  // POST: /create => Handles form submission for creating a new artwork 
  [HttpPost("create")]
  public IActionResult Create(CreateVM viewModel) 
  {
    if (!ModelState.IsValid)
    {
      return View(viewModel);
    }

    Artwork newArtwork = new()
    {
      Title = viewModel.Title,
      Artist = viewModel.Artist,
      Year = viewModel.Year,
      Style = viewModel.Style,
      Description = viewModel.Description,
      ImageUrl = viewModel.ImageUrl,
      Contributor = viewModel.Contributor
    };

    artworkService.AddArtwork(newArtwork);
    return RedirectToAction(nameof(Index));
  }


  // GET: /Details/{id} => Displays the details of a specific artwork
  [HttpGet("Details/{id}")]
  public IActionResult Details(int id)
  {
    Artwork artwork = artworkService.GetArtworkById(id);
    if (artwork == null)
    {
      return NotFound();
    }

    DetailsVM vm = new()
    {
      Id = artwork.Id,
      Title = artwork.Title,
      Artist = artwork.Artist,
      Year = artwork.Year,
      Style = artwork.Style,
      Description = artwork.Description,
      ImageUrl = artwork.ImageUrl,
      Contributor = artwork.Contributor
    };

    return View(vm);
  }
}
