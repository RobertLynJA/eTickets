using eTickets.Data;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [AllowNull]
        public string Name { get; set; }

        [AllowNull]
        public string Description { get; set; }

        public double Price { get; set; }

        [AllowNull]
        public string ImageUrl { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }

    }
}
