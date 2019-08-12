using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class adding_Service_to_EnrollActivity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

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

            //migrationBuilder.DeleteData(
            //    table: "Pediatrician",
            //    keyColumn: "Id",
            //    keyValue: new Guid("434532c4-03b0-4d6d-85c9-bbd39b0ec350"));

            //migrationBuilder.DeleteData(
            //    table: "Tutors",
            //    keyColumn: "Id",
            //    keyValue: new Guid("6ff19c47-feb2-45c0-9e73-4ecec5dbfdb3"));

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

            migrationBuilder.AddColumn<Guid>(
                name: "ServiceId",
                table: "EnrollActivity",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AppUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    KindergarterId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUser_Kindergarters_KindergarterId",
                        column: x => x.KindergarterId,
                        principalTable: "Kindergarters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EnrollActivity_ServiceId",
                table: "EnrollActivity",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_KindergarterId",
                table: "AppUser",
                column: "KindergarterId");

            migrationBuilder.AddForeignKey(
                name: "FK_EnrollActivity_Item_ServiceId",
                table: "EnrollActivity",
                column: "ServiceId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EnrollActivity_Item_ServiceId",
                table: "EnrollActivity");

            migrationBuilder.DropTable(
                name: "AppUser");

            migrationBuilder.DropIndex(
                name: "IX_EnrollActivity_ServiceId",
                table: "EnrollActivity");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "EnrollActivity");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    KindergarterId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Kindergarters_KindergarterId",
                        column: x => x.KindergarterId,
                        principalTable: "Kindergarters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_User_KindergarterId",
                table: "User",
                column: "KindergarterId");
        }
    }
}
