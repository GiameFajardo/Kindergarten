using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Adding_SiblingCount_to_Kid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "SiblingCount",
                table: "Kid",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c"), "KPH" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("04cbeadb-e000-4b9f-80a0-ee997cbc0bf8"), null, "Gregorio de Jesus", "Rojas Acosta", null, null, null });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("b7370d63-cec0-4d74-b669-d3539140c869"), null, "Yadira", "Pinales Delgado", null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityTemplate",
                columns: new[] { "Id", "Description", "KindergarterId" },
                values: new object[,]
                {
                    { new Guid("7aea95d2-9f9a-4d62-920c-dc442be0af2d"), "Clases de ingles", new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c") },
                    { new Guid("c7a0c679-1717-46f7-9f45-da9153a6a9a4"), "Cuidade matutino", new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c") },
                    { new Guid("fd6e0d8f-f92b-46c7-a37a-501f5528e144"), "Cuidado Vespertino", new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c") },
                    { new Guid("ea3c552b-98df-4e3c-9127-9650639cae76"), "Cuidado dia completo", new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c") },
                    { new Guid("d3d23037-7ae3-4005-8cc2-235acaaf0f54"), "Clases de Ballet", new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c") },
                    { new Guid("66bca942-7b3b-4f3e-831c-b7863268030d"), "Clases de logica", new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c") }
                });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "Address", "BirthDate", "FatherName", "FavoriteActivities", "FirstName", "KindergarterId", "MotherName", "SecondName", "SiblingCount", "TutorId" },
                values: new object[,]
                {
                    { new Guid("012202b9-61ee-494e-9099-ba6bce67aac6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee", null, "Dylan", new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c"), "Snow", "Carlos", 0, new Guid("04cbeadb-e000-4b9f-80a0-ee997cbc0bf8") },
                    { new Guid("0146bf6c-39fa-4e3a-9e9c-2c861384b4a0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Faringtom", null, "Aaron", new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c"), "White", "Carlos", 0, new Guid("04cbeadb-e000-4b9f-80a0-ee997cbc0bf8") },
                    { new Guid("0329e38b-c48c-48d0-9994-295db8ede606"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Faringtom", null, "Johan", new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c"), "Snow", "Eduardo", 0, new Guid("04cbeadb-e000-4b9f-80a0-ee997cbc0bf8") },
                    { new Guid("032fddb7-a66a-44f5-8b72-d89263bd306a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stackeetam", null, "Johan", new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c"), "White", "Carlos", 0, new Guid("04cbeadb-e000-4b9f-80a0-ee997cbc0bf8") },
                    { new Guid("04af1463-3174-4cae-b3c8-f6f85005d269"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee", null, "Aaron", new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c"), "Worm", "Enrique", 0, new Guid("04cbeadb-e000-4b9f-80a0-ee997cbc0bf8") },
                    { new Guid("04e4690b-74b1-48ab-95df-0ac3d46580e0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Escobar", null, "Johan", new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c"), "Snow", "Eduardo", 0, new Guid("04cbeadb-e000-4b9f-80a0-ee997cbc0bf8") },
                    { new Guid("05eada6b-ee1f-415c-927d-5dc9a76a0cd0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Faringtom", null, "Aaron", new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c"), "Washinton", "Emilio", 0, new Guid("04cbeadb-e000-4b9f-80a0-ee997cbc0bf8") },
                    { new Guid("06095d50-99c0-4e5e-88cf-b2434b82276e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Escobar", null, "Lyan", new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c"), "Snow", "Enrique", 0, new Guid("04cbeadb-e000-4b9f-80a0-ee997cbc0bf8") },
                    { new Guid("066f005f-1c36-433a-925b-d4be4688ea0e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Faringtom", null, "Dylan", new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c"), "Worm", "Eduardo", 0, new Guid("04cbeadb-e000-4b9f-80a0-ee997cbc0bf8") },
                    { new Guid("0764e7eb-3c42-4217-a71d-909931b59e83"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stackeetam", null, "Lyan", new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c"), "Worm", "Enrique", 0, new Guid("04cbeadb-e000-4b9f-80a0-ee997cbc0bf8") }
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "Id", "ActivityTemplateId", "Description" },
                values: new object[,]
                {
                    { new Guid("f0d3d0fc-a7eb-4772-9e4f-725d167014fe"), new Guid("7aea95d2-9f9a-4d62-920c-dc442be0af2d"), "Clases de ingles" },
                    { new Guid("bb6ec32c-bc6d-4286-a631-0b641cdea782"), new Guid("c7a0c679-1717-46f7-9f45-da9153a6a9a4"), "Cuidade matutino" },
                    { new Guid("b189d9df-946e-4315-bf6f-986ca1c36e69"), new Guid("fd6e0d8f-f92b-46c7-a37a-501f5528e144"), "Cuidado Vespertino" },
                    { new Guid("dec6a963-9e08-4373-9238-91713b80a7b6"), new Guid("ea3c552b-98df-4e3c-9127-9650639cae76"), "Cuidado dia completo" },
                    { new Guid("0d4fbdbc-6d67-4855-ac68-4a4a47c76bb4"), new Guid("d3d23037-7ae3-4005-8cc2-235acaaf0f54"), "Clases de Ballet" },
                    { new Guid("4dfd6ae0-f00d-46b2-a567-2f5c94de134b"), new Guid("66bca942-7b3b-4f3e-831c-b7863268030d"), "Clases de logica" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "Comment", "EnrollDay", "KidId" },
                values: new object[,]
                {
                    { new Guid("fbdafe7a-d595-42eb-8955-ab80811e8d1e"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("012202b9-61ee-494e-9099-ba6bce67aac6") },
                    { new Guid("48208912-5cd1-4e19-9309-fc7d74bb198a"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0146bf6c-39fa-4e3a-9e9c-2c861384b4a0") },
                    { new Guid("d1081690-b33d-48ed-b20b-d60fb8cadbe5"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0329e38b-c48c-48d0-9994-295db8ede606") },
                    { new Guid("64d6cd49-3369-4885-b6b3-09782b60a3ff"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("032fddb7-a66a-44f5-8b72-d89263bd306a") },
                    { new Guid("540c8f37-5ab4-4a16-9fae-fbcb6318459d"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("04af1463-3174-4cae-b3c8-f6f85005d269") }
                });

            migrationBuilder.InsertData(
                table: "EnrollActivity",
                columns: new[] { "Id", "ActivityId", "EnrollmentId" },
                values: new object[,]
                {
                    { new Guid("94885b1f-c5c5-4561-90af-d8645be3a327"), new Guid("b189d9df-946e-4315-bf6f-986ca1c36e69"), new Guid("fbdafe7a-d595-42eb-8955-ab80811e8d1e") },
                    { new Guid("af6f77f3-0dc0-4af1-99b3-71257d540a59"), new Guid("b189d9df-946e-4315-bf6f-986ca1c36e69"), new Guid("48208912-5cd1-4e19-9309-fc7d74bb198a") },
                    { new Guid("6983dd07-3165-4e10-9a95-cf06599e3834"), new Guid("b189d9df-946e-4315-bf6f-986ca1c36e69"), new Guid("d1081690-b33d-48ed-b20b-d60fb8cadbe5") },
                    { new Guid("b97f035a-f6b2-4290-ae14-e4fa0dfc278d"), new Guid("b189d9df-946e-4315-bf6f-986ca1c36e69"), new Guid("64d6cd49-3369-4885-b6b3-09782b60a3ff") },
                    { new Guid("26506b0c-9308-49b9-925d-d007a47154e0"), new Guid("f0d3d0fc-a7eb-4772-9e4f-725d167014fe"), new Guid("540c8f37-5ab4-4a16-9fae-fbcb6318459d") }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Price", "Reference", "ActivityId", "Description", "ServicePeriod" },
                values: new object[,]
                {
                    { new Guid("832baabe-ead6-41fd-b790-24719b6b6962"), "Service", 1758m, "SRV-840", new Guid("f0d3d0fc-a7eb-4772-9e4f-725d167014fe"), "Service Clases de ingles", 77 },
                    { new Guid("0633c3f6-3a8e-4765-bfe6-3b59799c9b4d"), "Service", 7692m, "SRV-851", new Guid("bb6ec32c-bc6d-4286-a631-0b641cdea782"), "Service Cuidade matutino", 77 },
                    { new Guid("704c6e7a-c8de-447a-bf58-e708cc79ea45"), "Service", 3734m, "SRV-615", new Guid("b189d9df-946e-4315-bf6f-986ca1c36e69"), "Service Cuidado Vespertino", 77 },
                    { new Guid("ae20cfaf-2f2c-4c42-a84d-48b7053e014d"), "Service", 8703m, "SRV-491", new Guid("dec6a963-9e08-4373-9238-91713b80a7b6"), "Service Cuidado dia completo", 77 },
                    { new Guid("a7598aff-7340-457e-8ac8-867501dd24b0"), "Service", 1116m, "SRV-942", new Guid("0d4fbdbc-6d67-4855-ac68-4a4a47c76bb4"), "Service Clases de Ballet", 77 },
                    { new Guid("6e05a1d7-5a3d-458c-a748-2300e4cfa880"), "Service", 890m, "SRV-941", new Guid("4dfd6ae0-f00d-46b2-a567-2f5c94de134b"), "Service Clases de logica", 77 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("26506b0c-9308-49b9-925d-d007a47154e0"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("6983dd07-3165-4e10-9a95-cf06599e3834"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("94885b1f-c5c5-4561-90af-d8645be3a327"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("af6f77f3-0dc0-4af1-99b3-71257d540a59"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("b97f035a-f6b2-4290-ae14-e4fa0dfc278d"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("0633c3f6-3a8e-4765-bfe6-3b59799c9b4d"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("6e05a1d7-5a3d-458c-a748-2300e4cfa880"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("704c6e7a-c8de-447a-bf58-e708cc79ea45"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("832baabe-ead6-41fd-b790-24719b6b6962"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("a7598aff-7340-457e-8ac8-867501dd24b0"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("ae20cfaf-2f2c-4c42-a84d-48b7053e014d"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("04e4690b-74b1-48ab-95df-0ac3d46580e0"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("05eada6b-ee1f-415c-927d-5dc9a76a0cd0"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("06095d50-99c0-4e5e-88cf-b2434b82276e"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("066f005f-1c36-433a-925b-d4be4688ea0e"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0764e7eb-3c42-4217-a71d-909931b59e83"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("b7370d63-cec0-4d74-b669-d3539140c869"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("0d4fbdbc-6d67-4855-ac68-4a4a47c76bb4"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("4dfd6ae0-f00d-46b2-a567-2f5c94de134b"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("b189d9df-946e-4315-bf6f-986ca1c36e69"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("bb6ec32c-bc6d-4286-a631-0b641cdea782"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("dec6a963-9e08-4373-9238-91713b80a7b6"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("f0d3d0fc-a7eb-4772-9e4f-725d167014fe"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("48208912-5cd1-4e19-9309-fc7d74bb198a"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("540c8f37-5ab4-4a16-9fae-fbcb6318459d"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("64d6cd49-3369-4885-b6b3-09782b60a3ff"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("d1081690-b33d-48ed-b20b-d60fb8cadbe5"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("fbdafe7a-d595-42eb-8955-ab80811e8d1e"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("66bca942-7b3b-4f3e-831c-b7863268030d"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("7aea95d2-9f9a-4d62-920c-dc442be0af2d"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("c7a0c679-1717-46f7-9f45-da9153a6a9a4"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("d3d23037-7ae3-4005-8cc2-235acaaf0f54"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("ea3c552b-98df-4e3c-9127-9650639cae76"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("fd6e0d8f-f92b-46c7-a37a-501f5528e144"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("012202b9-61ee-494e-9099-ba6bce67aac6"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0146bf6c-39fa-4e3a-9e9c-2c861384b4a0"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0329e38b-c48c-48d0-9994-295db8ede606"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("032fddb7-a66a-44f5-8b72-d89263bd306a"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("04af1463-3174-4cae-b3c8-f6f85005d269"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("04cbeadb-e000-4b9f-80a0-ee997cbc0bf8"));

            migrationBuilder.DropColumn(
                name: "SiblingCount",
                table: "Kid");

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
    }
}
