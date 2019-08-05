using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Adding_Address_to_Kid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            //migrationBuilder.DropColumn(
            //    name: "BirthDateTwo",
            //    table: "Kid");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Kid",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("c12f407f-c0c8-4533-99ae-3a698b046a1d"), "KPH" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("e6e6ea4a-290f-4d33-9ecc-214b4e2c22f9"), null, "Gregorio de Jesus", "Rojas Acosta", null, null, null });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("95123897-c780-4b70-8a61-22dae8e6c893"), null, "Yadira", "Pinales Delgado", null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityTemplate",
                columns: new[] { "Id", "Description", "KindergarterId" },
                values: new object[,]
                {
                    { new Guid("1b4db843-5320-4546-a515-e275b877501e"), "Clases de ingles", new Guid("c12f407f-c0c8-4533-99ae-3a698b046a1d") },
                    { new Guid("6bc2fcd6-0d5f-422b-b919-d52d3c06a4b5"), "Cuidade matutino", new Guid("c12f407f-c0c8-4533-99ae-3a698b046a1d") },
                    { new Guid("65cd530f-990d-49e2-ab15-e6ba0f748d8b"), "Cuidado Vespertino", new Guid("c12f407f-c0c8-4533-99ae-3a698b046a1d") },
                    { new Guid("b0f5b438-6d53-4aee-bc82-b55c019893c1"), "Cuidado dia completo", new Guid("c12f407f-c0c8-4533-99ae-3a698b046a1d") },
                    { new Guid("dd84798d-49d5-4dd5-a8b6-47601bd22d68"), "Clases de Ballet", new Guid("c12f407f-c0c8-4533-99ae-3a698b046a1d") },
                    { new Guid("15bba733-337b-4dc8-8090-67cfb1bcdd72"), "Clases de logica", new Guid("c12f407f-c0c8-4533-99ae-3a698b046a1d") }
                });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "Address", "BirthDate", "FatherName", "FirstName", "KindergarterId", "MotherName", "SecondName", "TutorId" },
                values: new object[,]
                {
                    { new Guid("0260a65f-4587-43bb-944c-6da64323d71e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Escobar", "Dylan", new Guid("c12f407f-c0c8-4533-99ae-3a698b046a1d"), "Worm", "Eduardo", new Guid("e6e6ea4a-290f-4d33-9ecc-214b4e2c22f9") },
                    { new Guid("04ecc741-2f31-4a63-afc6-08d94e889ec4"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Faringtom", "Lyan", new Guid("c12f407f-c0c8-4533-99ae-3a698b046a1d"), "Snow", "Eduardo", new Guid("e6e6ea4a-290f-4d33-9ecc-214b4e2c22f9") },
                    { new Guid("05875653-33d7-43b9-bba6-868a63d94044"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stackeetam", "Lyan", new Guid("c12f407f-c0c8-4533-99ae-3a698b046a1d"), "White", "Enrique", new Guid("e6e6ea4a-290f-4d33-9ecc-214b4e2c22f9") },
                    { new Guid("05e0812e-55d2-4bce-b236-026da3a861f1"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stackeetam", "Johan", new Guid("c12f407f-c0c8-4533-99ae-3a698b046a1d"), "Snow", "Enrique", new Guid("e6e6ea4a-290f-4d33-9ecc-214b4e2c22f9") },
                    { new Guid("062c57a7-e17b-41c1-91ef-997b3ff021f0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Faringtom", "Lyan", new Guid("c12f407f-c0c8-4533-99ae-3a698b046a1d"), "Washinton", "Eduardo", new Guid("e6e6ea4a-290f-4d33-9ecc-214b4e2c22f9") },
                    { new Guid("06c4e275-e8ef-45d5-bb3f-aa8d5bed5cf1"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee", "Aaron", new Guid("c12f407f-c0c8-4533-99ae-3a698b046a1d"), "Washinton", "Eduardo", new Guid("e6e6ea4a-290f-4d33-9ecc-214b4e2c22f9") },
                    { new Guid("078a6c8c-6fe5-4a08-a58d-0446f1bedf60"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee", "Lyan", new Guid("c12f407f-c0c8-4533-99ae-3a698b046a1d"), "Worm", "Eduardo", new Guid("e6e6ea4a-290f-4d33-9ecc-214b4e2c22f9") },
                    { new Guid("08edee74-5c00-4611-8a64-bfe4e7b72a50"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Faringtom", "Dylan", new Guid("c12f407f-c0c8-4533-99ae-3a698b046a1d"), "Worm", "Carlos", new Guid("e6e6ea4a-290f-4d33-9ecc-214b4e2c22f9") },
                    { new Guid("094751ab-cdb1-417b-905f-9b7b6a2391b2"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Escobar", "Dylan", new Guid("c12f407f-c0c8-4533-99ae-3a698b046a1d"), "Snow", "Eduardo", new Guid("e6e6ea4a-290f-4d33-9ecc-214b4e2c22f9") },
                    { new Guid("09aac835-2105-4c3e-83b4-0b3cc3ba5e5c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee", "Dylan", new Guid("c12f407f-c0c8-4533-99ae-3a698b046a1d"), "Snow", "Emilio", new Guid("e6e6ea4a-290f-4d33-9ecc-214b4e2c22f9") }
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "Id", "ActivityTemplateId", "Description" },
                values: new object[,]
                {
                    { new Guid("17fa9bcf-8116-4eae-84b4-a80ac90b528d"), new Guid("1b4db843-5320-4546-a515-e275b877501e"), "Clases de ingles" },
                    { new Guid("8a0347cd-5c63-4098-b9ad-7140bb393c0b"), new Guid("6bc2fcd6-0d5f-422b-b919-d52d3c06a4b5"), "Cuidade matutino" },
                    { new Guid("372a27eb-caa8-4b7d-ad43-c6acda4cbc80"), new Guid("65cd530f-990d-49e2-ab15-e6ba0f748d8b"), "Cuidado Vespertino" },
                    { new Guid("77bab25a-95e0-4262-a9f4-2b995f4aab45"), new Guid("b0f5b438-6d53-4aee-bc82-b55c019893c1"), "Cuidado dia completo" },
                    { new Guid("20f84f55-799c-4952-b530-6fa9097d8d5f"), new Guid("dd84798d-49d5-4dd5-a8b6-47601bd22d68"), "Clases de Ballet" },
                    { new Guid("45af3b8f-c30c-44ef-aaea-4585a6242d9d"), new Guid("15bba733-337b-4dc8-8090-67cfb1bcdd72"), "Clases de logica" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "Comment", "EnrollDay", "KidId" },
                values: new object[,]
                {
                    { new Guid("863458a7-3470-4e30-818b-19ca28495627"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0260a65f-4587-43bb-944c-6da64323d71e") },
                    { new Guid("4dcfe6cb-3a43-4cef-ab3d-6764e6e22fa7"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("04ecc741-2f31-4a63-afc6-08d94e889ec4") },
                    { new Guid("652b0a04-7338-4b4e-843e-a70517bb4727"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("05875653-33d7-43b9-bba6-868a63d94044") },
                    { new Guid("91199590-8525-41fc-ae14-cca705b280f9"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("05e0812e-55d2-4bce-b236-026da3a861f1") },
                    { new Guid("2ffeb79b-5789-4de8-9590-aebbee14f35d"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("062c57a7-e17b-41c1-91ef-997b3ff021f0") }
                });

            migrationBuilder.InsertData(
                table: "EnrollActivity",
                columns: new[] { "Id", "ActivityId", "EnrollmentId" },
                values: new object[,]
                {
                    { new Guid("8574ff75-33ef-480d-ae3d-e5e30da3b305"), new Guid("372a27eb-caa8-4b7d-ad43-c6acda4cbc80"), new Guid("863458a7-3470-4e30-818b-19ca28495627") },
                    { new Guid("055e065c-b253-457b-aa4f-625a0faf2a27"), new Guid("8a0347cd-5c63-4098-b9ad-7140bb393c0b"), new Guid("4dcfe6cb-3a43-4cef-ab3d-6764e6e22fa7") },
                    { new Guid("347cd0de-f0b3-4ff7-9e3a-69dec64e62c2"), new Guid("17fa9bcf-8116-4eae-84b4-a80ac90b528d"), new Guid("652b0a04-7338-4b4e-843e-a70517bb4727") },
                    { new Guid("b3d30626-e28d-4617-be41-236b51a14d3f"), new Guid("17fa9bcf-8116-4eae-84b4-a80ac90b528d"), new Guid("91199590-8525-41fc-ae14-cca705b280f9") },
                    { new Guid("4eecb2a8-fac5-4a27-a8d2-1ce085615bf9"), new Guid("77bab25a-95e0-4262-a9f4-2b995f4aab45"), new Guid("2ffeb79b-5789-4de8-9590-aebbee14f35d") }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Price", "Reference", "ActivityId", "Description", "ServicePeriod" },
                values: new object[,]
                {
                    { new Guid("9073ca29-75b6-4458-bcdb-c28858e08fc1"), "Service", 1057m, "SRV-8", new Guid("17fa9bcf-8116-4eae-84b4-a80ac90b528d"), "Service Clases de ingles", 77 },
                    { new Guid("5518ef4e-d930-4dbf-a025-397b0b679464"), "Service", 6080m, "SRV-541", new Guid("8a0347cd-5c63-4098-b9ad-7140bb393c0b"), "Service Cuidade matutino", 77 },
                    { new Guid("09d24c2d-5993-4ec2-b04b-866fcc2d82fd"), "Service", 9895m, "SRV-205", new Guid("372a27eb-caa8-4b7d-ad43-c6acda4cbc80"), "Service Cuidado Vespertino", 77 },
                    { new Guid("ca0318c2-d6d5-40e7-a614-d2ff45b2f9a3"), "Service", 418m, "SRV-516", new Guid("77bab25a-95e0-4262-a9f4-2b995f4aab45"), "Service Cuidado dia completo", 77 },
                    { new Guid("197e306d-8e12-4f30-b61c-f857628ee227"), "Service", 3105m, "SRV-817", new Guid("20f84f55-799c-4952-b530-6fa9097d8d5f"), "Service Clases de Ballet", 77 },
                    { new Guid("a9827127-d429-4088-9b03-1f16e6680eda"), "Service", 2662m, "SRV-422", new Guid("45af3b8f-c30c-44ef-aaea-4585a6242d9d"), "Service Clases de logica", 77 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("055e065c-b253-457b-aa4f-625a0faf2a27"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("347cd0de-f0b3-4ff7-9e3a-69dec64e62c2"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("4eecb2a8-fac5-4a27-a8d2-1ce085615bf9"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("8574ff75-33ef-480d-ae3d-e5e30da3b305"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("b3d30626-e28d-4617-be41-236b51a14d3f"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("09d24c2d-5993-4ec2-b04b-866fcc2d82fd"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("197e306d-8e12-4f30-b61c-f857628ee227"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("5518ef4e-d930-4dbf-a025-397b0b679464"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("9073ca29-75b6-4458-bcdb-c28858e08fc1"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("a9827127-d429-4088-9b03-1f16e6680eda"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("ca0318c2-d6d5-40e7-a614-d2ff45b2f9a3"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("06c4e275-e8ef-45d5-bb3f-aa8d5bed5cf1"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("078a6c8c-6fe5-4a08-a58d-0446f1bedf60"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("08edee74-5c00-4611-8a64-bfe4e7b72a50"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("094751ab-cdb1-417b-905f-9b7b6a2391b2"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("09aac835-2105-4c3e-83b4-0b3cc3ba5e5c"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("95123897-c780-4b70-8a61-22dae8e6c893"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("17fa9bcf-8116-4eae-84b4-a80ac90b528d"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("20f84f55-799c-4952-b530-6fa9097d8d5f"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("372a27eb-caa8-4b7d-ad43-c6acda4cbc80"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("45af3b8f-c30c-44ef-aaea-4585a6242d9d"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("77bab25a-95e0-4262-a9f4-2b995f4aab45"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("8a0347cd-5c63-4098-b9ad-7140bb393c0b"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("2ffeb79b-5789-4de8-9590-aebbee14f35d"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("4dcfe6cb-3a43-4cef-ab3d-6764e6e22fa7"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("652b0a04-7338-4b4e-843e-a70517bb4727"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("863458a7-3470-4e30-818b-19ca28495627"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("91199590-8525-41fc-ae14-cca705b280f9"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("15bba733-337b-4dc8-8090-67cfb1bcdd72"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("1b4db843-5320-4546-a515-e275b877501e"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("65cd530f-990d-49e2-ab15-e6ba0f748d8b"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("6bc2fcd6-0d5f-422b-b919-d52d3c06a4b5"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("b0f5b438-6d53-4aee-bc82-b55c019893c1"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("dd84798d-49d5-4dd5-a8b6-47601bd22d68"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0260a65f-4587-43bb-944c-6da64323d71e"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("04ecc741-2f31-4a63-afc6-08d94e889ec4"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("05875653-33d7-43b9-bba6-868a63d94044"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("05e0812e-55d2-4bce-b236-026da3a861f1"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("062c57a7-e17b-41c1-91ef-997b3ff021f0"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("c12f407f-c0c8-4533-99ae-3a698b046a1d"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("e6e6ea4a-290f-4d33-9ecc-214b4e2c22f9"));

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Kid");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDateTwo",
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
                columns: new[] { "Id", "BirthDate", "BirthDateTwo", "FatherName", "FirstName", "KindergarterId", "MotherName", "SecondName", "TutorId" },
                values: new object[,]
                {
                    { new Guid("006708aa-007c-4658-9a05-6446f66fe54f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stackeetam", "Johan", new Guid("4768f955-3a2a-4c94-aa9a-85c0f2ec2705"), "Washinton", "Carlos", new Guid("bb5d8000-bc2a-47dd-9279-b20e63258b0b") },
                    { new Guid("013d0f8c-964b-4a96-9c16-fa0645bf3e65"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Escobar", "Dylan", new Guid("4768f955-3a2a-4c94-aa9a-85c0f2ec2705"), "Worm", "Enrique", new Guid("bb5d8000-bc2a-47dd-9279-b20e63258b0b") },
                    { new Guid("0156dcd6-557d-4b9b-8339-bf90522f8265"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stackeetam", "Lyan", new Guid("4768f955-3a2a-4c94-aa9a-85c0f2ec2705"), "White", "Eduardo", new Guid("bb5d8000-bc2a-47dd-9279-b20e63258b0b") },
                    { new Guid("0169e738-7e2d-4e3d-92fc-88ddf334f4ec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Escobar", "Lyan", new Guid("4768f955-3a2a-4c94-aa9a-85c0f2ec2705"), "White", "Carlos", new Guid("bb5d8000-bc2a-47dd-9279-b20e63258b0b") },
                    { new Guid("0181bebe-94c4-4556-9cf0-7efc9f41156c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stackeetam", "Lyan", new Guid("4768f955-3a2a-4c94-aa9a-85c0f2ec2705"), "White", "Emilio", new Guid("bb5d8000-bc2a-47dd-9279-b20e63258b0b") },
                    { new Guid("0253b70d-39e8-47aa-9384-cb8fda12a06c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stackeetam", "Dylan", new Guid("4768f955-3a2a-4c94-aa9a-85c0f2ec2705"), "Worm", "Eduardo", new Guid("bb5d8000-bc2a-47dd-9279-b20e63258b0b") },
                    { new Guid("03ac5cfc-6f05-47a7-bfac-0d4452dba54c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Faringtom", "Johan", new Guid("4768f955-3a2a-4c94-aa9a-85c0f2ec2705"), "Snow", "Carlos", new Guid("bb5d8000-bc2a-47dd-9279-b20e63258b0b") },
                    { new Guid("046378b5-79fc-4138-9239-1cb43c81feaf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stackeetam", "Lyan", new Guid("4768f955-3a2a-4c94-aa9a-85c0f2ec2705"), "Worm", "Enrique", new Guid("bb5d8000-bc2a-47dd-9279-b20e63258b0b") },
                    { new Guid("046b8794-01ab-4b3a-b9bc-66ac3cf683e8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Faringtom", "Lyan", new Guid("4768f955-3a2a-4c94-aa9a-85c0f2ec2705"), "White", "Emilio", new Guid("bb5d8000-bc2a-47dd-9279-b20e63258b0b") },
                    { new Guid("05952a27-549f-4132-bb82-05e245021607"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee", "Aaron", new Guid("4768f955-3a2a-4c94-aa9a-85c0f2ec2705"), "Snow", "Eduardo", new Guid("bb5d8000-bc2a-47dd-9279-b20e63258b0b") }
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
    }
}
