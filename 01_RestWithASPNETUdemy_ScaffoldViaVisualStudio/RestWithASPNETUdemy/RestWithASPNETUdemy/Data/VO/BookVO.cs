using RestWithASPNETUdemy.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNETUdemy.Data
{
    public class BookVO
    {
        public long Id { get; set; }
        public string Author { get; set; } = string.Empty;
        public DateTime LaunchDate { get; set; } = DateTime.MinValue;
        public decimal Price { get; set; } = 0;
        public string Title { get; set; } = string.Empty;
    }
}
