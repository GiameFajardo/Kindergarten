using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Fixing_tutor_Feeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("001774ba-97bb-4204-bddd-b515d19e8a03"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("013a60bd-b271-4806-a57c-873220a12644"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0175827f-def4-461a-94db-d4b99e462491"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("03048b77-63b4-4e00-9f9c-1bf46d446a1f"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("03946e85-13fb-4726-83af-53f697deac53"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0463f5e4-22e4-48fb-b320-3ddf1fd00670"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("048648ea-2c0d-407e-af53-8201e2cc4690"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("05eb8efe-be0b-4b94-a11e-0ce6b7983e08"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("076b4b50-5beb-4694-872d-5c68527ec96b"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("07cc4334-79e1-4891-9f7f-c1f24a2160f5"));

            migrationBuilder.DeleteData(
                table: "Tutor",
                keyColumn: "Id",
                keyValue: new Guid("cdca05fd-ba01-4a5e-abc8-08bc56941c13"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("ea60a536-4485-483a-a289-6fd389c2b639"));

            migrationBuilder.DeleteData(
                table: "Tutor",
                keyColumn: "Id",
                keyValue: new Guid("83c6a4da-820e-404d-95bf-6d71ef75e7cd"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("ea60a536-4485-483a-a289-6fd389c2b639"), "Guarderia" });

            migrationBuilder.InsertData(
                table: "Tutor",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { new Guid("83c6a4da-820e-404d-95bf-6d71ef75e7cd"), "Gregorio de Jesus", "Rojas Acosta" });

            migrationBuilder.InsertData(
                table: "Tutor",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { new Guid("cdca05fd-ba01-4a5e-abc8-08bc56941c13"), "Yadira", "Pinales Delgado" });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "FatherName", "FirstName", "KindergarterId", "MotherName", "SecondName", "TutorId" },
                values: new object[,]
                {
                    { new Guid("001774ba-97bb-4204-bddd-b515d19e8a03"), "Escobar", "Lyan", new Guid("ea60a536-4485-483a-a289-6fd389c2b639"), "Worm", "Enrique", new Guid("83c6a4da-820e-404d-95bf-6d71ef75e7cd") },
                    { new Guid("013a60bd-b271-4806-a57c-873220a12644"), "Stackeetam", "Lyan", new Guid("ea60a536-4485-483a-a289-6fd389c2b639"), "Worm", "Enrique", new Guid("83c6a4da-820e-404d-95bf-6d71ef75e7cd") },
                    { new Guid("0175827f-def4-461a-94db-d4b99e462491"), "Stackeetam", "Aaron", new Guid("ea60a536-4485-483a-a289-6fd389c2b639"), "White", "Enrique", new Guid("83c6a4da-820e-404d-95bf-6d71ef75e7cd") },
                    { new Guid("03048b77-63b4-4e00-9f9c-1bf46d446a1f"), "Lee", "Johan", new Guid("ea60a536-4485-483a-a289-6fd389c2b639"), "White", "Eduardo", new Guid("83c6a4da-820e-404d-95bf-6d71ef75e7cd") },
                    { new Guid("03946e85-13fb-4726-83af-53f697deac53"), "Lee", "Aaron", new Guid("ea60a536-4485-483a-a289-6fd389c2b639"), "Snow", "Emilio", new Guid("83c6a4da-820e-404d-95bf-6d71ef75e7cd") },
                    { new Guid("0463f5e4-22e4-48fb-b320-3ddf1fd00670"), "Faringtom", "Aaron", new Guid("ea60a536-4485-483a-a289-6fd389c2b639"), "Snow", "Enrique", new Guid("83c6a4da-820e-404d-95bf-6d71ef75e7cd") },
                    { new Guid("048648ea-2c0d-407e-af53-8201e2cc4690"), "Escobar", "Johan", new Guid("ea60a536-4485-483a-a289-6fd389c2b639"), "Washinton", "Enrique", new Guid("83c6a4da-820e-404d-95bf-6d71ef75e7cd") },
                    { new Guid("05eb8efe-be0b-4b94-a11e-0ce6b7983e08"), "Lee", "Lyan", new Guid("ea60a536-4485-483a-a289-6fd389c2b639"), "Snow", "Carlos", new Guid("83c6a4da-820e-404d-95bf-6d71ef75e7cd") },
                    { new Guid("076b4b50-5beb-4694-872d-5c68527ec96b"), "Stackeetam", "Aaron", new Guid("ea60a536-4485-483a-a289-6fd389c2b639"), "Worm", "Emilio", new Guid("83c6a4da-820e-404d-95bf-6d71ef75e7cd") },
                    { new Guid("07cc4334-79e1-4891-9f7f-c1f24a2160f5"), "Faringtom", "Johan", new Guid("ea60a536-4485-483a-a289-6fd389c2b639"), "Washinton", "Emilio", new Guid("83c6a4da-820e-404d-95bf-6d71ef75e7cd") }
                });
        }
    }
}
