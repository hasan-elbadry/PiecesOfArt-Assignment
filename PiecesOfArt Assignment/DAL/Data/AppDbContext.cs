using PiecesOfArt_Assignment.DAL.Models;

namespace PiecesOfArt_Assignment.DAL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<LoyaltyCard>().HasData(
            new LoyaltyCard
            {
                Id = 1,
                Name = "Bronze",
                Description = "10% Off"
            },
            new LoyaltyCard
            {
                Id = 2,
                Name = "Silver",
                Description = "20% Off"
            },
            new LoyaltyCard
            {
                Id = 3,
                Name = "Gold",
                Description = "30% Off"
            },
            new LoyaltyCard
            {
                Id = 4,
                Name = "Platinum",
                Description = "40% Off"
            },
            new LoyaltyCard
            {
                Id = 5,
                Name = "Crystal",
                Description = "50% Off"
            }
        );

            modelBuilder.Entity<Category>().HasData(
           new Category
           {
               Id = 1,
               Name = "Impressionism",
               Description = "A 19th-century art movement characterized by small."
           },
           new Category
           {
               Id = 2,
               Name = "Renaissance",
               Description = "A period in European history and wisdom."
           },
           new Category
           {
               Id = 3,
               Name = "Abstract",
               Description = "Art that uses shapes."
           },
           new Category
           {
               Id = 4,
               Name = "Modern",
               Description = "A broad category during the late 19th to mid-20th century."
           },
           new Category
           {
               Id = 5,
               Name = "Ancient",
               Description = "Art from ancient, Mesopotamian, and classical Greek."
           }
       );
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "Alice Johnson",
                    Email = "alice.johnson@example.com",
                    Password = "SecurePassword123!",
                    Age = 28,
                    loyaltyCardId = 1,

                },
                new User
                {
                    Id = 2,
                    Name = "Bob Smith",
                    Email = "bob.smith@example.com",
                    Password = "Password456!",
                    Age = 35,
                    loyaltyCardId = 2
                },
                new User
                {
                    Id = 3,
                    Name = "Charlie Brown",
                    Email = "charlie.brown@example.com",
                    Password = "Passw0rd789!",
                    Age = 42,
                    loyaltyCardId = 3
                },
                new User
                {
                    Id = 4,
                    Name = "Diana Prince",
                    Email = "diana.prince@example.com",
                    Password = "WonderWoman321!",
                    Age = 30,
                    loyaltyCardId = 4
                },
                new User
                {
                    Id = 5,
                    Name = "Edward Nygma",
                    Email = "edward.nygma@example.com",
                    Password = "RiddleMeThis456!",
                    Age = 38,
                    loyaltyCardId = 5
                }
            );

            modelBuilder.Entity<PieceOfArt>().HasData(
                 new PieceOfArt
                 {
                     Id = 1,
                     Title = "Starry Night",
                     Price = 100000.00,
                     PublicationDate = new DateTime(1889, 6, 1),
                     UserId = 1, // Alice Johnson
                     CategoryId = 1 // Impressionism
                 },
                 new PieceOfArt
                 {
                     Id = 2,
                     Title = "The Mona Lisa",
                     Price = 500000.00,
                     PublicationDate = new DateTime(1503, 1, 1),
                     UserId = 2, // Bob Smith
                     CategoryId = 2 // Renaissance
                 },
                 new PieceOfArt
                 {
                     Id = 3,
                     Title = "Composition VIII",
                     Price = 120000.00,
                     PublicationDate = new DateTime(1923, 1, 1),
                     UserId = 3, // Charlie Brown
                     CategoryId = 3 // Abstract
                 }
            );



            modelBuilder
                .Entity<PieceOfArt>()
                .HasIndex(x => x.Title)
                .IsUnique(true);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<LoyaltyCard> LoyaltyCards { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PieceOfArt> PieceOfArts { get; set; }
    }
}
