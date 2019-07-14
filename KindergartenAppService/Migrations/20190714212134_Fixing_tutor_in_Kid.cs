using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Fixing_tutor_in_Kid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0200fd1b-a500-49af-bf2c-2d3364c89f19"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("02681151-8b7a-41ee-a86e-678bb6f28915"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("03b751b7-e12e-4915-975e-2c4e1f173214"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("062cd134-a7d7-4b99-b0a1-0306a63f94e2"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("06753fb0-a16a-4bbf-848c-39efd0d60474"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("07237924-f05d-4a88-a286-0777a7def8db"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("07cdd2b9-ce74-4850-83a0-4a4ff703a524"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0a6540e4-baa2-4879-b3aa-e89f7ba5bd9c"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0a95f554-7d9b-4024-ad59-07a02eb78cdd"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0b765647-0089-4b83-b041-2000e1c7ba2d"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("ebf24697-be48-4a79-a9b2-32b4cf33fd60"));

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("5723c611-0ccd-4309-89c9-f1340a8b2bdf"), "Guarderia" });

            migrationBuilder.InsertData(
                table: "Tutor",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { new Guid("954ce525-1194-4eb5-89a4-45130ecce040"), "Gregorio de Jesus", "Rojas Acosta" });

            migrationBuilder.InsertData(
                table: "Tutor",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { new Guid("6e763b79-0e0f-4ccd-9b7a-5e92af640a41"), "Yadira", "Pinales Delgado" });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "FatherName", "FirstName", "KindergarterId", "MotherName", "SecondName", "TutorId" },
                values: new object[,]
                {
                    { new Guid("01dc3af0-98a0-45c6-8912-bccb89819d4b"), "Escobar", "Lyan", new Guid("5723c611-0ccd-4309-89c9-f1340a8b2bdf"), "White", "Eduardo", new Guid("954ce525-1194-4eb5-89a4-45130ecce040") },
                    { new Guid("046b49bd-59cf-4186-a655-0d80c775b5ab"), "Lee", "Johan", new Guid("5723c611-0ccd-4309-89c9-f1340a8b2bdf"), "White", "Carlos", new Guid("954ce525-1194-4eb5-89a4-45130ecce040") },
                    { new Guid("0552fb18-f42a-40e5-8720-c2c1a766adb2"), "Faringtom", "Lyan", new Guid("5723c611-0ccd-4309-89c9-f1340a8b2bdf"), "Worm", "Enrique", new Guid("954ce525-1194-4eb5-89a4-45130ecce040") },
                    { new Guid("07a48321-d38b-4b55-8883-6bfee637c33b"), "Escobar", "Johan", new Guid("5723c611-0ccd-4309-89c9-f1340a8b2bdf"), "White", "Enrique", new Guid("954ce525-1194-4eb5-89a4-45130ecce040") },
                    { new Guid("08df6f2b-a67b-475c-877d-10b7c2f2e1fa"), "Faringtom", "Johan", new Guid("5723c611-0ccd-4309-89c9-f1340a8b2bdf"), "White", "Enrique", new Guid("954ce525-1194-4eb5-89a4-45130ecce040") },
                    { new Guid("09356375-5f1c-463e-9d83-27ab8c7e5bbb"), "Escobar", "Johan", new Guid("5723c611-0ccd-4309-89c9-f1340a8b2bdf"), "Snow", "Carlos", new Guid("954ce525-1194-4eb5-89a4-45130ecce040") },
                    { new Guid("002d5d52-36d9-4869-9bac-5732809c9c8d"), "Lee", "Aaron", new Guid("5723c611-0ccd-4309-89c9-f1340a8b2bdf"), "Washinton", "Enrique", new Guid("6e763b79-0e0f-4ccd-9b7a-5e92af640a41") },
                    { new Guid("088d21f8-0c8c-465a-8d15-1f183d0960bd"), "Faringtom", "Johan", new Guid("5723c611-0ccd-4309-89c9-f1340a8b2bdf"), "Worm", "Enrique", new Guid("6e763b79-0e0f-4ccd-9b7a-5e92af640a41") },
                    { new Guid("0a22952a-2acb-4b3e-b7a6-434c5cac5256"), "Escobar", "Johan", new Guid("5723c611-0ccd-4309-89c9-f1340a8b2bdf"), "Worm", "Enrique", new Guid("6e763b79-0e0f-4ccd-9b7a-5e92af640a41") },
                    { new Guid("0ada2328-85f3-4138-99e9-2f266ec940eb"), "Lee", "Johan", new Guid("5723c611-0ccd-4309-89c9-f1340a8b2bdf"), "Snow", "Carlos", new Guid("6e763b79-0e0f-4ccd-9b7a-5e92af640a41") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("002d5d52-36d9-4869-9bac-5732809c9c8d"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("01dc3af0-98a0-45c6-8912-bccb89819d4b"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("046b49bd-59cf-4186-a655-0d80c775b5ab"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0552fb18-f42a-40e5-8720-c2c1a766adb2"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("07a48321-d38b-4b55-8883-6bfee637c33b"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("088d21f8-0c8c-465a-8d15-1f183d0960bd"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("08df6f2b-a67b-475c-877d-10b7c2f2e1fa"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("09356375-5f1c-463e-9d83-27ab8c7e5bbb"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0a22952a-2acb-4b3e-b7a6-434c5cac5256"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0ada2328-85f3-4138-99e9-2f266ec940eb"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("5723c611-0ccd-4309-89c9-f1340a8b2bdf"));

            migrationBuilder.DeleteData(
                table: "Tutor",
                keyColumn: "Id",
                keyValue: new Guid("6e763b79-0e0f-4ccd-9b7a-5e92af640a41"));

            migrationBuilder.DeleteData(
                table: "Tutor",
                keyColumn: "Id",
                keyValue: new Guid("954ce525-1194-4eb5-89a4-45130ecce040"));

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("ebf24697-be48-4a79-a9b2-32b4cf33fd60"), "Guarderia" });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "FatherName", "FirstName", "KindergarterId", "MotherName", "SecondName", "TutorId" },
                values: new object[,]
                {
                    { new Guid("0200fd1b-a500-49af-bf2c-2d3364c89f19"), "Faringtom", "Dylan", new Guid("ebf24697-be48-4a79-a9b2-32b4cf33fd60"), "Worm", "Emilio", new Guid("e14cab87-5afd-49c5-87cf-200b64cde27e") },
                    { new Guid("02681151-8b7a-41ee-a86e-678bb6f28915"), "Stackeetam", "Lyan", new Guid("ebf24697-be48-4a79-a9b2-32b4cf33fd60"), "Worm", "Eduardo", new Guid("e14cab87-5afd-49c5-87cf-200b64cde27e") },
                    { new Guid("03b751b7-e12e-4915-975e-2c4e1f173214"), "Escobar", "Johan", new Guid("ebf24697-be48-4a79-a9b2-32b4cf33fd60"), "White", "Emilio", new Guid("e14cab87-5afd-49c5-87cf-200b64cde27e") },
                    { new Guid("062cd134-a7d7-4b99-b0a1-0306a63f94e2"), "Stackeetam", "Johan", new Guid("ebf24697-be48-4a79-a9b2-32b4cf33fd60"), "Snow", "Enrique", new Guid("4808078c-cffd-4263-91e4-893d3e8dafd7") },
                    { new Guid("06753fb0-a16a-4bbf-848c-39efd0d60474"), "Stackeetam", "Aaron", new Guid("ebf24697-be48-4a79-a9b2-32b4cf33fd60"), "Washinton", "Emilio", new Guid("4808078c-cffd-4263-91e4-893d3e8dafd7") },
                    { new Guid("07237924-f05d-4a88-a286-0777a7def8db"), "Stackeetam", "Dylan", new Guid("ebf24697-be48-4a79-a9b2-32b4cf33fd60"), "Washinton", "Emilio", new Guid("4808078c-cffd-4263-91e4-893d3e8dafd7") },
                    { new Guid("07cdd2b9-ce74-4850-83a0-4a4ff703a524"), "Faringtom", "Lyan", new Guid("ebf24697-be48-4a79-a9b2-32b4cf33fd60"), "Worm", "Eduardo", new Guid("e14cab87-5afd-49c5-87cf-200b64cde27e") },
                    { new Guid("0a6540e4-baa2-4879-b3aa-e89f7ba5bd9c"), "Stackeetam", "Aaron", new Guid("ebf24697-be48-4a79-a9b2-32b4cf33fd60"), "Snow", "Carlos", new Guid("e14cab87-5afd-49c5-87cf-200b64cde27e") },
                    { new Guid("0a95f554-7d9b-4024-ad59-07a02eb78cdd"), "Lee", "Lyan", new Guid("ebf24697-be48-4a79-a9b2-32b4cf33fd60"), "Snow", "Enrique", new Guid("e14cab87-5afd-49c5-87cf-200b64cde27e") },
                    { new Guid("0b765647-0089-4b83-b041-2000e1c7ba2d"), "Escobar", "Dylan", new Guid("ebf24697-be48-4a79-a9b2-32b4cf33fd60"), "Washinton", "Eduardo", new Guid("4808078c-cffd-4263-91e4-893d3e8dafd7") }
                });
        }
    }
}
