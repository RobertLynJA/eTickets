namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        [AllowNull]
        public string ProfilePictureURL { get; set; }

        [AllowNull]
        public string FullName { get; set; }

        [AllowNull]
        public string Bio { get; set; }

        //RelationShips
        [AllowNull]
        public List<Movie> Movies { get; set; }
    }
}
