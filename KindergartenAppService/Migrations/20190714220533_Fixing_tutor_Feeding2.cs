using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Fixing_tutor_Feeding2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("04d4d650-bfcb-4a5e-8707-600775b4a361"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("05c79ad7-1d07-45d9-8321-781ff9974df6"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("066f6d6d-a1c5-4e36-b3d2-0db0189a15f4"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0b2e9aa5-a42d-43ae-9c7c-518ce82383eb"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0bf0523b-99fc-4c18-b653-f69ff53b9122"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0e64cf03-313c-42e2-a193-dcf2aa6ca1fc"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("10f96eea-82b3-43bf-a74b-bb6783e7116b"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("11c446f8-3621-4aab-9d97-09a14b07dd8f"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("120a9b81-0f3a-4a68-8b3b-83e3dac9b6cf"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("12631c61-889b-4ffe-b3b4-ff78ccc31137"));

            migrationBuilder.DeleteData(
                table: "Tutor",
                keyColumn: "Id",
                keyValue: new Guid("6b079598-baa6-4098-9d7f-f5124b61e050"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("ef6c5692-9813-439b-aa2e-d77ebe9e2d67"));

            migrationBuilder.DeleteData(
                table: "Tutor",
                keyColumn: "Id",
                keyValue: new Guid("0adeff61-3aed-416e-a452-4f6e14565d21"));

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("a15de111-15d0-4218-8b1f-bf4ae20adccd"), "Guarderia" });

            migrationBuilder.InsertData(
                table: "Tutor",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { new Guid("f5f65d1c-8065-408a-9b51-c669ee8ddfda"), "Gregorio de Jesus", "Rojas Acosta" });

            migrationBuilder.InsertData(
                table: "Tutor",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { new Guid("720c473d-50cb-41ab-acc3-5214b8add509"), "Yadira", "Pinales Delgado" });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "FatherName", "FirstName", "KindergarterId", "MotherName", "SecondName", "TutorId" },
                values: new object[,]
                {
                    { new Guid("005b5f2c-5e97-416f-b06f-da5635538e09"), "Escobar", "Aaron", new Guid("a15de111-15d0-4218-8b1f-bf4ae20adccd"), "White", "Enrique", new Guid("f5f65d1c-8065-408a-9b51-c669ee8ddfda") },
                    { new Guid("00a7b9e6-2dab-4de2-9f79-4ad8dd2ac249"), "Faringtom", "Dylan", new Guid("a15de111-15d0-4218-8b1f-bf4ae20adccd"), "Washinton", "Eduardo", new Guid("f5f65d1c-8065-408a-9b51-c669ee8ddfda") },
                    { new Guid("0106d9be-a6c9-4434-8e44-6ba5858c2684"), "Faringtom", "Dylan", new Guid("a15de111-15d0-4218-8b1f-bf4ae20adccd"), "Washinton", "Emilio", new Guid("f5f65d1c-8065-408a-9b51-c669ee8ddfda") },
                    { new Guid("02e6eb28-623d-4a5f-ad61-8be2e695797c"), "Lee", "Dylan", new Guid("a15de111-15d0-4218-8b1f-bf4ae20adccd"), "Washinton", "Emilio", new Guid("f5f65d1c-8065-408a-9b51-c669ee8ddfda") },
                    { new Guid("046f9e8c-310d-4b95-8a2d-78efc967006a"), "Faringtom", "Aaron", new Guid("a15de111-15d0-4218-8b1f-bf4ae20adccd"), "White", "Carlos", new Guid("f5f65d1c-8065-408a-9b51-c669ee8ddfda") },
                    { new Guid("0504c518-4465-462e-bbf6-937a14c6c1ef"), "Escobar", "Johan", new Guid("a15de111-15d0-4218-8b1f-bf4ae20adccd"), "Washinton", "Emilio", new Guid("f5f65d1c-8065-408a-9b51-c669ee8ddfda") },
                    { new Guid("052884a6-505b-4de8-957c-db87513ab396"), "Lee", "Dylan", new Guid("a15de111-15d0-4218-8b1f-bf4ae20adccd"), "Washinton", "Carlos", new Guid("f5f65d1c-8065-408a-9b51-c669ee8ddfda") },
                    { new Guid("0663a3b6-f134-49df-b823-400a74db62ef"), "Lee", "Dylan", new Guid("a15de111-15d0-4218-8b1f-bf4ae20adccd"), "Worm", "Eduardo", new Guid("f5f65d1c-8065-408a-9b51-c669ee8ddfda") },
                    { new Guid("0748ee52-2acc-4688-80e7-6a3d1feb22aa"), "Lee", "Lyan", new Guid("a15de111-15d0-4218-8b1f-bf4ae20adccd"), "Washinton", "Carlos", new Guid("f5f65d1c-8065-408a-9b51-c669ee8ddfda") },
                    { new Guid("08c4432f-25af-4827-95e6-c2cfeca3d5b3"), "Lee", "Aaron", new Guid("a15de111-15d0-4218-8b1f-bf4ae20adccd"), "Washinton", "Eduardo", new Guid("f5f65d1c-8065-408a-9b51-c669ee8ddfda") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("005b5f2c-5e97-416f-b06f-da5635538e09"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("00a7b9e6-2dab-4de2-9f79-4ad8dd2ac249"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0106d9be-a6c9-4434-8e44-6ba5858c2684"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("02e6eb28-623d-4a5f-ad61-8be2e695797c"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("046f9e8c-310d-4b95-8a2d-78efc967006a"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0504c518-4465-462e-bbf6-937a14c6c1ef"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("052884a6-505b-4de8-957c-db87513ab396"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0663a3b6-f134-49df-b823-400a74db62ef"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0748ee52-2acc-4688-80e7-6a3d1feb22aa"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("08c4432f-25af-4827-95e6-c2cfeca3d5b3"));

            migrationBuilder.DeleteData(
                table: "Tutor",
                keyColumn: "Id",
                keyValue: new Guid("720c473d-50cb-41ab-acc3-5214b8add509"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("a15de111-15d0-4218-8b1f-bf4ae20adccd"));

            migrationBuilder.DeleteData(
                table: "Tutor",
                keyColumn: "Id",
                keyValue: new Guid("f5f65d1c-8065-408a-9b51-c669ee8ddfda"));

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("ef6c5692-9813-439b-aa2e-d77ebe9e2d67"), "Guarderia" });

            migrationBuilder.InsertData(
                table: "Tutor",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { new Guid("0adeff61-3aed-416e-a452-4f6e14565d21"), "Gregorio de Jesus", "Rojas Acosta" });

            migrationBuilder.InsertData(
                table: "Tutor",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { new Guid("6b079598-baa6-4098-9d7f-f5124b61e050"), "Yadira", "Pinales Delgado" });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "FatherName", "FirstName", "KindergarterId", "MotherName", "SecondName", "TutorId" },
                values: new object[,]
                {
                    { new Guid("04d4d650-bfcb-4a5e-8707-600775b4a361"), "Stackeetam", "Dylan", new Guid("ef6c5692-9813-439b-aa2e-d77ebe9e2d67"), "White", "Eduardo", new Guid("0adeff61-3aed-416e-a452-4f6e14565d21") },
                    { new Guid("05c79ad7-1d07-45d9-8321-781ff9974df6"), "Lee", "Dylan", new Guid("ef6c5692-9813-439b-aa2e-d77ebe9e2d67"), "White", "Enrique", new Guid("0adeff61-3aed-416e-a452-4f6e14565d21") },
                    { new Guid("066f6d6d-a1c5-4e36-b3d2-0db0189a15f4"), "Lee", "Johan", new Guid("ef6c5692-9813-439b-aa2e-d77ebe9e2d67"), "Washinton", "Eduardo", new Guid("0adeff61-3aed-416e-a452-4f6e14565d21") },
                    { new Guid("0b2e9aa5-a42d-43ae-9c7c-518ce82383eb"), "Lee", "Johan", new Guid("ef6c5692-9813-439b-aa2e-d77ebe9e2d67"), "Snow", "Carlos", new Guid("0adeff61-3aed-416e-a452-4f6e14565d21") },
                    { new Guid("0bf0523b-99fc-4c18-b653-f69ff53b9122"), "Lee", "Aaron", new Guid("ef6c5692-9813-439b-aa2e-d77ebe9e2d67"), "Worm", "Enrique", new Guid("0adeff61-3aed-416e-a452-4f6e14565d21") },
                    { new Guid("0e64cf03-313c-42e2-a193-dcf2aa6ca1fc"), "Lee", "Aaron", new Guid("ef6c5692-9813-439b-aa2e-d77ebe9e2d67"), "Snow", "Carlos", new Guid("0adeff61-3aed-416e-a452-4f6e14565d21") },
                    { new Guid("10f96eea-82b3-43bf-a74b-bb6783e7116b"), "Escobar", "Johan", new Guid("ef6c5692-9813-439b-aa2e-d77ebe9e2d67"), "Snow", "Eduardo", new Guid("0adeff61-3aed-416e-a452-4f6e14565d21") },
                    { new Guid("11c446f8-3621-4aab-9d97-09a14b07dd8f"), "Escobar", "Johan", new Guid("ef6c5692-9813-439b-aa2e-d77ebe9e2d67"), "White", "Eduardo", new Guid("0adeff61-3aed-416e-a452-4f6e14565d21") },
                    { new Guid("120a9b81-0f3a-4a68-8b3b-83e3dac9b6cf"), "Escobar", "Aaron", new Guid("ef6c5692-9813-439b-aa2e-d77ebe9e2d67"), "Worm", "Eduardo", new Guid("0adeff61-3aed-416e-a452-4f6e14565d21") },
                    { new Guid("12631c61-889b-4ffe-b3b4-ff78ccc31137"), "Faringtom", "Dylan", new Guid("ef6c5692-9813-439b-aa2e-d77ebe9e2d67"), "Snow", "Emilio", new Guid("0adeff61-3aed-416e-a452-4f6e14565d21") }
                });
        }
    }
}
