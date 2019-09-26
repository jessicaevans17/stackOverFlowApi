using Microsoft.EntityFrameworkCore.Migrations;

namespace stackoverflowapi.Migrations
{
    public partial class AddedTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Question",
                table: "Questions",
                newName: "QuestionTitle");

            migrationBuilder.AddColumn<string>(
                name: "QuestionContent",
                table: "Questions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuestionsId",
                table: "Answers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionsId",
                table: "Answers",
                column: "QuestionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_QuestionsId",
                table: "Answers",
                column: "QuestionsId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionsId",
                table: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Answers_QuestionsId",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "QuestionContent",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "QuestionsId",
                table: "Answers");

            migrationBuilder.RenameColumn(
                name: "QuestionTitle",
                table: "Questions",
                newName: "Question");
        }
    }
}
