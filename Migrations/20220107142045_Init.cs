using Microsoft.EntityFrameworkCore.Migrations;

namespace FeedbackSystem.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Pid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Pid);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Qid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Questions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Qid);
                });

            migrationBuilder.CreateTable(
                name: "Surveys",
                columns: table => new
                {
                    Sid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surveys", x => x.Sid);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Tid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductPid = table.Column<int>(type: "int", nullable: true),
                    SurveySid = table.Column<int>(type: "int", nullable: true),
                    QuestionQid = table.Column<int>(type: "int", nullable: true),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Tid);
                    table.ForeignKey(
                        name: "FK_Transactions_Products_ProductPid",
                        column: x => x.ProductPid,
                        principalTable: "Products",
                        principalColumn: "Pid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transactions_Questions_QuestionQid",
                        column: x => x.QuestionQid,
                        principalTable: "Questions",
                        principalColumn: "Qid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transactions_Surveys_SurveySid",
                        column: x => x.SurveySid,
                        principalTable: "Surveys",
                        principalColumn: "Sid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_ProductPid",
                table: "Transactions",
                column: "ProductPid");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_QuestionQid",
                table: "Transactions",
                column: "QuestionQid");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_SurveySid",
                table: "Transactions",
                column: "SurveySid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Surveys");
        }
    }
}
