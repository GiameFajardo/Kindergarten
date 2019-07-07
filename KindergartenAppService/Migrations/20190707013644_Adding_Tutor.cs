using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Adding_Tutor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<Guid>(
                name: "TutorId",
                table: "Kid",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tutor",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutor", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kid_TutorId",
                table: "Kid",
                column: "TutorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Kid_Tutor_TutorId",
                table: "Kid",
                column: "TutorId1",
                principalTable: "Tutor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kid_Tutor_TutorId",
                table: "Kid");

            migrationBuilder.DropTable(
                name: "Tutor");

            migrationBuilder.DropIndex(
                name: "IX_Kid_TutorId",
                table: "Kid");


            migrationBuilder.DropColumn(
                name: "TutorId",
                table: "Kid");
        }
    }
}
