using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class seed_kindergarater_and_kids : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("7b7526d6-c7e4-47b6-a324-926b72238f17"));

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("c34ee1d0-bc32-49f0-a06a-f9c732c84de2"), "Guarderia" });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "FatherName", "FirstName", "KindergarterId", "MotherName", "SecondName", "TutorId" },
                values: new object[,]
                {
                    { new Guid("b2c32fc0-53ef-45a2-97b6-b58d8081bd76"), "Faringtom", "Johan", new Guid("c34ee1d0-bc32-49f0-a06a-f9c732c84de2"), "Washinton", "Carlos", null },
                    { new Guid("65220488-65f1-4b5f-86a6-92abc2023b63"), "Faringtom", "Johan", new Guid("c34ee1d0-bc32-49f0-a06a-f9c732c84de2"), "White", "Carlos", null },
                    { new Guid("56b08770-46e7-455d-a60f-18655bfcd452"), "Faringtom", "Johan", new Guid("c34ee1d0-bc32-49f0-a06a-f9c732c84de2"), "Worm", "Carlos", null },
                    { new Guid("33c73c14-4fcf-40a5-859a-faf8a86eb02d"), "Faringtom", "Johan", new Guid("c34ee1d0-bc32-49f0-a06a-f9c732c84de2"), "Snow", "Carlos", null },
                    { new Guid("4c99dbee-9281-4c74-910d-23954ec879e7"), "Escobar", "Johan", new Guid("c34ee1d0-bc32-49f0-a06a-f9c732c84de2"), "Washinton", "Carlos", null },
                    { new Guid("cefa6715-9138-4f9c-8dfa-25381b577111"), "Escobar", "Johan", new Guid("c34ee1d0-bc32-49f0-a06a-f9c732c84de2"), "White", "Carlos", null },
                    { new Guid("a49d4ccc-d9f4-45a8-a00d-2fee9c70d6e3"), "Escobar", "Johan", new Guid("c34ee1d0-bc32-49f0-a06a-f9c732c84de2"), "Worm", "Carlos", null },
                    { new Guid("748c28e4-9051-4f5c-bca9-80ef4330a6ee"), "Escobar", "Johan", new Guid("c34ee1d0-bc32-49f0-a06a-f9c732c84de2"), "Snow", "Carlos", null },
                    { new Guid("2dec3744-b5e6-4f5a-a92c-a12c932494e9"), "Lee", "Johan", new Guid("c34ee1d0-bc32-49f0-a06a-f9c732c84de2"), "Washinton", "Carlos", null },
                    { new Guid("d2137cb9-d34d-490b-9ce0-90f99ceec7b9"), "Lee", "Johan", new Guid("c34ee1d0-bc32-49f0-a06a-f9c732c84de2"), "White", "Carlos", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("2dec3744-b5e6-4f5a-a92c-a12c932494e9"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("33c73c14-4fcf-40a5-859a-faf8a86eb02d"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("4c99dbee-9281-4c74-910d-23954ec879e7"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("56b08770-46e7-455d-a60f-18655bfcd452"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("65220488-65f1-4b5f-86a6-92abc2023b63"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("748c28e4-9051-4f5c-bca9-80ef4330a6ee"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("a49d4ccc-d9f4-45a8-a00d-2fee9c70d6e3"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("b2c32fc0-53ef-45a2-97b6-b58d8081bd76"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("cefa6715-9138-4f9c-8dfa-25381b577111"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("d2137cb9-d34d-490b-9ce0-90f99ceec7b9"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("c34ee1d0-bc32-49f0-a06a-f9c732c84de2"));

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("7b7526d6-c7e4-47b6-a324-926b72238f17"), "Guarderia" });
        }
    }
}
