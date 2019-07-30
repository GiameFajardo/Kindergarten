using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Seed_EnrollActivities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("2b345b98-130b-47ca-94af-deb6305e495a"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("3128d1da-c9a9-4d74-9967-2277c327b78a"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("39eb909c-2ff6-4f7d-9393-f9c1d5f4d681"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("8df1535b-fe95-4913-b7bc-18ebd3a88984"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("9baddb84-3f3d-4709-898b-a1aae728b58f"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("207ffc57-aab6-4c24-bd89-4b057956db22"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("383209c0-cbc9-4082-b401-75102123650c"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("4cfa8938-20f8-4379-a9ff-c2bcf8bb418f"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("6ce9c196-4866-48a7-afe8-03e859f62419"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("d2bf002d-b426-4457-8095-257c8291cd14"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("e3cd256c-994b-46cf-8382-c5912d74e52e"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0471bd25-ba55-4602-be30-0ec28f733969"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("048d2511-c55b-4803-b9ee-e3240e6bede4"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0675a1ce-94e4-4530-9211-8f4bc4e2d321"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("07fc6563-788b-43d4-8f3b-94c4b817e11b"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("09a380f2-5c54-4589-9378-907270284fa7"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("f700b95f-119d-4605-acfc-9e2a2b35d628"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("2bdc425a-fedc-4aad-9cef-971dd27cac7b"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("64d345f8-1ba6-45eb-9076-36828660ce9b"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("8568b490-d4b2-4d88-8954-0c7d2fd60e13"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("c3a347e8-d6fb-4b30-90a6-472f7f2d37b8"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("c4c825cb-0aee-4d27-814e-98661d22f926"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("e5de7a0a-8290-48dc-9db3-7281e9efcfb2"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("01f13d20-31f0-4bf4-ad42-f946eda593ed"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("022cbe94-ee5c-467b-933b-2ccb1b07d8d0"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("02690970-6295-4a09-b831-a0b82aa2e123"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("033c8c83-b365-4ae1-a7de-65455b4ab950"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("046903d7-0749-4a08-88c8-930b7ea431e9"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("4e3bebd4-7322-4b81-af94-48ea98600b0c"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("7efbbf3a-6c04-466c-a74c-54a5f328293d"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("b3640ad7-3e76-46a4-9267-f55987080873"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("bee0237a-aa13-4f53-8229-35773d1cc277"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("d186fcc9-2f8e-401e-acf6-bff58a3741f2"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("d2006162-bfa7-43fc-b7ef-f7f8f87dfa33"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("99d8b713-7bf9-459a-9860-f0dfd937cdaf"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("6874815d-9a4e-4e0a-b3e7-0f4b03c69838"));

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("e75c087f-ed5f-45f7-ad4d-9082fac3f9f0"), "KPH" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("68c9f6f8-54de-465f-a05c-c5fec4dccbb0"), null, "Gregorio de Jesus", "Rojas Acosta", null, null, null });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("d73426b6-7a5b-4557-9f38-83f53eb93cf6"), null, "Yadira", "Pinales Delgado", null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityTemplate",
                columns: new[] { "Id", "Description", "KindergarterId" },
                values: new object[,]
                {
                    { new Guid("2ffbfdd4-14a7-4a54-9e6d-21c80027267f"), "Clases de ingles", new Guid("e75c087f-ed5f-45f7-ad4d-9082fac3f9f0") },
                    { new Guid("197a84ce-7546-4a1f-8274-8ed92f5f5197"), "Cuidade matutino", new Guid("e75c087f-ed5f-45f7-ad4d-9082fac3f9f0") },
                    { new Guid("39375427-76fd-4e5d-8e5d-0fa81b7f38f2"), "Cuidado Vespertino", new Guid("e75c087f-ed5f-45f7-ad4d-9082fac3f9f0") },
                    { new Guid("5728a637-b4ec-4ee3-a75e-2e8470f18443"), "Cuidado dia completo", new Guid("e75c087f-ed5f-45f7-ad4d-9082fac3f9f0") },
                    { new Guid("cc319f79-27ee-43b8-ad3d-cfa8d1428442"), "Clases de Ballet", new Guid("e75c087f-ed5f-45f7-ad4d-9082fac3f9f0") },
                    { new Guid("c3354e05-6f04-4327-a282-158fb3eb2a1c"), "Clases de logica", new Guid("e75c087f-ed5f-45f7-ad4d-9082fac3f9f0") }
                });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "FatherName", "FirstName", "KindergarterId", "MotherName", "SecondName", "TutorId" },
                values: new object[,]
                {
                    { new Guid("006ad93b-0987-412d-8b4f-03d8f05bb683"), "Faringtom", "Dylan", new Guid("e75c087f-ed5f-45f7-ad4d-9082fac3f9f0"), "Washinton", "Emilio", new Guid("68c9f6f8-54de-465f-a05c-c5fec4dccbb0") },
                    { new Guid("0071536b-710d-45ae-9b09-d3f5b013a1f0"), "Escobar", "Aaron", new Guid("e75c087f-ed5f-45f7-ad4d-9082fac3f9f0"), "Snow", "Carlos", new Guid("68c9f6f8-54de-465f-a05c-c5fec4dccbb0") },
                    { new Guid("00895b03-1022-4604-a98e-c152a383ee6a"), "Faringtom", "Johan", new Guid("e75c087f-ed5f-45f7-ad4d-9082fac3f9f0"), "Worm", "Enrique", new Guid("68c9f6f8-54de-465f-a05c-c5fec4dccbb0") },
                    { new Guid("01f528cb-b26e-4591-96f6-08cfd77adb1a"), "Stackeetam", "Dylan", new Guid("e75c087f-ed5f-45f7-ad4d-9082fac3f9f0"), "Snow", "Carlos", new Guid("68c9f6f8-54de-465f-a05c-c5fec4dccbb0") },
                    { new Guid("03e2ced5-3c50-4f7c-9914-e6011d6706ad"), "Escobar", "Johan", new Guid("e75c087f-ed5f-45f7-ad4d-9082fac3f9f0"), "Worm", "Carlos", new Guid("68c9f6f8-54de-465f-a05c-c5fec4dccbb0") },
                    { new Guid("0413ecd2-8c06-40e0-a6bc-0e7d8abd7a6d"), "Stackeetam", "Dylan", new Guid("e75c087f-ed5f-45f7-ad4d-9082fac3f9f0"), "White", "Emilio", new Guid("68c9f6f8-54de-465f-a05c-c5fec4dccbb0") },
                    { new Guid("04f89858-2075-4377-9e7c-786fef73b8aa"), "Stackeetam", "Lyan", new Guid("e75c087f-ed5f-45f7-ad4d-9082fac3f9f0"), "Worm", "Eduardo", new Guid("68c9f6f8-54de-465f-a05c-c5fec4dccbb0") },
                    { new Guid("0555f3b2-c03f-4591-a154-2d28d6915c14"), "Faringtom", "Johan", new Guid("e75c087f-ed5f-45f7-ad4d-9082fac3f9f0"), "Snow", "Enrique", new Guid("68c9f6f8-54de-465f-a05c-c5fec4dccbb0") },
                    { new Guid("07454bdb-9c63-4718-8d52-77086e8bcefa"), "Stackeetam", "Lyan", new Guid("e75c087f-ed5f-45f7-ad4d-9082fac3f9f0"), "Snow", "Carlos", new Guid("68c9f6f8-54de-465f-a05c-c5fec4dccbb0") },
                    { new Guid("08cf2771-3631-492e-ad24-3c0d63af3be9"), "Faringtom", "Dylan", new Guid("e75c087f-ed5f-45f7-ad4d-9082fac3f9f0"), "White", "Emilio", new Guid("68c9f6f8-54de-465f-a05c-c5fec4dccbb0") }
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "Id", "ActivityTemplateId", "Description" },
                values: new object[,]
                {
                    { new Guid("53528a0f-bfa6-4d22-a5d5-0041ab668277"), new Guid("2ffbfdd4-14a7-4a54-9e6d-21c80027267f"), "Clases de ingles" },
                    { new Guid("ce169702-f578-4602-8668-9221ff4c772c"), new Guid("197a84ce-7546-4a1f-8274-8ed92f5f5197"), "Cuidade matutino" },
                    { new Guid("710e6930-b848-4ebb-8c3e-b30e8b15d381"), new Guid("39375427-76fd-4e5d-8e5d-0fa81b7f38f2"), "Cuidado Vespertino" },
                    { new Guid("d9ea92a0-ea49-44e3-8725-e6f71e3a5fe9"), new Guid("5728a637-b4ec-4ee3-a75e-2e8470f18443"), "Cuidado dia completo" },
                    { new Guid("c42834e4-38d6-4595-8bef-cd10a9fb76d4"), new Guid("cc319f79-27ee-43b8-ad3d-cfa8d1428442"), "Clases de Ballet" },
                    { new Guid("4f84167d-bef4-43c9-8d53-09e8721ce49a"), new Guid("c3354e05-6f04-4327-a282-158fb3eb2a1c"), "Clases de logica" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "Comment", "EnrollDay", "KidId" },
                values: new object[,]
                {
                    { new Guid("9246d9d4-9be9-440d-aab7-fe620052935c"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("006ad93b-0987-412d-8b4f-03d8f05bb683") },
                    { new Guid("8b278c80-7658-4774-b21b-773852393516"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0071536b-710d-45ae-9b09-d3f5b013a1f0") },
                    { new Guid("5bd39bdc-55ee-463a-a908-86668060d2fd"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00895b03-1022-4604-a98e-c152a383ee6a") },
                    { new Guid("1e12a9da-eae6-4fa6-9491-57b6c2556a9b"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("01f528cb-b26e-4591-96f6-08cfd77adb1a") },
                    { new Guid("670ffef5-8cdb-41fd-ba98-d244787f81e8"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("03e2ced5-3c50-4f7c-9914-e6011d6706ad") }
                });

            migrationBuilder.InsertData(
                table: "EnrollActivity",
                columns: new[] { "Id", "ActivityId", "EnrollmentId" },
                values: new object[,]
                {
                    { new Guid("fc79897b-c37e-4d9b-a56d-0634d3d46888"), new Guid("ce169702-f578-4602-8668-9221ff4c772c"), null },
                    { new Guid("35e6fa9d-1c72-4290-be5f-fa9a3ed8b2ea"), new Guid("710e6930-b848-4ebb-8c3e-b30e8b15d381"), null },
                    { new Guid("24f59242-6cc1-48fa-b544-16735c5ed5d1"), new Guid("d9ea92a0-ea49-44e3-8725-e6f71e3a5fe9"), null },
                    { new Guid("bb02ec79-150d-4936-aaba-9c052a208d7b"), new Guid("d9ea92a0-ea49-44e3-8725-e6f71e3a5fe9"), null },
                    { new Guid("5756f886-dcc3-428f-825d-a8f1da65f983"), new Guid("c42834e4-38d6-4595-8bef-cd10a9fb76d4"), null }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Price", "Reference", "ActivityId", "Description", "ServicePeriod" },
                values: new object[,]
                {
                    { new Guid("4d10e5b3-dc0e-4e01-9329-ae6f281419f8"), "Service", 1597m, "SRV-833", new Guid("53528a0f-bfa6-4d22-a5d5-0041ab668277"), "Service Clases de ingles", 77 },
                    { new Guid("551680a2-5177-4022-bb79-7426f9102c72"), "Service", 7671m, "SRV-394", new Guid("ce169702-f578-4602-8668-9221ff4c772c"), "Service Cuidade matutino", 77 },
                    { new Guid("e8f814e1-c461-4796-b608-c9832ede7b89"), "Service", 1848m, "SRV-696", new Guid("710e6930-b848-4ebb-8c3e-b30e8b15d381"), "Service Cuidado Vespertino", 77 },
                    { new Guid("3b67cb00-4f69-4a5f-a6f7-880b85bc086c"), "Service", 1989m, "SRV-596", new Guid("d9ea92a0-ea49-44e3-8725-e6f71e3a5fe9"), "Service Cuidado dia completo", 77 },
                    { new Guid("a41df5fc-b714-4526-ad20-2777147f04f1"), "Service", 8988m, "SRV-843", new Guid("c42834e4-38d6-4595-8bef-cd10a9fb76d4"), "Service Clases de Ballet", 77 },
                    { new Guid("e21898b2-b52c-4205-b0b6-d5ba318b2fce"), "Service", 5033m, "SRV-313", new Guid("4f84167d-bef4-43c9-8d53-09e8721ce49a"), "Service Clases de logica", 77 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("24f59242-6cc1-48fa-b544-16735c5ed5d1"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("35e6fa9d-1c72-4290-be5f-fa9a3ed8b2ea"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("5756f886-dcc3-428f-825d-a8f1da65f983"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("bb02ec79-150d-4936-aaba-9c052a208d7b"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("fc79897b-c37e-4d9b-a56d-0634d3d46888"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("1e12a9da-eae6-4fa6-9491-57b6c2556a9b"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("5bd39bdc-55ee-463a-a908-86668060d2fd"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("670ffef5-8cdb-41fd-ba98-d244787f81e8"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("8b278c80-7658-4774-b21b-773852393516"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("9246d9d4-9be9-440d-aab7-fe620052935c"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("3b67cb00-4f69-4a5f-a6f7-880b85bc086c"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("4d10e5b3-dc0e-4e01-9329-ae6f281419f8"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("551680a2-5177-4022-bb79-7426f9102c72"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("a41df5fc-b714-4526-ad20-2777147f04f1"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("e21898b2-b52c-4205-b0b6-d5ba318b2fce"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("e8f814e1-c461-4796-b608-c9832ede7b89"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0413ecd2-8c06-40e0-a6bc-0e7d8abd7a6d"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("04f89858-2075-4377-9e7c-786fef73b8aa"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0555f3b2-c03f-4591-a154-2d28d6915c14"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("07454bdb-9c63-4718-8d52-77086e8bcefa"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("08cf2771-3631-492e-ad24-3c0d63af3be9"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("d73426b6-7a5b-4557-9f38-83f53eb93cf6"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("4f84167d-bef4-43c9-8d53-09e8721ce49a"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("53528a0f-bfa6-4d22-a5d5-0041ab668277"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("710e6930-b848-4ebb-8c3e-b30e8b15d381"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("c42834e4-38d6-4595-8bef-cd10a9fb76d4"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("ce169702-f578-4602-8668-9221ff4c772c"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("d9ea92a0-ea49-44e3-8725-e6f71e3a5fe9"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("006ad93b-0987-412d-8b4f-03d8f05bb683"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0071536b-710d-45ae-9b09-d3f5b013a1f0"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("00895b03-1022-4604-a98e-c152a383ee6a"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("01f528cb-b26e-4591-96f6-08cfd77adb1a"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("03e2ced5-3c50-4f7c-9914-e6011d6706ad"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("197a84ce-7546-4a1f-8274-8ed92f5f5197"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("2ffbfdd4-14a7-4a54-9e6d-21c80027267f"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("39375427-76fd-4e5d-8e5d-0fa81b7f38f2"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("5728a637-b4ec-4ee3-a75e-2e8470f18443"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("c3354e05-6f04-4327-a282-158fb3eb2a1c"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("cc319f79-27ee-43b8-ad3d-cfa8d1428442"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("68c9f6f8-54de-465f-a05c-c5fec4dccbb0"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("e75c087f-ed5f-45f7-ad4d-9082fac3f9f0"));

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("6874815d-9a4e-4e0a-b3e7-0f4b03c69838"), "Guarderia" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("99d8b713-7bf9-459a-9860-f0dfd937cdaf"), null, "Gregorio de Jesus", "Rojas Acosta", null, null, null });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("f700b95f-119d-4605-acfc-9e2a2b35d628"), null, "Yadira", "Pinales Delgado", null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityTemplate",
                columns: new[] { "Id", "Description", "KindergarterId" },
                values: new object[,]
                {
                    { new Guid("b3640ad7-3e76-46a4-9267-f55987080873"), "Clases de ingles", new Guid("6874815d-9a4e-4e0a-b3e7-0f4b03c69838") },
                    { new Guid("d186fcc9-2f8e-401e-acf6-bff58a3741f2"), "Cuidade matutino", new Guid("6874815d-9a4e-4e0a-b3e7-0f4b03c69838") },
                    { new Guid("d2006162-bfa7-43fc-b7ef-f7f8f87dfa33"), "Cuidado Vespertino", new Guid("6874815d-9a4e-4e0a-b3e7-0f4b03c69838") },
                    { new Guid("7efbbf3a-6c04-466c-a74c-54a5f328293d"), "Cuidado dia completo", new Guid("6874815d-9a4e-4e0a-b3e7-0f4b03c69838") },
                    { new Guid("bee0237a-aa13-4f53-8229-35773d1cc277"), "Clases de Ballet", new Guid("6874815d-9a4e-4e0a-b3e7-0f4b03c69838") },
                    { new Guid("4e3bebd4-7322-4b81-af94-48ea98600b0c"), "Clases de logica", new Guid("6874815d-9a4e-4e0a-b3e7-0f4b03c69838") }
                });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "FatherName", "FirstName", "KindergarterId", "MotherName", "SecondName", "TutorId" },
                values: new object[,]
                {
                    { new Guid("01f13d20-31f0-4bf4-ad42-f946eda593ed"), "Faringtom", "Dylan", new Guid("6874815d-9a4e-4e0a-b3e7-0f4b03c69838"), "Snow", "Enrique", new Guid("99d8b713-7bf9-459a-9860-f0dfd937cdaf") },
                    { new Guid("022cbe94-ee5c-467b-933b-2ccb1b07d8d0"), "Stackeetam", "Aaron", new Guid("6874815d-9a4e-4e0a-b3e7-0f4b03c69838"), "White", "Eduardo", new Guid("99d8b713-7bf9-459a-9860-f0dfd937cdaf") },
                    { new Guid("02690970-6295-4a09-b831-a0b82aa2e123"), "Escobar", "Aaron", new Guid("6874815d-9a4e-4e0a-b3e7-0f4b03c69838"), "Worm", "Eduardo", new Guid("99d8b713-7bf9-459a-9860-f0dfd937cdaf") },
                    { new Guid("033c8c83-b365-4ae1-a7de-65455b4ab950"), "Faringtom", "Lyan", new Guid("6874815d-9a4e-4e0a-b3e7-0f4b03c69838"), "Worm", "Carlos", new Guid("99d8b713-7bf9-459a-9860-f0dfd937cdaf") },
                    { new Guid("046903d7-0749-4a08-88c8-930b7ea431e9"), "Lee", "Lyan", new Guid("6874815d-9a4e-4e0a-b3e7-0f4b03c69838"), "Worm", "Eduardo", new Guid("99d8b713-7bf9-459a-9860-f0dfd937cdaf") },
                    { new Guid("0471bd25-ba55-4602-be30-0ec28f733969"), "Lee", "Dylan", new Guid("6874815d-9a4e-4e0a-b3e7-0f4b03c69838"), "White", "Emilio", new Guid("99d8b713-7bf9-459a-9860-f0dfd937cdaf") },
                    { new Guid("048d2511-c55b-4803-b9ee-e3240e6bede4"), "Faringtom", "Lyan", new Guid("6874815d-9a4e-4e0a-b3e7-0f4b03c69838"), "Worm", "Emilio", new Guid("99d8b713-7bf9-459a-9860-f0dfd937cdaf") },
                    { new Guid("0675a1ce-94e4-4530-9211-8f4bc4e2d321"), "Lee", "Aaron", new Guid("6874815d-9a4e-4e0a-b3e7-0f4b03c69838"), "Snow", "Enrique", new Guid("99d8b713-7bf9-459a-9860-f0dfd937cdaf") },
                    { new Guid("07fc6563-788b-43d4-8f3b-94c4b817e11b"), "Faringtom", "Aaron", new Guid("6874815d-9a4e-4e0a-b3e7-0f4b03c69838"), "White", "Enrique", new Guid("99d8b713-7bf9-459a-9860-f0dfd937cdaf") },
                    { new Guid("09a380f2-5c54-4589-9378-907270284fa7"), "Lee", "Aaron", new Guid("6874815d-9a4e-4e0a-b3e7-0f4b03c69838"), "Snow", "Eduardo", new Guid("99d8b713-7bf9-459a-9860-f0dfd937cdaf") }
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "Id", "ActivityTemplateId", "Description" },
                values: new object[,]
                {
                    { new Guid("e5de7a0a-8290-48dc-9db3-7281e9efcfb2"), new Guid("b3640ad7-3e76-46a4-9267-f55987080873"), "Clases de ingles" },
                    { new Guid("8568b490-d4b2-4d88-8954-0c7d2fd60e13"), new Guid("d186fcc9-2f8e-401e-acf6-bff58a3741f2"), "Cuidade matutino" },
                    { new Guid("64d345f8-1ba6-45eb-9076-36828660ce9b"), new Guid("d2006162-bfa7-43fc-b7ef-f7f8f87dfa33"), "Cuidado Vespertino" },
                    { new Guid("2bdc425a-fedc-4aad-9cef-971dd27cac7b"), new Guid("7efbbf3a-6c04-466c-a74c-54a5f328293d"), "Cuidado dia completo" },
                    { new Guid("c4c825cb-0aee-4d27-814e-98661d22f926"), new Guid("bee0237a-aa13-4f53-8229-35773d1cc277"), "Clases de Ballet" },
                    { new Guid("c3a347e8-d6fb-4b30-90a6-472f7f2d37b8"), new Guid("4e3bebd4-7322-4b81-af94-48ea98600b0c"), "Clases de logica" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "Comment", "EnrollDay", "KidId" },
                values: new object[,]
                {
                    { new Guid("8df1535b-fe95-4913-b7bc-18ebd3a88984"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("01f13d20-31f0-4bf4-ad42-f946eda593ed") },
                    { new Guid("39eb909c-2ff6-4f7d-9393-f9c1d5f4d681"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("022cbe94-ee5c-467b-933b-2ccb1b07d8d0") },
                    { new Guid("2b345b98-130b-47ca-94af-deb6305e495a"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("02690970-6295-4a09-b831-a0b82aa2e123") },
                    { new Guid("9baddb84-3f3d-4709-898b-a1aae728b58f"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("033c8c83-b365-4ae1-a7de-65455b4ab950") },
                    { new Guid("3128d1da-c9a9-4d74-9967-2277c327b78a"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("046903d7-0749-4a08-88c8-930b7ea431e9") }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Price", "Reference", "ActivityId", "Description", "ServicePeriod" },
                values: new object[,]
                {
                    { new Guid("e3cd256c-994b-46cf-8382-c5912d74e52e"), "Service", 5582m, "SRV-537", new Guid("e5de7a0a-8290-48dc-9db3-7281e9efcfb2"), "Service Clases de ingles", 77 },
                    { new Guid("4cfa8938-20f8-4379-a9ff-c2bcf8bb418f"), "Service", 7862m, "SRV-26", new Guid("8568b490-d4b2-4d88-8954-0c7d2fd60e13"), "Service Cuidade matutino", 77 },
                    { new Guid("d2bf002d-b426-4457-8095-257c8291cd14"), "Service", 7132m, "SRV-747", new Guid("64d345f8-1ba6-45eb-9076-36828660ce9b"), "Service Cuidado Vespertino", 77 },
                    { new Guid("383209c0-cbc9-4082-b401-75102123650c"), "Service", 574m, "SRV-874", new Guid("2bdc425a-fedc-4aad-9cef-971dd27cac7b"), "Service Cuidado dia completo", 77 },
                    { new Guid("6ce9c196-4866-48a7-afe8-03e859f62419"), "Service", 4733m, "SRV-970", new Guid("c4c825cb-0aee-4d27-814e-98661d22f926"), "Service Clases de Ballet", 77 },
                    { new Guid("207ffc57-aab6-4c24-bd89-4b057956db22"), "Service", 271m, "SRV-472", new Guid("c3a347e8-d6fb-4b30-90a6-472f7f2d37b8"), "Service Clases de logica", 77 }
                });
        }
    }
}
