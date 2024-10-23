namespace PiecesOfArt_Assignment.Dtos.CategoryDtos
{
    public class CategoryDto
    {
        public int Id { get; set; }

        [Required, MaxLength(170)]
        public string Name { get; set; } = string.Empty;

        [Required, MaxLength(170)]
        public string Description { get; set; } = string.Empty;
    }
}
