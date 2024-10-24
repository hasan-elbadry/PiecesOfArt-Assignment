namespace PiecesOfArt_Assignment.BBL.Dtos.LoyaltyCardDtos
{
    public class UpdateLoyaltyCardDto
    {
        public int Id { get; set; }
        [Required, MaxLength(170)]
        public string Name { get; set; } = string.Empty;

        [Required, MaxLength(170)]
        public string Description { get; set; } = string.Empty;
    }
}
