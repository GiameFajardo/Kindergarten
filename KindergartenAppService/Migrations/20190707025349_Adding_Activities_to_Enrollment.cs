using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Adding_Activities_to_Enrollment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activity_Enrollments_EnrollmentId",
                table: "Activity");

            migrationBuilder.DropIndex(
                name: "IX_Activity_EnrollmentId",
                table: "Activity");

            migrationBuilder.DropColumn(
                name: "EnrollmentId",
                table: "Activity");

            migrationBuilder.CreateTable(
                name: "EnrollActivity",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ActivityId = table.Column<Guid>(nullable: false),
                    EnrollmentId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnrollActivity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnrollActivity_Activity_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EnrollActivity_Enrollments_EnrollmentId",
                        column: x => x.EnrollmentId,
                        principalTable: "Enrollments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EnrollActivity_ActivityId",
                table: "EnrollActivity",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_EnrollActivity_EnrollmentId",
                table: "EnrollActivity",
                column: "EnrollmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnrollActivity");

            migrationBuilder.AddColumn<Guid>(
                name: "EnrollmentId",
                table: "Activity",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Activity_EnrollmentId",
                table: "Activity",
                column: "EnrollmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_Enrollments_EnrollmentId",
                table: "Activity",
                column: "EnrollmentId",
                principalTable: "Enrollments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
