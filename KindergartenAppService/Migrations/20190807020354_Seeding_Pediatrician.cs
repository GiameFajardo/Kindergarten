using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Seeding_Pediatrician : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a"), "KPH" });

            migrationBuilder.InsertData(
                table: "Pediatrician",
                columns: new[] { "Id", "Address", "Name", "PhoneNumber" },
                values: new object[] { new Guid("434532c4-03b0-4d6d-85c9-bbd39b0ec350"), "Address", "Felipe Felix", "809-852-8521" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "Facebook", "FirstName", "Identification", "Instagram", "LastName", "Mail", "MovilNumber", "PhoneNumber", "Relationship" },
                values: new object[,]
                {
                    { new Guid("0ab1b68d-0ce4-476f-80f2-54d40daa3cb7"), null, null, "Gregorio de Jesus", null, null, "Rojas Acosta", null, null, null, 0 },
                    { new Guid("6ff19c47-feb2-45c0-9e73-4ecec5dbfdb3"), null, null, "Yadira", null, null, "Pinales Delgado", null, null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "ActivityTemplate",
                columns: new[] { "Id", "Description", "KindergarterId" },
                values: new object[,]
                {
                    { new Guid("f229ad69-c892-4944-8c5f-de843f05e23a"), "Clases de ingles", new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a") },
                    { new Guid("64f78ab3-cdf5-45b4-9adb-b4fbd730553e"), "Cuidade matutino", new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a") },
                    { new Guid("e558595e-5b87-49ad-b711-d64ffb400200"), "Cuidado Vespertino", new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a") },
                    { new Guid("32c63273-04e9-4d6e-a216-ccb4567e470c"), "Cuidado dia completo", new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a") },
                    { new Guid("8ba04f88-a81e-4206-8003-b83ea09b3b5d"), "Clases de Ballet", new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a") },
                    { new Guid("e93b2822-4cef-4014-8550-df9155500806"), "Clases de logica", new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a") }
                });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "Address", "BirthDate", "Diseases", "FatherName", "FavoriteActivities", "FirstName", "KindergarterId", "MotherName", "PediatricianId", "SecondName", "Sex", "SiblingCount", "TShirtSize", "TutorAutorizedId", "TutorId", "TutorPrincipalId", "TutorSecundaryId" },
                values: new object[,]
                {
                    { new Guid("00015c47-dbcb-4ca3-9bb6-5d79818f53c3"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Escobar", null, "Lyan", new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a"), "Washinton", null, "Carlos", 0, 0, 0, null, null, new Guid("0ab1b68d-0ce4-476f-80f2-54d40daa3cb7"), null },
                    { new Guid("0072d391-db51-4122-a484-1f441149d702"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Escobar", null, "Lyan", new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a"), "Snow", null, "Eduardo", 0, 0, 0, null, null, new Guid("0ab1b68d-0ce4-476f-80f2-54d40daa3cb7"), null },
                    { new Guid("01da5487-9b6e-4370-a34a-b604592e92cd"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Escobar", null, "Johan", new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a"), "Snow", null, "Enrique", 0, 0, 0, null, null, new Guid("0ab1b68d-0ce4-476f-80f2-54d40daa3cb7"), null },
                    { new Guid("058a9b67-1ab5-4a8b-8b93-18d8750f76b0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lee", null, "Aaron", new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a"), "White", null, "Carlos", 0, 0, 0, null, null, new Guid("0ab1b68d-0ce4-476f-80f2-54d40daa3cb7"), null },
                    { new Guid("060c00fc-bfe7-4412-a71b-ecfcd73e0ca1"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Faringtom", null, "Lyan", new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a"), "Washinton", null, "Carlos", 0, 0, 0, null, null, new Guid("0ab1b68d-0ce4-476f-80f2-54d40daa3cb7"), null },
                    { new Guid("066b26fb-0cc4-49b9-b308-78cf2ee8afe5"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Stackeetam", null, "Dylan", new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a"), "White", null, "Emilio", 0, 0, 0, null, null, new Guid("0ab1b68d-0ce4-476f-80f2-54d40daa3cb7"), null },
                    { new Guid("071d688d-1300-473b-90ec-1eb4291c377e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Stackeetam", null, "Dylan", new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a"), "Snow", null, "Enrique", 0, 0, 0, null, null, new Guid("0ab1b68d-0ce4-476f-80f2-54d40daa3cb7"), null },
                    { new Guid("093477eb-06e6-4241-88d4-cb903431bae4"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Faringtom", null, "Dylan", new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a"), "White", null, "Enrique", 0, 0, 0, null, null, new Guid("0ab1b68d-0ce4-476f-80f2-54d40daa3cb7"), null },
                    { new Guid("0a0230e5-77cc-4aa4-b464-853422e331ee"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Faringtom", null, "Aaron", new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a"), "Washinton", null, "Eduardo", 0, 0, 0, null, null, new Guid("0ab1b68d-0ce4-476f-80f2-54d40daa3cb7"), null },
                    { new Guid("0a6ecd72-5ae3-403d-aabd-1b186825a045"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Faringtom", null, "Aaron", new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a"), "Snow", null, "Carlos", 0, 0, 0, null, null, new Guid("0ab1b68d-0ce4-476f-80f2-54d40daa3cb7"), null }
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "Id", "ActivityTemplateId", "Description" },
                values: new object[,]
                {
                    { new Guid("f4c4bd06-eac0-44d9-9953-a8c94c7b13c0"), new Guid("f229ad69-c892-4944-8c5f-de843f05e23a"), "Clases de ingles" },
                    { new Guid("33572fb1-fa20-466a-aa09-9b523d440503"), new Guid("64f78ab3-cdf5-45b4-9adb-b4fbd730553e"), "Cuidade matutino" },
                    { new Guid("b1a1f881-4436-43e5-bd10-ae3b4f3f35b0"), new Guid("e558595e-5b87-49ad-b711-d64ffb400200"), "Cuidado Vespertino" },
                    { new Guid("a1afb5fa-bd98-492c-b9e1-cc79638fea92"), new Guid("32c63273-04e9-4d6e-a216-ccb4567e470c"), "Cuidado dia completo" },
                    { new Guid("b27f15cd-71a1-4969-a1d1-26953a6588de"), new Guid("8ba04f88-a81e-4206-8003-b83ea09b3b5d"), "Clases de Ballet" },
                    { new Guid("729570b9-afab-4db7-aa43-bebd6d12703d"), new Guid("e93b2822-4cef-4014-8550-df9155500806"), "Clases de logica" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "Comment", "EnrollDay", "KidId" },
                values: new object[,]
                {
                    { new Guid("fd2e534b-b745-4b1e-a047-e8a1e3a7a025"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00015c47-dbcb-4ca3-9bb6-5d79818f53c3") },
                    { new Guid("d91398fc-3123-40f9-bdac-d4a919f2aa5a"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0072d391-db51-4122-a484-1f441149d702") },
                    { new Guid("a601e722-c11a-4e4e-817c-07d461ea413c"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("01da5487-9b6e-4370-a34a-b604592e92cd") },
                    { new Guid("0dc1fe68-0344-470b-97be-840f56db48d3"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("058a9b67-1ab5-4a8b-8b93-18d8750f76b0") },
                    { new Guid("d419db9a-25c9-4af6-9615-6de91147588e"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("060c00fc-bfe7-4412-a71b-ecfcd73e0ca1") }
                });

            migrationBuilder.InsertData(
                table: "EnrollActivity",
                columns: new[] { "Id", "ActivityId", "EnrollmentId" },
                values: new object[,]
                {
                    { new Guid("585034d6-63f2-4f15-96b1-a8ab4b80dcee"), new Guid("729570b9-afab-4db7-aa43-bebd6d12703d"), new Guid("fd2e534b-b745-4b1e-a047-e8a1e3a7a025") },
                    { new Guid("f0dfff45-601e-405f-86e5-03fad2944153"), new Guid("a1afb5fa-bd98-492c-b9e1-cc79638fea92"), new Guid("d91398fc-3123-40f9-bdac-d4a919f2aa5a") },
                    { new Guid("8b40a582-675b-4d2c-92bc-f8f8220b09f1"), new Guid("b27f15cd-71a1-4969-a1d1-26953a6588de"), new Guid("a601e722-c11a-4e4e-817c-07d461ea413c") },
                    { new Guid("f7354b3b-f1da-4005-8ac4-e66cc51ce0e4"), new Guid("f4c4bd06-eac0-44d9-9953-a8c94c7b13c0"), new Guid("0dc1fe68-0344-470b-97be-840f56db48d3") },
                    { new Guid("15198bbf-4ac8-4551-9e7f-0293dee487ae"), new Guid("b1a1f881-4436-43e5-bd10-ae3b4f3f35b0"), new Guid("d419db9a-25c9-4af6-9615-6de91147588e") }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Price", "Reference", "ActivityId", "Description", "ServicePeriod" },
                values: new object[,]
                {
                    { new Guid("0f917693-08d3-4d50-9e3f-14a780eb269b"), "Service", 6347m, "SRV-563", new Guid("f4c4bd06-eac0-44d9-9953-a8c94c7b13c0"), "Service Clases de ingles", 77 },
                    { new Guid("868a4733-2199-4cd7-97ac-7aecd5d92e78"), "Service", 328m, "SRV-346", new Guid("33572fb1-fa20-466a-aa09-9b523d440503"), "Service Cuidade matutino", 77 },
                    { new Guid("c4d5315d-0012-4aee-b5f5-ea4b0c4175c5"), "Service", 867m, "SRV-641", new Guid("b1a1f881-4436-43e5-bd10-ae3b4f3f35b0"), "Service Cuidado Vespertino", 77 },
                    { new Guid("371d4038-a7a3-418c-9a27-ef0378d44899"), "Service", 1899m, "SRV-298", new Guid("a1afb5fa-bd98-492c-b9e1-cc79638fea92"), "Service Cuidado dia completo", 77 },
                    { new Guid("ea1aafaa-2866-4aeb-8c8a-530d0b9b5f64"), "Service", 8973m, "SRV-399", new Guid("b27f15cd-71a1-4969-a1d1-26953a6588de"), "Service Clases de Ballet", 77 },
                    { new Guid("014b94ee-adc1-4127-b73a-33f05417ac05"), "Service", 2009m, "SRV-811", new Guid("729570b9-afab-4db7-aa43-bebd6d12703d"), "Service Clases de logica", 77 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("15198bbf-4ac8-4551-9e7f-0293dee487ae"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("585034d6-63f2-4f15-96b1-a8ab4b80dcee"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("8b40a582-675b-4d2c-92bc-f8f8220b09f1"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("f0dfff45-601e-405f-86e5-03fad2944153"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("f7354b3b-f1da-4005-8ac4-e66cc51ce0e4"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("014b94ee-adc1-4127-b73a-33f05417ac05"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("0f917693-08d3-4d50-9e3f-14a780eb269b"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("371d4038-a7a3-418c-9a27-ef0378d44899"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("868a4733-2199-4cd7-97ac-7aecd5d92e78"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("c4d5315d-0012-4aee-b5f5-ea4b0c4175c5"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("ea1aafaa-2866-4aeb-8c8a-530d0b9b5f64"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("066b26fb-0cc4-49b9-b308-78cf2ee8afe5"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("071d688d-1300-473b-90ec-1eb4291c377e"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("093477eb-06e6-4241-88d4-cb903431bae4"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0a0230e5-77cc-4aa4-b464-853422e331ee"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0a6ecd72-5ae3-403d-aabd-1b186825a045"));

            migrationBuilder.DeleteData(
                table: "Pediatrician",
                keyColumn: "Id",
                keyValue: new Guid("434532c4-03b0-4d6d-85c9-bbd39b0ec350"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("6ff19c47-feb2-45c0-9e73-4ecec5dbfdb3"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("33572fb1-fa20-466a-aa09-9b523d440503"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("729570b9-afab-4db7-aa43-bebd6d12703d"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("a1afb5fa-bd98-492c-b9e1-cc79638fea92"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("b1a1f881-4436-43e5-bd10-ae3b4f3f35b0"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("b27f15cd-71a1-4969-a1d1-26953a6588de"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("f4c4bd06-eac0-44d9-9953-a8c94c7b13c0"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("0dc1fe68-0344-470b-97be-840f56db48d3"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("a601e722-c11a-4e4e-817c-07d461ea413c"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("d419db9a-25c9-4af6-9615-6de91147588e"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("d91398fc-3123-40f9-bdac-d4a919f2aa5a"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("fd2e534b-b745-4b1e-a047-e8a1e3a7a025"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("32c63273-04e9-4d6e-a216-ccb4567e470c"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("64f78ab3-cdf5-45b4-9adb-b4fbd730553e"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("8ba04f88-a81e-4206-8003-b83ea09b3b5d"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("e558595e-5b87-49ad-b711-d64ffb400200"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("e93b2822-4cef-4014-8550-df9155500806"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("f229ad69-c892-4944-8c5f-de843f05e23a"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("00015c47-dbcb-4ca3-9bb6-5d79818f53c3"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0072d391-db51-4122-a484-1f441149d702"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("01da5487-9b6e-4370-a34a-b604592e92cd"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("058a9b67-1ab5-4a8b-8b93-18d8750f76b0"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("060c00fc-bfe7-4412-a71b-ecfcd73e0ca1"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("0ab1b68d-0ce4-476f-80f2-54d40daa3cb7"));

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
    }
}
