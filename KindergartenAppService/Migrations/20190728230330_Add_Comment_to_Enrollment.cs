using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Add_Comment_to_Enrollment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("3bf3ecc3-a918-4498-950c-0205922d0169"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("4b56bd27-4723-4368-967f-99069d4dff00"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("4dc927ae-7454-4f8e-a598-caae7501e5ec"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("72a9cc41-2899-47c1-9337-0d2536372adf"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("f3506732-9953-49ff-b5b8-05c0561177ac"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("18ec49b9-60ec-4900-ac89-0773ba1642e9"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("362ea5ed-ec46-4f3b-b291-8d3444c213e4"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("5e5f2602-f08e-4c0d-a996-492f28a6dcdd"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("63d1ab26-28c1-4c60-8826-b3c34ba14ef0"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("82cb97d1-aab8-42a2-bfd6-c0ba02aaa241"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("de3a3a4b-1613-428d-bdb3-f3b75102e8d5"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0508c7a7-99f9-4e0b-b952-4d948bb6b022"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0566fa33-b74f-4166-9bb4-7a35bce04834"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("072874d2-027e-4a33-94a7-643cf2b52fb5"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0840cbe8-7f1f-483d-8a8f-9e3dc2b96c5b"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("08b4a08f-5b04-48be-9ca8-13d8e9fa10a9"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("5e695c94-b864-492f-80e1-2cf3adbca27e"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("12621cab-dc05-4974-ba4f-1c54d34ce21c"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("631bffac-3544-46c0-bf7d-72a55b328168"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("747d5fac-17f7-416f-81e2-41a4d5e496b0"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("9f54f57b-fe34-481c-9843-ea61ec4e754b"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("cc27ed0f-d030-48cf-8ac7-26bc35adfc12"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("d8479cf2-ad34-46e4-b5cc-5f79cc3a2d2c"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("00b5da96-c0a4-415c-a274-9dad288587b7"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0271773b-64a5-41ad-afab-67277133d40b"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0290bfac-6b94-4847-ae48-d8f94a34568b"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0363ec8d-4c9f-46cc-8547-730f0e6fa2d3"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0457456d-ebc2-4e46-80d0-b827e109e005"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("2b7c19c5-e250-4779-a398-024eb6971b7c"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("65c3e282-bc12-430e-8249-f0ec13a3b461"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("a971554e-f4eb-4242-8f35-d82bfcadc2a3"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("ae805a83-0388-4fcb-b84d-07a0aee2dd95"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("e06b37a2-8c42-4521-8c01-45d846112960"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("ed9183e2-36c2-4923-88a5-eef879e27381"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("cb96ef58-0c95-43b8-a846-512ce825bf35"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("5a3f922c-8571-4550-a306-b9baca7f8538"));

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Enrollments",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Enrollments");

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("5a3f922c-8571-4550-a306-b9baca7f8538"), "Guarderia" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("cb96ef58-0c95-43b8-a846-512ce825bf35"), null, "Gregorio de Jesus", "Rojas Acosta", null, null, null });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("5e695c94-b864-492f-80e1-2cf3adbca27e"), null, "Yadira", "Pinales Delgado", null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityTemplate",
                columns: new[] { "Id", "Description", "KindergarterId" },
                values: new object[,]
                {
                    { new Guid("ae805a83-0388-4fcb-b84d-07a0aee2dd95"), "Clases de ingles", new Guid("5a3f922c-8571-4550-a306-b9baca7f8538") },
                    { new Guid("65c3e282-bc12-430e-8249-f0ec13a3b461"), "Cuidade matutino", new Guid("5a3f922c-8571-4550-a306-b9baca7f8538") },
                    { new Guid("a971554e-f4eb-4242-8f35-d82bfcadc2a3"), "Cuidado Vespertino", new Guid("5a3f922c-8571-4550-a306-b9baca7f8538") },
                    { new Guid("e06b37a2-8c42-4521-8c01-45d846112960"), "Cuidado dia completo", new Guid("5a3f922c-8571-4550-a306-b9baca7f8538") },
                    { new Guid("ed9183e2-36c2-4923-88a5-eef879e27381"), "Clases de Ballet", new Guid("5a3f922c-8571-4550-a306-b9baca7f8538") },
                    { new Guid("2b7c19c5-e250-4779-a398-024eb6971b7c"), "Clases de logica", new Guid("5a3f922c-8571-4550-a306-b9baca7f8538") }
                });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "FatherName", "FirstName", "KindergarterId", "MotherName", "SecondName", "TutorId" },
                values: new object[,]
                {
                    { new Guid("00b5da96-c0a4-415c-a274-9dad288587b7"), "Faringtom", "Johan", new Guid("5a3f922c-8571-4550-a306-b9baca7f8538"), "Washinton", "Carlos", new Guid("cb96ef58-0c95-43b8-a846-512ce825bf35") },
                    { new Guid("0271773b-64a5-41ad-afab-67277133d40b"), "Escobar", "Lyan", new Guid("5a3f922c-8571-4550-a306-b9baca7f8538"), "Worm", "Carlos", new Guid("cb96ef58-0c95-43b8-a846-512ce825bf35") },
                    { new Guid("0290bfac-6b94-4847-ae48-d8f94a34568b"), "Escobar", "Johan", new Guid("5a3f922c-8571-4550-a306-b9baca7f8538"), "Washinton", "Carlos", new Guid("cb96ef58-0c95-43b8-a846-512ce825bf35") },
                    { new Guid("0363ec8d-4c9f-46cc-8547-730f0e6fa2d3"), "Faringtom", "Lyan", new Guid("5a3f922c-8571-4550-a306-b9baca7f8538"), "White", "Eduardo", new Guid("cb96ef58-0c95-43b8-a846-512ce825bf35") },
                    { new Guid("0457456d-ebc2-4e46-80d0-b827e109e005"), "Escobar", "Lyan", new Guid("5a3f922c-8571-4550-a306-b9baca7f8538"), "Washinton", "Emilio", new Guid("cb96ef58-0c95-43b8-a846-512ce825bf35") },
                    { new Guid("0508c7a7-99f9-4e0b-b952-4d948bb6b022"), "Lee", "Johan", new Guid("5a3f922c-8571-4550-a306-b9baca7f8538"), "Snow", "Emilio", new Guid("cb96ef58-0c95-43b8-a846-512ce825bf35") },
                    { new Guid("0566fa33-b74f-4166-9bb4-7a35bce04834"), "Escobar", "Dylan", new Guid("5a3f922c-8571-4550-a306-b9baca7f8538"), "White", "Enrique", new Guid("cb96ef58-0c95-43b8-a846-512ce825bf35") },
                    { new Guid("072874d2-027e-4a33-94a7-643cf2b52fb5"), "Stackeetam", "Johan", new Guid("5a3f922c-8571-4550-a306-b9baca7f8538"), "White", "Eduardo", new Guid("cb96ef58-0c95-43b8-a846-512ce825bf35") },
                    { new Guid("0840cbe8-7f1f-483d-8a8f-9e3dc2b96c5b"), "Stackeetam", "Lyan", new Guid("5a3f922c-8571-4550-a306-b9baca7f8538"), "Worm", "Eduardo", new Guid("cb96ef58-0c95-43b8-a846-512ce825bf35") },
                    { new Guid("08b4a08f-5b04-48be-9ca8-13d8e9fa10a9"), "Faringtom", "Johan", new Guid("5a3f922c-8571-4550-a306-b9baca7f8538"), "Snow", "Enrique", new Guid("cb96ef58-0c95-43b8-a846-512ce825bf35") }
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "Id", "ActivityTemplateId", "Description" },
                values: new object[,]
                {
                    { new Guid("747d5fac-17f7-416f-81e2-41a4d5e496b0"), new Guid("ae805a83-0388-4fcb-b84d-07a0aee2dd95"), "Clases de ingles" },
                    { new Guid("9f54f57b-fe34-481c-9843-ea61ec4e754b"), new Guid("65c3e282-bc12-430e-8249-f0ec13a3b461"), "Cuidade matutino" },
                    { new Guid("631bffac-3544-46c0-bf7d-72a55b328168"), new Guid("a971554e-f4eb-4242-8f35-d82bfcadc2a3"), "Cuidado Vespertino" },
                    { new Guid("d8479cf2-ad34-46e4-b5cc-5f79cc3a2d2c"), new Guid("e06b37a2-8c42-4521-8c01-45d846112960"), "Cuidado dia completo" },
                    { new Guid("12621cab-dc05-4974-ba4f-1c54d34ce21c"), new Guid("ed9183e2-36c2-4923-88a5-eef879e27381"), "Clases de Ballet" },
                    { new Guid("cc27ed0f-d030-48cf-8ac7-26bc35adfc12"), new Guid("2b7c19c5-e250-4779-a398-024eb6971b7c"), "Clases de logica" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "EnrollDay", "KidId" },
                values: new object[,]
                {
                    { new Guid("4dc927ae-7454-4f8e-a598-caae7501e5ec"), new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00b5da96-c0a4-415c-a274-9dad288587b7") },
                    { new Guid("3bf3ecc3-a918-4498-950c-0205922d0169"), new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0271773b-64a5-41ad-afab-67277133d40b") },
                    { new Guid("4b56bd27-4723-4368-967f-99069d4dff00"), new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0290bfac-6b94-4847-ae48-d8f94a34568b") },
                    { new Guid("f3506732-9953-49ff-b5b8-05c0561177ac"), new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0363ec8d-4c9f-46cc-8547-730f0e6fa2d3") },
                    { new Guid("72a9cc41-2899-47c1-9337-0d2536372adf"), new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0457456d-ebc2-4e46-80d0-b827e109e005") }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Price", "Reference", "ActivityId", "Description", "ServicePeriod" },
                values: new object[,]
                {
                    { new Guid("82cb97d1-aab8-42a2-bfd6-c0ba02aaa241"), "Service", 1539m, "SRV-777", new Guid("747d5fac-17f7-416f-81e2-41a4d5e496b0"), "Service Clases de ingles", 77 },
                    { new Guid("5e5f2602-f08e-4c0d-a996-492f28a6dcdd"), "Service", 6110m, "SRV-380", new Guid("9f54f57b-fe34-481c-9843-ea61ec4e754b"), "Service Cuidade matutino", 77 },
                    { new Guid("63d1ab26-28c1-4c60-8826-b3c34ba14ef0"), "Service", 147m, "SRV-26", new Guid("631bffac-3544-46c0-bf7d-72a55b328168"), "Service Cuidado Vespertino", 77 },
                    { new Guid("362ea5ed-ec46-4f3b-b291-8d3444c213e4"), "Service", 9827m, "SRV-251", new Guid("d8479cf2-ad34-46e4-b5cc-5f79cc3a2d2c"), "Service Cuidado dia completo", 77 },
                    { new Guid("18ec49b9-60ec-4900-ac89-0773ba1642e9"), "Service", 6149m, "SRV-837", new Guid("12621cab-dc05-4974-ba4f-1c54d34ce21c"), "Service Clases de Ballet", 77 },
                    { new Guid("de3a3a4b-1613-428d-bdb3-f3b75102e8d5"), "Service", 8078m, "SRV-941", new Guid("cc27ed0f-d030-48cf-8ac7-26bc35adfc12"), "Service Clases de logica", 77 }
                });
        }
    }
}
