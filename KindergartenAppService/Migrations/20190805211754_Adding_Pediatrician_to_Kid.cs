using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Adding_Pediatrician_to_Kid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("21c4c6cf-4b16-4454-b646-a434d7cbd142"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("34f3c006-0f9e-44ab-b170-600a44425ea6"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("601cf899-35d0-4fd0-b7c6-62737b4f1d44"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("7ad46170-c929-4a9c-876e-0467eab58767"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("bb429747-f614-4c79-b79a-67e01710be93"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("1b73e220-114a-47e1-991c-e335571d4fff"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("98a6ddbd-6cf1-487b-9bb4-029cb6756f68"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("b5a0a086-68a1-4ee2-8e75-9ffcb3ce954f"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("f3b61b66-5482-45d4-a29f-3df918f26514"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("f4d5550c-8f27-4752-a6cb-95339efd2659"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("f95dfbed-9f8e-4f94-864d-dff62cce82a2"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0853539c-38ce-4ab7-847f-69b7b17ff028"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("09d75120-d6dd-4ac8-a3ae-467abfc00265"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0ca8a160-9dd1-4899-b2e0-c5e437f61e37"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0d051043-dc6f-43e6-8c93-eeb4ddb23701"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0e1dc6a7-b79b-43e1-a085-3c087865bd02"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("ff49656f-3d11-4bc2-8c00-3db54943ece1"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("42a053db-c47c-4a51-bdbd-32353fc8fa74"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("45ac2cbb-d47f-48ab-8f27-d0aa149a9455"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("6606bc3c-136c-46fc-965e-50d405d3c8bb"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("c798d23c-2ae7-4da7-9c2d-232d4eb9c95d"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("cfc72c08-1567-4da0-948f-154949506e7f"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("f928027e-f5ed-401b-8e93-59caa2de5338"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("5976976c-62f1-44ec-9440-3c2521536c34"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("5ae4fd1a-e858-485a-9497-0bfe176f6f69"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("92dfe308-94bb-49e7-af7e-17394c35454d"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("95ffc573-12b9-416e-b323-971d348fe707"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("ec5d94dd-4111-47a4-82be-092fd55ff927"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("1cf0bf9e-2bc0-45ef-b120-cdaaa4f64d60"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("66b72d6a-7eb0-4b9b-91e3-762f75b60594"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("7585b91e-b1e4-4926-92ad-9e9c537e3628"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("7b62b015-517f-42d0-a250-92371711e610"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("864fd426-bb3b-458a-b429-71757a90c8fd"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("c6138c54-ef19-45e4-b8cd-4017b629b49b"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0011bf63-6361-4add-a0e9-b0246c37d5d8"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("01101aa7-48cf-4837-8e0d-43c0d2e5124f"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("012fb48d-3ddd-4165-bbb2-78b2ce0c1277"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0247636c-21ba-46e1-a1f0-7312991b13c7"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("046fe88d-ab29-4b90-bd25-895cc7f6c83c"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("cbf3402a-883f-49d7-8376-95fe307ee250"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("baa939fa-7f17-44b6-851d-c24aaf5c676d"));

            migrationBuilder.AddColumn<Guid>(
                name: "PediatricianId",
                table: "Kid",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Pediatrician",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pediatrician", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("fdaa9313-85a1-48b4-9f66-a2290124c72d"), "KPH" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("7f9138c8-873b-4fc2-b19b-08ca00efabea"), null, "Gregorio de Jesus", "Rojas Acosta", null, null, null });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("715bbb09-3ae5-4767-94d4-1a118c0d69a6"), null, "Yadira", "Pinales Delgado", null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityTemplate",
                columns: new[] { "Id", "Description", "KindergarterId" },
                values: new object[,]
                {
                    { new Guid("ff946efc-d44e-4f1b-8fcc-756fa025427c"), "Clases de ingles", new Guid("fdaa9313-85a1-48b4-9f66-a2290124c72d") },
                    { new Guid("6e1fd942-d780-4f51-a516-3deef08c11ab"), "Cuidade matutino", new Guid("fdaa9313-85a1-48b4-9f66-a2290124c72d") },
                    { new Guid("daf7e390-5680-4140-af4d-70886ecc5506"), "Cuidado Vespertino", new Guid("fdaa9313-85a1-48b4-9f66-a2290124c72d") },
                    { new Guid("14302609-9f6a-4013-a656-9b4690056c48"), "Cuidado dia completo", new Guid("fdaa9313-85a1-48b4-9f66-a2290124c72d") },
                    { new Guid("f07898bf-1b7c-4bd5-9de3-2633f46aecc4"), "Clases de Ballet", new Guid("fdaa9313-85a1-48b4-9f66-a2290124c72d") },
                    { new Guid("77a1fcd6-4b49-4732-af72-03336eac3bcc"), "Clases de logica", new Guid("fdaa9313-85a1-48b4-9f66-a2290124c72d") }
                });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "Address", "BirthDate", "Diseases", "FatherName", "FavoriteActivities", "FirstName", "KindergarterId", "MotherName", "PediatricianId", "SecondName", "Sex", "SiblingCount", "TShirtSize", "TutorId" },
                values: new object[,]
                {
                    { new Guid("0035c2f5-e3e0-4f42-8a72-4d8551178524"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Faringtom", null, "Lyan", new Guid("fdaa9313-85a1-48b4-9f66-a2290124c72d"), "Washinton", null, "Carlos", 0, 0, 0, new Guid("7f9138c8-873b-4fc2-b19b-08ca00efabea") },
                    { new Guid("00ab6b81-fa29-4920-9e41-b78258bb978c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Escobar", null, "Lyan", new Guid("fdaa9313-85a1-48b4-9f66-a2290124c72d"), "Worm", null, "Enrique", 0, 0, 0, new Guid("7f9138c8-873b-4fc2-b19b-08ca00efabea") },
                    { new Guid("0192df81-5ee0-4978-b9b2-2375c7bbd257"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Escobar", null, "Lyan", new Guid("fdaa9313-85a1-48b4-9f66-a2290124c72d"), "Washinton", null, "Carlos", 0, 0, 0, new Guid("7f9138c8-873b-4fc2-b19b-08ca00efabea") },
                    { new Guid("0226cdd5-656c-4549-8c34-d05d514c473e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Stackeetam", null, "Johan", new Guid("fdaa9313-85a1-48b4-9f66-a2290124c72d"), "Washinton", null, "Emilio", 0, 0, 0, new Guid("7f9138c8-873b-4fc2-b19b-08ca00efabea") },
                    { new Guid("02607677-0f09-4aef-b3e9-972af027866a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Escobar", null, "Dylan", new Guid("fdaa9313-85a1-48b4-9f66-a2290124c72d"), "White", null, "Eduardo", 0, 0, 0, new Guid("7f9138c8-873b-4fc2-b19b-08ca00efabea") },
                    { new Guid("02935f7b-2a34-48f4-a594-d4b89a0a3b90"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lee", null, "Johan", new Guid("fdaa9313-85a1-48b4-9f66-a2290124c72d"), "Snow", null, "Enrique", 0, 0, 0, new Guid("7f9138c8-873b-4fc2-b19b-08ca00efabea") },
                    { new Guid("036f9715-c60a-4b90-b446-9225122ef8cb"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Escobar", null, "Johan", new Guid("fdaa9313-85a1-48b4-9f66-a2290124c72d"), "White", null, "Carlos", 0, 0, 0, new Guid("7f9138c8-873b-4fc2-b19b-08ca00efabea") },
                    { new Guid("03d4d4fb-9081-4ce9-bc13-f9fa8689c564"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Escobar", null, "Dylan", new Guid("fdaa9313-85a1-48b4-9f66-a2290124c72d"), "Washinton", null, "Eduardo", 0, 0, 0, new Guid("7f9138c8-873b-4fc2-b19b-08ca00efabea") },
                    { new Guid("053d68d3-0770-494e-9af1-f91d15f507b1"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Stackeetam", null, "Dylan", new Guid("fdaa9313-85a1-48b4-9f66-a2290124c72d"), "White", null, "Carlos", 0, 0, 0, new Guid("7f9138c8-873b-4fc2-b19b-08ca00efabea") },
                    { new Guid("0674de8e-536e-459f-b7ae-957b959b7204"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lee", null, "Aaron", new Guid("fdaa9313-85a1-48b4-9f66-a2290124c72d"), "White", null, "Emilio", 0, 0, 0, new Guid("7f9138c8-873b-4fc2-b19b-08ca00efabea") }
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "Id", "ActivityTemplateId", "Description" },
                values: new object[,]
                {
                    { new Guid("568a0d13-f0ed-4098-962f-8a41cdec8324"), new Guid("ff946efc-d44e-4f1b-8fcc-756fa025427c"), "Clases de ingles" },
                    { new Guid("e2052434-cf38-4b51-83c5-8069bbbeedd2"), new Guid("6e1fd942-d780-4f51-a516-3deef08c11ab"), "Cuidade matutino" },
                    { new Guid("49fd2436-bb19-4739-8f68-ac6cebb9628d"), new Guid("daf7e390-5680-4140-af4d-70886ecc5506"), "Cuidado Vespertino" },
                    { new Guid("a3f2f940-6c5c-4e2c-806f-44094476af8a"), new Guid("14302609-9f6a-4013-a656-9b4690056c48"), "Cuidado dia completo" },
                    { new Guid("9e006968-0d60-488e-b08b-c1b30b3b6414"), new Guid("f07898bf-1b7c-4bd5-9de3-2633f46aecc4"), "Clases de Ballet" },
                    { new Guid("595b1233-1725-4c4b-9e3c-1a6211c3291e"), new Guid("77a1fcd6-4b49-4732-af72-03336eac3bcc"), "Clases de logica" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "Comment", "EnrollDay", "KidId" },
                values: new object[,]
                {
                    { new Guid("98d0cebc-55e7-4b3a-9245-f850918b9819"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0035c2f5-e3e0-4f42-8a72-4d8551178524") },
                    { new Guid("2376f248-e6ef-4bcb-a910-e984dec2e95c"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00ab6b81-fa29-4920-9e41-b78258bb978c") },
                    { new Guid("2d7d6d8f-7c55-4f65-9f62-472ea01192ba"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0192df81-5ee0-4978-b9b2-2375c7bbd257") },
                    { new Guid("c29c677f-23d0-4c01-8d58-5747291a47ba"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0226cdd5-656c-4549-8c34-d05d514c473e") },
                    { new Guid("6450a483-aaa6-4adb-a5bf-2d4fa3de60c8"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("02607677-0f09-4aef-b3e9-972af027866a") }
                });

            migrationBuilder.InsertData(
                table: "EnrollActivity",
                columns: new[] { "Id", "ActivityId", "EnrollmentId" },
                values: new object[,]
                {
                    { new Guid("285a00d1-6276-4762-ba93-ecc4af59288e"), new Guid("49fd2436-bb19-4739-8f68-ac6cebb9628d"), new Guid("98d0cebc-55e7-4b3a-9245-f850918b9819") },
                    { new Guid("de8c04bb-f612-4603-85fe-9ad0461f5048"), new Guid("49fd2436-bb19-4739-8f68-ac6cebb9628d"), new Guid("2376f248-e6ef-4bcb-a910-e984dec2e95c") },
                    { new Guid("88981255-6748-4225-9f74-15a096ff7516"), new Guid("9e006968-0d60-488e-b08b-c1b30b3b6414"), new Guid("2d7d6d8f-7c55-4f65-9f62-472ea01192ba") },
                    { new Guid("17f11c45-7a8e-411d-93ce-8d873d7f311d"), new Guid("a3f2f940-6c5c-4e2c-806f-44094476af8a"), new Guid("c29c677f-23d0-4c01-8d58-5747291a47ba") },
                    { new Guid("45f266ba-068d-40ac-95b7-da7884c318b2"), new Guid("568a0d13-f0ed-4098-962f-8a41cdec8324"), new Guid("6450a483-aaa6-4adb-a5bf-2d4fa3de60c8") }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Price", "Reference", "ActivityId", "Description", "ServicePeriod" },
                values: new object[,]
                {
                    { new Guid("c070f1d4-d661-41be-9b17-37675095fc11"), "Service", 4336m, "SRV-349", new Guid("568a0d13-f0ed-4098-962f-8a41cdec8324"), "Service Clases de ingles", 77 },
                    { new Guid("d1fe24b5-d12b-4dda-9671-70d0f6db02f9"), "Service", 8754m, "SRV-578", new Guid("e2052434-cf38-4b51-83c5-8069bbbeedd2"), "Service Cuidade matutino", 77 },
                    { new Guid("e4da998f-6541-487b-b373-95bedfc185fc"), "Service", 8183m, "SRV-135", new Guid("49fd2436-bb19-4739-8f68-ac6cebb9628d"), "Service Cuidado Vespertino", 77 },
                    { new Guid("fe3f6730-4f0e-41dc-b843-3e060596a952"), "Service", 9943m, "SRV-941", new Guid("a3f2f940-6c5c-4e2c-806f-44094476af8a"), "Service Cuidado dia completo", 77 },
                    { new Guid("daefe694-f069-4dc9-a319-849e7ef08d2a"), "Service", 1928m, "SRV-576", new Guid("9e006968-0d60-488e-b08b-c1b30b3b6414"), "Service Clases de Ballet", 77 },
                    { new Guid("dbdd5735-3b98-429c-9e4b-d27a83cfaa43"), "Service", 7735m, "SRV-924", new Guid("595b1233-1725-4c4b-9e3c-1a6211c3291e"), "Service Clases de logica", 77 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kid_PediatricianId",
                table: "Kid",
                column: "PediatricianId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kid_Pediatrician_PediatricianId",
                table: "Kid",
                column: "PediatricianId",
                principalTable: "Pediatrician",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kid_Pediatrician_PediatricianId",
                table: "Kid");

            migrationBuilder.DropTable(
                name: "Pediatrician");

            migrationBuilder.DropIndex(
                name: "IX_Kid_PediatricianId",
                table: "Kid");

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("17f11c45-7a8e-411d-93ce-8d873d7f311d"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("285a00d1-6276-4762-ba93-ecc4af59288e"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("45f266ba-068d-40ac-95b7-da7884c318b2"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("88981255-6748-4225-9f74-15a096ff7516"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("de8c04bb-f612-4603-85fe-9ad0461f5048"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("c070f1d4-d661-41be-9b17-37675095fc11"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("d1fe24b5-d12b-4dda-9671-70d0f6db02f9"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("daefe694-f069-4dc9-a319-849e7ef08d2a"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("dbdd5735-3b98-429c-9e4b-d27a83cfaa43"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("e4da998f-6541-487b-b373-95bedfc185fc"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("fe3f6730-4f0e-41dc-b843-3e060596a952"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("02935f7b-2a34-48f4-a594-d4b89a0a3b90"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("036f9715-c60a-4b90-b446-9225122ef8cb"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("03d4d4fb-9081-4ce9-bc13-f9fa8689c564"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("053d68d3-0770-494e-9af1-f91d15f507b1"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0674de8e-536e-459f-b7ae-957b959b7204"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("715bbb09-3ae5-4767-94d4-1a118c0d69a6"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("49fd2436-bb19-4739-8f68-ac6cebb9628d"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("568a0d13-f0ed-4098-962f-8a41cdec8324"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("595b1233-1725-4c4b-9e3c-1a6211c3291e"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("9e006968-0d60-488e-b08b-c1b30b3b6414"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("a3f2f940-6c5c-4e2c-806f-44094476af8a"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("e2052434-cf38-4b51-83c5-8069bbbeedd2"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("2376f248-e6ef-4bcb-a910-e984dec2e95c"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("2d7d6d8f-7c55-4f65-9f62-472ea01192ba"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("6450a483-aaa6-4adb-a5bf-2d4fa3de60c8"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("98d0cebc-55e7-4b3a-9245-f850918b9819"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("c29c677f-23d0-4c01-8d58-5747291a47ba"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("14302609-9f6a-4013-a656-9b4690056c48"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("6e1fd942-d780-4f51-a516-3deef08c11ab"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("77a1fcd6-4b49-4732-af72-03336eac3bcc"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("daf7e390-5680-4140-af4d-70886ecc5506"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("f07898bf-1b7c-4bd5-9de3-2633f46aecc4"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("ff946efc-d44e-4f1b-8fcc-756fa025427c"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0035c2f5-e3e0-4f42-8a72-4d8551178524"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("00ab6b81-fa29-4920-9e41-b78258bb978c"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0192df81-5ee0-4978-b9b2-2375c7bbd257"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0226cdd5-656c-4549-8c34-d05d514c473e"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("02607677-0f09-4aef-b3e9-972af027866a"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("fdaa9313-85a1-48b4-9f66-a2290124c72d"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("7f9138c8-873b-4fc2-b19b-08ca00efabea"));

            migrationBuilder.DropColumn(
                name: "PediatricianId",
                table: "Kid");

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("cbf3402a-883f-49d7-8376-95fe307ee250"), "KPH" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("baa939fa-7f17-44b6-851d-c24aaf5c676d"), null, "Gregorio de Jesus", "Rojas Acosta", null, null, null });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("ff49656f-3d11-4bc2-8c00-3db54943ece1"), null, "Yadira", "Pinales Delgado", null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityTemplate",
                columns: new[] { "Id", "Description", "KindergarterId" },
                values: new object[,]
                {
                    { new Guid("864fd426-bb3b-458a-b429-71757a90c8fd"), "Clases de ingles", new Guid("cbf3402a-883f-49d7-8376-95fe307ee250") },
                    { new Guid("7b62b015-517f-42d0-a250-92371711e610"), "Cuidade matutino", new Guid("cbf3402a-883f-49d7-8376-95fe307ee250") },
                    { new Guid("1cf0bf9e-2bc0-45ef-b120-cdaaa4f64d60"), "Cuidado Vespertino", new Guid("cbf3402a-883f-49d7-8376-95fe307ee250") },
                    { new Guid("c6138c54-ef19-45e4-b8cd-4017b629b49b"), "Cuidado dia completo", new Guid("cbf3402a-883f-49d7-8376-95fe307ee250") },
                    { new Guid("7585b91e-b1e4-4926-92ad-9e9c537e3628"), "Clases de Ballet", new Guid("cbf3402a-883f-49d7-8376-95fe307ee250") },
                    { new Guid("66b72d6a-7eb0-4b9b-91e3-762f75b60594"), "Clases de logica", new Guid("cbf3402a-883f-49d7-8376-95fe307ee250") }
                });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "Address", "BirthDate", "Diseases", "FatherName", "FavoriteActivities", "FirstName", "KindergarterId", "MotherName", "SecondName", "Sex", "SiblingCount", "TShirtSize", "TutorId" },
                values: new object[,]
                {
                    { new Guid("0011bf63-6361-4add-a0e9-b0246c37d5d8"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Stackeetam", null, "Lyan", new Guid("cbf3402a-883f-49d7-8376-95fe307ee250"), "White", "Carlos", 0, 0, 0, new Guid("baa939fa-7f17-44b6-851d-c24aaf5c676d") },
                    { new Guid("01101aa7-48cf-4837-8e0d-43c0d2e5124f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Escobar", null, "Johan", new Guid("cbf3402a-883f-49d7-8376-95fe307ee250"), "White", "Enrique", 0, 0, 0, new Guid("baa939fa-7f17-44b6-851d-c24aaf5c676d") },
                    { new Guid("012fb48d-3ddd-4165-bbb2-78b2ce0c1277"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Faringtom", null, "Aaron", new Guid("cbf3402a-883f-49d7-8376-95fe307ee250"), "Washinton", "Carlos", 0, 0, 0, new Guid("baa939fa-7f17-44b6-851d-c24aaf5c676d") },
                    { new Guid("0247636c-21ba-46e1-a1f0-7312991b13c7"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lee", null, "Johan", new Guid("cbf3402a-883f-49d7-8376-95fe307ee250"), "Washinton", "Carlos", 0, 0, 0, new Guid("baa939fa-7f17-44b6-851d-c24aaf5c676d") },
                    { new Guid("046fe88d-ab29-4b90-bd25-895cc7f6c83c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lee", null, "Johan", new Guid("cbf3402a-883f-49d7-8376-95fe307ee250"), "Snow", "Eduardo", 0, 0, 0, new Guid("baa939fa-7f17-44b6-851d-c24aaf5c676d") },
                    { new Guid("0853539c-38ce-4ab7-847f-69b7b17ff028"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Stackeetam", null, "Dylan", new Guid("cbf3402a-883f-49d7-8376-95fe307ee250"), "Washinton", "Carlos", 0, 0, 0, new Guid("baa939fa-7f17-44b6-851d-c24aaf5c676d") },
                    { new Guid("09d75120-d6dd-4ac8-a3ae-467abfc00265"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Escobar", null, "Aaron", new Guid("cbf3402a-883f-49d7-8376-95fe307ee250"), "Snow", "Eduardo", 0, 0, 0, new Guid("baa939fa-7f17-44b6-851d-c24aaf5c676d") },
                    { new Guid("0ca8a160-9dd1-4899-b2e0-c5e437f61e37"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Escobar", null, "Johan", new Guid("cbf3402a-883f-49d7-8376-95fe307ee250"), "Washinton", "Carlos", 0, 0, 0, new Guid("baa939fa-7f17-44b6-851d-c24aaf5c676d") },
                    { new Guid("0d051043-dc6f-43e6-8c93-eeb4ddb23701"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Stackeetam", null, "Aaron", new Guid("cbf3402a-883f-49d7-8376-95fe307ee250"), "Snow", "Carlos", 0, 0, 0, new Guid("baa939fa-7f17-44b6-851d-c24aaf5c676d") },
                    { new Guid("0e1dc6a7-b79b-43e1-a085-3c087865bd02"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Escobar", null, "Johan", new Guid("cbf3402a-883f-49d7-8376-95fe307ee250"), "Worm", "Eduardo", 0, 0, 0, new Guid("baa939fa-7f17-44b6-851d-c24aaf5c676d") }
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "Id", "ActivityTemplateId", "Description" },
                values: new object[,]
                {
                    { new Guid("cfc72c08-1567-4da0-948f-154949506e7f"), new Guid("864fd426-bb3b-458a-b429-71757a90c8fd"), "Clases de ingles" },
                    { new Guid("45ac2cbb-d47f-48ab-8f27-d0aa149a9455"), new Guid("7b62b015-517f-42d0-a250-92371711e610"), "Cuidade matutino" },
                    { new Guid("6606bc3c-136c-46fc-965e-50d405d3c8bb"), new Guid("1cf0bf9e-2bc0-45ef-b120-cdaaa4f64d60"), "Cuidado Vespertino" },
                    { new Guid("f928027e-f5ed-401b-8e93-59caa2de5338"), new Guid("c6138c54-ef19-45e4-b8cd-4017b629b49b"), "Cuidado dia completo" },
                    { new Guid("c798d23c-2ae7-4da7-9c2d-232d4eb9c95d"), new Guid("7585b91e-b1e4-4926-92ad-9e9c537e3628"), "Clases de Ballet" },
                    { new Guid("42a053db-c47c-4a51-bdbd-32353fc8fa74"), new Guid("66b72d6a-7eb0-4b9b-91e3-762f75b60594"), "Clases de logica" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "Comment", "EnrollDay", "KidId" },
                values: new object[,]
                {
                    { new Guid("5ae4fd1a-e858-485a-9497-0bfe176f6f69"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0011bf63-6361-4add-a0e9-b0246c37d5d8") },
                    { new Guid("92dfe308-94bb-49e7-af7e-17394c35454d"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("01101aa7-48cf-4837-8e0d-43c0d2e5124f") },
                    { new Guid("95ffc573-12b9-416e-b323-971d348fe707"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("012fb48d-3ddd-4165-bbb2-78b2ce0c1277") },
                    { new Guid("ec5d94dd-4111-47a4-82be-092fd55ff927"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0247636c-21ba-46e1-a1f0-7312991b13c7") },
                    { new Guid("5976976c-62f1-44ec-9440-3c2521536c34"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("046fe88d-ab29-4b90-bd25-895cc7f6c83c") }
                });

            migrationBuilder.InsertData(
                table: "EnrollActivity",
                columns: new[] { "Id", "ActivityId", "EnrollmentId" },
                values: new object[,]
                {
                    { new Guid("bb429747-f614-4c79-b79a-67e01710be93"), new Guid("6606bc3c-136c-46fc-965e-50d405d3c8bb"), new Guid("5ae4fd1a-e858-485a-9497-0bfe176f6f69") },
                    { new Guid("34f3c006-0f9e-44ab-b170-600a44425ea6"), new Guid("45ac2cbb-d47f-48ab-8f27-d0aa149a9455"), new Guid("92dfe308-94bb-49e7-af7e-17394c35454d") },
                    { new Guid("7ad46170-c929-4a9c-876e-0467eab58767"), new Guid("6606bc3c-136c-46fc-965e-50d405d3c8bb"), new Guid("95ffc573-12b9-416e-b323-971d348fe707") },
                    { new Guid("601cf899-35d0-4fd0-b7c6-62737b4f1d44"), new Guid("6606bc3c-136c-46fc-965e-50d405d3c8bb"), new Guid("ec5d94dd-4111-47a4-82be-092fd55ff927") },
                    { new Guid("21c4c6cf-4b16-4454-b646-a434d7cbd142"), new Guid("c798d23c-2ae7-4da7-9c2d-232d4eb9c95d"), new Guid("5976976c-62f1-44ec-9440-3c2521536c34") }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Price", "Reference", "ActivityId", "Description", "ServicePeriod" },
                values: new object[,]
                {
                    { new Guid("1b73e220-114a-47e1-991c-e335571d4fff"), "Service", 6955m, "SRV-47", new Guid("cfc72c08-1567-4da0-948f-154949506e7f"), "Service Clases de ingles", 77 },
                    { new Guid("98a6ddbd-6cf1-487b-9bb4-029cb6756f68"), "Service", 6313m, "SRV-283", new Guid("45ac2cbb-d47f-48ab-8f27-d0aa149a9455"), "Service Cuidade matutino", 77 },
                    { new Guid("b5a0a086-68a1-4ee2-8e75-9ffcb3ce954f"), "Service", 1793m, "SRV-376", new Guid("6606bc3c-136c-46fc-965e-50d405d3c8bb"), "Service Cuidado Vespertino", 77 },
                    { new Guid("f95dfbed-9f8e-4f94-864d-dff62cce82a2"), "Service", 357m, "SRV-981", new Guid("f928027e-f5ed-401b-8e93-59caa2de5338"), "Service Cuidado dia completo", 77 },
                    { new Guid("f4d5550c-8f27-4752-a6cb-95339efd2659"), "Service", 2921m, "SRV-771", new Guid("c798d23c-2ae7-4da7-9c2d-232d4eb9c95d"), "Service Clases de Ballet", 77 },
                    { new Guid("f3b61b66-5482-45d4-a29f-3df918f26514"), "Service", 1945m, "SRV-760", new Guid("42a053db-c47c-4a51-bdbd-32353fc8fa74"), "Service Clases de logica", 77 }
                });
        }
    }
}
