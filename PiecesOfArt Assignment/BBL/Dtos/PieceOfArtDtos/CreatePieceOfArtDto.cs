namespace PiecesOfArt_Assignment.BBL.Dtos.PieceOfArtDtos
{
    public class CreatePieceOfArtDto
    {
        [Required, MaxLength(170)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public double Price { get; set; }

        public DateTime PublicationDate { get; set; } = DateTime.Now;

        public int CategoryId { get; set; }
    }
}
