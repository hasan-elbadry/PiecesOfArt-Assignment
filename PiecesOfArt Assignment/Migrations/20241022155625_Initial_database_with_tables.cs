#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PiecesOfArt_Assignment.Migrations
{
    /// <inheritdoc />
    public partial class Initial_database_with_tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(170)", maxLength: 170, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(170)", maxLength: 170, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoyaltyCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(170)", maxLength: 170, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(170)", maxLength: 170, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoyaltyCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(170)", maxLength: 170, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(170)", maxLength: 170, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    loyaltyCardId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_LoyaltyCards_loyaltyCardId",
                        column: x => x.loyaltyCardId,
                        principalTable: "LoyaltyCards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PieceOfArts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(170)", maxLength: 170, nullable: false),
                    Price = table.Column<double>(type: "float", maxLength: 170, nullable: false),
                    PublicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PieceOfArts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PieceOfArts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PieceOfArts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "A 19th-century art movement characterized by small.", "Impressionism" },
                    { 2, "A period in European history and wisdom.", "Renaissance" },
                    { 3, "Art that uses shapes.", "Abstract" },
                    { 4, "A broad category during the late 19th to mid-20th century.", "Modern" },
                    { 5, "Art from ancient, Mesopotamian, and classical Greek.", "Ancient" }
                });

            migrationBuilder.InsertData(
                table: "LoyaltyCards",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "10% Off", "Bronze" },
                    { 2, "20% Off", "Silver" },
                    { 3, "30% Off", "Gold" },
                    { 4, "40% Off", "Platinum" },
                    { 5, "50% Off", "Crystal" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "Name", "Password", "loyaltyCardId" },
                values: new object[,]
                {
                    { 1, 28, "alice.johnson@example.com", "Alice Johnson", "SecurePassword123!", 1 },
                    { 2, 35, "bob.smith@example.com", "Bob Smith", "Password456!", 2 },
                    { 3, 42, "charlie.brown@example.com", "Charlie Brown", "Passw0rd789!", 3 },
                    { 4, 30, "diana.prince@example.com", "Diana Prince", "WonderWoman321!", 4 },
                    { 5, 38, "edward.nygma@example.com", "Edward Nygma", "RiddleMeThis456!", 5 }
                });

            migrationBuilder.InsertData(
                table: "PieceOfArts",
                columns: new[] { "Id", "CategoryId", "Price", "PublicationDate", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 100000.0, new DateTime(1889, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Starry Night", 1 },
                    { 2, 2, 500000.0, new DateTime(1503, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Mona Lisa", 2 },
                    { 3, 3, 120000.0, new DateTime(1923, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Composition VIII", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PieceOfArts_CategoryId",
                table: "PieceOfArts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PieceOfArts_UserId",
                table: "PieceOfArts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_loyaltyCardId",
                table: "Users",
                column: "loyaltyCardId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PieceOfArts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "LoyaltyCards");
        }
    }
}
