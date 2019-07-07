using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Adding_Kid_to_Medical_record : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalRecord_Kid_KidId",
                table: "MedicalRecord");

            migrationBuilder.AlterColumn<Guid>(
                name: "KidId",
                table: "MedicalRecord",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalRecord_Kid_KidId",
                table: "MedicalRecord",
                column: "KidId",
                principalTable: "Kid",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalRecord_Kid_KidId",
                table: "MedicalRecord");

            migrationBuilder.AlterColumn<Guid>(
                name: "KidId",
                table: "MedicalRecord",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalRecord_Kid_KidId",
                table: "MedicalRecord",
                column: "KidId",
                principalTable: "Kid",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
