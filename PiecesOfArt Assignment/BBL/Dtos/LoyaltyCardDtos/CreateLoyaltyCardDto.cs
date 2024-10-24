namespace PiecesOfArt_Assignment.BBL.Dtos.LoyaltyCardDtos
{
    public class CreateLoyaltyCardDto
    {
        [Required, MaxLength(170)]
        public string Name { get; set; } = string.Empty;

        [Required, MaxLength(170)]
        public string Description { get; set; } = string.Empty;
    }
}
