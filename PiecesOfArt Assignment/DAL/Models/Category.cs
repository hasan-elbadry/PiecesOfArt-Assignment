namespace PiecesOfArt_Assignment.DAL.Models
{
    public class Category
    {

        public int Id { get; set; }

        [Required, MaxLength(170)]
        public string Name { get; set; } = string.Empty;

        [Required, MaxLength(170)]
        public string Description { get; set; } = string.Empty;
        [JsonIgnore]
        public IEnumerable<PieceOfArt>? PieceOfArts { get; set; }
    }
}
