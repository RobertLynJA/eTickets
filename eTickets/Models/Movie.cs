using eTickets.Data.Enums;

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

        //RelationShips
        [AllowNull]
        public List<Actor_Movie> Actors_Movies { get; set; }

        //Cinema
        [AllowNull]
        public Cinema Cinema { get; set; }

        [ForeignKey("CinemaId")]
        public int CinemaId { get; set; }

        //Producer
        [AllowNull]
        public Producer Producer { get; set; }

        [ForeignKey("ProducerId")]
        public int ProducerId { get; set; }
    }
}
