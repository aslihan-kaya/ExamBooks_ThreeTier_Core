using Microsoft.EntityFrameworkCore.Migrations;

namespace Books.Data.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EXAM",
                columns: table => new
                {
                    ExamID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EXAM", x => x.ExamID);
                });

            migrationBuilder.CreateTable(
                name: "AYT",
                columns: table => new
                {
                    TytID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LessonName = table.Column<string>(nullable: false),
                    BookName = table.Column<string>(nullable: false),
                    BookType = table.Column<string>(nullable: false),
                    BookAuthor = table.Column<string>(maxLength: 50, nullable: false),
                    PageCount = table.Column<int>(nullable: false),
                    ExamID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AYT", x => x.TytID);
                    table.ForeignKey(
                        name: "FK_AYT_EXAM_ExamID",
                        column: x => x.ExamID,
                        principalTable: "EXAM",
                        principalColumn: "ExamID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TYT",
                columns: table => new
                {
                    TytID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LessonName = table.Column<string>(nullable: false),
                    BookName = table.Column<string>(nullable: false),
                    BookType = table.Column<string>(nullable: false),
                    BookAuthor = table.Column<string>(maxLength: 50, nullable: false),
                    PageCount = table.Column<int>(nullable: false),
                    ExamID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TYT", x => x.TytID);
                    table.ForeignKey(
                        name: "FK_TYT_EXAM_ExamID",
                        column: x => x.ExamID,
                        principalTable: "EXAM",
                        principalColumn: "ExamID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AYT_ExamID",
                table: "AYT",
                column: "ExamID");

            migrationBuilder.CreateIndex(
                name: "IX_TYT_ExamID",
                table: "TYT",
                column: "ExamID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AYT");

            migrationBuilder.DropTable(
                name: "TYT");

            migrationBuilder.DropTable(
                name: "EXAM");
        }
    }
}
