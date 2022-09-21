using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookwormAPI.Solution.Migrations
{
    public partial class UndoRemove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookLibrary",
                columns: table => new
                {
                    BookLibraryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    LibraryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookLibrary", x => x.BookLibraryId);
                    table.ForeignKey(
                        name: "FK_BookLibrary_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookLibrary_Librarys_LibraryId",
                        column: x => x.LibraryId,
                        principalTable: "Librarys",
                        principalColumn: "LibraryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookLibrary_BookId",
                table: "BookLibrary",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookLibrary_LibraryId",
                table: "BookLibrary",
                column: "LibraryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookLibrary");
        }
    }
}
