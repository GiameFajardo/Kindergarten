using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Adding_Feeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Feeding",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feeding", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FeedingKid",
                columns: table => new
                {
                    KidId = table.Column<Guid>(nullable: false),
                    FeddingId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedingKid", x => new { x.KidId, x.FeddingId });
                    table.ForeignKey(
                        name: "FK_FeedingKid_Feeding_FeddingId",
                        column: x => x.FeddingId,
                        principalTable: "Feeding",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeedingKid_Kid_KidId",
                        column: x => x.KidId,
                        principalTable: "Kid",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FeedingKid_FeddingId",
                table: "FeedingKid",
                column: "FeddingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeedingKid");

            migrationBuilder.DropTable(
                name: "Feeding");
        }
    }
}
