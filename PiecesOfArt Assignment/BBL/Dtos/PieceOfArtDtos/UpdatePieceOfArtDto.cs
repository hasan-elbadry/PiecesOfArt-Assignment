namespace PiecesOfArt_Assignment.BBL.Dtos.PieceOfArtDtos
{
    public class UpdatePieceOfArtDto
    {
        public int Id { get; set; }

        [Required, MaxLength(170)]
        public string Title { get; set; } = string.Empty;

        [Required, MaxLength(170)]
        public double Price { get; set; }

        public DateTime PublicationDate { get; set; } = DateTime.Now;
        public CategoryDto Category { get; set; } = default!;
    }
}
