using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Adding_FavoriteActivities_to_Kid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "FavoriteActivities",
                table: "Kid",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("1588cf77-df21-416c-a7d8-f8d402ebaab8"), "KPH" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("1949de07-e92c-4897-892f-1f78be1dabf2"), null, "Gregorio de Jesus", "Rojas Acosta", null, null, null });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("ca489c14-8eeb-46d3-8e06-13be3d48b00c"), null, "Yadira", "Pinales Delgado", null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityTemplate",
                columns: new[] { "Id", "Description", "KindergarterId" },
                values: new object[,]
                {
                    { new Guid("3b62d539-7ffc-41ec-a780-ec4e77b1ce20"), "Clases de ingles", new Guid("1588cf77-df21-416c-a7d8-f8d402ebaab8") },
                    { new Guid("be91e60b-2969-457a-8def-6ced38b414d6"), "Cuidade matutino", new Guid("1588cf77-df21-416c-a7d8-f8d402ebaab8") },
                    { new Guid("9a2812e8-6810-4b74-a60f-860ccc31e5c4"), "Cuidado Vespertino", new Guid("1588cf77-df21-416c-a7d8-f8d402ebaab8") },
                    { new Guid("8bf18490-06ac-4ef8-8e3a-d5ff13e3fd86"), "Cuidado dia completo", new Guid("1588cf77-df21-416c-a7d8-f8d402ebaab8") },
                    { new Guid("9ad7bf47-9147-4a75-9e68-a2b113d43d60"), "Clases de Ballet", new Guid("1588cf77-df21-416c-a7d8-f8d402ebaab8") },
                    { new Guid("a43aa05f-797f-47ce-be68-1003dc3a113d"), "Clases de logica", new Guid("1588cf77-df21-416c-a7d8-f8d402ebaab8") }
                });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "Address", "BirthDate", "FatherName", "FavoriteActivities", "FirstName", "KindergarterId", "MotherName", "SecondName", "TutorId" },
                values: new object[,]
                {
                    { new Guid("01a3fef1-eaf7-41c4-9bd7-e908c30abda5"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Faringtom", null, "Johan", new Guid("1588cf77-df21-416c-a7d8-f8d402ebaab8"), "Worm", "Eduardo", new Guid("1949de07-e92c-4897-892f-1f78be1dabf2") },
                    { new Guid("05182b77-1f84-4b81-9e61-e75435b87fd1"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Escobar", null, "Dylan", new Guid("1588cf77-df21-416c-a7d8-f8d402ebaab8"), "Washinton", "Emilio", new Guid("1949de07-e92c-4897-892f-1f78be1dabf2") },
                    { new Guid("056bba8a-98ec-4147-955f-5a3684927556"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee", null, "Aaron", new Guid("1588cf77-df21-416c-a7d8-f8d402ebaab8"), "Washinton", "Enrique", new Guid("1949de07-e92c-4897-892f-1f78be1dabf2") },
                    { new Guid("05e13b0c-ea29-49d0-8795-a65c2a77934a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Faringtom", null, "Lyan", new Guid("1588cf77-df21-416c-a7d8-f8d402ebaab8"), "White", "Eduardo", new Guid("1949de07-e92c-4897-892f-1f78be1dabf2") },
                    { new Guid("06547ee0-39e1-47f4-b10d-942e63ad3614"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Escobar", null, "Johan", new Guid("1588cf77-df21-416c-a7d8-f8d402ebaab8"), "Worm", "Emilio", new Guid("1949de07-e92c-4897-892f-1f78be1dabf2") },
                    { new Guid("065e0aa0-fdf1-43cf-9d7a-fd848657627b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Faringtom", null, "Lyan", new Guid("1588cf77-df21-416c-a7d8-f8d402ebaab8"), "Snow", "Emilio", new Guid("1949de07-e92c-4897-892f-1f78be1dabf2") },
                    { new Guid("08795253-b933-46b2-8865-385a4b4567d7"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Escobar", null, "Lyan", new Guid("1588cf77-df21-416c-a7d8-f8d402ebaab8"), "Snow", "Emilio", new Guid("1949de07-e92c-4897-892f-1f78be1dabf2") },
                    { new Guid("0900b090-199f-4b9d-9f01-15f325e9b5e8"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stackeetam", null, "Johan", new Guid("1588cf77-df21-416c-a7d8-f8d402ebaab8"), "Snow", "Eduardo", new Guid("1949de07-e92c-4897-892f-1f78be1dabf2") },
                    { new Guid("090e53fd-9af6-49b5-a2a6-bc0948136e7f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Faringtom", null, "Aaron", new Guid("1588cf77-df21-416c-a7d8-f8d402ebaab8"), "White", "Eduardo", new Guid("1949de07-e92c-4897-892f-1f78be1dabf2") },
                    { new Guid("0a1620c0-aba1-4786-a2cb-2b9d2ee1ec45"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee", null, "Dylan", new Guid("1588cf77-df21-416c-a7d8-f8d402ebaab8"), "Snow", "Enrique", new Guid("1949de07-e92c-4897-892f-1f78be1dabf2") }
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "Id", "ActivityTemplateId", "Description" },
                values: new object[,]
                {
                    { new Guid("bf3d24bc-38d3-4192-940e-0047bfc0d8ac"), new Guid("3b62d539-7ffc-41ec-a780-ec4e77b1ce20"), "Clases de ingles" },
                    { new Guid("b7614181-f95d-4c79-88bb-953cd05e8cf8"), new Guid("be91e60b-2969-457a-8def-6ced38b414d6"), "Cuidade matutino" },
                    { new Guid("e85a6f41-6322-471f-b02d-502bbba378fc"), new Guid("9a2812e8-6810-4b74-a60f-860ccc31e5c4"), "Cuidado Vespertino" },
                    { new Guid("a995b2ac-a212-4ba6-925f-f8ed1028fe27"), new Guid("8bf18490-06ac-4ef8-8e3a-d5ff13e3fd86"), "Cuidado dia completo" },
                    { new Guid("3251825f-8d74-45ef-94c4-8fdc7876024c"), new Guid("9ad7bf47-9147-4a75-9e68-a2b113d43d60"), "Clases de Ballet" },
                    { new Guid("d04c4313-77df-44ee-b660-209c45f05a54"), new Guid("a43aa05f-797f-47ce-be68-1003dc3a113d"), "Clases de logica" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "Comment", "EnrollDay", "KidId" },
                values: new object[,]
                {
                    { new Guid("a1cb17d8-df5f-4f78-baac-484c5fd3b763"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("01a3fef1-eaf7-41c4-9bd7-e908c30abda5") },
                    { new Guid("b5b5d820-a63c-4fc3-bbbd-24a61c171663"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("05182b77-1f84-4b81-9e61-e75435b87fd1") },
                    { new Guid("94ee1898-2358-4619-85c6-8438bd5572aa"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("056bba8a-98ec-4147-955f-5a3684927556") },
                    { new Guid("a88db378-015e-4fc5-95db-40a26cd7aabd"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("05e13b0c-ea29-49d0-8795-a65c2a77934a") },
                    { new Guid("7e445422-4532-48ba-9fd7-585eac7e961e"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("06547ee0-39e1-47f4-b10d-942e63ad3614") }
                });

            migrationBuilder.InsertData(
                table: "EnrollActivity",
                columns: new[] { "Id", "ActivityId", "EnrollmentId" },
                values: new object[,]
                {
                    { new Guid("cd33f4a4-2acd-45f1-949f-d6c793db3236"), new Guid("a995b2ac-a212-4ba6-925f-f8ed1028fe27"), new Guid("a1cb17d8-df5f-4f78-baac-484c5fd3b763") },
                    { new Guid("db5eccc3-9834-4df6-bb7c-714b90917597"), new Guid("bf3d24bc-38d3-4192-940e-0047bfc0d8ac"), new Guid("b5b5d820-a63c-4fc3-bbbd-24a61c171663") },
                    { new Guid("b3ebae2f-a2b9-468f-83f0-edf2d561afb2"), new Guid("bf3d24bc-38d3-4192-940e-0047bfc0d8ac"), new Guid("94ee1898-2358-4619-85c6-8438bd5572aa") },
                    { new Guid("6265ffd0-62e9-4d18-a6b7-d109182d51fe"), new Guid("d04c4313-77df-44ee-b660-209c45f05a54"), new Guid("a88db378-015e-4fc5-95db-40a26cd7aabd") },
                    { new Guid("ffbf909e-88a2-438c-87db-6859e999b662"), new Guid("d04c4313-77df-44ee-b660-209c45f05a54"), new Guid("7e445422-4532-48ba-9fd7-585eac7e961e") }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Price", "Reference", "ActivityId", "Description", "ServicePeriod" },
                values: new object[,]
                {
                    { new Guid("2b1b56f3-0b0e-469c-90e3-5e6f489270f8"), "Service", 2538m, "SRV-422", new Guid("bf3d24bc-38d3-4192-940e-0047bfc0d8ac"), "Service Clases de ingles", 77 },
                    { new Guid("e1e882be-bdba-4c1b-9fb0-cff8492fe7fd"), "Service", 4776m, "SRV-228", new Guid("b7614181-f95d-4c79-88bb-953cd05e8cf8"), "Service Cuidade matutino", 77 },
                    { new Guid("72b3e906-da55-4b93-82dc-33e1a3dfce8e"), "Service", 1448m, "SRV-987", new Guid("e85a6f41-6322-471f-b02d-502bbba378fc"), "Service Cuidado Vespertino", 77 },
                    { new Guid("db1f8c8c-c980-4591-bd29-7f2b901e7610"), "Service", 892m, "SRV-547", new Guid("a995b2ac-a212-4ba6-925f-f8ed1028fe27"), "Service Cuidado dia completo", 77 },
                    { new Guid("ec49407e-071f-47d7-8dab-13ea8210181e"), "Service", 4517m, "SRV-802", new Guid("3251825f-8d74-45ef-94c4-8fdc7876024c"), "Service Clases de Ballet", 77 },
                    { new Guid("9731ab1d-05f1-4a40-8408-9a45d40702be"), "Service", 3996m, "SRV-821", new Guid("d04c4313-77df-44ee-b660-209c45f05a54"), "Service Clases de logica", 77 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("6265ffd0-62e9-4d18-a6b7-d109182d51fe"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("b3ebae2f-a2b9-468f-83f0-edf2d561afb2"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("cd33f4a4-2acd-45f1-949f-d6c793db3236"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("db5eccc3-9834-4df6-bb7c-714b90917597"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("ffbf909e-88a2-438c-87db-6859e999b662"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("2b1b56f3-0b0e-469c-90e3-5e6f489270f8"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("72b3e906-da55-4b93-82dc-33e1a3dfce8e"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("9731ab1d-05f1-4a40-8408-9a45d40702be"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("db1f8c8c-c980-4591-bd29-7f2b901e7610"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("e1e882be-bdba-4c1b-9fb0-cff8492fe7fd"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("ec49407e-071f-47d7-8dab-13ea8210181e"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("065e0aa0-fdf1-43cf-9d7a-fd848657627b"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("08795253-b933-46b2-8865-385a4b4567d7"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0900b090-199f-4b9d-9f01-15f325e9b5e8"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("090e53fd-9af6-49b5-a2a6-bc0948136e7f"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0a1620c0-aba1-4786-a2cb-2b9d2ee1ec45"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("ca489c14-8eeb-46d3-8e06-13be3d48b00c"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("3251825f-8d74-45ef-94c4-8fdc7876024c"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("a995b2ac-a212-4ba6-925f-f8ed1028fe27"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("b7614181-f95d-4c79-88bb-953cd05e8cf8"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("bf3d24bc-38d3-4192-940e-0047bfc0d8ac"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("d04c4313-77df-44ee-b660-209c45f05a54"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("e85a6f41-6322-471f-b02d-502bbba378fc"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("7e445422-4532-48ba-9fd7-585eac7e961e"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("94ee1898-2358-4619-85c6-8438bd5572aa"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("a1cb17d8-df5f-4f78-baac-484c5fd3b763"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("a88db378-015e-4fc5-95db-40a26cd7aabd"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("b5b5d820-a63c-4fc3-bbbd-24a61c171663"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("3b62d539-7ffc-41ec-a780-ec4e77b1ce20"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("8bf18490-06ac-4ef8-8e3a-d5ff13e3fd86"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("9a2812e8-6810-4b74-a60f-860ccc31e5c4"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("9ad7bf47-9147-4a75-9e68-a2b113d43d60"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("a43aa05f-797f-47ce-be68-1003dc3a113d"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("be91e60b-2969-457a-8def-6ced38b414d6"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("01a3fef1-eaf7-41c4-9bd7-e908c30abda5"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("05182b77-1f84-4b81-9e61-e75435b87fd1"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("056bba8a-98ec-4147-955f-5a3684927556"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("05e13b0c-ea29-49d0-8795-a65c2a77934a"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("06547ee0-39e1-47f4-b10d-942e63ad3614"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("1588cf77-df21-416c-a7d8-f8d402ebaab8"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("1949de07-e92c-4897-892f-1f78be1dabf2"));

            migrationBuilder.DropColumn(
                name: "FavoriteActivities",
                table: "Kid");

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
    }
}
