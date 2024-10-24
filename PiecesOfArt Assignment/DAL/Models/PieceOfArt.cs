namespace PiecesOfArt_Assignment.DAL.Models
{
    public class PieceOfArt
    {

        public int Id { get; set; }

        [Required, MaxLength(170)]
        public string Title { get; set; } = string.Empty;

        [Required, MaxLength(170)]
        public double Price { get; set; }

        public DateTime PublicationDate { get; set; } = DateTime.Now;

        public int UserId { get; set; }
        [JsonIgnore]
        public User? User { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; } = default!;
    }
}
