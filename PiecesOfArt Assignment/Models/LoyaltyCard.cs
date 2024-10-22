namespace PiecesOfArt_Assignment.Models
{
    public class LoyaltyCard
    {
        
        public int Id { get; set; }

        [Required, MaxLength(170)]
        public string Name { get; set; } = string.Empty;

        [Required, MaxLength(170)]
        public string Description { get; set; } = string.Empty;

        [JsonIgnore]
        public List<User>? Users { get; set; }
    }
}
