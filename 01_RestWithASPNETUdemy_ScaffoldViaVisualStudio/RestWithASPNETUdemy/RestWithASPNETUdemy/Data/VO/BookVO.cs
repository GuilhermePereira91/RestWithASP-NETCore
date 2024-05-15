using RestWithASPNETUdemy.Hypermedia;
using RestWithASPNETUdemy.Hypermedia.Abstract;

namespace RestWithASPNETUdemy.Data
{
    public class BookVO : ISupportsHyperMedia
    {
        public long Id { get; set; }
        public string Author { get; set; } = string.Empty;
        public DateTime LaunchDate { get; set; } = DateTime.MinValue;
        public decimal Price { get; set; } = 0;
        public string Title { get; set; } = string.Empty;
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
