
namespace ArtConnect.Web.Views.Artwork
{
    public class DetailsVM
    {
        public required int Id { get; set; }
        public required string Title { get; set; }
        public required string Artist { get; set; }
        public int? Year { get; set; }
        public string? Style { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? Contributor { get; set; }
    }
}
