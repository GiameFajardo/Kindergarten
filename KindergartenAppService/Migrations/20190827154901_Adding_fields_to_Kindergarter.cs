using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Adding_fields_to_Kindergarter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Kindergarters",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InvoiceMessage",
                table: "Kindergarters",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mail",
                table: "Kindergarters",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Kindergarters",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Kindergarters");

            migrationBuilder.DropColumn(
                name: "InvoiceMessage",
                table: "Kindergarters");

            migrationBuilder.DropColumn(
                name: "Mail",
                table: "Kindergarters");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Kindergarters");
        }
    }
}
