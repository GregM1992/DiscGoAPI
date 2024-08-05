using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiscGoAPI.Migrations
{
    /// <inheritdoc />
    public partial class baggedDiscUpdate5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Turn",
                table: "BaggedDiscs",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Speed",
                table: "BaggedDiscs",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Glide",
                table: "BaggedDiscs",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Fade",
                table: "BaggedDiscs",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "Background_color",
                table: "BaggedDiscs",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BaggedDiscs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Background_color",
                value: "#34532");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Background_color",
                table: "BaggedDiscs");

            migrationBuilder.AlterColumn<string>(
                name: "Turn",
                table: "BaggedDiscs",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Speed",
                table: "BaggedDiscs",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Glide",
                table: "BaggedDiscs",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Fade",
                table: "BaggedDiscs",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
