using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiscGoAPI.Migrations
{
    /// <inheritdoc />
    public partial class baggedDiscUpdate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DiscId",
                table: "BaggedDiscs",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "BaggedDiscs",
                keyColumn: "Id",
                keyValue: 2,
                column: "DiscId",
                value: "hdye73-hfuye=3jdfuj");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscId",
                table: "BaggedDiscs");
        }
    }
}
