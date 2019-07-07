using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Kindergarter_NotNullable_in_Activity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activity_Kindergarters_KindergarterId",
                table: "Activity");

            migrationBuilder.AlterColumn<Guid>(
                name: "KindergarterId",
                table: "Activity",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_Kindergarters_KindergarterId",
                table: "Activity",
                column: "KindergarterId",
                principalTable: "Kindergarters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activity_Kindergarters_KindergarterId",
                table: "Activity");

            migrationBuilder.AlterColumn<Guid>(
                name: "KindergarterId",
                table: "Activity",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_Kindergarters_KindergarterId",
                table: "Activity",
                column: "KindergarterId",
                principalTable: "Kindergarters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
