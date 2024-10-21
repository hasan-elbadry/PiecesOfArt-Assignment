using System.ComponentModel.DataAnnotations;

namespace PiecesOfArt_Assignment.DAL.Models
{
    public class PieceOfArt
    {
        public byte Id { get; set; }
        [Required, MaxLength(170)]
        public string Title { get; set; } = string.Empty;

        [Required, MaxLength(170)]
        public double Price { get; set; }

        public DateTime PublicationDate { get; set; } = DateTime.Now;

        public byte UserId { get; set; }

        public User? User { get; set; }

        public byte CategoryId { get; set; }
        public Category Category { get; set; } = default!;
    }
}
