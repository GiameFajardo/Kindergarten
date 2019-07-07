using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Adding_Precense : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Precense_Kid_KidId",
                table: "Precense");

            migrationBuilder.AlterColumn<Guid>(
                name: "KidId",
                table: "Precense",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Precense_Kid_KidId",
                table: "Precense",
                column: "KidId",
                principalTable: "Kid",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Precense_Kid_KidId",
                table: "Precense");

            migrationBuilder.AlterColumn<Guid>(
                name: "KidId",
                table: "Precense",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_Precense_Kid_KidId",
                table: "Precense",
                column: "KidId",
                principalTable: "Kid",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
