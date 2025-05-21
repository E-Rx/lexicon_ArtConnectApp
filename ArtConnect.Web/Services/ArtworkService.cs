using ArtConnect.Web.Models;

namespace ArtConnect.Web.Services
{
    public class ArtworkService
    {
        private List<Artwork> artworks =
        [
            new Artwork
            {
                Id= 123,
                Title = "Water Lilies",
                Artist = "Claude Monet",
                Year = 1916,
                Style = "Impressionism",
                Description = "Part of Monet's famous series of water lily paintings, capturing the light and reflection on his garden pond in Giverny.",
                ImageUrl = "https://cdn.mediatheque.epmoo.fr/link/3c9igq/hqw1bby67kna5ls.jpg",
                Contributor = "Elise"
            },
            new Artwork
            {
                Id= 4,
                Title = "Bird in Space",
                Artist = "Constantin Brâncuși",
                Year = 1923,
                Style = "Modern Sculpture",
                Description = "An abstract bronze sculpture representing the essence of flight, simplified to its purest form.",
                ImageUrl = "https://www.guggenheim.org/wp-content/uploads/1932/01/76.2553.51_ph_web-1.jpg",
                Contributor = "Pablito"
            },
            new Artwork
            {
                Id= 98,
                Title = "Untitled (Portrait of Ross in L.A.)",
                Artist = "Felix Gonzalez-Torres",
                Year = 1991,
                Style = "Conceptual Art",
                Description = "An interactive installation of candy symbolizing the artist’s partner who died of AIDS. Visitors are invited to take a piece.",
                ImageUrl = "https://www.artic.edu/iiif/2/9036870e-9ec4-19ab-3d73-3cbf79c1af8b/full/843,/0/default.jpg",
                Contributor = "Rose"
            }
        ];

        // GetAll method
        public Artwork[] GetAllArtworks() => artworks
            .OrderBy(a => a.Title)
            .ToArray();


        // AddArtwork method
        public void AddArtwork(Artwork artwork)
        {
            // Generate a new ID for the artwork
            artwork.Id = artworks.Count < 0 ? 1 : artworks.Max(a => a.Id) + 1;
            artworks.Add(artwork);

        }

        // GetArtworkById method
        public Artwork GetArtworkById(int id) => artworks
            .Single(a => a.Id == id);

    }



}
