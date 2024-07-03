using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiscGoAPI.Migrations
{
    /// <inheritdoc />
    public partial class baggedDiscUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Aces",
                table: "BaggedDiscs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "BaggedDiscs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Aces",
                value: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aces",
                table: "BaggedDiscs");
        }
    }
}
