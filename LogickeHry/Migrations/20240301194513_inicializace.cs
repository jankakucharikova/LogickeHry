using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogickeHry.Migrations
{
    /// <inheritdoc />
    public partial class inicializace : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "sudoku",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    obtiznost = table.Column<string>(type: "longtext", nullable: false),
                    text = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sudoku", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "uzivatele",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    HashHesla = table.Column<string>(type: "longtext", nullable: false),
                    Jmeno = table.Column<string>(type: "longtext", nullable: false),
                    Pohlavi = table.Column<string>(type: "longtext", nullable: false),
                    Vek = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_uzivatele", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "statistiky",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    cas = table.Column<int>(type: "int", nullable: false),
                    hra = table.Column<string>(type: "longtext", nullable: false),
                    obtiznost = table.Column<string>(type: "longtext", nullable: false),
                    uzivatelId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_statistiky", x => x.Id);
                    table.ForeignKey(
                        name: "FK_statistiky_uzivatele_uzivatelId",
                        column: x => x.uzivatelId,
                        principalTable: "uzivatele",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SudokuZadaniUzivatel",
                columns: table => new
                {
                    UzivatelId = table.Column<Guid>(type: "char(36)", nullable: false),
                    videlId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SudokuZadaniUzivatel", x => new { x.UzivatelId, x.videlId });
                    table.ForeignKey(
                        name: "FK_SudokuZadaniUzivatel_sudoku_videlId",
                        column: x => x.videlId,
                        principalTable: "sudoku",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SudokuZadaniUzivatel_uzivatele_UzivatelId",
                        column: x => x.UzivatelId,
                        principalTable: "uzivatele",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_statistiky_uzivatelId",
                table: "statistiky",
                column: "uzivatelId");

            migrationBuilder.CreateIndex(
                name: "IX_SudokuZadaniUzivatel_videlId",
                table: "SudokuZadaniUzivatel",
                column: "videlId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "statistiky");

            migrationBuilder.DropTable(
                name: "SudokuZadaniUzivatel");

            migrationBuilder.DropTable(
                name: "sudoku");

            migrationBuilder.DropTable(
                name: "uzivatele");
        }
    }
}
