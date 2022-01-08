using Microsoft.EntityFrameworkCore.Migrations;

namespace FeedbackSystem.Migrations
{
    public partial class FeedBackSystem4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Products_ProductPid",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Questions_QuestionQid",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Surveys_SurveySid",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_ProductPid",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_QuestionQid",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_SurveySid",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "ProductPid",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "QuestionQid",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "SurveySid",
                table: "Transactions");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QuestionID",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SurveyID",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Surveys_Surveys_SurveySid",
                table: "Surveys");

            migrationBuilder.DropIndex(
                name: "IX_Surveys_SurveySid",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "QuestionID",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "SurveyID",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "SurveySid",
                table: "Surveys");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductPid",
                table: "Transactions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuestionQid",
                table: "Transactions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SurveySid",
                table: "Transactions",
                type: "int",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Products_ProductPid",
                table: "Transactions",
                column: "ProductPid",
                principalTable: "Products",
                principalColumn: "Pid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Questions_QuestionQid",
                table: "Transactions",
                column: "QuestionQid",
                principalTable: "Questions",
                principalColumn: "Qid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Surveys_SurveySid",
                table: "Transactions",
                column: "SurveySid",
                principalTable: "Surveys",
                principalColumn: "Sid",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
