namespace ArtConnect.Web.ViewModels
{
    public class IndexVM
    {
        public ArtworkVM[] Artworks { get; set; } = null!;

        // ViewModel for the Index view
        // This class is used to represent a single artwork in the list
        public class ArtworkVM
        {
            public required int Id { get; set; }
            public required string Title { get; set; }
            public required string Artist { get; set; }
            public string? ImageUrl { get; set; }
            public required string Contributor { get; set; }
        }
    }
}
