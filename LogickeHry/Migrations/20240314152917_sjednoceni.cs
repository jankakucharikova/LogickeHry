using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogickeHry.Migrations
{
    /// <inheritdoc />
    public partial class sjednoceni : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sudoku",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    obtiznost = table.Column<string>(type: "longtext", nullable: false),
                    text = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sudoku", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Uzivatele",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    hashHesla = table.Column<string>(type: "longtext", nullable: false),
                    jmeno = table.Column<string>(type: "longtext", nullable: false),
                    pohlavi = table.Column<string>(type: "longtext", nullable: false),
                    vek = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uzivatele", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Statistiky",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    cas = table.Column<int>(type: "int", nullable: false),
                    datum = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    hra = table.Column<string>(type: "longtext", nullable: false),
                    obtiznost = table.Column<string>(type: "longtext", nullable: false),
                    skore = table.Column<int>(type: "int", nullable: false),
                    uzivatelId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistiky", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Statistiky_Uzivatele_uzivatelId",
                        column: x => x.uzivatelId,
                        principalTable: "Uzivatele",
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
                        name: "FK_SudokuZadaniUzivatel_Sudoku_videlId",
                        column: x => x.videlId,
                        principalTable: "Sudoku",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SudokuZadaniUzivatel_Uzivatele_UzivatelId",
                        column: x => x.UzivatelId,
                        principalTable: "Uzivatele",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Statistiky_uzivatelId",
                table: "Statistiky",
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
                name: "Statistiky");

            migrationBuilder.DropTable(
                name: "SudokuZadaniUzivatel");

            migrationBuilder.DropTable(
                name: "Sudoku");

            migrationBuilder.DropTable(
                name: "Uzivatele");
        }
    }
}
