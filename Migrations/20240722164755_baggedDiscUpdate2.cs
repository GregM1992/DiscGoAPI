using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiscGoAPI.Migrations
{
    /// <inheritdoc />
    public partial class baggedDiscUpdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Favorite",
                table: "BaggedDiscs",
                type: "boolean",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BaggedDiscs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Favorite",
                value: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Favorite",
                table: "BaggedDiscs");
        }
    }
}
