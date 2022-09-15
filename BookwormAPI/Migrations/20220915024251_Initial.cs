using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookwormAPI.Solution.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Author = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    AgeRange = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Summary = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Rating = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Genre = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Tags = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Reviews = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AgeRange", "Author", "Genre", "Rating", "Reviews", "Summary", "Tags", "Title" },
                values: new object[,]
                {
                    { 1, "1-5", "Maurice Sendak", "Sci-Fi & Fantasy", "5", "This book is amazing!", "Max sets sail to an island inhabited by Wild Things, who name him king.", "multi-cultural", "Where The Wild Things Are" },
                    { 2, "1-5", "Ezra Jack Keats", "Picture", "5", "This book is amazing!", "Peter takes a walk in his snowsuit through New York capturing magic and wonder.", "multi-cultural", "The Snowy Day" },
                    { 3, "Baby-3", "Margaret Wise Brown", "Picture", "5", "This book is amazing!", "A little bunny tucked away in bed, says goodnight to all of his favorite things.", "multi-cultural", "Goodnight Moon" },
                    { 4, "5-9", "Shel Silverstein", "Literature & Fiction", "5", "This book is amazing!", "Collection of loopy and imaginative poems and drawings, loved by generations.", "multi-cultural", "Where the Sidewalk Ends" },
                    { 5, "15-17", "Stephen King", "Adventure, Scary", "4", "There is no greater fear than that of losing a child. Stephen King explores the deepest depths of grief and the lengths a father is willing to go through in order to undo the mysterious power of what's beyond the Pet Sematary.", "When Dr. Louis Creed takes a new job and moves his family to the idyllic, rural town of Ludlow, Maine, this new beginning seems too good to be true.", "fantasy, supernatural", "Pet Cemetary" },
                    { 6, "12-17", "Stephanie Meyer", "romance, fantasy", "3.5", "I'm team Edward", "Vampires, warewolves, and high school", "action, young adult", "Twilight" },
                    { 7, "2-8", "Shel Silverstein", "Bedtime, classics", "5", "Classic", "Once there was a tree...and she loved a little boy.", "nature", "The Giving Tree" },
                    { 8, "2-5", "Eric Carle", "Adventure", "5", "This book is amazing!", "Featuring interactive die-cut pages, this board book edition is the perfect size for little hands and great for teaching counting and days of the week.", "nature, science", "The Very Hungry Caterpillar" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
