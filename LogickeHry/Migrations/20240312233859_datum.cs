using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogickeHry.Migrations
{
    /// <inheritdoc />
    public partial class datum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "datum",
                table: "statistiky",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "datum",
                table: "statistiky");
        }
    }
}
