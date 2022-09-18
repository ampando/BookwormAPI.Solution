using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookwormAPI.Solution.Migrations
{
    public partial class LibraryBookLibraryClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Users_UserId",
                table: "Ratings");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_UserId",
                table: "Reviews");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "LibraryId",
                table: "Reviews",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LibraryId",
                table: "Ratings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Librarys",
                columns: table => new
                {
                    LibraryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Librarys", x => x.LibraryId);
                });

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
                name: "IX_Reviews_LibraryId",
                table: "Reviews",
                column: "LibraryId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_LibraryId",
                table: "Ratings",
                column: "LibraryId");

            migrationBuilder.CreateIndex(
                name: "IX_BookLibrary_BookId",
                table: "BookLibrary",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookLibrary_LibraryId",
                table: "BookLibrary",
                column: "LibraryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Librarys_LibraryId",
                table: "Ratings",
                column: "LibraryId",
                principalTable: "Librarys",
                principalColumn: "LibraryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Librarys_LibraryId",
                table: "Reviews",
                column: "LibraryId",
                principalTable: "Librarys",
                principalColumn: "LibraryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Librarys_LibraryId",
                table: "Ratings");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Librarys_LibraryId",
                table: "Reviews");

            migrationBuilder.DropTable(
                name: "BookLibrary");

            migrationBuilder.DropTable(
                name: "Librarys");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_LibraryId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_LibraryId",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "LibraryId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "LibraryId",
                table: "Ratings");

            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "Books",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Users_UserId",
                table: "Ratings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
