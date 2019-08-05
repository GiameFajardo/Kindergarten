using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Adding_Tutors_to_Kid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kid_Tutors_TutorId",
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

            migrationBuilder.AlterColumn<Guid>(
                name: "TutorId",
                table: "Kid",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<Guid>(
                name: "TutorPrincipalId",
                table: "Kid",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Kid_TutorPrincipalId",
                table: "Kid",
                column: "TutorPrincipalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kid_Tutors_TutorId",
                table: "Kid",
                column: "TutorId",
                principalTable: "Tutors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Kid_Tutors_TutorPrincipalId",
                table: "Kid",
                column: "TutorPrincipalId",
                principalTable: "Tutors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kid_Tutors_TutorId",
                table: "Kid");

            migrationBuilder.DropForeignKey(
                name: "FK_Kid_Tutors_TutorPrincipalId",
                table: "Kid");

            migrationBuilder.DropIndex(
                name: "IX_Kid_TutorPrincipalId",
                table: "Kid");

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

            migrationBuilder.DropColumn(
                name: "TutorPrincipalId",
                table: "Kid");

            migrationBuilder.AlterColumn<Guid>(
                name: "TutorId",
                table: "Kid",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Kid_Tutors_TutorId",
                table: "Kid",
                column: "TutorId",
                principalTable: "Tutors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
