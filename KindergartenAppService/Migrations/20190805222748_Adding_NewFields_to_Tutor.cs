using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Adding_NewFields_to_Tutor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "Facebook",
                table: "Tutors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Identification",
                table: "Tutors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Instagram",
                table: "Tutors",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Relationship",
                table: "Tutors",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc"), "KPH" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "Facebook", "FirstName", "Identification", "Instagram", "LastName", "Mail", "MovilNumber", "PhoneNumber", "Relationship" },
                values: new object[] { new Guid("f4a95ab5-9a96-40d4-95be-6c8e036f5107"), null, null, "Gregorio de Jesus", null, null, "Rojas Acosta", null, null, null, 0 });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "Facebook", "FirstName", "Identification", "Instagram", "LastName", "Mail", "MovilNumber", "PhoneNumber", "Relationship" },
                values: new object[] { new Guid("07662e45-c74c-471b-9a51-5eb0eab737c6"), null, null, "Yadira", null, null, "Pinales Delgado", null, null, null, 0 });

            migrationBuilder.InsertData(
                table: "ActivityTemplate",
                columns: new[] { "Id", "Description", "KindergarterId" },
                values: new object[,]
                {
                    { new Guid("52680218-6927-4b78-b70f-da089f7c66ab"), "Clases de ingles", new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc") },
                    { new Guid("89afae68-4d45-4f6f-afae-b4a715c14e71"), "Cuidade matutino", new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc") },
                    { new Guid("d592df4d-57d6-4e12-afe3-45aad36f0f69"), "Cuidado Vespertino", new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc") },
                    { new Guid("53e9029c-b970-4357-83e8-6634ccb32527"), "Cuidado dia completo", new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc") },
                    { new Guid("61600c37-13e8-43dd-b8e7-e9f62a916335"), "Clases de Ballet", new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc") },
                    { new Guid("c4eb6cec-546f-4ff4-b8fa-87916ce2e1e2"), "Clases de logica", new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc") }
                });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "Address", "BirthDate", "Diseases", "FatherName", "FavoriteActivities", "FirstName", "KindergarterId", "MotherName", "PediatricianId", "SecondName", "Sex", "SiblingCount", "TShirtSize", "TutorAutorizedId", "TutorId", "TutorPrincipalId", "TutorSecundaryId" },
                values: new object[,]
                {
                    { new Guid("008e1b32-757a-4c4d-90d3-cace69412327"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lee", null, "Johan", new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc"), "Worm", null, "Carlos", 0, 0, 0, null, null, new Guid("f4a95ab5-9a96-40d4-95be-6c8e036f5107"), null },
                    { new Guid("0098f83a-5257-4247-a841-97dc3167b088"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Faringtom", null, "Johan", new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc"), "Washinton", null, "Enrique", 0, 0, 0, null, null, new Guid("f4a95ab5-9a96-40d4-95be-6c8e036f5107"), null },
                    { new Guid("01542ad7-82e1-4a29-83eb-e9555a2f9a37"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Escobar", null, "Aaron", new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc"), "White", null, "Enrique", 0, 0, 0, null, null, new Guid("f4a95ab5-9a96-40d4-95be-6c8e036f5107"), null },
                    { new Guid("03cbf736-0adc-446a-8c5f-86c20c338c84"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Faringtom", null, "Aaron", new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc"), "Snow", null, "Eduardo", 0, 0, 0, null, null, new Guid("f4a95ab5-9a96-40d4-95be-6c8e036f5107"), null },
                    { new Guid("03de317f-f94d-4a37-9eff-bf1dcac32088"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Stackeetam", null, "Lyan", new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc"), "Washinton", null, "Eduardo", 0, 0, 0, null, null, new Guid("f4a95ab5-9a96-40d4-95be-6c8e036f5107"), null },
                    { new Guid("069bb0ee-bdec-4415-97fb-114ed091e5cd"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Faringtom", null, "Lyan", new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc"), "Washinton", null, "Carlos", 0, 0, 0, null, null, new Guid("f4a95ab5-9a96-40d4-95be-6c8e036f5107"), null },
                    { new Guid("07902544-6e07-43af-8345-f11948b179e2"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lee", null, "Aaron", new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc"), "Worm", null, "Carlos", 0, 0, 0, null, null, new Guid("f4a95ab5-9a96-40d4-95be-6c8e036f5107"), null },
                    { new Guid("07aa97d6-d54b-42de-8cd2-d40bea395461"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lee", null, "Johan", new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc"), "Snow", null, "Carlos", 0, 0, 0, null, null, new Guid("f4a95ab5-9a96-40d4-95be-6c8e036f5107"), null },
                    { new Guid("08340cda-5c08-4dee-945d-d469627884dc"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Faringtom", null, "Dylan", new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc"), "Washinton", null, "Enrique", 0, 0, 0, null, null, new Guid("f4a95ab5-9a96-40d4-95be-6c8e036f5107"), null },
                    { new Guid("0924d5f0-63e8-41c9-8804-f90c34833ce6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Escobar", null, "Aaron", new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc"), "Worm", null, "Emilio", 0, 0, 0, null, null, new Guid("f4a95ab5-9a96-40d4-95be-6c8e036f5107"), null }
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "Id", "ActivityTemplateId", "Description" },
                values: new object[,]
                {
                    { new Guid("659924bd-1522-430a-b521-423964bea024"), new Guid("52680218-6927-4b78-b70f-da089f7c66ab"), "Clases de ingles" },
                    { new Guid("7c31f467-c0b1-4718-a92b-4fb078e34eb2"), new Guid("89afae68-4d45-4f6f-afae-b4a715c14e71"), "Cuidade matutino" },
                    { new Guid("b1b3bed4-a201-4aa5-9837-da2ff76e035d"), new Guid("d592df4d-57d6-4e12-afe3-45aad36f0f69"), "Cuidado Vespertino" },
                    { new Guid("16706578-21d5-48c4-bbec-7cc8d7ecd6d9"), new Guid("53e9029c-b970-4357-83e8-6634ccb32527"), "Cuidado dia completo" },
                    { new Guid("5e6a0154-ac07-4519-8513-fe9fe93ae6b9"), new Guid("61600c37-13e8-43dd-b8e7-e9f62a916335"), "Clases de Ballet" },
                    { new Guid("7493eac5-b59c-4343-8c60-9d4363c0f37f"), new Guid("c4eb6cec-546f-4ff4-b8fa-87916ce2e1e2"), "Clases de logica" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "Comment", "EnrollDay", "KidId" },
                values: new object[,]
                {
                    { new Guid("645d5ff6-88b3-4efd-bad6-58824277a99a"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("008e1b32-757a-4c4d-90d3-cace69412327") },
                    { new Guid("363174a4-711d-448c-b8a1-f13d7d8e2ae2"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0098f83a-5257-4247-a841-97dc3167b088") },
                    { new Guid("59f38413-4b46-4045-8627-f826e4c47e48"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("01542ad7-82e1-4a29-83eb-e9555a2f9a37") },
                    { new Guid("3e2f1a33-d057-4390-9882-e09b0a4ce9f9"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("03cbf736-0adc-446a-8c5f-86c20c338c84") },
                    { new Guid("9c527e12-6086-4a20-9d3e-1fa82f0e8ea2"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("03de317f-f94d-4a37-9eff-bf1dcac32088") }
                });

            migrationBuilder.InsertData(
                table: "EnrollActivity",
                columns: new[] { "Id", "ActivityId", "EnrollmentId" },
                values: new object[,]
                {
                    { new Guid("e352ff3b-ea93-4ccd-b38f-1670524bdf29"), new Guid("7c31f467-c0b1-4718-a92b-4fb078e34eb2"), new Guid("645d5ff6-88b3-4efd-bad6-58824277a99a") },
                    { new Guid("6b2878a8-b08d-4109-8a2b-5d76b210cec9"), new Guid("5e6a0154-ac07-4519-8513-fe9fe93ae6b9"), new Guid("363174a4-711d-448c-b8a1-f13d7d8e2ae2") },
                    { new Guid("5aed8a4d-f718-4b7b-be57-1653636a3f5b"), new Guid("b1b3bed4-a201-4aa5-9837-da2ff76e035d"), new Guid("59f38413-4b46-4045-8627-f826e4c47e48") },
                    { new Guid("e22035c0-ea70-49de-8edb-4ebc36111138"), new Guid("5e6a0154-ac07-4519-8513-fe9fe93ae6b9"), new Guid("3e2f1a33-d057-4390-9882-e09b0a4ce9f9") },
                    { new Guid("982929a0-d17f-4904-bda5-9ded2bf2c65d"), new Guid("5e6a0154-ac07-4519-8513-fe9fe93ae6b9"), new Guid("9c527e12-6086-4a20-9d3e-1fa82f0e8ea2") }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Price", "Reference", "ActivityId", "Description", "ServicePeriod" },
                values: new object[,]
                {
                    { new Guid("0098aef8-199e-41c0-91b7-0e7b2da7592c"), "Service", 7108m, "SRV-328", new Guid("659924bd-1522-430a-b521-423964bea024"), "Service Clases de ingles", 77 },
                    { new Guid("dc65a1f8-d529-4975-9aec-10cdb993878f"), "Service", 727m, "SRV-146", new Guid("7c31f467-c0b1-4718-a92b-4fb078e34eb2"), "Service Cuidade matutino", 77 },
                    { new Guid("efd16c04-5744-4717-b9fc-0e9e2e0a870e"), "Service", 5294m, "SRV-507", new Guid("b1b3bed4-a201-4aa5-9837-da2ff76e035d"), "Service Cuidado Vespertino", 77 },
                    { new Guid("904507a1-c82d-4173-ae47-5c3895fc8c1f"), "Service", 2957m, "SRV-558", new Guid("16706578-21d5-48c4-bbec-7cc8d7ecd6d9"), "Service Cuidado dia completo", 77 },
                    { new Guid("448d9918-4d8e-45b4-8a29-5506a1ba7bf6"), "Service", 560m, "SRV-966", new Guid("5e6a0154-ac07-4519-8513-fe9fe93ae6b9"), "Service Clases de Ballet", 77 },
                    { new Guid("08267875-59c4-402c-abc8-9e0eaf01eabe"), "Service", 4773m, "SRV-103", new Guid("7493eac5-b59c-4343-8c60-9d4363c0f37f"), "Service Clases de logica", 77 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("5aed8a4d-f718-4b7b-be57-1653636a3f5b"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("6b2878a8-b08d-4109-8a2b-5d76b210cec9"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("982929a0-d17f-4904-bda5-9ded2bf2c65d"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("e22035c0-ea70-49de-8edb-4ebc36111138"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("e352ff3b-ea93-4ccd-b38f-1670524bdf29"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("0098aef8-199e-41c0-91b7-0e7b2da7592c"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("08267875-59c4-402c-abc8-9e0eaf01eabe"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("448d9918-4d8e-45b4-8a29-5506a1ba7bf6"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("904507a1-c82d-4173-ae47-5c3895fc8c1f"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("dc65a1f8-d529-4975-9aec-10cdb993878f"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("efd16c04-5744-4717-b9fc-0e9e2e0a870e"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("069bb0ee-bdec-4415-97fb-114ed091e5cd"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("07902544-6e07-43af-8345-f11948b179e2"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("07aa97d6-d54b-42de-8cd2-d40bea395461"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("08340cda-5c08-4dee-945d-d469627884dc"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0924d5f0-63e8-41c9-8804-f90c34833ce6"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("07662e45-c74c-471b-9a51-5eb0eab737c6"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("16706578-21d5-48c4-bbec-7cc8d7ecd6d9"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("5e6a0154-ac07-4519-8513-fe9fe93ae6b9"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("659924bd-1522-430a-b521-423964bea024"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("7493eac5-b59c-4343-8c60-9d4363c0f37f"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("7c31f467-c0b1-4718-a92b-4fb078e34eb2"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("b1b3bed4-a201-4aa5-9837-da2ff76e035d"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("363174a4-711d-448c-b8a1-f13d7d8e2ae2"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("3e2f1a33-d057-4390-9882-e09b0a4ce9f9"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("59f38413-4b46-4045-8627-f826e4c47e48"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("645d5ff6-88b3-4efd-bad6-58824277a99a"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("9c527e12-6086-4a20-9d3e-1fa82f0e8ea2"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("52680218-6927-4b78-b70f-da089f7c66ab"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("53e9029c-b970-4357-83e8-6634ccb32527"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("61600c37-13e8-43dd-b8e7-e9f62a916335"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("89afae68-4d45-4f6f-afae-b4a715c14e71"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("c4eb6cec-546f-4ff4-b8fa-87916ce2e1e2"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("d592df4d-57d6-4e12-afe3-45aad36f0f69"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("008e1b32-757a-4c4d-90d3-cace69412327"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0098f83a-5257-4247-a841-97dc3167b088"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("01542ad7-82e1-4a29-83eb-e9555a2f9a37"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("03cbf736-0adc-446a-8c5f-86c20c338c84"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("03de317f-f94d-4a37-9eff-bf1dcac32088"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("f4a95ab5-9a96-40d4-95be-6c8e036f5107"));

            migrationBuilder.DropColumn(
                name: "Facebook",
                table: "Tutors");

            migrationBuilder.DropColumn(
                name: "Identification",
                table: "Tutors");

            migrationBuilder.DropColumn(
                name: "Instagram",
                table: "Tutors");

            migrationBuilder.DropColumn(
                name: "Relationship",
                table: "Tutors");

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
        }
    }
}
