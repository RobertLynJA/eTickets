using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        
        [AllowNull]
        public string ProfilePictureURL { get; set; }

        [AllowNull]
        public string FullName { get; set; }

        [AllowNull]
        public string Bio { get; set; }
    }
}
