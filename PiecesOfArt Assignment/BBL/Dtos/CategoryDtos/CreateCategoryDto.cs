namespace PiecesOfArt_Assignment.BBL.Dtos.CategoryDtos
{
    public class CreateCategoryDto
    {
        [Required, MaxLength(170)]
        public string Name { get; set; } = string.Empty;

        [Required, MaxLength(170)]
        public string Description { get; set; } = string.Empty;
    }
}
