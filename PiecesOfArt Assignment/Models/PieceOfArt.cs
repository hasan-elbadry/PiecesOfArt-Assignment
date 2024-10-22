using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PiecesOfArt_Assignment.Models
{
    public class PieceOfArt
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
