using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Adding_socials_to_Kindergarter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Facebook",
                table: "Kindergarters",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Instagram",
                table: "Kindergarters",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Facebook",
                table: "Kindergarters");

            migrationBuilder.DropColumn(
                name: "Instagram",
                table: "Kindergarters");
        }
    }
}
