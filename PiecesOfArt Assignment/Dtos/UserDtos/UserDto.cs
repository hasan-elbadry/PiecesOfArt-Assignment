using PiecesOfArt_Assignment.Dtos.LoyaltyCardDtos;
using PiecesOfArt_Assignment.Dtos.PieceOfArtDtos;
using PiecesOfArt_Assignment.Models;
using System.ComponentModel.DataAnnotations;

namespace PiecesOfArt_Assignment.Dtos.UserDtos
{
    public class UserDto
    {
        public byte Id { get; set; }

        [Required, MaxLength(170)]
        public string Name { get; set; } = string.Empty;

        [Required, MaxLength(170), EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required, MaxLength(250)]
        public string Password { get; set; } = string.Empty;

        [Required]
        public byte Age { get; set; }

        public IEnumerable<PieceOfArtDto>? PieceOfArts { get; set; }

        public LoyaltyCardDto? LoyaltyCard { get; set; }
    }
}
