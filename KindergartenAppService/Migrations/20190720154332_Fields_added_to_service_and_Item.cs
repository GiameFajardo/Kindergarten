using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Fields_added_to_service_and_Item : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0050138d-2857-4062-8b0f-edeb1d822fb9"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("007dd309-3d1a-4f86-aa94-9ba1dbd43396"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("01573811-9188-412d-9a11-d5ca1ef40d5c"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0161769e-5cee-4c6a-b194-f7461ea51c20"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("01c6ab49-d8bc-49e9-97d6-bc1004df6d32"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0230008b-9542-4ac4-8e24-04cde9982a2e"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0376dd59-20a3-421a-a25a-6622fd89d23e"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("047bfc58-ba69-4d85-8ff2-bfdc109f17d2"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("047ed0cf-a3fa-4415-a895-354e0fac36f7"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("06495524-e145-418e-88c1-799addb53066"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("d1ac6bf2-f1e2-4532-bd95-4d0c5fb3eac3"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("9627236d-bd58-4ae3-97af-788e95af1a9a"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("c69f0c0f-4b23-421b-b5d0-67a592dbe6fa"));

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Item",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Item",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Activity",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"), "Guarderia" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d"), null, "Gregorio de Jesus", "Rojas Acosta", null, null, null });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("380a7446-94f4-480f-9806-5091afcde014"), null, "Yadira", "Pinales Delgado", null, null, null });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "FatherName", "FirstName", "KindergarterId", "MotherName", "SecondName", "TutorId" },
                values: new object[,]
                {
                    { new Guid("017db7ca-deee-4412-884b-d4b46fc372e7"), "Escobar", "Lyan", new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"), "Washinton", "Enrique", new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d") },
                    { new Guid("02e2617d-e74d-4ef4-a13e-deca76d10bc8"), "Faringtom", "Johan", new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"), "Snow", "Enrique", new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d") },
                    { new Guid("0379cc56-36d8-4316-98fb-ef9e9edfab35"), "Faringtom", "Lyan", new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"), "Worm", "Carlos", new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d") },
                    { new Guid("03c9df9a-d484-45f0-b858-fbe75520b320"), "Faringtom", "Aaron", new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"), "Snow", "Enrique", new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d") },
                    { new Guid("03ec5db0-fe1f-4503-be6e-e8d8dc27449c"), "Faringtom", "Johan", new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"), "Washinton", "Carlos", new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d") },
                    { new Guid("049349af-fc53-41b4-90d8-947bfcc38fd1"), "Faringtom", "Johan", new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"), "White", "Emilio", new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d") },
                    { new Guid("04fb0a57-8134-45ed-86b3-160cbbec3996"), "Lee", "Lyan", new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"), "Worm", "Emilio", new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d") },
                    { new Guid("056a4650-ef32-46f1-9a4d-4b8ab28c142c"), "Escobar", "Johan", new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"), "Snow", "Enrique", new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d") },
                    { new Guid("05bf9154-4750-410f-b6c1-99d2320d794a"), "Stackeetam", "Johan", new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"), "Snow", "Enrique", new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d") },
                    { new Guid("06645412-9112-4d7f-869c-5a6f87998a58"), "Faringtom", "Johan", new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"), "Worm", "Eduardo", new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("017db7ca-deee-4412-884b-d4b46fc372e7"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("02e2617d-e74d-4ef4-a13e-deca76d10bc8"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0379cc56-36d8-4316-98fb-ef9e9edfab35"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("03c9df9a-d484-45f0-b858-fbe75520b320"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("03ec5db0-fe1f-4503-be6e-e8d8dc27449c"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("049349af-fc53-41b4-90d8-947bfcc38fd1"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("04fb0a57-8134-45ed-86b3-160cbbec3996"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("056a4650-ef32-46f1-9a4d-4b8ab28c142c"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("05bf9154-4750-410f-b6c1-99d2320d794a"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("06645412-9112-4d7f-869c-5a6f87998a58"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("380a7446-94f4-480f-9806-5091afcde014"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d"));

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Item");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Activity",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("9627236d-bd58-4ae3-97af-788e95af1a9a"), "Guarderia" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("c69f0c0f-4b23-421b-b5d0-67a592dbe6fa"), null, "Gregorio de Jesus", "Rojas Acosta", null, null, null });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("d1ac6bf2-f1e2-4532-bd95-4d0c5fb3eac3"), null, "Yadira", "Pinales Delgado", null, null, null });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "FatherName", "FirstName", "KindergarterId", "MotherName", "SecondName", "TutorId" },
                values: new object[,]
                {
                    { new Guid("0050138d-2857-4062-8b0f-edeb1d822fb9"), "Lee", "Johan", new Guid("9627236d-bd58-4ae3-97af-788e95af1a9a"), "White", "Carlos", new Guid("c69f0c0f-4b23-421b-b5d0-67a592dbe6fa") },
                    { new Guid("007dd309-3d1a-4f86-aa94-9ba1dbd43396"), "Stackeetam", "Johan", new Guid("9627236d-bd58-4ae3-97af-788e95af1a9a"), "Worm", "Emilio", new Guid("c69f0c0f-4b23-421b-b5d0-67a592dbe6fa") },
                    { new Guid("01573811-9188-412d-9a11-d5ca1ef40d5c"), "Stackeetam", "Dylan", new Guid("9627236d-bd58-4ae3-97af-788e95af1a9a"), "Worm", "Carlos", new Guid("c69f0c0f-4b23-421b-b5d0-67a592dbe6fa") },
                    { new Guid("0161769e-5cee-4c6a-b194-f7461ea51c20"), "Lee", "Lyan", new Guid("9627236d-bd58-4ae3-97af-788e95af1a9a"), "Worm", "Eduardo", new Guid("c69f0c0f-4b23-421b-b5d0-67a592dbe6fa") },
                    { new Guid("01c6ab49-d8bc-49e9-97d6-bc1004df6d32"), "Faringtom", "Aaron", new Guid("9627236d-bd58-4ae3-97af-788e95af1a9a"), "Worm", "Enrique", new Guid("c69f0c0f-4b23-421b-b5d0-67a592dbe6fa") },
                    { new Guid("0230008b-9542-4ac4-8e24-04cde9982a2e"), "Escobar", "Lyan", new Guid("9627236d-bd58-4ae3-97af-788e95af1a9a"), "Snow", "Enrique", new Guid("c69f0c0f-4b23-421b-b5d0-67a592dbe6fa") },
                    { new Guid("0376dd59-20a3-421a-a25a-6622fd89d23e"), "Stackeetam", "Aaron", new Guid("9627236d-bd58-4ae3-97af-788e95af1a9a"), "Washinton", "Carlos", new Guid("c69f0c0f-4b23-421b-b5d0-67a592dbe6fa") },
                    { new Guid("047bfc58-ba69-4d85-8ff2-bfdc109f17d2"), "Faringtom", "Lyan", new Guid("9627236d-bd58-4ae3-97af-788e95af1a9a"), "Worm", "Eduardo", new Guid("c69f0c0f-4b23-421b-b5d0-67a592dbe6fa") },
                    { new Guid("047ed0cf-a3fa-4415-a895-354e0fac36f7"), "Escobar", "Aaron", new Guid("9627236d-bd58-4ae3-97af-788e95af1a9a"), "Washinton", "Enrique", new Guid("c69f0c0f-4b23-421b-b5d0-67a592dbe6fa") },
                    { new Guid("06495524-e145-418e-88c1-799addb53066"), "Lee", "Lyan", new Guid("9627236d-bd58-4ae3-97af-788e95af1a9a"), "Washinton", "Carlos", new Guid("c69f0c0f-4b23-421b-b5d0-67a592dbe6fa") }
                });
        }
    }
}
