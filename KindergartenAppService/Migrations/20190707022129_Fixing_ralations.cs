using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Fixing_ralations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kid_Tutor_TutorId1",
                table: "Kid");

            

            migrationBuilder.DropIndex(
                name: "IX_Kid_TutorId1",
                table: "Kid");


            migrationBuilder.DropColumn(
                name: "TutorId1",
                table: "Kid");


            migrationBuilder.AlterColumn<Guid>(
                name: "TutorId",
                table: "Kid",
                nullable: false,
                oldClrType: typeof(int));


            migrationBuilder.CreateIndex(
                name: "IX_Kid_TutorId",
                table: "Kid",
                column: "TutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kid_Tutor_TutorId",
                table: "Kid",
                column: "TutorId",
                principalTable: "Tutor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kid_Tutor_TutorId",
                table: "Kid");


            migrationBuilder.DropIndex(
                name: "IX_Kid_TutorId",
                table: "Kid");


            migrationBuilder.AlterColumn<int>(
                name: "TutorId",
                table: "Kid",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<Guid>(
                name: "TutorId1",
                table: "Kid",
                nullable: true);


            migrationBuilder.CreateIndex(
                name: "IX_Kid_TutorId1",
                table: "Kid",
                column: "TutorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Kid_Tutor_TutorId1",
                table: "Kid",
                column: "TutorId1",
                principalTable: "Tutor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

        }
    }
}
