using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PiecesOfArt_Assignment.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Id { get; set; }

        [Required, MaxLength(170)]
        public string Name { get; set; } = string.Empty;

        [Required, MaxLength(170), EmailAddress]
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
