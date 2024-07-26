using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiscGoAPI.Migrations
{
    /// <inheritdoc />
    public partial class baggedDiscUpdate7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LongestThrow",
                table: "BaggedDiscs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "BaggedDiscs",
                keyColumn: "Id",
                keyValue: 2,
                column: "LongestThrow",
                value: 375);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LongestThrow",
                table: "BaggedDiscs");
        }
    }
}
