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
            },
            new Artwork
            {
                Id = 2198,
                Title = "The Great Wave off Kanagawa",
                Artist = "Hokusai",
                Year = 1831,
                Style = "Ukiyo-e (Japanese woodblock print)",
                Description = "Iconic depiction of a giant wave threatening boats off the coast of Kanagawa, Mount Fuji in the background.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a5/Tsunami_by_hokusai_19th_century.jpg/2560px-Tsunami_by_hokusai_19th_century.jpg",
                Contributor = "Naoko"
            },
            new Artwork
            {
                Id = 6,
                Title = "Broadway Boogie Woogie",
                Artist = "Piet Mondrian",
                Year = 1943,
                Style = "De Stijl / Abstract",
                Description = "A vibrant composition inspired by New York's grid and the rhythm of boogie-woogie music.",
                ImageUrl = "https://www.piet-mondrian.org/assets/img/paintings/broadway-boogie-woogie.jpg",
                Contributor = "Liammmm"
            },
            new Artwork
            {
                Id = 201,
                Title = "The Secret of the Great Pyramid",
                Artist = "JR",
                Year = 2019,
                Style = "Street Art / Photographie urbaine",
                Description = "the collage provides a glimpse at what may lie beneath the iconic glass pyramid.",
                ImageUrl = "https://www.thisiscolossal.com/wp-content/uploads/2019/03/D26-qA7XcAA6dog.jpg",
                Contributor = "Adèle"
            },
            new Artwork
            {
                Id = 404,
                Title = "Infinity Mirror Room – Phalli’s Field",
                Artist = "Yayoi Kusama",
                Year = 1965,
                Style = "Installation Art",
                Description = "A room filled with soft sculptures and mirrors that create the illusion of infinite repetition.",
                ImageUrl = "https://flv-prd-oxud8mggj93od145.imgix.net/4d9ed5b3-b3df-4b9d-8275-53bfc74af287/94390-YayoiKusama%2CInfinityMirrorRoom-PhallisFieldorFloorShow%2C19652013%2Cvuedinstallation%2CFondationLouisVuitton%2CParis..jpg?dpi=72&s=ede0b4ae96a1fb249fd09b9c2e807b21",
                Contributor = "ArtLover"
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
