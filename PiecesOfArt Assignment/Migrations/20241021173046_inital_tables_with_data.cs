using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PiecesOfArt_Assignment.Migrations
{
    /// <inheritdoc />
    public partial class inital_tables_with_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(170)", maxLength: 170, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(170)", maxLength: 170, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoyaltyCard",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(170)", maxLength: 170, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(170)", maxLength: 170, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoyaltyCard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(170)", maxLength: 170, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Age = table.Column<byte>(type: "tinyint", nullable: false),
                    loyaltyCardId = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_LoyaltyCard_loyaltyCardId",
                        column: x => x.loyaltyCardId,
                        principalTable: "LoyaltyCard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PieceOfArt",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(170)", maxLength: 170, nullable: false),
                    Price = table.Column<double>(type: "float", maxLength: 170, nullable: false),
                    PublicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<byte>(type: "tinyint", nullable: false),
                    CategoryId = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PieceOfArt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PieceOfArt_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PieceOfArt_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { (byte)1, "A 19th-century art movement characterized by small.", "Impressionism" },
                    { (byte)2, "A period in European history and wisdom.", "Renaissance" },
                    { (byte)3, "Art that uses shapes.", "Abstract" },
                    { (byte)4, "A broad category during the late 19th to mid-20th century.", "Modern" },
                    { (byte)5, "Art from ancient, Mesopotamian, and classical Greek.", "Ancient" }
                });

            migrationBuilder.InsertData(
                table: "LoyaltyCard",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { (byte)1, "10% Off", "Bronze" },
                    { (byte)2, "20% Off", "Silver" },
                    { (byte)3, "30% Off", "Gold" },
                    { (byte)4, "40% Off", "Platinum" },
                    { (byte)5, "50% Off", "Crystal" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Age", "Email", "Name", "Password", "loyaltyCardId" },
                values: new object[,]
                {
                    { (byte)1, (byte)28, "alice.johnson@example.com", "Alice Johnson", "SecurePassword123!", (byte)1 },
                    { (byte)2, (byte)35, "bob.smith@example.com", "Bob Smith", "Password456!", (byte)2 },
                    { (byte)3, (byte)42, "charlie.brown@example.com", "Charlie Brown", "Passw0rd789!", (byte)3 },
                    { (byte)4, (byte)30, "diana.prince@example.com", "Diana Prince", "WonderWoman321!", (byte)4 },
                    { (byte)5, (byte)38, "edward.nygma@example.com", "Edward Nygma", "RiddleMeThis456!", (byte)5 }
                });

            migrationBuilder.InsertData(
                table: "PieceOfArt",
                columns: new[] { "Id", "CategoryId", "Price", "PublicationDate", "Title", "UserId" },
                values: new object[,]
                {
                    { (byte)1, (byte)1, 100000.0, new DateTime(1889, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Starry Night", (byte)1 },
                    { (byte)2, (byte)2, 500000.0, new DateTime(1503, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Mona Lisa", (byte)2 },
                    { (byte)3, (byte)3, 120000.0, new DateTime(1923, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Composition VIII", (byte)3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PieceOfArt_CategoryId",
                table: "PieceOfArt",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PieceOfArt_UserId",
                table: "PieceOfArt",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_loyaltyCardId",
                table: "User",
                column: "loyaltyCardId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PieceOfArt");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "LoyaltyCard");
        }
    }
}
