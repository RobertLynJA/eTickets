namespace eTickets.Models
{
    public class Actor_Movie
    {
        public int MovieId { get; set; }

        [AllowNull]
        public Movie Movie { get; set; }

        public int ActorId { get; set; }

        [AllowNull]
        public Actor Actor { get; set; }
    }
}
