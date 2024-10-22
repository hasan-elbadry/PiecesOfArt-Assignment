using System.ComponentModel.DataAnnotations;

namespace PiecesOfArt_Assignment.Dtos.LoyaltyCardDtos
{
    public class LoyaltyCardDto
    {
        public int Id { get; set; }

        [Required, MaxLength(170)]
        public string Name { get; set; } = string.Empty;

        [Required, MaxLength(170)]
        public string Description { get; set; } = string.Empty;
    }
}
