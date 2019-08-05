using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Adding_BirthDate_to_Kid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("1161efa7-9a2c-4467-8ef2-1e76c5d8412a"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("1fc966ff-3464-4f2f-ae84-87fc2360dabf"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("a65bd27c-7704-493b-8f6e-994a909323ed"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("b67ff89c-cb72-4c0b-9840-5e3b17fc7e61"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("d4a69bc5-f187-4aaa-8c25-ddc1de7ade25"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("18db18b4-3164-4497-944e-023711df4424"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("3d7abb96-de7f-44c5-b075-42d5ecad5066"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("6004b02f-65f2-43f1-9109-7fcee558bf6c"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("8b14c5fe-a711-4fd9-9e51-221ce33f76d9"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("ac3a8e16-9a6b-49f5-a176-923edc4fcf17"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("dbcce2c0-fca3-4ce9-b231-040a46b7e1ca"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("06baad3e-ea74-40da-b2a7-c7141bcb9c70"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("08b40c54-4bdc-40d1-9efc-eab5919828b3"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("096f35e9-3f28-4fb6-a274-4444fc9eb6e4"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0b4bf8c3-a2a9-4580-b056-f95e1ee4364f"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0b6b127f-d33e-4879-8f23-175180f08f8f"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("8bf7419e-950c-4866-b96a-17b0514bb2e1"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("06a5d035-f3ce-417c-8dbd-e9f4ca81eea6"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("74a34b47-ca19-4af5-b29e-41fa52c8d5d6"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("775c206c-0bb0-49aa-9b2e-adba07e55d7b"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("81a8ea27-a4d2-417e-8178-28fbcb9c4c30"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("ac4aca9b-a9cd-48a3-9d4e-79338e7c9368"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("d4f3fe31-a463-45a1-873e-b0b91d4d0e22"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("13fb1ce8-8290-4433-9839-77f98e812773"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("22c9e6ba-b9d0-412c-980a-3b549ee4ccd4"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("9f04635e-df2b-4afe-b6ee-3768acc0b181"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("eca44541-ee6a-4361-a7c0-6b82eb9c5de8"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("f2affcab-d1c7-4419-a9cf-8b06ddb24585"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("27898f26-db98-49d3-a237-623357fa77c6"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("425312bc-f796-4aaa-b2d7-316a46fb3970"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("7231b674-23c0-42e3-8b2d-72f326f1983d"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("7be9657d-67a7-4821-9607-4d800c719dd1"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("92e4b1c7-6893-4b6a-809a-2e23ca2208ee"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("b5322eab-3f8f-446c-bf51-9384359a7027"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("009ca332-3223-4944-8d86-f0a302c01d7d"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("009cfc4d-2169-4046-92d9-d1915cf4f514"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("023a9889-3ee8-4ddc-9581-5569f9a31b80"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("033e312a-ece5-474f-9c69-a07163db1975"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("06146d3a-b87a-4c68-a630-908c6998dfaa"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("a6e5a2ca-4b40-4344-9913-bf1f402563be"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("e70fa540-30cf-4c91-8331-897eec5b1cc3"));

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Kid",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("4768f955-3a2a-4c94-aa9a-85c0f2ec2705"), "KPH" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("bb5d8000-bc2a-47dd-9279-b20e63258b0b"), null, "Gregorio de Jesus", "Rojas Acosta", null, null, null });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("b0286bf5-d928-4f53-8357-627e49f48de0"), null, "Yadira", "Pinales Delgado", null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityTemplate",
                columns: new[] { "Id", "Description", "KindergarterId" },
                values: new object[,]
                {
                    { new Guid("6445b41e-703d-43e0-bd61-9b5da9c000d4"), "Clases de ingles", new Guid("4768f955-3a2a-4c94-aa9a-85c0f2ec2705") },
                    { new Guid("34f79d9f-cb86-4630-a902-5112255cb14b"), "Cuidade matutino", new Guid("4768f955-3a2a-4c94-aa9a-85c0f2ec2705") },
                    { new Guid("2f7da22f-d8ff-434e-a809-9be2bfa4e336"), "Cuidado Vespertino", new Guid("4768f955-3a2a-4c94-aa9a-85c0f2ec2705") },
                    { new Guid("965fa3ce-d2ba-4bf2-a86a-017e68fc1f88"), "Cuidado dia completo", new Guid("4768f955-3a2a-4c94-aa9a-85c0f2ec2705") },
                    { new Guid("a7a84b8d-8994-486d-af9f-108e3a143371"), "Clases de Ballet", new Guid("4768f955-3a2a-4c94-aa9a-85c0f2ec2705") },
                    { new Guid("d4e06d32-38be-448c-8d2f-f6fb53c435fb"), "Clases de logica", new Guid("4768f955-3a2a-4c94-aa9a-85c0f2ec2705") }
                });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "BirthDate", "FatherName", "FirstName", "KindergarterId", "MotherName", "SecondName", "TutorId" },
                values: new object[,]
                {
                    { new Guid("006708aa-007c-4658-9a05-6446f66fe54f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stackeetam", "Johan", new Guid("4768f955-3a2a-4c94-aa9a-85c0f2ec2705"), "Washinton", "Carlos", new Guid("bb5d8000-bc2a-47dd-9279-b20e63258b0b") },
                    { new Guid("013d0f8c-964b-4a96-9c16-fa0645bf3e65"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Escobar", "Dylan", new Guid("4768f955-3a2a-4c94-aa9a-85c0f2ec2705"), "Worm", "Enrique", new Guid("bb5d8000-bc2a-47dd-9279-b20e63258b0b") },
                    { new Guid("0156dcd6-557d-4b9b-8339-bf90522f8265"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stackeetam", "Lyan", new Guid("4768f955-3a2a-4c94-aa9a-85c0f2ec2705"), "White", "Eduardo", new Guid("bb5d8000-bc2a-47dd-9279-b20e63258b0b") },
                    { new Guid("0169e738-7e2d-4e3d-92fc-88ddf334f4ec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Escobar", "Lyan", new Guid("4768f955-3a2a-4c94-aa9a-85c0f2ec2705"), "White", "Carlos", new Guid("bb5d8000-bc2a-47dd-9279-b20e63258b0b") },
                    { new Guid("0181bebe-94c4-4556-9cf0-7efc9f41156c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stackeetam", "Lyan", new Guid("4768f955-3a2a-4c94-aa9a-85c0f2ec2705"), "White", "Emilio", new Guid("bb5d8000-bc2a-47dd-9279-b20e63258b0b") },
                    { new Guid("0253b70d-39e8-47aa-9384-cb8fda12a06c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stackeetam", "Dylan", new Guid("4768f955-3a2a-4c94-aa9a-85c0f2ec2705"), "Worm", "Eduardo", new Guid("bb5d8000-bc2a-47dd-9279-b20e63258b0b") },
                    { new Guid("03ac5cfc-6f05-47a7-bfac-0d4452dba54c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Faringtom", "Johan", new Guid("4768f955-3a2a-4c94-aa9a-85c0f2ec2705"), "Snow", "Carlos", new Guid("bb5d8000-bc2a-47dd-9279-b20e63258b0b") },
                    { new Guid("046378b5-79fc-4138-9239-1cb43c81feaf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stackeetam", "Lyan", new Guid("4768f955-3a2a-4c94-aa9a-85c0f2ec2705"), "Worm", "Enrique", new Guid("bb5d8000-bc2a-47dd-9279-b20e63258b0b") },
                    { new Guid("046b8794-01ab-4b3a-b9bc-66ac3cf683e8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Faringtom", "Lyan", new Guid("4768f955-3a2a-4c94-aa9a-85c0f2ec2705"), "White", "Emilio", new Guid("bb5d8000-bc2a-47dd-9279-b20e63258b0b") },
                    { new Guid("05952a27-549f-4132-bb82-05e245021607"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee", "Aaron", new Guid("4768f955-3a2a-4c94-aa9a-85c0f2ec2705"), "Snow", "Eduardo", new Guid("bb5d8000-bc2a-47dd-9279-b20e63258b0b") }
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "Id", "ActivityTemplateId", "Description" },
                values: new object[,]
                {
                    { new Guid("8b88105b-c876-4a28-87d7-1f3d0322a0a1"), new Guid("6445b41e-703d-43e0-bd61-9b5da9c000d4"), "Clases de ingles" },
                    { new Guid("0cd9815a-7009-4030-8dbb-0154b54f688f"), new Guid("34f79d9f-cb86-4630-a902-5112255cb14b"), "Cuidade matutino" },
                    { new Guid("d5188193-9818-4456-a285-79d5c999fa2d"), new Guid("2f7da22f-d8ff-434e-a809-9be2bfa4e336"), "Cuidado Vespertino" },
                    { new Guid("d42deb14-3394-4985-89ff-331183a5695b"), new Guid("965fa3ce-d2ba-4bf2-a86a-017e68fc1f88"), "Cuidado dia completo" },
                    { new Guid("4cdc7f6b-21e3-4d66-828c-85cb5dc95dc6"), new Guid("a7a84b8d-8994-486d-af9f-108e3a143371"), "Clases de Ballet" },
                    { new Guid("aae44eba-e3d8-40ec-958c-00cf40889477"), new Guid("d4e06d32-38be-448c-8d2f-f6fb53c435fb"), "Clases de logica" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "Comment", "EnrollDay", "KidId" },
                values: new object[,]
                {
                    { new Guid("b96c00a4-a7b7-4d87-b9e1-b3cc3914f7e6"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("006708aa-007c-4658-9a05-6446f66fe54f") },
                    { new Guid("9bc99801-c966-4050-bf1a-4be92d535027"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("013d0f8c-964b-4a96-9c16-fa0645bf3e65") },
                    { new Guid("b0e86651-5a50-426f-a499-6f9b44f8a682"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0156dcd6-557d-4b9b-8339-bf90522f8265") },
                    { new Guid("4c369bda-8931-420a-b048-583bc5dcff76"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0169e738-7e2d-4e3d-92fc-88ddf334f4ec") },
                    { new Guid("ca921d2d-6c3d-4e4f-b7f8-c3c65f6cd7a1"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0181bebe-94c4-4556-9cf0-7efc9f41156c") }
                });

            migrationBuilder.InsertData(
                table: "EnrollActivity",
                columns: new[] { "Id", "ActivityId", "EnrollmentId" },
                values: new object[,]
                {
                    { new Guid("176b4594-3fa2-4291-a621-600edecc7d36"), new Guid("d5188193-9818-4456-a285-79d5c999fa2d"), new Guid("b96c00a4-a7b7-4d87-b9e1-b3cc3914f7e6") },
                    { new Guid("f7387356-ba8d-449e-b735-06c33b7b289d"), new Guid("aae44eba-e3d8-40ec-958c-00cf40889477"), new Guid("9bc99801-c966-4050-bf1a-4be92d535027") },
                    { new Guid("1b5e670b-ce8d-4517-9361-9ee0e8c2dab0"), new Guid("d42deb14-3394-4985-89ff-331183a5695b"), new Guid("b0e86651-5a50-426f-a499-6f9b44f8a682") },
                    { new Guid("07fdbcb0-14e4-4e57-97bc-84c1c7f2cf4b"), new Guid("4cdc7f6b-21e3-4d66-828c-85cb5dc95dc6"), new Guid("4c369bda-8931-420a-b048-583bc5dcff76") },
                    { new Guid("940a15f8-6248-4e5c-ae02-b86f7add694b"), new Guid("8b88105b-c876-4a28-87d7-1f3d0322a0a1"), new Guid("ca921d2d-6c3d-4e4f-b7f8-c3c65f6cd7a1") }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Price", "Reference", "ActivityId", "Description", "ServicePeriod" },
                values: new object[,]
                {
                    { new Guid("45249a36-feb2-492d-b718-47012ff8ee25"), "Service", 9071m, "SRV-553", new Guid("8b88105b-c876-4a28-87d7-1f3d0322a0a1"), "Service Clases de ingles", 77 },
                    { new Guid("58e5a707-829e-4bae-9779-c0426ff22630"), "Service", 2915m, "SRV-513", new Guid("0cd9815a-7009-4030-8dbb-0154b54f688f"), "Service Cuidade matutino", 77 },
                    { new Guid("3a52e074-9395-4606-8b81-4d3c621b359e"), "Service", 5167m, "SRV-880", new Guid("d5188193-9818-4456-a285-79d5c999fa2d"), "Service Cuidado Vespertino", 77 },
                    { new Guid("b52b5d61-3c31-417e-83c6-b361ab064ed6"), "Service", 5901m, "SRV-668", new Guid("d42deb14-3394-4985-89ff-331183a5695b"), "Service Cuidado dia completo", 77 },
                    { new Guid("434e8ff8-6dab-4f98-bfd1-2118d53e3032"), "Service", 2220m, "SRV-823", new Guid("4cdc7f6b-21e3-4d66-828c-85cb5dc95dc6"), "Service Clases de Ballet", 77 },
                    { new Guid("a05e44d1-a5de-4ad9-b0e2-928abb51b1cd"), "Service", 8063m, "SRV-257", new Guid("aae44eba-e3d8-40ec-958c-00cf40889477"), "Service Clases de logica", 77 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("07fdbcb0-14e4-4e57-97bc-84c1c7f2cf4b"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("176b4594-3fa2-4291-a621-600edecc7d36"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("1b5e670b-ce8d-4517-9361-9ee0e8c2dab0"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("940a15f8-6248-4e5c-ae02-b86f7add694b"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("f7387356-ba8d-449e-b735-06c33b7b289d"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("3a52e074-9395-4606-8b81-4d3c621b359e"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("434e8ff8-6dab-4f98-bfd1-2118d53e3032"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("45249a36-feb2-492d-b718-47012ff8ee25"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("58e5a707-829e-4bae-9779-c0426ff22630"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("a05e44d1-a5de-4ad9-b0e2-928abb51b1cd"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("b52b5d61-3c31-417e-83c6-b361ab064ed6"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0253b70d-39e8-47aa-9384-cb8fda12a06c"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("03ac5cfc-6f05-47a7-bfac-0d4452dba54c"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("046378b5-79fc-4138-9239-1cb43c81feaf"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("046b8794-01ab-4b3a-b9bc-66ac3cf683e8"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("05952a27-549f-4132-bb82-05e245021607"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("b0286bf5-d928-4f53-8357-627e49f48de0"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("0cd9815a-7009-4030-8dbb-0154b54f688f"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("4cdc7f6b-21e3-4d66-828c-85cb5dc95dc6"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("8b88105b-c876-4a28-87d7-1f3d0322a0a1"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("aae44eba-e3d8-40ec-958c-00cf40889477"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("d42deb14-3394-4985-89ff-331183a5695b"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("d5188193-9818-4456-a285-79d5c999fa2d"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("4c369bda-8931-420a-b048-583bc5dcff76"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("9bc99801-c966-4050-bf1a-4be92d535027"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("b0e86651-5a50-426f-a499-6f9b44f8a682"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("b96c00a4-a7b7-4d87-b9e1-b3cc3914f7e6"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("ca921d2d-6c3d-4e4f-b7f8-c3c65f6cd7a1"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("2f7da22f-d8ff-434e-a809-9be2bfa4e336"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("34f79d9f-cb86-4630-a902-5112255cb14b"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("6445b41e-703d-43e0-bd61-9b5da9c000d4"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("965fa3ce-d2ba-4bf2-a86a-017e68fc1f88"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("a7a84b8d-8994-486d-af9f-108e3a143371"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("d4e06d32-38be-448c-8d2f-f6fb53c435fb"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("006708aa-007c-4658-9a05-6446f66fe54f"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("013d0f8c-964b-4a96-9c16-fa0645bf3e65"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0156dcd6-557d-4b9b-8339-bf90522f8265"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0169e738-7e2d-4e3d-92fc-88ddf334f4ec"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0181bebe-94c4-4556-9cf0-7efc9f41156c"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("4768f955-3a2a-4c94-aa9a-85c0f2ec2705"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("bb5d8000-bc2a-47dd-9279-b20e63258b0b"));

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Kid");

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("a6e5a2ca-4b40-4344-9913-bf1f402563be"), "KPH" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("e70fa540-30cf-4c91-8331-897eec5b1cc3"), null, "Gregorio de Jesus", "Rojas Acosta", null, null, null });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("8bf7419e-950c-4866-b96a-17b0514bb2e1"), null, "Yadira", "Pinales Delgado", null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityTemplate",
                columns: new[] { "Id", "Description", "KindergarterId" },
                values: new object[,]
                {
                    { new Guid("27898f26-db98-49d3-a237-623357fa77c6"), "Clases de ingles", new Guid("a6e5a2ca-4b40-4344-9913-bf1f402563be") },
                    { new Guid("7231b674-23c0-42e3-8b2d-72f326f1983d"), "Cuidade matutino", new Guid("a6e5a2ca-4b40-4344-9913-bf1f402563be") },
                    { new Guid("425312bc-f796-4aaa-b2d7-316a46fb3970"), "Cuidado Vespertino", new Guid("a6e5a2ca-4b40-4344-9913-bf1f402563be") },
                    { new Guid("b5322eab-3f8f-446c-bf51-9384359a7027"), "Cuidado dia completo", new Guid("a6e5a2ca-4b40-4344-9913-bf1f402563be") },
                    { new Guid("92e4b1c7-6893-4b6a-809a-2e23ca2208ee"), "Clases de Ballet", new Guid("a6e5a2ca-4b40-4344-9913-bf1f402563be") },
                    { new Guid("7be9657d-67a7-4821-9607-4d800c719dd1"), "Clases de logica", new Guid("a6e5a2ca-4b40-4344-9913-bf1f402563be") }
                });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "BirthDateTwo", "FatherName", "FirstName", "KindergarterId", "MotherName", "SecondName", "TutorId" },
                values: new object[,]
                {
                    { new Guid("009ca332-3223-4944-8d86-f0a302c01d7d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee", "Johan", new Guid("a6e5a2ca-4b40-4344-9913-bf1f402563be"), "Worm", "Emilio", new Guid("e70fa540-30cf-4c91-8331-897eec5b1cc3") },
                    { new Guid("009cfc4d-2169-4046-92d9-d1915cf4f514"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stackeetam", "Johan", new Guid("a6e5a2ca-4b40-4344-9913-bf1f402563be"), "Washinton", "Carlos", new Guid("e70fa540-30cf-4c91-8331-897eec5b1cc3") },
                    { new Guid("023a9889-3ee8-4ddc-9581-5569f9a31b80"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Escobar", "Johan", new Guid("a6e5a2ca-4b40-4344-9913-bf1f402563be"), "Snow", "Eduardo", new Guid("e70fa540-30cf-4c91-8331-897eec5b1cc3") },
                    { new Guid("033e312a-ece5-474f-9c69-a07163db1975"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Escobar", "Aaron", new Guid("a6e5a2ca-4b40-4344-9913-bf1f402563be"), "White", "Eduardo", new Guid("e70fa540-30cf-4c91-8331-897eec5b1cc3") },
                    { new Guid("06146d3a-b87a-4c68-a630-908c6998dfaa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Faringtom", "Johan", new Guid("a6e5a2ca-4b40-4344-9913-bf1f402563be"), "Snow", "Eduardo", new Guid("e70fa540-30cf-4c91-8331-897eec5b1cc3") },
                    { new Guid("06baad3e-ea74-40da-b2a7-c7141bcb9c70"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stackeetam", "Dylan", new Guid("a6e5a2ca-4b40-4344-9913-bf1f402563be"), "White", "Enrique", new Guid("e70fa540-30cf-4c91-8331-897eec5b1cc3") },
                    { new Guid("08b40c54-4bdc-40d1-9efc-eab5919828b3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stackeetam", "Lyan", new Guid("a6e5a2ca-4b40-4344-9913-bf1f402563be"), "Worm", "Carlos", new Guid("e70fa540-30cf-4c91-8331-897eec5b1cc3") },
                    { new Guid("096f35e9-3f28-4fb6-a274-4444fc9eb6e4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Faringtom", "Aaron", new Guid("a6e5a2ca-4b40-4344-9913-bf1f402563be"), "White", "Carlos", new Guid("e70fa540-30cf-4c91-8331-897eec5b1cc3") },
                    { new Guid("0b4bf8c3-a2a9-4580-b056-f95e1ee4364f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee", "Johan", new Guid("a6e5a2ca-4b40-4344-9913-bf1f402563be"), "White", "Eduardo", new Guid("e70fa540-30cf-4c91-8331-897eec5b1cc3") },
                    { new Guid("0b6b127f-d33e-4879-8f23-175180f08f8f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Faringtom", "Dylan", new Guid("a6e5a2ca-4b40-4344-9913-bf1f402563be"), "Washinton", "Emilio", new Guid("e70fa540-30cf-4c91-8331-897eec5b1cc3") }
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "Id", "ActivityTemplateId", "Description" },
                values: new object[,]
                {
                    { new Guid("81a8ea27-a4d2-417e-8178-28fbcb9c4c30"), new Guid("27898f26-db98-49d3-a237-623357fa77c6"), "Clases de ingles" },
                    { new Guid("775c206c-0bb0-49aa-9b2e-adba07e55d7b"), new Guid("7231b674-23c0-42e3-8b2d-72f326f1983d"), "Cuidade matutino" },
                    { new Guid("d4f3fe31-a463-45a1-873e-b0b91d4d0e22"), new Guid("425312bc-f796-4aaa-b2d7-316a46fb3970"), "Cuidado Vespertino" },
                    { new Guid("06a5d035-f3ce-417c-8dbd-e9f4ca81eea6"), new Guid("b5322eab-3f8f-446c-bf51-9384359a7027"), "Cuidado dia completo" },
                    { new Guid("74a34b47-ca19-4af5-b29e-41fa52c8d5d6"), new Guid("92e4b1c7-6893-4b6a-809a-2e23ca2208ee"), "Clases de Ballet" },
                    { new Guid("ac4aca9b-a9cd-48a3-9d4e-79338e7c9368"), new Guid("7be9657d-67a7-4821-9607-4d800c719dd1"), "Clases de logica" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "Comment", "EnrollDay", "KidId" },
                values: new object[,]
                {
                    { new Guid("22c9e6ba-b9d0-412c-980a-3b549ee4ccd4"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("009ca332-3223-4944-8d86-f0a302c01d7d") },
                    { new Guid("9f04635e-df2b-4afe-b6ee-3768acc0b181"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("009cfc4d-2169-4046-92d9-d1915cf4f514") },
                    { new Guid("eca44541-ee6a-4361-a7c0-6b82eb9c5de8"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("023a9889-3ee8-4ddc-9581-5569f9a31b80") },
                    { new Guid("f2affcab-d1c7-4419-a9cf-8b06ddb24585"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("033e312a-ece5-474f-9c69-a07163db1975") },
                    { new Guid("13fb1ce8-8290-4433-9839-77f98e812773"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("06146d3a-b87a-4c68-a630-908c6998dfaa") }
                });

            migrationBuilder.InsertData(
                table: "EnrollActivity",
                columns: new[] { "Id", "ActivityId", "EnrollmentId" },
                values: new object[,]
                {
                    { new Guid("1fc966ff-3464-4f2f-ae84-87fc2360dabf"), new Guid("d4f3fe31-a463-45a1-873e-b0b91d4d0e22"), new Guid("22c9e6ba-b9d0-412c-980a-3b549ee4ccd4") },
                    { new Guid("d4a69bc5-f187-4aaa-8c25-ddc1de7ade25"), new Guid("74a34b47-ca19-4af5-b29e-41fa52c8d5d6"), new Guid("9f04635e-df2b-4afe-b6ee-3768acc0b181") },
                    { new Guid("b67ff89c-cb72-4c0b-9840-5e3b17fc7e61"), new Guid("74a34b47-ca19-4af5-b29e-41fa52c8d5d6"), new Guid("eca44541-ee6a-4361-a7c0-6b82eb9c5de8") },
                    { new Guid("a65bd27c-7704-493b-8f6e-994a909323ed"), new Guid("81a8ea27-a4d2-417e-8178-28fbcb9c4c30"), new Guid("f2affcab-d1c7-4419-a9cf-8b06ddb24585") },
                    { new Guid("1161efa7-9a2c-4467-8ef2-1e76c5d8412a"), new Guid("81a8ea27-a4d2-417e-8178-28fbcb9c4c30"), new Guid("13fb1ce8-8290-4433-9839-77f98e812773") }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Price", "Reference", "ActivityId", "Description", "ServicePeriod" },
                values: new object[,]
                {
                    { new Guid("dbcce2c0-fca3-4ce9-b231-040a46b7e1ca"), "Service", 5714m, "SRV-29", new Guid("81a8ea27-a4d2-417e-8178-28fbcb9c4c30"), "Service Clases de ingles", 77 },
                    { new Guid("3d7abb96-de7f-44c5-b075-42d5ecad5066"), "Service", 1535m, "SRV-613", new Guid("775c206c-0bb0-49aa-9b2e-adba07e55d7b"), "Service Cuidade matutino", 77 },
                    { new Guid("6004b02f-65f2-43f1-9109-7fcee558bf6c"), "Service", 368m, "SRV-182", new Guid("d4f3fe31-a463-45a1-873e-b0b91d4d0e22"), "Service Cuidado Vespertino", 77 },
                    { new Guid("ac3a8e16-9a6b-49f5-a176-923edc4fcf17"), "Service", 4621m, "SRV-667", new Guid("06a5d035-f3ce-417c-8dbd-e9f4ca81eea6"), "Service Cuidado dia completo", 77 },
                    { new Guid("18db18b4-3164-4497-944e-023711df4424"), "Service", 4351m, "SRV-576", new Guid("74a34b47-ca19-4af5-b29e-41fa52c8d5d6"), "Service Clases de Ballet", 77 },
                    { new Guid("8b14c5fe-a711-4fd9-9e51-221ce33f76d9"), "Service", 9488m, "SRV-219", new Guid("ac4aca9b-a9cd-48a3-9d4e-79338e7c9368"), "Service Clases de logica", 77 }
                });
        }
    }
}
