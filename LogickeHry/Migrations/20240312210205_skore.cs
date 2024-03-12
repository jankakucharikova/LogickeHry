using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogickeHry.Migrations
{
    /// <inheritdoc />
    public partial class skore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "skore",
                table: "statistiky",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "skore",
                table: "statistiky");
        }
    }
}
