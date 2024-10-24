namespace PiecesOfArt_Assignment.BBL.Dtos.UserDtos
{
    public class UpdateUserDto
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

        public IEnumerable<int>? PieceOfArts { get; set; }

        public int? loyaltyCardId { get; set; }
    }
}
