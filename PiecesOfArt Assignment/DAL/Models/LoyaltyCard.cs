using System.ComponentModel.DataAnnotations;

namespace PiecesOfArt_Assignment.DAL.Models
{
    public class LoyaltyCard
    {
        public byte Id { get; set; }

        [Required, MaxLength(170)]
        public string Name { get; set; } = string.Empty;

        [Required, MaxLength(170)]
        public string Description { get; set; } = string.Empty;

        public IEnumerable<User> Users { get; set; } = Enumerable.Empty<User>();
    }
}
