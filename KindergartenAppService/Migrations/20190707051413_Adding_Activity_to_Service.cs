using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Adding_Activity_to_Service : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ActivityId",
                table: "Item",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Item_ActivityId",
                table: "Item",
                column: "ActivityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Activity_ActivityId",
                table: "Item",
                column: "ActivityId",
                principalTable: "Activity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Activity_ActivityId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_ActivityId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "ActivityId",
                table: "Item");
        }
    }
}
