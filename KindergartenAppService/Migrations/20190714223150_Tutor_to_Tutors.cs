using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Tutor_to_Tutors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kid_Tutor_TutorId",
                table: "Kid");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tutor",
                table: "Tutor");

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

            migrationBuilder.RenameTable(
                name: "Tutor",
                newName: "Tutors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tutors",
                table: "Tutors",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Kid_Tutors_TutorId",
                table: "Kid",
                column: "TutorId",
                principalTable: "Tutors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kid_Tutors_TutorId",
                table: "Kid");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tutors",
                table: "Tutors");

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

            migrationBuilder.RenameTable(
                name: "Tutors",
                newName: "Tutor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tutor",
                table: "Tutor",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Kid_Tutor_TutorId",
                table: "Kid",
                column: "TutorId",
                principalTable: "Tutor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
