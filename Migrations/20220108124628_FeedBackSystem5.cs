using Microsoft.EntityFrameworkCore.Migrations;

namespace FeedbackSystem.Migrations
{
    public partial class FeedBackSystem5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Surveys_Surveys_SurveySid",
                table: "Surveys");

            migrationBuilder.DropIndex(
                name: "IX_Surveys_SurveySid",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "SurveySid",
                table: "Surveys");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_SurveyID",
                table: "Transactions",
                column: "SurveyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Surveys_SurveyID",
                table: "Transactions",
                column: "SurveyID",
                principalTable: "Surveys",
                principalColumn: "Sid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Surveys_SurveyID",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_SurveyID",
                table: "Transactions");

            migrationBuilder.AddColumn<int>(
                name: "SurveySid",
                table: "Surveys",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Surveys_SurveySid",
                table: "Surveys",
                column: "SurveySid");

            migrationBuilder.AddForeignKey(
                name: "FK_Surveys_Surveys_SurveySid",
                table: "Surveys",
                column: "SurveySid",
                principalTable: "Surveys",
                principalColumn: "Sid",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
