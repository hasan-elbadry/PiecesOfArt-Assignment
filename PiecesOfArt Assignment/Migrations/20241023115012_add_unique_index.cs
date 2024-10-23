using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PiecesOfArt_Assignment.Migrations
{
    /// <inheritdoc />
    public partial class add_unique_index : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_PieceOfArts_Title",
                table: "PieceOfArts",
                column: "Title",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PieceOfArts_Title",
                table: "PieceOfArts");
        }
    }
}
