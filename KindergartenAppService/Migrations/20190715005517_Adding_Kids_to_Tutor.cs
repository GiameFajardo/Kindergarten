using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Adding_Kids_to_Tutor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
