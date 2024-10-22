using PiecesOfArt_Assignment.Dtos.CategoryDtos;
using System.ComponentModel.DataAnnotations;

namespace PiecesOfArt_Assignment.Dtos.PieceOfArtDtos
{
    public class PieceOfArtDto
    {
        public byte Id { get; set; }

        [Required, MaxLength(170)]
        public string Title { get; set; } = string.Empty;

        [Required, MaxLength(170)]
        public double Price { get; set; }

        public DateTime PublicationDate { get; set; } = DateTime.Now;
        public CategoryDto Category { get; set; } = default!;
    }
}
