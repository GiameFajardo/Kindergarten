using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Ading_Status_to_Receipt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Receipt",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Receipt");
        }
    }
}
