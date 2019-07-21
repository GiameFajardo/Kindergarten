using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Some_changes_in_activities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activity_Kindergarters_KindergarterId",
                table: "Activity");

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("34f83c8d-3cec-4bbb-9f2f-25080facfaa4"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("4a854f55-10b7-44db-9c64-ff3a793f606d"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("9faae3cd-efe8-40a6-b07b-0a0ef8e56165"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("b4083002-f8cf-4f47-aee6-7515ada2bedb"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("f26d6663-72aa-4270-88dd-676e5766f37a"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("f2a6d136-477a-4f4e-bc38-bb89587c2081"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("00963687-583e-4f7b-bdaf-27d56678c1ea"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("00cb3fc6-9f14-412a-8b47-7499e66e466c"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0208c1ff-80cd-4c23-aa05-7bbd6d1d2f30"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("026ab79b-a088-4943-88eb-34dc28ec35ef"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("02af99bf-3d28-432e-8ced-46524ced40c0"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0347137d-a77b-4019-bee2-3d198d63a92e"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("05440a9a-980c-45cb-88ca-30a2c6b70ec5"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("054da3c6-f81e-4ef9-b7b4-ad16b1f1fb85"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("06e4a271-e77a-4c89-95b4-f98f86cd1416"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("07cc9a50-c827-4f14-b0df-071131932316"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("9543f9a8-13fd-480a-bf7e-2b57dfadf4f6"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("0d9e3f4b-5b7d-4314-8487-be7bc2805f84"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("1c4d4e73-8c3e-4170-bc4e-d2a80b4c6fd9"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("2d8b436a-ae91-46c3-b08b-da43039f0ca2"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("80c3e424-508d-4f1c-bb18-6b22c8a6fb3a"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("8c8cc46a-9375-4017-9f81-2c42fd3b2048"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("af4cc57d-983c-4d46-9e1b-dc35ab44c118"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("79948198-a56e-4612-9276-d22b58453b90"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("2e6215a3-d9c8-45c5-ba39-e9e1e36360ea"));

            migrationBuilder.RenameColumn(
                name: "KindergarterId",
                table: "Activity",
                newName: "ActivityTemplateId");

            migrationBuilder.RenameIndex(
                name: "IX_Activity_KindergarterId",
                table: "Activity",
                newName: "IX_Activity_ActivityTemplateId");

            migrationBuilder.CreateTable(
                name: "ActivityTemplate",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    KindergarterId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityTemplate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityTemplate_Kindergarters_KindergarterId",
                        column: x => x.KindergarterId,
                        principalTable: "Kindergarters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubActivities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    StaringTime = table.Column<TimeSpan>(nullable: false),
                    EndingTime = table.Column<TimeSpan>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    ActivityId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubActivities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubActivities_Activity_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315"), "Guarderia" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("725cb50c-2249-4874-9449-40a4131d9af9"), null, "Gregorio de Jesus", "Rojas Acosta", null, null, null });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("cc873f7a-13a4-473d-bb8d-3bd345d17fea"), null, "Yadira", "Pinales Delgado", null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityTemplate",
                columns: new[] { "Id", "Description", "KindergarterId" },
                values: new object[,]
                {
                    { new Guid("e9b0e1f4-23a9-4a6b-b621-4789522c6e5a"), "Clases de ingles", new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315") },
                    { new Guid("d2794bf3-8776-454c-b836-b0901151d011"), "Cuidade matutino", new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315") },
                    { new Guid("9183f68e-d32c-40dc-bbc8-ee99cc25107b"), "Cuidado Vespertino", new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315") },
                    { new Guid("ab7c7726-ab62-4b8c-8749-b947b3b572cd"), "Cuidado dia completo", new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315") },
                    { new Guid("0807cc78-0ac6-4c88-b2b4-b01ca22cc149"), "Clases de Ballet", new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315") },
                    { new Guid("6a80c76c-f235-4e40-962e-38f32cf8bf52"), "Clases de logica", new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315") }
                });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "FatherName", "FirstName", "KindergarterId", "MotherName", "SecondName", "TutorId" },
                values: new object[,]
                {
                    { new Guid("0064873e-1568-4fb6-ad36-d4947d51497b"), "Faringtom", "Johan", new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315"), "Worm", "Eduardo", new Guid("725cb50c-2249-4874-9449-40a4131d9af9") },
                    { new Guid("011ac463-23d2-4fd2-b2f2-9cf61333b176"), "Escobar", "Lyan", new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315"), "Washinton", "Eduardo", new Guid("725cb50c-2249-4874-9449-40a4131d9af9") },
                    { new Guid("0165fb1f-703c-4b03-b0c0-ce98a20ae2fe"), "Escobar", "Aaron", new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315"), "Worm", "Eduardo", new Guid("725cb50c-2249-4874-9449-40a4131d9af9") },
                    { new Guid("030f1ddf-cc6e-4a1b-a282-14137325fcc8"), "Faringtom", "Dylan", new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315"), "Washinton", "Carlos", new Guid("725cb50c-2249-4874-9449-40a4131d9af9") },
                    { new Guid("03829b93-9356-4359-92f7-e675c2044627"), "Escobar", "Johan", new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315"), "Worm", "Emilio", new Guid("725cb50c-2249-4874-9449-40a4131d9af9") },
                    { new Guid("06447503-271f-4d84-a9c9-803b8479ccce"), "Faringtom", "Johan", new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315"), "White", "Eduardo", new Guid("725cb50c-2249-4874-9449-40a4131d9af9") },
                    { new Guid("06d8e76e-336d-4e25-99d4-c5698a9bfea5"), "Escobar", "Dylan", new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315"), "Washinton", "Carlos", new Guid("725cb50c-2249-4874-9449-40a4131d9af9") },
                    { new Guid("06ec4a8a-0b2d-4a48-ac22-7dc668396980"), "Lee", "Lyan", new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315"), "Snow", "Enrique", new Guid("725cb50c-2249-4874-9449-40a4131d9af9") },
                    { new Guid("07c18f9c-8129-46aa-bec4-daaffbdacd89"), "Faringtom", "Dylan", new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315"), "Snow", "Enrique", new Guid("725cb50c-2249-4874-9449-40a4131d9af9") },
                    { new Guid("09e63d6a-15cd-41e9-a098-0ab11a02a45d"), "Escobar", "Johan", new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315"), "Snow", "Enrique", new Guid("725cb50c-2249-4874-9449-40a4131d9af9") }
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "Id", "ActivityTemplateId", "Description" },
                values: new object[,]
                {
                    { new Guid("77993c94-1523-4890-85ab-d767bc87697f"), new Guid("e9b0e1f4-23a9-4a6b-b621-4789522c6e5a"), "Clases de ingles" },
                    { new Guid("5a3d8aeb-9f95-4cac-91ca-08e751ac805a"), new Guid("d2794bf3-8776-454c-b836-b0901151d011"), "Cuidade matutino" },
                    { new Guid("c9f38097-4f54-4a57-b68d-d19e79d58374"), new Guid("9183f68e-d32c-40dc-bbc8-ee99cc25107b"), "Cuidado Vespertino" },
                    { new Guid("63323267-a10c-4bfb-9f22-c7d0f297fc73"), new Guid("ab7c7726-ab62-4b8c-8749-b947b3b572cd"), "Cuidado dia completo" },
                    { new Guid("132fbefa-982f-4e27-98bb-2f846aae7176"), new Guid("0807cc78-0ac6-4c88-b2b4-b01ca22cc149"), "Clases de Ballet" },
                    { new Guid("a6c5ffd2-8103-4d8c-9c0a-2a46cdf9deae"), new Guid("6a80c76c-f235-4e40-962e-38f32cf8bf52"), "Clases de logica" }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Price", "Reference", "ActivityId", "Description", "ServicePeriod" },
                values: new object[,]
                {
                    { new Guid("4b4804a9-6d51-4496-b08c-a9f4fba035de"), "Service", 3920m, "SRV-818", new Guid("77993c94-1523-4890-85ab-d767bc87697f"), "Service Clases de ingles", 77 },
                    { new Guid("2a05f3ea-83c8-4773-87ed-d86f09830227"), "Service", 260m, "SRV-798", new Guid("5a3d8aeb-9f95-4cac-91ca-08e751ac805a"), "Service Cuidade matutino", 77 },
                    { new Guid("de439620-81f6-4cfb-90ef-2953a2586300"), "Service", 5842m, "SRV-262", new Guid("c9f38097-4f54-4a57-b68d-d19e79d58374"), "Service Cuidado Vespertino", 77 },
                    { new Guid("1c43e6d1-1fff-4727-a10e-4eaa15939dbc"), "Service", 4141m, "SRV-698", new Guid("63323267-a10c-4bfb-9f22-c7d0f297fc73"), "Service Cuidado dia completo", 77 },
                    { new Guid("4ff02c44-f7c0-4337-8b11-3cff4849820c"), "Service", 5229m, "SRV-782", new Guid("132fbefa-982f-4e27-98bb-2f846aae7176"), "Service Clases de Ballet", 77 },
                    { new Guid("f8db1edf-3e74-4103-925c-8c0d53885e63"), "Service", 6932m, "SRV-4", new Guid("a6c5ffd2-8103-4d8c-9c0a-2a46cdf9deae"), "Service Clases de logica", 77 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityTemplate_KindergarterId",
                table: "ActivityTemplate",
                column: "KindergarterId");

            migrationBuilder.CreateIndex(
                name: "IX_SubActivities_ActivityId",
                table: "SubActivities",
                column: "ActivityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_ActivityTemplate_ActivityTemplateId",
                table: "Activity",
                column: "ActivityTemplateId",
                principalTable: "ActivityTemplate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activity_ActivityTemplate_ActivityTemplateId",
                table: "Activity");

            migrationBuilder.DropTable(
                name: "ActivityTemplate");

            migrationBuilder.DropTable(
                name: "SubActivities");

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("1c43e6d1-1fff-4727-a10e-4eaa15939dbc"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("2a05f3ea-83c8-4773-87ed-d86f09830227"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("4b4804a9-6d51-4496-b08c-a9f4fba035de"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("4ff02c44-f7c0-4337-8b11-3cff4849820c"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("de439620-81f6-4cfb-90ef-2953a2586300"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("f8db1edf-3e74-4103-925c-8c0d53885e63"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0064873e-1568-4fb6-ad36-d4947d51497b"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("011ac463-23d2-4fd2-b2f2-9cf61333b176"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0165fb1f-703c-4b03-b0c0-ce98a20ae2fe"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("030f1ddf-cc6e-4a1b-a282-14137325fcc8"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("03829b93-9356-4359-92f7-e675c2044627"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("06447503-271f-4d84-a9c9-803b8479ccce"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("06d8e76e-336d-4e25-99d4-c5698a9bfea5"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("06ec4a8a-0b2d-4a48-ac22-7dc668396980"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("07c18f9c-8129-46aa-bec4-daaffbdacd89"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("09e63d6a-15cd-41e9-a098-0ab11a02a45d"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("cc873f7a-13a4-473d-bb8d-3bd345d17fea"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("132fbefa-982f-4e27-98bb-2f846aae7176"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("5a3d8aeb-9f95-4cac-91ca-08e751ac805a"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("63323267-a10c-4bfb-9f22-c7d0f297fc73"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("77993c94-1523-4890-85ab-d767bc87697f"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("a6c5ffd2-8103-4d8c-9c0a-2a46cdf9deae"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("c9f38097-4f54-4a57-b68d-d19e79d58374"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("725cb50c-2249-4874-9449-40a4131d9af9"));

            migrationBuilder.RenameColumn(
                name: "ActivityTemplateId",
                table: "Activity",
                newName: "KindergarterId");

            migrationBuilder.RenameIndex(
                name: "IX_Activity_ActivityTemplateId",
                table: "Activity",
                newName: "IX_Activity_KindergarterId");

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("2e6215a3-d9c8-45c5-ba39-e9e1e36360ea"), "Guarderia" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("79948198-a56e-4612-9276-d22b58453b90"), null, "Gregorio de Jesus", "Rojas Acosta", null, null, null });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("9543f9a8-13fd-480a-bf7e-2b57dfadf4f6"), null, "Yadira", "Pinales Delgado", null, null, null });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "Id", "Description", "KindergarterId" },
                values: new object[,]
                {
                    { new Guid("2d8b436a-ae91-46c3-b08b-da43039f0ca2"), "Clases de ingles", new Guid("2e6215a3-d9c8-45c5-ba39-e9e1e36360ea") },
                    { new Guid("8c8cc46a-9375-4017-9f81-2c42fd3b2048"), "Cuidade matutino", new Guid("2e6215a3-d9c8-45c5-ba39-e9e1e36360ea") },
                    { new Guid("80c3e424-508d-4f1c-bb18-6b22c8a6fb3a"), "Cuidado Vespertino", new Guid("2e6215a3-d9c8-45c5-ba39-e9e1e36360ea") },
                    { new Guid("1c4d4e73-8c3e-4170-bc4e-d2a80b4c6fd9"), "Cuidado dia completo", new Guid("2e6215a3-d9c8-45c5-ba39-e9e1e36360ea") },
                    { new Guid("af4cc57d-983c-4d46-9e1b-dc35ab44c118"), "Clases de Ballet", new Guid("2e6215a3-d9c8-45c5-ba39-e9e1e36360ea") },
                    { new Guid("0d9e3f4b-5b7d-4314-8487-be7bc2805f84"), "Clases de logica", new Guid("2e6215a3-d9c8-45c5-ba39-e9e1e36360ea") }
                });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "FatherName", "FirstName", "KindergarterId", "MotherName", "SecondName", "TutorId" },
                values: new object[,]
                {
                    { new Guid("00963687-583e-4f7b-bdaf-27d56678c1ea"), "Escobar", "Dylan", new Guid("2e6215a3-d9c8-45c5-ba39-e9e1e36360ea"), "White", "Emilio", new Guid("79948198-a56e-4612-9276-d22b58453b90") },
                    { new Guid("00cb3fc6-9f14-412a-8b47-7499e66e466c"), "Escobar", "Aaron", new Guid("2e6215a3-d9c8-45c5-ba39-e9e1e36360ea"), "Snow", "Enrique", new Guid("79948198-a56e-4612-9276-d22b58453b90") },
                    { new Guid("0208c1ff-80cd-4c23-aa05-7bbd6d1d2f30"), "Stackeetam", "Dylan", new Guid("2e6215a3-d9c8-45c5-ba39-e9e1e36360ea"), "Washinton", "Emilio", new Guid("79948198-a56e-4612-9276-d22b58453b90") },
                    { new Guid("026ab79b-a088-4943-88eb-34dc28ec35ef"), "Faringtom", "Johan", new Guid("2e6215a3-d9c8-45c5-ba39-e9e1e36360ea"), "Washinton", "Emilio", new Guid("79948198-a56e-4612-9276-d22b58453b90") },
                    { new Guid("02af99bf-3d28-432e-8ced-46524ced40c0"), "Escobar", "Lyan", new Guid("2e6215a3-d9c8-45c5-ba39-e9e1e36360ea"), "Snow", "Enrique", new Guid("79948198-a56e-4612-9276-d22b58453b90") },
                    { new Guid("0347137d-a77b-4019-bee2-3d198d63a92e"), "Lee", "Dylan", new Guid("2e6215a3-d9c8-45c5-ba39-e9e1e36360ea"), "Washinton", "Carlos", new Guid("79948198-a56e-4612-9276-d22b58453b90") },
                    { new Guid("05440a9a-980c-45cb-88ca-30a2c6b70ec5"), "Lee", "Johan", new Guid("2e6215a3-d9c8-45c5-ba39-e9e1e36360ea"), "Snow", "Carlos", new Guid("79948198-a56e-4612-9276-d22b58453b90") },
                    { new Guid("054da3c6-f81e-4ef9-b7b4-ad16b1f1fb85"), "Faringtom", "Aaron", new Guid("2e6215a3-d9c8-45c5-ba39-e9e1e36360ea"), "Washinton", "Carlos", new Guid("79948198-a56e-4612-9276-d22b58453b90") },
                    { new Guid("06e4a271-e77a-4c89-95b4-f98f86cd1416"), "Lee", "Dylan", new Guid("2e6215a3-d9c8-45c5-ba39-e9e1e36360ea"), "Snow", "Enrique", new Guid("79948198-a56e-4612-9276-d22b58453b90") },
                    { new Guid("07cc9a50-c827-4f14-b0df-071131932316"), "Lee", "Johan", new Guid("2e6215a3-d9c8-45c5-ba39-e9e1e36360ea"), "Washinton", "Eduardo", new Guid("79948198-a56e-4612-9276-d22b58453b90") }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Price", "Reference", "ActivityId", "Description", "ServicePeriod" },
                values: new object[,]
                {
                    { new Guid("f2a6d136-477a-4f4e-bc38-bb89587c2081"), "Service", 2777m, "SRV-981", new Guid("2d8b436a-ae91-46c3-b08b-da43039f0ca2"), "Service Clases de ingles", 0 },
                    { new Guid("4a854f55-10b7-44db-9c64-ff3a793f606d"), "Service", 9868m, "SRV-85", new Guid("8c8cc46a-9375-4017-9f81-2c42fd3b2048"), "Service Cuidade matutino", 0 },
                    { new Guid("34f83c8d-3cec-4bbb-9f2f-25080facfaa4"), "Service", 8868m, "SRV-78", new Guid("80c3e424-508d-4f1c-bb18-6b22c8a6fb3a"), "Service Cuidado Vespertino", 0 },
                    { new Guid("b4083002-f8cf-4f47-aee6-7515ada2bedb"), "Service", 6581m, "SRV-865", new Guid("1c4d4e73-8c3e-4170-bc4e-d2a80b4c6fd9"), "Service Cuidado dia completo", 0 },
                    { new Guid("9faae3cd-efe8-40a6-b07b-0a0ef8e56165"), "Service", 6956m, "SRV-581", new Guid("af4cc57d-983c-4d46-9e1b-dc35ab44c118"), "Service Clases de Ballet", 0 },
                    { new Guid("f26d6663-72aa-4270-88dd-676e5766f37a"), "Service", 6933m, "SRV-50", new Guid("0d9e3f4b-5b7d-4314-8487-be7bc2805f84"), "Service Clases de logica", 0 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_Kindergarters_KindergarterId",
                table: "Activity",
                column: "KindergarterId",
                principalTable: "Kindergarters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
