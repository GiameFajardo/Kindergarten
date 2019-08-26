using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Adding_jobinfo_to_Tutor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobNumber",
                table: "Tutors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkPlace",
                table: "Tutors",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ServiceId",
                table: "EnrollActivity",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobNumber",
                table: "Tutors");

            migrationBuilder.DropColumn(
                name: "WorkPlace",
                table: "Tutors");

            migrationBuilder.AlterColumn<Guid>(
                name: "ServiceId",
                table: "EnrollActivity",
                nullable: true,
                oldClrType: typeof(Guid));
        }
    }
}
