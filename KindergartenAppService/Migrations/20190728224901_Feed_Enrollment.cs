using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Feed_Enrollment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("16a01a55-2bcf-430d-a9ca-59cfac0786b8"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("9b7d468d-857c-4380-ae8e-0b4dcd4a48ab"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("b59df544-c8f1-411a-8052-d3457fcf2fa3"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("c3b02f0d-1731-48b7-bef8-82dcb8ca6754"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("e3913bcc-6648-4e70-bf09-631a46954f81"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("ee5c2991-3737-49db-b596-06c187d857b0"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("002e6a70-0bb9-4162-8c85-7c432b2f56db"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("00773398-7b1c-41f1-b65b-a1dceec8e7a3"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0132eb93-4d3d-4472-aca3-9f8a8d506234"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("03002be0-4f63-40bc-bb32-8734b843b35b"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("04e7e1f3-9c90-4f89-adfb-eb837f135077"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("06c7192c-0e6a-4cb5-b431-b8c79b52b0c5"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("090dbdab-11e9-417e-93a9-bc59322f2c34"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0a8e5c8a-91bd-4e09-a87e-ccc717179aed"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0aad51f6-dc53-46b4-83d5-f2bbbb3ede8c"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0cebdd70-cc57-4733-9311-c29e49b75b8f"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("1396a498-0dc6-4f21-9f1a-abbe4be78adb"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("1ea2d94b-b07d-48a7-ae8b-cb3fb0de0a13"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("2fab997b-0454-4dbd-ade5-893af8dcaa7d"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("2fcb55d6-689d-4e2e-9fe1-bc28122dc5da"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("3646c0db-030c-44ae-b8dd-cbd419318c9e"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("3fdf45aa-3573-4766-a83b-61ea24fa837d"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("477aef3a-3b50-4c3a-b5a8-50e41b831439"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("ba9a51b0-c1eb-4cec-a94c-eb443c3d5175"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("18f11f7d-c6f3-4f32-9721-6bfc0fbe1bbb"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("216a05a2-5e05-44c2-a209-e2e01602beb3"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("431ec10d-bf14-4773-958b-1b40434e95eb"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("9bab709b-3d16-4b8b-a27f-2f02d21088e1"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("cc3fa6b3-2ce7-47c1-abeb-73694249ec08"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("df564db2-39ec-4a0b-8d2a-bc474a0bfd1d"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("531c3231-59b9-4d32-9e1d-ce003cd5b88b"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("531c3231-59b9-4d32-9e1d-ce003cd5b88b"), "Guarderia" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("ba9a51b0-c1eb-4cec-a94c-eb443c3d5175"), null, "Gregorio de Jesus", "Rojas Acosta", null, null, null });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("1396a498-0dc6-4f21-9f1a-abbe4be78adb"), null, "Yadira", "Pinales Delgado", null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityTemplate",
                columns: new[] { "Id", "Description", "KindergarterId" },
                values: new object[,]
                {
                    { new Guid("cc3fa6b3-2ce7-47c1-abeb-73694249ec08"), "Clases de ingles", new Guid("531c3231-59b9-4d32-9e1d-ce003cd5b88b") },
                    { new Guid("18f11f7d-c6f3-4f32-9721-6bfc0fbe1bbb"), "Cuidade matutino", new Guid("531c3231-59b9-4d32-9e1d-ce003cd5b88b") },
                    { new Guid("9bab709b-3d16-4b8b-a27f-2f02d21088e1"), "Cuidado Vespertino", new Guid("531c3231-59b9-4d32-9e1d-ce003cd5b88b") },
                    { new Guid("431ec10d-bf14-4773-958b-1b40434e95eb"), "Cuidado dia completo", new Guid("531c3231-59b9-4d32-9e1d-ce003cd5b88b") },
                    { new Guid("df564db2-39ec-4a0b-8d2a-bc474a0bfd1d"), "Clases de Ballet", new Guid("531c3231-59b9-4d32-9e1d-ce003cd5b88b") },
                    { new Guid("216a05a2-5e05-44c2-a209-e2e01602beb3"), "Clases de logica", new Guid("531c3231-59b9-4d32-9e1d-ce003cd5b88b") }
                });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "FatherName", "FirstName", "KindergarterId", "MotherName", "SecondName", "TutorId" },
                values: new object[,]
                {
                    { new Guid("002e6a70-0bb9-4162-8c85-7c432b2f56db"), "Stackeetam", "Aaron", new Guid("531c3231-59b9-4d32-9e1d-ce003cd5b88b"), "White", "Emilio", new Guid("ba9a51b0-c1eb-4cec-a94c-eb443c3d5175") },
                    { new Guid("00773398-7b1c-41f1-b65b-a1dceec8e7a3"), "Lee", "Lyan", new Guid("531c3231-59b9-4d32-9e1d-ce003cd5b88b"), "Washinton", "Enrique", new Guid("ba9a51b0-c1eb-4cec-a94c-eb443c3d5175") },
                    { new Guid("0132eb93-4d3d-4472-aca3-9f8a8d506234"), "Faringtom", "Lyan", new Guid("531c3231-59b9-4d32-9e1d-ce003cd5b88b"), "Snow", "Eduardo", new Guid("ba9a51b0-c1eb-4cec-a94c-eb443c3d5175") },
                    { new Guid("03002be0-4f63-40bc-bb32-8734b843b35b"), "Escobar", "Johan", new Guid("531c3231-59b9-4d32-9e1d-ce003cd5b88b"), "White", "Eduardo", new Guid("ba9a51b0-c1eb-4cec-a94c-eb443c3d5175") },
                    { new Guid("04e7e1f3-9c90-4f89-adfb-eb837f135077"), "Faringtom", "Dylan", new Guid("531c3231-59b9-4d32-9e1d-ce003cd5b88b"), "Washinton", "Eduardo", new Guid("ba9a51b0-c1eb-4cec-a94c-eb443c3d5175") },
                    { new Guid("06c7192c-0e6a-4cb5-b431-b8c79b52b0c5"), "Escobar", "Johan", new Guid("531c3231-59b9-4d32-9e1d-ce003cd5b88b"), "Worm", "Emilio", new Guid("ba9a51b0-c1eb-4cec-a94c-eb443c3d5175") },
                    { new Guid("090dbdab-11e9-417e-93a9-bc59322f2c34"), "Lee", "Johan", new Guid("531c3231-59b9-4d32-9e1d-ce003cd5b88b"), "Washinton", "Emilio", new Guid("ba9a51b0-c1eb-4cec-a94c-eb443c3d5175") },
                    { new Guid("0a8e5c8a-91bd-4e09-a87e-ccc717179aed"), "Stackeetam", "Johan", new Guid("531c3231-59b9-4d32-9e1d-ce003cd5b88b"), "White", "Enrique", new Guid("ba9a51b0-c1eb-4cec-a94c-eb443c3d5175") },
                    { new Guid("0aad51f6-dc53-46b4-83d5-f2bbbb3ede8c"), "Escobar", "Dylan", new Guid("531c3231-59b9-4d32-9e1d-ce003cd5b88b"), "Worm", "Enrique", new Guid("ba9a51b0-c1eb-4cec-a94c-eb443c3d5175") },
                    { new Guid("0cebdd70-cc57-4733-9311-c29e49b75b8f"), "Faringtom", "Lyan", new Guid("531c3231-59b9-4d32-9e1d-ce003cd5b88b"), "White", "Enrique", new Guid("ba9a51b0-c1eb-4cec-a94c-eb443c3d5175") }
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "Id", "ActivityTemplateId", "Description" },
                values: new object[,]
                {
                    { new Guid("3fdf45aa-3573-4766-a83b-61ea24fa837d"), new Guid("cc3fa6b3-2ce7-47c1-abeb-73694249ec08"), "Clases de ingles" },
                    { new Guid("1ea2d94b-b07d-48a7-ae8b-cb3fb0de0a13"), new Guid("18f11f7d-c6f3-4f32-9721-6bfc0fbe1bbb"), "Cuidade matutino" },
                    { new Guid("2fab997b-0454-4dbd-ade5-893af8dcaa7d"), new Guid("9bab709b-3d16-4b8b-a27f-2f02d21088e1"), "Cuidado Vespertino" },
                    { new Guid("477aef3a-3b50-4c3a-b5a8-50e41b831439"), new Guid("431ec10d-bf14-4773-958b-1b40434e95eb"), "Cuidado dia completo" },
                    { new Guid("3646c0db-030c-44ae-b8dd-cbd419318c9e"), new Guid("df564db2-39ec-4a0b-8d2a-bc474a0bfd1d"), "Clases de Ballet" },
                    { new Guid("2fcb55d6-689d-4e2e-9fe1-bc28122dc5da"), new Guid("216a05a2-5e05-44c2-a209-e2e01602beb3"), "Clases de logica" }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Price", "Reference", "ActivityId", "Description", "ServicePeriod" },
                values: new object[,]
                {
                    { new Guid("9b7d468d-857c-4380-ae8e-0b4dcd4a48ab"), "Service", 7412m, "SRV-154", new Guid("3fdf45aa-3573-4766-a83b-61ea24fa837d"), "Service Clases de ingles", 77 },
                    { new Guid("c3b02f0d-1731-48b7-bef8-82dcb8ca6754"), "Service", 4252m, "SRV-602", new Guid("1ea2d94b-b07d-48a7-ae8b-cb3fb0de0a13"), "Service Cuidade matutino", 77 },
                    { new Guid("b59df544-c8f1-411a-8052-d3457fcf2fa3"), "Service", 814m, "SRV-425", new Guid("2fab997b-0454-4dbd-ade5-893af8dcaa7d"), "Service Cuidado Vespertino", 77 },
                    { new Guid("e3913bcc-6648-4e70-bf09-631a46954f81"), "Service", 4824m, "SRV-727", new Guid("477aef3a-3b50-4c3a-b5a8-50e41b831439"), "Service Cuidado dia completo", 77 },
                    { new Guid("16a01a55-2bcf-430d-a9ca-59cfac0786b8"), "Service", 1073m, "SRV-353", new Guid("3646c0db-030c-44ae-b8dd-cbd419318c9e"), "Service Clases de Ballet", 77 },
                    { new Guid("ee5c2991-3737-49db-b596-06c187d857b0"), "Service", 9932m, "SRV-779", new Guid("2fcb55d6-689d-4e2e-9fe1-bc28122dc5da"), "Service Clases de logica", 77 }
                });
        }
    }
}
