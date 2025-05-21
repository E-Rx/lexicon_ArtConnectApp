namespace ArtConnect.Web.Artworks
{
    public class IndexVM
    {
        public ArtworkVM[] Artworks { get; set; } = null!;

        // ViewModel for the Index view
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
