namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        [AllowNull]
        public string Logo { get; set; }

        [AllowNull]
        public string Name { get; set; }

        [AllowNull]
        public string Description { get; set; }
    }
}
