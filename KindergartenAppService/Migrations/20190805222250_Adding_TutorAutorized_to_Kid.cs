using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Adding_TutorAutorized_to_Kid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<Guid>(
                name: "TutorAutorizedId",
                table: "Kid",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("eb4df537-a2fe-4742-9199-1440d8f89257"), "KPH" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("ba831be7-0bd9-4e32-b355-f3de57a96f54"), null, "Gregorio de Jesus", "Rojas Acosta", null, null, null });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("96aa0978-cc00-435d-acbe-27b7fc1337da"), null, "Yadira", "Pinales Delgado", null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityTemplate",
                columns: new[] { "Id", "Description", "KindergarterId" },
                values: new object[,]
                {
                    { new Guid("f9235fbe-cf0c-4c74-a817-b40a49b0a979"), "Clases de ingles", new Guid("eb4df537-a2fe-4742-9199-1440d8f89257") },
                    { new Guid("c5e7e563-8ebd-455d-9e00-79770c46698e"), "Cuidade matutino", new Guid("eb4df537-a2fe-4742-9199-1440d8f89257") },
                    { new Guid("43c573ea-b2eb-40c1-8221-7359d3a65b88"), "Cuidado Vespertino", new Guid("eb4df537-a2fe-4742-9199-1440d8f89257") },
                    { new Guid("0501e0de-6c22-4279-9f14-8bf500dceb17"), "Cuidado dia completo", new Guid("eb4df537-a2fe-4742-9199-1440d8f89257") },
                    { new Guid("05af409f-c46b-4737-b55c-75d57a456c6e"), "Clases de Ballet", new Guid("eb4df537-a2fe-4742-9199-1440d8f89257") },
                    { new Guid("0f82e686-dc38-479d-9552-f0025e84dab7"), "Clases de logica", new Guid("eb4df537-a2fe-4742-9199-1440d8f89257") }
                });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "Address", "BirthDate", "Diseases", "FatherName", "FavoriteActivities", "FirstName", "KindergarterId", "MotherName", "PediatricianId", "SecondName", "Sex", "SiblingCount", "TShirtSize", "TutorAutorizedId", "TutorId", "TutorPrincipalId", "TutorSecundaryId" },
                values: new object[,]
                {
                    { new Guid("0107af35-bb37-488e-bd67-0fda79132b6d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Faringtom", null, "Aaron", new Guid("eb4df537-a2fe-4742-9199-1440d8f89257"), "Washinton", null, "Carlos", 0, 0, 0, null, null, new Guid("ba831be7-0bd9-4e32-b355-f3de57a96f54"), null },
                    { new Guid("01b9678f-2082-4edf-8af7-191f1a512e89"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Faringtom", null, "Dylan", new Guid("eb4df537-a2fe-4742-9199-1440d8f89257"), "Snow", null, "Enrique", 0, 0, 0, null, null, new Guid("ba831be7-0bd9-4e32-b355-f3de57a96f54"), null },
                    { new Guid("039f019c-28f9-4b73-ae43-c2ab9f31eb40"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lee", null, "Lyan", new Guid("eb4df537-a2fe-4742-9199-1440d8f89257"), "White", null, "Carlos", 0, 0, 0, null, null, new Guid("ba831be7-0bd9-4e32-b355-f3de57a96f54"), null },
                    { new Guid("04629a6a-69b9-443d-b91b-f94b22322c00"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lee", null, "Aaron", new Guid("eb4df537-a2fe-4742-9199-1440d8f89257"), "Washinton", null, "Enrique", 0, 0, 0, null, null, new Guid("ba831be7-0bd9-4e32-b355-f3de57a96f54"), null },
                    { new Guid("04a4d77d-3304-46f9-9028-a7c134c3b192"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Escobar", null, "Lyan", new Guid("eb4df537-a2fe-4742-9199-1440d8f89257"), "Washinton", null, "Enrique", 0, 0, 0, null, null, new Guid("ba831be7-0bd9-4e32-b355-f3de57a96f54"), null },
                    { new Guid("0560d00b-fed5-4189-b35d-ea4d0d2486a7"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lee", null, "Dylan", new Guid("eb4df537-a2fe-4742-9199-1440d8f89257"), "Worm", null, "Eduardo", 0, 0, 0, null, null, new Guid("ba831be7-0bd9-4e32-b355-f3de57a96f54"), null },
                    { new Guid("05b1a20d-c9ac-4a95-a145-1924ce10efcd"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lee", null, "Aaron", new Guid("eb4df537-a2fe-4742-9199-1440d8f89257"), "Washinton", null, "Emilio", 0, 0, 0, null, null, new Guid("ba831be7-0bd9-4e32-b355-f3de57a96f54"), null },
                    { new Guid("06b0bfa1-2f69-4d49-86c8-2d51fb2836e7"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Stackeetam", null, "Aaron", new Guid("eb4df537-a2fe-4742-9199-1440d8f89257"), "Worm", null, "Enrique", 0, 0, 0, null, null, new Guid("ba831be7-0bd9-4e32-b355-f3de57a96f54"), null },
                    { new Guid("0d34c466-795d-4ad1-958a-3a193f97fda2"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Escobar", null, "Lyan", new Guid("eb4df537-a2fe-4742-9199-1440d8f89257"), "White", null, "Emilio", 0, 0, 0, null, null, new Guid("ba831be7-0bd9-4e32-b355-f3de57a96f54"), null },
                    { new Guid("0d78c112-5e27-402b-9517-90782fc5bdee"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Faringtom", null, "Aaron", new Guid("eb4df537-a2fe-4742-9199-1440d8f89257"), "White", null, "Emilio", 0, 0, 0, null, null, new Guid("ba831be7-0bd9-4e32-b355-f3de57a96f54"), null }
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "Id", "ActivityTemplateId", "Description" },
                values: new object[,]
                {
                    { new Guid("71487dd9-0eed-44d9-aae5-9ddf085aefd0"), new Guid("f9235fbe-cf0c-4c74-a817-b40a49b0a979"), "Clases de ingles" },
                    { new Guid("1290235e-1037-45d9-b9b3-4b5fc3918ada"), new Guid("c5e7e563-8ebd-455d-9e00-79770c46698e"), "Cuidade matutino" },
                    { new Guid("f0451cea-b825-4614-83b6-ea86c9d6b291"), new Guid("43c573ea-b2eb-40c1-8221-7359d3a65b88"), "Cuidado Vespertino" },
                    { new Guid("ed6d5ae4-ba00-40d4-8ea8-d382e5ea9de1"), new Guid("0501e0de-6c22-4279-9f14-8bf500dceb17"), "Cuidado dia completo" },
                    { new Guid("09660603-09fb-4f75-82bc-d827b0e14dc5"), new Guid("05af409f-c46b-4737-b55c-75d57a456c6e"), "Clases de Ballet" },
                    { new Guid("9227d683-1730-47af-8b3d-c409b32a4100"), new Guid("0f82e686-dc38-479d-9552-f0025e84dab7"), "Clases de logica" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "Comment", "EnrollDay", "KidId" },
                values: new object[,]
                {
                    { new Guid("62c67059-8279-4b24-92c8-513fd5bf15f3"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0107af35-bb37-488e-bd67-0fda79132b6d") },
                    { new Guid("43c34b15-7129-4d67-9040-aa07dff64207"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("01b9678f-2082-4edf-8af7-191f1a512e89") },
                    { new Guid("62837b88-e9d4-419f-8235-f047fd436595"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("039f019c-28f9-4b73-ae43-c2ab9f31eb40") },
                    { new Guid("bd63b8b5-dafa-45d8-b1a8-7c048fcf9f0b"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("04629a6a-69b9-443d-b91b-f94b22322c00") },
                    { new Guid("cb9ea899-f28a-4684-af5c-017814cc99a2"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("04a4d77d-3304-46f9-9028-a7c134c3b192") }
                });

            migrationBuilder.InsertData(
                table: "EnrollActivity",
                columns: new[] { "Id", "ActivityId", "EnrollmentId" },
                values: new object[,]
                {
                    { new Guid("7615f179-70c8-4326-bd60-479f3fca0e57"), new Guid("09660603-09fb-4f75-82bc-d827b0e14dc5"), new Guid("62c67059-8279-4b24-92c8-513fd5bf15f3") },
                    { new Guid("33110e30-fd27-433a-8230-fd4b1c01e313"), new Guid("71487dd9-0eed-44d9-aae5-9ddf085aefd0"), new Guid("43c34b15-7129-4d67-9040-aa07dff64207") },
                    { new Guid("cd602a42-d481-47c3-acd7-7a488d464d5c"), new Guid("71487dd9-0eed-44d9-aae5-9ddf085aefd0"), new Guid("62837b88-e9d4-419f-8235-f047fd436595") },
                    { new Guid("14fcf44a-ef7c-4159-b490-bf50d68be21a"), new Guid("1290235e-1037-45d9-b9b3-4b5fc3918ada"), new Guid("bd63b8b5-dafa-45d8-b1a8-7c048fcf9f0b") },
                    { new Guid("193f55e4-3785-4d7e-83af-c3717e450e27"), new Guid("71487dd9-0eed-44d9-aae5-9ddf085aefd0"), new Guid("cb9ea899-f28a-4684-af5c-017814cc99a2") }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Price", "Reference", "ActivityId", "Description", "ServicePeriod" },
                values: new object[,]
                {
                    { new Guid("f93ccaec-86e8-423c-a2f8-c51b72c699e7"), "Service", 6217m, "SRV-625", new Guid("71487dd9-0eed-44d9-aae5-9ddf085aefd0"), "Service Clases de ingles", 77 },
                    { new Guid("2b5bdf62-11b5-4228-9331-473fa9438daa"), "Service", 3951m, "SRV-769", new Guid("1290235e-1037-45d9-b9b3-4b5fc3918ada"), "Service Cuidade matutino", 77 },
                    { new Guid("1952abdc-a3ac-47d9-b881-106acff46e7f"), "Service", 5201m, "SRV-168", new Guid("f0451cea-b825-4614-83b6-ea86c9d6b291"), "Service Cuidado Vespertino", 77 },
                    { new Guid("48eb5331-6082-4319-a22b-9f9138a2d816"), "Service", 4009m, "SRV-123", new Guid("ed6d5ae4-ba00-40d4-8ea8-d382e5ea9de1"), "Service Cuidado dia completo", 77 },
                    { new Guid("4647ecc2-0fa7-4e99-8fba-08fb493b69b8"), "Service", 8049m, "SRV-997", new Guid("09660603-09fb-4f75-82bc-d827b0e14dc5"), "Service Clases de Ballet", 77 },
                    { new Guid("cf9c50fa-5419-435d-b959-80679c893ca4"), "Service", 849m, "SRV-862", new Guid("9227d683-1730-47af-8b3d-c409b32a4100"), "Service Clases de logica", 77 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kid_TutorAutorizedId",
                table: "Kid",
                column: "TutorAutorizedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kid_Tutors_TutorAutorizedId",
                table: "Kid",
                column: "TutorAutorizedId",
                principalTable: "Tutors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kid_Tutors_TutorAutorizedId",
                table: "Kid");

            migrationBuilder.DropIndex(
                name: "IX_Kid_TutorAutorizedId",
                table: "Kid");

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("14fcf44a-ef7c-4159-b490-bf50d68be21a"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("193f55e4-3785-4d7e-83af-c3717e450e27"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("33110e30-fd27-433a-8230-fd4b1c01e313"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("7615f179-70c8-4326-bd60-479f3fca0e57"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("cd602a42-d481-47c3-acd7-7a488d464d5c"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("1952abdc-a3ac-47d9-b881-106acff46e7f"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("2b5bdf62-11b5-4228-9331-473fa9438daa"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("4647ecc2-0fa7-4e99-8fba-08fb493b69b8"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("48eb5331-6082-4319-a22b-9f9138a2d816"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("cf9c50fa-5419-435d-b959-80679c893ca4"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("f93ccaec-86e8-423c-a2f8-c51b72c699e7"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0560d00b-fed5-4189-b35d-ea4d0d2486a7"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("05b1a20d-c9ac-4a95-a145-1924ce10efcd"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("06b0bfa1-2f69-4d49-86c8-2d51fb2836e7"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0d34c466-795d-4ad1-958a-3a193f97fda2"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0d78c112-5e27-402b-9517-90782fc5bdee"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("96aa0978-cc00-435d-acbe-27b7fc1337da"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("09660603-09fb-4f75-82bc-d827b0e14dc5"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("1290235e-1037-45d9-b9b3-4b5fc3918ada"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("71487dd9-0eed-44d9-aae5-9ddf085aefd0"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("9227d683-1730-47af-8b3d-c409b32a4100"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("ed6d5ae4-ba00-40d4-8ea8-d382e5ea9de1"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("f0451cea-b825-4614-83b6-ea86c9d6b291"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("43c34b15-7129-4d67-9040-aa07dff64207"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("62837b88-e9d4-419f-8235-f047fd436595"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("62c67059-8279-4b24-92c8-513fd5bf15f3"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("bd63b8b5-dafa-45d8-b1a8-7c048fcf9f0b"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("cb9ea899-f28a-4684-af5c-017814cc99a2"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("0501e0de-6c22-4279-9f14-8bf500dceb17"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("05af409f-c46b-4737-b55c-75d57a456c6e"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("0f82e686-dc38-479d-9552-f0025e84dab7"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("43c573ea-b2eb-40c1-8221-7359d3a65b88"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("c5e7e563-8ebd-455d-9e00-79770c46698e"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("f9235fbe-cf0c-4c74-a817-b40a49b0a979"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0107af35-bb37-488e-bd67-0fda79132b6d"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("01b9678f-2082-4edf-8af7-191f1a512e89"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("039f019c-28f9-4b73-ae43-c2ab9f31eb40"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("04629a6a-69b9-443d-b91b-f94b22322c00"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("04a4d77d-3304-46f9-9028-a7c134c3b192"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("eb4df537-a2fe-4742-9199-1440d8f89257"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("ba831be7-0bd9-4e32-b355-f3de57a96f54"));

            migrationBuilder.DropColumn(
                name: "TutorAutorizedId",
                table: "Kid");

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
        }
    }
}
