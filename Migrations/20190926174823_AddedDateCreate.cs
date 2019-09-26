using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace stackoverflowapi.Migrations
{
    public partial class AddedDateCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QuestionUpVote",
                table: "Questions",
                newName: "QuestionLike");

            migrationBuilder.RenameColumn(
                name: "QuestionDownVote",
                table: "Questions",
                newName: "QuestionDislike");

            migrationBuilder.RenameColumn(
                name: "AnswerUpVote",
                table: "Answers",
                newName: "AnswerLike");

            migrationBuilder.RenameColumn(
                name: "AnswerDownVote",
                table: "Answers",
                newName: "AnswerDislike");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Questions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Questions");

            migrationBuilder.RenameColumn(
                name: "QuestionLike",
                table: "Questions",
                newName: "QuestionUpVote");

            migrationBuilder.RenameColumn(
                name: "QuestionDislike",
                table: "Questions",
                newName: "QuestionDownVote");

            migrationBuilder.RenameColumn(
                name: "AnswerLike",
                table: "Answers",
                newName: "AnswerUpVote");

            migrationBuilder.RenameColumn(
                name: "AnswerDislike",
                table: "Answers",
                newName: "AnswerDownVote");
        }
    }
}
