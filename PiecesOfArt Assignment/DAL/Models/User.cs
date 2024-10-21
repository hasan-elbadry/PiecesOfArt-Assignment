using System.ComponentModel.DataAnnotations;

namespace PiecesOfArt_Assignment.DAL.Models
{
    public class User
    {
        public byte Id { get; set; }

        [Required, MaxLength(170)]
        public string Name { get; set; } = string.Empty;

        [Required, MaxLength(70),EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required, MaxLength(250)]
        public string Password { get; set; } = string.Empty;

        [Required]
        public byte Age { get; set; }

        public IEnumerable<PieceOfArt>? PieceOfArts { get; set; } = Enumerable.Empty<PieceOfArt>();

        public byte? loyaltyCardId { get; set; }

        public LoyaltyCard LoyaltyCard { get; set; } = default!;
    }
}
