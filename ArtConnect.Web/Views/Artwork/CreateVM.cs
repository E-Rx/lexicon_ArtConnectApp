using System.ComponentModel.DataAnnotations;

namespace ArtConnect.Web.Views.Artwork;


public class CreateVM
{
    [Required(ErrorMessage = "Title is required")]
    [Display(Name = "Artwork Title")]
    public string Title { get; set; } = String.Empty;

    [Required(ErrorMessage = "Artist is required")]
    [Display(Name = "Artist Name")]
    public string Artist { get; set; } = String.Empty;

    [Display(Name = "Art Style")]
    public string Style { get; set; } = String.Empty;

    [Required(ErrorMessage = "Year is required")]
    [Range(0, 2026, ErrorMessage = "Year must be between 0 and 2025")]
    public int Year { get; set; }

    [Required(ErrorMessage = "Description is required")]
    [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
    [Display(Name = "Artwork Description")]
    public string Description { get; set; } = String.Empty;

    [Required(ErrorMessage = "Image URL is required")]
    [Url(ErrorMessage = "Invalid URL format")]
    [Display(Name = "Image URL")]
    public string ImageUrl { get; set; } = String.Empty;

    [Required(ErrorMessage = "You must specify a name")]
    [Display(Name = "Your Name (Contributor)")]
    public string Contributor { get; set; } = String.Empty;
}
