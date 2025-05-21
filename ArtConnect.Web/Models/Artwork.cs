using System.ComponentModel.DataAnnotations;



namespace ArtConnect.Web.Models
{
    public class Artwork
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; } = null!;

        [Required(ErrorMessage = "Artist is required")]
        public string Artist { get; set; } = null!;

        public string Style { get; set; } = null!;

        [Required(ErrorMessage = "Year is required")]
        [Range(0, 2026, ErrorMessage = "Year must be between 0 and 2025")]
        public int Year { get; set; }


        [Required(ErrorMessage = "Description is required")]
        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
        public string Description { get; set; } = null!;

        [Required(ErrorMessage = "Image URL is required")]
        [Url(ErrorMessage = "Invalid URL format")]
        public string ImageUrl { get; set; } = null!;

        [Required(ErrorMessage = "You must specify a name")]
        public string Contributor { get; set; } = null!;

    }
}
