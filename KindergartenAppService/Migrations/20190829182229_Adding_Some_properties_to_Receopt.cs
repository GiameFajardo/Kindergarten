using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Adding_Some_properties_to_Receopt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Document",
                table: "Receipt",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "GeneratedDate",
                table: "Receipt",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "Sequence",
                table: "Receipt",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Document",
                table: "Receipt");

            migrationBuilder.DropColumn(
                name: "GeneratedDate",
                table: "Receipt");

            migrationBuilder.DropColumn(
                name: "Sequence",
                table: "Receipt");
        }
    }
}
