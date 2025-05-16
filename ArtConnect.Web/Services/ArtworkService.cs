using ArtConnect.Web.Models;

namespace ArtConnect.Web.Services
{
    public class ArtworkService
    {
        private List<Artwork> artworks =
        [
            new Artwork
            {
                Title = "Water Lilies",
                Artist = "Claude Monet",
                Year = 1916,
                Style = "Impressionism",
                Description = "Part of Monet's famous series of water lily paintings, capturing the light and reflection on his garden pond in Giverny.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/1/17/Claude_Monet_-_Water_Lilies_-_Google_Art_Project.jpg",
                Contributor = "Elise"
            },
            new Artwork
            {
                Title = "Bird in Space",
                Artist = "Constantin Brâncuși",
                Year = 1923,
                Style = "Modern Sculpture",
                Description = "An abstract bronze sculpture representing the essence of flight, simplified to its purest form.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/f/fb/Brancusi_Bird_in_Space.jpg",
                Contributor = "Pablito"
            },
            new Artwork
            {
                Title = "Untitled (Portrait of Ross in L.A.)",
                Artist = "Felix Gonzalez-Torres",
                Year = 1991,
                Style = "Conceptual Art",
                Description = "An interactive installation of candy symbolizing the artist’s partner who died of AIDS. Visitors are invited to take a piece.",
                ImageUrl = "https://www.artic.edu/iiif/2/83abeb1f-38e0-51d5-005d-07f66b4961a2/full/843,/0/default.jpg",
                Contributor = "Rose"
            }
        ];

        // GetAll method
        publi Artwork
        {
            return artworks;
        }

        // AddArtwork method
        public void AddArtwork(Artwork artwork)
        {
            artworks.Add(artwork);
        }
    }
}
