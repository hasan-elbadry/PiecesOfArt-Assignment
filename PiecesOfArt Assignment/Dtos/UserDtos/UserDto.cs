namespace PiecesOfArt_Assignment.Dtos.UserDtos
{
    public class UserDto
    {
        public int Id { get; set; }

        [Required, MaxLength(170)]
        public string Name { get; set; } = string.Empty;

        [Required, MaxLength(170), EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required, MaxLength(250)]
        public string Password { get; set; } = string.Empty;

        [Required]
        public int Age { get; set; }

        public IEnumerable<PieceOfArtDto>? PieceOfArts { get; set; }

        public LoyaltyCardDto? LoyaltyCard { get; set; }
    }
}
