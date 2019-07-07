using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Activity_NotNullable_in_Service : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Activity_ActivityId",
                table: "Item");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Activity_ActivityId",
                table: "Item",
                column: "ActivityId",
                principalTable: "Activity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Activity_ActivityId",
                table: "Item");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Activity_ActivityId",
                table: "Item",
                column: "ActivityId",
                principalTable: "Activity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
