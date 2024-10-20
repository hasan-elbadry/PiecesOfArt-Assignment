namespace PiecesOfArt_Assignment.Models
{
    public class PieceOfArt
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public double Price { get; set; }
        public DateTime PublicationDate { get; set; } = DateTime.Now;
    }
}
