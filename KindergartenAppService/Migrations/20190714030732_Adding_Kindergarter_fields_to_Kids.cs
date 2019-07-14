using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Adding_Kindergarter_fields_to_Kids : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kid_Kindergarters_KindergarterId",
                table: "Kid");

            migrationBuilder.AlterColumn<Guid>(
                name: "KindergarterId",
                table: "Kid",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Kid_Kindergarters_KindergarterId",
                table: "Kid",
                column: "KindergarterId",
                principalTable: "Kindergarters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kid_Kindergarters_KindergarterId",
                table: "Kid");

           
            migrationBuilder.AlterColumn<Guid>(
                name: "KindergarterId",
                table: "Kid",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_Kid_Kindergarters_KindergarterId",
                table: "Kid",
                column: "KindergarterId",
                principalTable: "Kindergarters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
