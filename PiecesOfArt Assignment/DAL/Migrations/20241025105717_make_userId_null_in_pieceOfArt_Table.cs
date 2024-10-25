using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PiecesOfArt_Assignment.Migrations
{
    /// <inheritdoc />
    public partial class make_userId_null_in_pieceOfArt_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PieceOfArts_Users_UserId",
                table: "PieceOfArts");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "PieceOfArts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_PieceOfArts_Users_UserId",
                table: "PieceOfArts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PieceOfArts_Users_UserId",
                table: "PieceOfArts");

            migrationBuilder.DropIndex(
                name: "IX_PieceOfArts_Title",
                table: "PieceOfArts");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "PieceOfArts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PieceOfArts_Users_UserId",
                table: "PieceOfArts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
