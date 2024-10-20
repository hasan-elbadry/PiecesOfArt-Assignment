using System.ComponentModel.DataAnnotations;

namespace PiecesOfArt_Assignment.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required,MaxLength(70)]
        public string Name { get; set; } = string.Empty;

        [Required,MaxLength(70)]
        public string Email { get; set; } = string.Empty;

        [Required]
        public int Age { get; set; }
    }
}
