using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Adding_some_fields_to_Tutor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("013cd664-596f-43c0-b12b-57e5b15fe674"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("017d8688-9250-43ab-ae16-7026afdb6b39"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("040e52b4-0bb2-44fd-b3db-21f8bc178e3b"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0499fffb-ef40-476a-aeb6-82e3132d0b11"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("05e81e34-aa4e-4956-beb6-21031128287f"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("060b0968-c65a-40c1-b398-921411b11235"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("086c32c6-c636-4ccc-9fd6-4ca6c30029c4"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("08af9320-2f7d-4356-9c5f-aaaa79202dc4"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0c5a396d-e074-4050-aa72-e6b2bc827a62"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0d29e9cd-dde1-4aa7-afe0-2d4e63685ca9"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("5b664dab-b67b-47ba-8400-2d86ad256b6e"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("fd672c9a-0c51-4af9-bf62-0a2545091db8"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("7e93c619-dab5-4d79-b8bd-cb22629d28a9"));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Tutors",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Tutors",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Tutors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mail",
                table: "Tutors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MovilNumber",
                table: "Tutors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Tutors",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("ea932267-0363-4acb-b18a-23395797aefd"), "Guarderia" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("5c6bc6e3-51e2-4272-a283-25fdc4baeecf"), null, "Gregorio de Jesus", "Rojas Acosta", null, null, null });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("bc88774d-c604-410e-8495-96550967e90c"), null, "Yadira", "Pinales Delgado", null, null, null });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "FatherName", "FirstName", "KindergarterId", "MotherName", "SecondName", "TutorId" },
                values: new object[,]
                {
                    { new Guid("001534be-7d33-4cc8-9de2-50c61da9d982"), "Lee", "Aaron", new Guid("ea932267-0363-4acb-b18a-23395797aefd"), "Worm", "Carlos", new Guid("5c6bc6e3-51e2-4272-a283-25fdc4baeecf") },
                    { new Guid("0037bf31-4cd9-4ee8-b066-24c99a6a2199"), "Faringtom", "Dylan", new Guid("ea932267-0363-4acb-b18a-23395797aefd"), "Snow", "Enrique", new Guid("5c6bc6e3-51e2-4272-a283-25fdc4baeecf") },
                    { new Guid("01e248b9-c5f9-4b7f-8094-ed76aec8b42e"), "Escobar", "Lyan", new Guid("ea932267-0363-4acb-b18a-23395797aefd"), "Snow", "Emilio", new Guid("5c6bc6e3-51e2-4272-a283-25fdc4baeecf") },
                    { new Guid("03a6e0d1-d17c-4172-99ce-faa9231a5385"), "Stackeetam", "Lyan", new Guid("ea932267-0363-4acb-b18a-23395797aefd"), "Washinton", "Enrique", new Guid("5c6bc6e3-51e2-4272-a283-25fdc4baeecf") },
                    { new Guid("03e5fe5e-1f80-4219-8937-60755c2fe3bb"), "Lee", "Aaron", new Guid("ea932267-0363-4acb-b18a-23395797aefd"), "White", "Emilio", new Guid("5c6bc6e3-51e2-4272-a283-25fdc4baeecf") },
                    { new Guid("042390e0-bdb8-4fcd-8dbf-c99c52dc0def"), "Stackeetam", "Johan", new Guid("ea932267-0363-4acb-b18a-23395797aefd"), "White", "Enrique", new Guid("5c6bc6e3-51e2-4272-a283-25fdc4baeecf") },
                    { new Guid("0561e7ef-6c0e-4d67-905d-964ffb30ff1b"), "Escobar", "Lyan", new Guid("ea932267-0363-4acb-b18a-23395797aefd"), "Worm", "Emilio", new Guid("5c6bc6e3-51e2-4272-a283-25fdc4baeecf") },
                    { new Guid("060134fd-7599-4220-9222-10999c887aeb"), "Stackeetam", "Lyan", new Guid("ea932267-0363-4acb-b18a-23395797aefd"), "Snow", "Carlos", new Guid("5c6bc6e3-51e2-4272-a283-25fdc4baeecf") },
                    { new Guid("06aff1c0-6f84-4359-a517-8f0065be443d"), "Escobar", "Lyan", new Guid("ea932267-0363-4acb-b18a-23395797aefd"), "Worm", "Carlos", new Guid("5c6bc6e3-51e2-4272-a283-25fdc4baeecf") },
                    { new Guid("071238f3-7887-41ea-9828-3757a2349314"), "Stackeetam", "Lyan", new Guid("ea932267-0363-4acb-b18a-23395797aefd"), "Washinton", "Eduardo", new Guid("5c6bc6e3-51e2-4272-a283-25fdc4baeecf") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("001534be-7d33-4cc8-9de2-50c61da9d982"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0037bf31-4cd9-4ee8-b066-24c99a6a2199"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("01e248b9-c5f9-4b7f-8094-ed76aec8b42e"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("03a6e0d1-d17c-4172-99ce-faa9231a5385"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("03e5fe5e-1f80-4219-8937-60755c2fe3bb"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("042390e0-bdb8-4fcd-8dbf-c99c52dc0def"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0561e7ef-6c0e-4d67-905d-964ffb30ff1b"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("060134fd-7599-4220-9222-10999c887aeb"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("06aff1c0-6f84-4359-a517-8f0065be443d"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("071238f3-7887-41ea-9828-3757a2349314"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("bc88774d-c604-410e-8495-96550967e90c"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("ea932267-0363-4acb-b18a-23395797aefd"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("5c6bc6e3-51e2-4272-a283-25fdc4baeecf"));

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Tutors");

            migrationBuilder.DropColumn(
                name: "Mail",
                table: "Tutors");

            migrationBuilder.DropColumn(
                name: "MovilNumber",
                table: "Tutors");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Tutors");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Tutors",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Tutors",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("fd672c9a-0c51-4af9-bf62-0a2545091db8"), "Guarderia" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { new Guid("7e93c619-dab5-4d79-b8bd-cb22629d28a9"), "Gregorio de Jesus", "Rojas Acosta" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { new Guid("5b664dab-b67b-47ba-8400-2d86ad256b6e"), "Yadira", "Pinales Delgado" });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "FatherName", "FirstName", "KindergarterId", "MotherName", "SecondName", "TutorId" },
                values: new object[,]
                {
                    { new Guid("013cd664-596f-43c0-b12b-57e5b15fe674"), "Escobar", "Lyan", new Guid("fd672c9a-0c51-4af9-bf62-0a2545091db8"), "Worm", "Eduardo", new Guid("7e93c619-dab5-4d79-b8bd-cb22629d28a9") },
                    { new Guid("017d8688-9250-43ab-ae16-7026afdb6b39"), "Faringtom", "Aaron", new Guid("fd672c9a-0c51-4af9-bf62-0a2545091db8"), "White", "Eduardo", new Guid("7e93c619-dab5-4d79-b8bd-cb22629d28a9") },
                    { new Guid("040e52b4-0bb2-44fd-b3db-21f8bc178e3b"), "Lee", "Dylan", new Guid("fd672c9a-0c51-4af9-bf62-0a2545091db8"), "Washinton", "Eduardo", new Guid("7e93c619-dab5-4d79-b8bd-cb22629d28a9") },
                    { new Guid("0499fffb-ef40-476a-aeb6-82e3132d0b11"), "Escobar", "Johan", new Guid("fd672c9a-0c51-4af9-bf62-0a2545091db8"), "Washinton", "Emilio", new Guid("7e93c619-dab5-4d79-b8bd-cb22629d28a9") },
                    { new Guid("05e81e34-aa4e-4956-beb6-21031128287f"), "Stackeetam", "Johan", new Guid("fd672c9a-0c51-4af9-bf62-0a2545091db8"), "Snow", "Carlos", new Guid("7e93c619-dab5-4d79-b8bd-cb22629d28a9") },
                    { new Guid("060b0968-c65a-40c1-b398-921411b11235"), "Lee", "Johan", new Guid("fd672c9a-0c51-4af9-bf62-0a2545091db8"), "Snow", "Emilio", new Guid("7e93c619-dab5-4d79-b8bd-cb22629d28a9") },
                    { new Guid("086c32c6-c636-4ccc-9fd6-4ca6c30029c4"), "Stackeetam", "Lyan", new Guid("fd672c9a-0c51-4af9-bf62-0a2545091db8"), "White", "Eduardo", new Guid("7e93c619-dab5-4d79-b8bd-cb22629d28a9") },
                    { new Guid("08af9320-2f7d-4356-9c5f-aaaa79202dc4"), "Escobar", "Johan", new Guid("fd672c9a-0c51-4af9-bf62-0a2545091db8"), "Washinton", "Enrique", new Guid("7e93c619-dab5-4d79-b8bd-cb22629d28a9") },
                    { new Guid("0c5a396d-e074-4050-aa72-e6b2bc827a62"), "Lee", "Johan", new Guid("fd672c9a-0c51-4af9-bf62-0a2545091db8"), "White", "Enrique", new Guid("7e93c619-dab5-4d79-b8bd-cb22629d28a9") },
                    { new Guid("0d29e9cd-dde1-4aa7-afe0-2d4e63685ca9"), "Escobar", "Dylan", new Guid("fd672c9a-0c51-4af9-bf62-0a2545091db8"), "Snow", "Enrique", new Guid("7e93c619-dab5-4d79-b8bd-cb22629d28a9") }
                });
        }
    }
}
