using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Adding_TutorSecundary_to_Kid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("0f7c6b56-928f-4aa0-a7f6-12d4fe1e4fe1"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("13a3865b-b3e0-4673-a876-8f871b0d1b7c"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("26ecac98-8285-4620-bd0b-bce16443c83b"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("96871fdd-f0d4-44a2-9703-a1bb3f059abd"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("9c88680b-8ffe-4b84-ad06-d17f97f93a11"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("0ed2e4fd-f755-46d2-aebb-3f3216c5b3b5"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("23d70a44-77c8-426c-a91d-7b1970912142"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("44236066-9f88-4879-bffd-6a84cd8adc77"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("692e5f12-abfd-4df0-9c8e-168457692e4c"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("959041e4-ee86-4577-8f9a-d9186904ec17"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("c09e0427-8e66-4445-a7f0-2e644aa71eec"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("09578ab0-2e44-41f5-944d-c425b92e96b5"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0a4802bb-e02d-49bc-9e4e-5e0de0152635"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0ab5dffb-80e6-4209-8112-deb27c032810"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0c652477-7662-4204-90ac-a06228197e63"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0c996e27-5252-4512-ab5e-ba6047dc9e71"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("2d6040a3-b05c-440e-b3a6-be02fa9cd575"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("1326f828-d5ef-4117-aaa4-7b1f4b34ac7e"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("3312b7e3-c04a-4be2-8f9b-3cf4f574f288"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("66a4f647-dff5-4f81-b865-7a45427a68af"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("7fc358e5-25b1-4b42-8ebd-6b8c1e98f675"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("8bb1277f-8967-4a2b-ac36-1c8d52050b68"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("a106b783-137c-474f-802a-61000f55952e"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("0666e8fd-cb25-49c3-b0ef-5eb80897ca6b"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("24673ef2-f1b7-47d6-84f4-e99538690ebb"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("2d87e04e-b81c-4410-96d5-4640e2408c9e"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("5012fced-b301-46ba-aeda-b2d70e8bc60d"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("7919813f-5c96-4e09-b576-957322ab4400"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("27af2180-3ff7-45fc-9743-4ed7bf5d6b98"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("4ea02d29-0ea6-4b83-b875-cede1059ad09"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("79603975-f59b-457f-bf3d-0efb44efa16e"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("d915fe3a-b9a7-4b30-b3c4-e3c16c104c60"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("e99eba97-ff7a-4bcd-95f6-10bcf5256041"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("ffd9e183-cf99-45d8-867e-3037b13bea8b"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("017bd1bf-416d-4fc0-95c8-103b1fb7b7c2"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("02eae199-c9f9-4c3f-abde-54c654b4fad2"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("043c5b84-774e-4435-8d64-a23403154215"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("048125a2-fe5f-4da2-8b03-1f38cf2147c6"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("07773e11-cf9b-4236-b6b0-8b6521eddbc1"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("eb510eaa-d99b-4dbf-980a-0af1411a3a8d"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("658fb13b-6f73-46bc-bcff-71da8a05805e"));

            migrationBuilder.AddColumn<Guid>(
                name: "TutorSecundaryId",
                table: "Kid",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("51af87e0-2918-459b-ae69-d487052307e4"), "KPH" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("239cad8d-3bfc-4520-be32-a5bb02eee899"), null, "Gregorio de Jesus", "Rojas Acosta", null, null, null });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("c04dbe8c-eba2-4c77-8f46-7f8402957cc9"), null, "Yadira", "Pinales Delgado", null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityTemplate",
                columns: new[] { "Id", "Description", "KindergarterId" },
                values: new object[,]
                {
                    { new Guid("84421da6-e3bb-4cb9-8cb0-09f872d43e51"), "Clases de ingles", new Guid("51af87e0-2918-459b-ae69-d487052307e4") },
                    { new Guid("72a9f25c-dcc3-4bcc-9297-ed761836dd1c"), "Cuidade matutino", new Guid("51af87e0-2918-459b-ae69-d487052307e4") },
                    { new Guid("97f36898-913c-400c-a03c-198411367dc2"), "Cuidado Vespertino", new Guid("51af87e0-2918-459b-ae69-d487052307e4") },
                    { new Guid("d0aa6637-5380-46a4-aa70-a7d14ceaa9c0"), "Cuidado dia completo", new Guid("51af87e0-2918-459b-ae69-d487052307e4") },
                    { new Guid("36940db3-dea1-43c6-b907-966af699e5a2"), "Clases de Ballet", new Guid("51af87e0-2918-459b-ae69-d487052307e4") },
                    { new Guid("89e442ff-656e-4fdf-a46d-44c72cc31c10"), "Clases de logica", new Guid("51af87e0-2918-459b-ae69-d487052307e4") }
                });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "Address", "BirthDate", "Diseases", "FatherName", "FavoriteActivities", "FirstName", "KindergarterId", "MotherName", "PediatricianId", "SecondName", "Sex", "SiblingCount", "TShirtSize", "TutorId", "TutorPrincipalId", "TutorSecundaryId" },
                values: new object[,]
                {
                    { new Guid("00091a53-fed5-4037-bd5c-e9b20d2c7d08"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Faringtom", null, "Johan", new Guid("51af87e0-2918-459b-ae69-d487052307e4"), "Washinton", null, "Eduardo", 0, 0, 0, null, new Guid("239cad8d-3bfc-4520-be32-a5bb02eee899"), null },
                    { new Guid("0025e092-4df1-4844-b8a0-295e05454804"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Faringtom", null, "Lyan", new Guid("51af87e0-2918-459b-ae69-d487052307e4"), "Washinton", null, "Eduardo", 0, 0, 0, null, new Guid("239cad8d-3bfc-4520-be32-a5bb02eee899"), null },
                    { new Guid("00c58263-eed5-4a10-805d-37eda69e0780"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Stackeetam", null, "Aaron", new Guid("51af87e0-2918-459b-ae69-d487052307e4"), "Snow", null, "Eduardo", 0, 0, 0, null, new Guid("239cad8d-3bfc-4520-be32-a5bb02eee899"), null },
                    { new Guid("0123a20e-fe35-48da-93e3-ecb845100cef"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Faringtom", null, "Lyan", new Guid("51af87e0-2918-459b-ae69-d487052307e4"), "Worm", null, "Enrique", 0, 0, 0, null, new Guid("239cad8d-3bfc-4520-be32-a5bb02eee899"), null },
                    { new Guid("01271909-de28-45f7-93be-9a78edbe3413"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Stackeetam", null, "Johan", new Guid("51af87e0-2918-459b-ae69-d487052307e4"), "Worm", null, "Emilio", 0, 0, 0, null, new Guid("239cad8d-3bfc-4520-be32-a5bb02eee899"), null },
                    { new Guid("018bd892-0497-4bd4-982f-513068c44c59"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Escobar", null, "Johan", new Guid("51af87e0-2918-459b-ae69-d487052307e4"), "Snow", null, "Carlos", 0, 0, 0, null, new Guid("239cad8d-3bfc-4520-be32-a5bb02eee899"), null },
                    { new Guid("018e7a0a-bd29-40ba-8827-55483f3f16ee"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Stackeetam", null, "Dylan", new Guid("51af87e0-2918-459b-ae69-d487052307e4"), "Washinton", null, "Enrique", 0, 0, 0, null, new Guid("239cad8d-3bfc-4520-be32-a5bb02eee899"), null },
                    { new Guid("040e0cf9-723a-436f-a7a3-629743068b8a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lee", null, "Dylan", new Guid("51af87e0-2918-459b-ae69-d487052307e4"), "Worm", null, "Eduardo", 0, 0, 0, null, new Guid("239cad8d-3bfc-4520-be32-a5bb02eee899"), null },
                    { new Guid("043a2596-7cd2-4f2f-b1e7-322a378a6d55"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Escobar", null, "Lyan", new Guid("51af87e0-2918-459b-ae69-d487052307e4"), "Washinton", null, "Eduardo", 0, 0, 0, null, new Guid("239cad8d-3bfc-4520-be32-a5bb02eee899"), null },
                    { new Guid("04470ba6-b289-4978-9179-9935905da9a5"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lee", null, "Dylan", new Guid("51af87e0-2918-459b-ae69-d487052307e4"), "Snow", null, "Eduardo", 0, 0, 0, null, new Guid("239cad8d-3bfc-4520-be32-a5bb02eee899"), null }
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "Id", "ActivityTemplateId", "Description" },
                values: new object[,]
                {
                    { new Guid("b42040ee-4c33-449a-881c-99428ba496b3"), new Guid("84421da6-e3bb-4cb9-8cb0-09f872d43e51"), "Clases de ingles" },
                    { new Guid("abb09f6f-7aa5-4822-b299-600d84a74f46"), new Guid("72a9f25c-dcc3-4bcc-9297-ed761836dd1c"), "Cuidade matutino" },
                    { new Guid("c2f2cdc8-92f9-4586-9bed-fd358bffd15a"), new Guid("97f36898-913c-400c-a03c-198411367dc2"), "Cuidado Vespertino" },
                    { new Guid("6b5e622f-b719-438f-90f8-3c5eaba2bc0c"), new Guid("d0aa6637-5380-46a4-aa70-a7d14ceaa9c0"), "Cuidado dia completo" },
                    { new Guid("b6b08d32-7d08-4bfb-bee7-69c8c67266f9"), new Guid("36940db3-dea1-43c6-b907-966af699e5a2"), "Clases de Ballet" },
                    { new Guid("38fd512a-b0bd-4970-b1c7-751b89bcf254"), new Guid("89e442ff-656e-4fdf-a46d-44c72cc31c10"), "Clases de logica" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "Comment", "EnrollDay", "KidId" },
                values: new object[,]
                {
                    { new Guid("49204268-3769-48c2-8584-5aec9caefab3"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00091a53-fed5-4037-bd5c-e9b20d2c7d08") },
                    { new Guid("6687c358-8d3b-419f-a1a6-bae06994201c"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0025e092-4df1-4844-b8a0-295e05454804") },
                    { new Guid("6bd5ec18-0e76-4751-8610-4cfdd2d89a87"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00c58263-eed5-4a10-805d-37eda69e0780") },
                    { new Guid("76588d1a-fdc3-464b-a87b-cb8b3c867be4"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0123a20e-fe35-48da-93e3-ecb845100cef") },
                    { new Guid("4d2291a3-3a4c-48e8-b243-8c96b961b617"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("01271909-de28-45f7-93be-9a78edbe3413") }
                });

            migrationBuilder.InsertData(
                table: "EnrollActivity",
                columns: new[] { "Id", "ActivityId", "EnrollmentId" },
                values: new object[,]
                {
                    { new Guid("a63c4d56-8a39-4ac4-b90c-92be1e4bb3d0"), new Guid("c2f2cdc8-92f9-4586-9bed-fd358bffd15a"), new Guid("49204268-3769-48c2-8584-5aec9caefab3") },
                    { new Guid("dd3e2ee1-4247-474b-9381-9283c609c1b8"), new Guid("b6b08d32-7d08-4bfb-bee7-69c8c67266f9"), new Guid("6687c358-8d3b-419f-a1a6-bae06994201c") },
                    { new Guid("1e6c5380-5910-4e8a-87ae-7a74a5abf075"), new Guid("b6b08d32-7d08-4bfb-bee7-69c8c67266f9"), new Guid("6bd5ec18-0e76-4751-8610-4cfdd2d89a87") },
                    { new Guid("6be8e0d4-c7d4-4cf1-8ce8-a458df47908f"), new Guid("38fd512a-b0bd-4970-b1c7-751b89bcf254"), new Guid("76588d1a-fdc3-464b-a87b-cb8b3c867be4") },
                    { new Guid("26681be5-7a6c-40e1-83b5-e416f7b7ca08"), new Guid("abb09f6f-7aa5-4822-b299-600d84a74f46"), new Guid("4d2291a3-3a4c-48e8-b243-8c96b961b617") }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Price", "Reference", "ActivityId", "Description", "ServicePeriod" },
                values: new object[,]
                {
                    { new Guid("9041b72b-d1c9-4463-b55c-ae785a9fccb6"), "Service", 8085m, "SRV-361", new Guid("b42040ee-4c33-449a-881c-99428ba496b3"), "Service Clases de ingles", 77 },
                    { new Guid("5ac835d3-fb32-429b-9b88-691c74a08a25"), "Service", 1494m, "SRV-910", new Guid("abb09f6f-7aa5-4822-b299-600d84a74f46"), "Service Cuidade matutino", 77 },
                    { new Guid("04342f79-c97f-4ab3-a53c-003d15b57f04"), "Service", 2654m, "SRV-167", new Guid("c2f2cdc8-92f9-4586-9bed-fd358bffd15a"), "Service Cuidado Vespertino", 77 },
                    { new Guid("2c5b686a-cd6b-4639-a49d-964408624160"), "Service", 892m, "SRV-467", new Guid("6b5e622f-b719-438f-90f8-3c5eaba2bc0c"), "Service Cuidado dia completo", 77 },
                    { new Guid("afae4ea6-e903-4790-a969-c34c742b784e"), "Service", 8535m, "SRV-947", new Guid("b6b08d32-7d08-4bfb-bee7-69c8c67266f9"), "Service Clases de Ballet", 77 },
                    { new Guid("eb3bb085-4452-4407-a562-04f1f0ef8b66"), "Service", 1965m, "SRV-864", new Guid("38fd512a-b0bd-4970-b1c7-751b89bcf254"), "Service Clases de logica", 77 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kid_TutorSecundaryId",
                table: "Kid",
                column: "TutorSecundaryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kid_Tutors_TutorSecundaryId",
                table: "Kid",
                column: "TutorSecundaryId",
                principalTable: "Tutors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kid_Tutors_TutorSecundaryId",
                table: "Kid");

            migrationBuilder.DropIndex(
                name: "IX_Kid_TutorSecundaryId",
                table: "Kid");

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("1e6c5380-5910-4e8a-87ae-7a74a5abf075"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("26681be5-7a6c-40e1-83b5-e416f7b7ca08"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("6be8e0d4-c7d4-4cf1-8ce8-a458df47908f"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("a63c4d56-8a39-4ac4-b90c-92be1e4bb3d0"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("dd3e2ee1-4247-474b-9381-9283c609c1b8"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("04342f79-c97f-4ab3-a53c-003d15b57f04"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("2c5b686a-cd6b-4639-a49d-964408624160"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("5ac835d3-fb32-429b-9b88-691c74a08a25"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("9041b72b-d1c9-4463-b55c-ae785a9fccb6"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("afae4ea6-e903-4790-a969-c34c742b784e"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("eb3bb085-4452-4407-a562-04f1f0ef8b66"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("018bd892-0497-4bd4-982f-513068c44c59"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("018e7a0a-bd29-40ba-8827-55483f3f16ee"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("040e0cf9-723a-436f-a7a3-629743068b8a"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("043a2596-7cd2-4f2f-b1e7-322a378a6d55"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("04470ba6-b289-4978-9179-9935905da9a5"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("c04dbe8c-eba2-4c77-8f46-7f8402957cc9"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("38fd512a-b0bd-4970-b1c7-751b89bcf254"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("6b5e622f-b719-438f-90f8-3c5eaba2bc0c"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("abb09f6f-7aa5-4822-b299-600d84a74f46"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("b42040ee-4c33-449a-881c-99428ba496b3"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("b6b08d32-7d08-4bfb-bee7-69c8c67266f9"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("c2f2cdc8-92f9-4586-9bed-fd358bffd15a"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("49204268-3769-48c2-8584-5aec9caefab3"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("4d2291a3-3a4c-48e8-b243-8c96b961b617"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("6687c358-8d3b-419f-a1a6-bae06994201c"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("6bd5ec18-0e76-4751-8610-4cfdd2d89a87"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("76588d1a-fdc3-464b-a87b-cb8b3c867be4"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("36940db3-dea1-43c6-b907-966af699e5a2"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("72a9f25c-dcc3-4bcc-9297-ed761836dd1c"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("84421da6-e3bb-4cb9-8cb0-09f872d43e51"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("89e442ff-656e-4fdf-a46d-44c72cc31c10"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("97f36898-913c-400c-a03c-198411367dc2"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("d0aa6637-5380-46a4-aa70-a7d14ceaa9c0"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("00091a53-fed5-4037-bd5c-e9b20d2c7d08"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0025e092-4df1-4844-b8a0-295e05454804"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("00c58263-eed5-4a10-805d-37eda69e0780"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0123a20e-fe35-48da-93e3-ecb845100cef"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("01271909-de28-45f7-93be-9a78edbe3413"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("51af87e0-2918-459b-ae69-d487052307e4"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("239cad8d-3bfc-4520-be32-a5bb02eee899"));

            migrationBuilder.DropColumn(
                name: "TutorSecundaryId",
                table: "Kid");

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("eb510eaa-d99b-4dbf-980a-0af1411a3a8d"), "KPH" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("658fb13b-6f73-46bc-bcff-71da8a05805e"), null, "Gregorio de Jesus", "Rojas Acosta", null, null, null });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("2d6040a3-b05c-440e-b3a6-be02fa9cd575"), null, "Yadira", "Pinales Delgado", null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityTemplate",
                columns: new[] { "Id", "Description", "KindergarterId" },
                values: new object[,]
                {
                    { new Guid("79603975-f59b-457f-bf3d-0efb44efa16e"), "Clases de ingles", new Guid("eb510eaa-d99b-4dbf-980a-0af1411a3a8d") },
                    { new Guid("27af2180-3ff7-45fc-9743-4ed7bf5d6b98"), "Cuidade matutino", new Guid("eb510eaa-d99b-4dbf-980a-0af1411a3a8d") },
                    { new Guid("ffd9e183-cf99-45d8-867e-3037b13bea8b"), "Cuidado Vespertino", new Guid("eb510eaa-d99b-4dbf-980a-0af1411a3a8d") },
                    { new Guid("4ea02d29-0ea6-4b83-b875-cede1059ad09"), "Cuidado dia completo", new Guid("eb510eaa-d99b-4dbf-980a-0af1411a3a8d") },
                    { new Guid("e99eba97-ff7a-4bcd-95f6-10bcf5256041"), "Clases de Ballet", new Guid("eb510eaa-d99b-4dbf-980a-0af1411a3a8d") },
                    { new Guid("d915fe3a-b9a7-4b30-b3c4-e3c16c104c60"), "Clases de logica", new Guid("eb510eaa-d99b-4dbf-980a-0af1411a3a8d") }
                });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "Address", "BirthDate", "Diseases", "FatherName", "FavoriteActivities", "FirstName", "KindergarterId", "MotherName", "PediatricianId", "SecondName", "Sex", "SiblingCount", "TShirtSize", "TutorId", "TutorPrincipalId" },
                values: new object[,]
                {
                    { new Guid("017bd1bf-416d-4fc0-95c8-103b1fb7b7c2"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Faringtom", null, "Johan", new Guid("eb510eaa-d99b-4dbf-980a-0af1411a3a8d"), "Snow", null, "Carlos", 0, 0, 0, null, new Guid("658fb13b-6f73-46bc-bcff-71da8a05805e") },
                    { new Guid("02eae199-c9f9-4c3f-abde-54c654b4fad2"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Escobar", null, "Johan", new Guid("eb510eaa-d99b-4dbf-980a-0af1411a3a8d"), "Worm", null, "Eduardo", 0, 0, 0, null, new Guid("658fb13b-6f73-46bc-bcff-71da8a05805e") },
                    { new Guid("043c5b84-774e-4435-8d64-a23403154215"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lee", null, "Dylan", new Guid("eb510eaa-d99b-4dbf-980a-0af1411a3a8d"), "Worm", null, "Eduardo", 0, 0, 0, null, new Guid("658fb13b-6f73-46bc-bcff-71da8a05805e") },
                    { new Guid("048125a2-fe5f-4da2-8b03-1f38cf2147c6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lee", null, "Lyan", new Guid("eb510eaa-d99b-4dbf-980a-0af1411a3a8d"), "Snow", null, "Carlos", 0, 0, 0, null, new Guid("658fb13b-6f73-46bc-bcff-71da8a05805e") },
                    { new Guid("07773e11-cf9b-4236-b6b0-8b6521eddbc1"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lee", null, "Johan", new Guid("eb510eaa-d99b-4dbf-980a-0af1411a3a8d"), "Washinton", null, "Carlos", 0, 0, 0, null, new Guid("658fb13b-6f73-46bc-bcff-71da8a05805e") },
                    { new Guid("09578ab0-2e44-41f5-944d-c425b92e96b5"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Escobar", null, "Dylan", new Guid("eb510eaa-d99b-4dbf-980a-0af1411a3a8d"), "White", null, "Carlos", 0, 0, 0, null, new Guid("658fb13b-6f73-46bc-bcff-71da8a05805e") },
                    { new Guid("0a4802bb-e02d-49bc-9e4e-5e0de0152635"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Stackeetam", null, "Lyan", new Guid("eb510eaa-d99b-4dbf-980a-0af1411a3a8d"), "White", null, "Carlos", 0, 0, 0, null, new Guid("658fb13b-6f73-46bc-bcff-71da8a05805e") },
                    { new Guid("0ab5dffb-80e6-4209-8112-deb27c032810"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Escobar", null, "Aaron", new Guid("eb510eaa-d99b-4dbf-980a-0af1411a3a8d"), "Snow", null, "Carlos", 0, 0, 0, null, new Guid("658fb13b-6f73-46bc-bcff-71da8a05805e") },
                    { new Guid("0c652477-7662-4204-90ac-a06228197e63"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Stackeetam", null, "Johan", new Guid("eb510eaa-d99b-4dbf-980a-0af1411a3a8d"), "Worm", null, "Carlos", 0, 0, 0, null, new Guid("658fb13b-6f73-46bc-bcff-71da8a05805e") },
                    { new Guid("0c996e27-5252-4512-ab5e-ba6047dc9e71"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Escobar", null, "Aaron", new Guid("eb510eaa-d99b-4dbf-980a-0af1411a3a8d"), "White", null, "Eduardo", 0, 0, 0, null, new Guid("658fb13b-6f73-46bc-bcff-71da8a05805e") }
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "Id", "ActivityTemplateId", "Description" },
                values: new object[,]
                {
                    { new Guid("8bb1277f-8967-4a2b-ac36-1c8d52050b68"), new Guid("79603975-f59b-457f-bf3d-0efb44efa16e"), "Clases de ingles" },
                    { new Guid("3312b7e3-c04a-4be2-8f9b-3cf4f574f288"), new Guid("27af2180-3ff7-45fc-9743-4ed7bf5d6b98"), "Cuidade matutino" },
                    { new Guid("a106b783-137c-474f-802a-61000f55952e"), new Guid("ffd9e183-cf99-45d8-867e-3037b13bea8b"), "Cuidado Vespertino" },
                    { new Guid("7fc358e5-25b1-4b42-8ebd-6b8c1e98f675"), new Guid("4ea02d29-0ea6-4b83-b875-cede1059ad09"), "Cuidado dia completo" },
                    { new Guid("66a4f647-dff5-4f81-b865-7a45427a68af"), new Guid("e99eba97-ff7a-4bcd-95f6-10bcf5256041"), "Clases de Ballet" },
                    { new Guid("1326f828-d5ef-4117-aaa4-7b1f4b34ac7e"), new Guid("d915fe3a-b9a7-4b30-b3c4-e3c16c104c60"), "Clases de logica" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "Comment", "EnrollDay", "KidId" },
                values: new object[,]
                {
                    { new Guid("24673ef2-f1b7-47d6-84f4-e99538690ebb"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("017bd1bf-416d-4fc0-95c8-103b1fb7b7c2") },
                    { new Guid("5012fced-b301-46ba-aeda-b2d70e8bc60d"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("02eae199-c9f9-4c3f-abde-54c654b4fad2") },
                    { new Guid("0666e8fd-cb25-49c3-b0ef-5eb80897ca6b"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("043c5b84-774e-4435-8d64-a23403154215") },
                    { new Guid("7919813f-5c96-4e09-b576-957322ab4400"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("048125a2-fe5f-4da2-8b03-1f38cf2147c6") },
                    { new Guid("2d87e04e-b81c-4410-96d5-4640e2408c9e"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("07773e11-cf9b-4236-b6b0-8b6521eddbc1") }
                });

            migrationBuilder.InsertData(
                table: "EnrollActivity",
                columns: new[] { "Id", "ActivityId", "EnrollmentId" },
                values: new object[,]
                {
                    { new Guid("26ecac98-8285-4620-bd0b-bce16443c83b"), new Guid("a106b783-137c-474f-802a-61000f55952e"), new Guid("24673ef2-f1b7-47d6-84f4-e99538690ebb") },
                    { new Guid("96871fdd-f0d4-44a2-9703-a1bb3f059abd"), new Guid("7fc358e5-25b1-4b42-8ebd-6b8c1e98f675"), new Guid("5012fced-b301-46ba-aeda-b2d70e8bc60d") },
                    { new Guid("9c88680b-8ffe-4b84-ad06-d17f97f93a11"), new Guid("66a4f647-dff5-4f81-b865-7a45427a68af"), new Guid("0666e8fd-cb25-49c3-b0ef-5eb80897ca6b") },
                    { new Guid("0f7c6b56-928f-4aa0-a7f6-12d4fe1e4fe1"), new Guid("1326f828-d5ef-4117-aaa4-7b1f4b34ac7e"), new Guid("7919813f-5c96-4e09-b576-957322ab4400") },
                    { new Guid("13a3865b-b3e0-4673-a876-8f871b0d1b7c"), new Guid("8bb1277f-8967-4a2b-ac36-1c8d52050b68"), new Guid("2d87e04e-b81c-4410-96d5-4640e2408c9e") }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Price", "Reference", "ActivityId", "Description", "ServicePeriod" },
                values: new object[,]
                {
                    { new Guid("959041e4-ee86-4577-8f9a-d9186904ec17"), "Service", 7591m, "SRV-39", new Guid("8bb1277f-8967-4a2b-ac36-1c8d52050b68"), "Service Clases de ingles", 77 },
                    { new Guid("23d70a44-77c8-426c-a91d-7b1970912142"), "Service", 8977m, "SRV-2", new Guid("3312b7e3-c04a-4be2-8f9b-3cf4f574f288"), "Service Cuidade matutino", 77 },
                    { new Guid("c09e0427-8e66-4445-a7f0-2e644aa71eec"), "Service", 4196m, "SRV-280", new Guid("a106b783-137c-474f-802a-61000f55952e"), "Service Cuidado Vespertino", 77 },
                    { new Guid("692e5f12-abfd-4df0-9c8e-168457692e4c"), "Service", 4936m, "SRV-720", new Guid("7fc358e5-25b1-4b42-8ebd-6b8c1e98f675"), "Service Cuidado dia completo", 77 },
                    { new Guid("0ed2e4fd-f755-46d2-aebb-3f3216c5b3b5"), "Service", 897m, "SRV-887", new Guid("66a4f647-dff5-4f81-b865-7a45427a68af"), "Service Clases de Ballet", 77 },
                    { new Guid("44236066-9f88-4879-bffd-6a84cd8adc77"), "Service", 7020m, "SRV-55", new Guid("1326f828-d5ef-4117-aaa4-7b1f4b34ac7e"), "Service Clases de logica", 77 }
                });
        }
    }
}
