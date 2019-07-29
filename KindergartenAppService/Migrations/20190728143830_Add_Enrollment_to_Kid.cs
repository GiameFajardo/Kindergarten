using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Add_Enrollment_to_Kid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Kid_Enrollments_EnrollmentId",
            //    table: "Kid");

            //migrationBuilder.DropIndex(
            //    name: "IX_Kid_EnrollmentId",
            //    table: "Kid");

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("1826ef64-fe62-446c-abc8-5f5dbef70391"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("43bccdf2-5fc8-4cd1-9836-a36d5916836b"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("4cb96381-5bc2-454a-bc25-bfb083c150a9"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("da12a751-06f8-4348-955f-5ab3be83abf1"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("e29c87ac-b7d4-409e-b0d5-aa1b8f1dbd26"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("ea7f0ba0-8325-492b-b799-936b6aa32b08"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0062a4d0-cffb-4087-8b51-ee9cb2992989"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0194db9f-e7b4-4dd3-8d13-eafadd3982bc"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("03bf6564-c230-4364-ae6c-0f17b1bafba6"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("068f82e5-e0e2-4b4e-abca-9ec657106461"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("070ee839-daa7-40e1-9c1a-0e93640fdd34"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("071d3565-fd70-4786-94e1-2a9eb4d050a3"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("07fa69ca-17c5-493c-b38d-64c0be924eaa"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("08aac7e1-a723-41df-97ab-0e27d1c8fb27"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("08f91cec-b3f4-4255-99ea-1b8366e2b6df"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0af9b387-8d45-42af-be98-357242f3cefd"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("78f120b1-7b2b-48e4-8680-5ed510bea282"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("24626d65-fafe-438f-ab60-80297c8ec269"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("29a6e898-db2c-4c8b-a389-bd553599f54d"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("971e7f2e-e083-4cee-8ee2-d1a84d44b826"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("ab907c53-6fcd-4feb-834d-95341a3855fa"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("b8b6ce08-b584-4b01-a8a5-ffba6781a5ab"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("fffeff63-d092-4960-90e9-ad5551376c4f"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("c18fba5f-fa86-4662-ba54-27b6ea1c394c"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("34f51eb1-e740-462c-b4e3-3ae66515c66e"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("3660793e-14de-490f-876b-4adcf6b32dcb"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("533491aa-edc9-497b-b618-755d9aeb455c"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("7cba2432-c5dd-4243-8e46-7c9f9c12a8e3"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("b4b89cbf-c44e-430e-b625-7ae4148eba52"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("f430646a-87af-4775-89ac-97ce6e661df8"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("18f78a41-0c80-46b2-905f-c1f1d34605fb"));

            //migrationBuilder.DropColumn(
            //    name: "EnrollmentId",
            //    table: "Kid");

            migrationBuilder.AddColumn<Guid>(
                name: "KidId",
                table: "Enrollments",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_KidId",
                table: "Enrollments",
                column: "KidId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Kid_KidId",
                table: "Enrollments",
                column: "KidId",
                principalTable: "Kid",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Kid_KidId",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_KidId",
                table: "Enrollments");

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

            migrationBuilder.DropColumn(
                name: "KidId",
                table: "Enrollments");

            migrationBuilder.AddColumn<Guid>(
                name: "EnrollmentId",
                table: "Kid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("18f78a41-0c80-46b2-905f-c1f1d34605fb"), "Guarderia" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("c18fba5f-fa86-4662-ba54-27b6ea1c394c"), null, "Gregorio de Jesus", "Rojas Acosta", null, null, null });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("78f120b1-7b2b-48e4-8680-5ed510bea282"), null, "Yadira", "Pinales Delgado", null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityTemplate",
                columns: new[] { "Id", "Description", "KindergarterId" },
                values: new object[,]
                {
                    { new Guid("3660793e-14de-490f-876b-4adcf6b32dcb"), "Clases de ingles", new Guid("18f78a41-0c80-46b2-905f-c1f1d34605fb") },
                    { new Guid("533491aa-edc9-497b-b618-755d9aeb455c"), "Cuidade matutino", new Guid("18f78a41-0c80-46b2-905f-c1f1d34605fb") },
                    { new Guid("34f51eb1-e740-462c-b4e3-3ae66515c66e"), "Cuidado Vespertino", new Guid("18f78a41-0c80-46b2-905f-c1f1d34605fb") },
                    { new Guid("f430646a-87af-4775-89ac-97ce6e661df8"), "Cuidado dia completo", new Guid("18f78a41-0c80-46b2-905f-c1f1d34605fb") },
                    { new Guid("b4b89cbf-c44e-430e-b625-7ae4148eba52"), "Clases de Ballet", new Guid("18f78a41-0c80-46b2-905f-c1f1d34605fb") },
                    { new Guid("7cba2432-c5dd-4243-8e46-7c9f9c12a8e3"), "Clases de logica", new Guid("18f78a41-0c80-46b2-905f-c1f1d34605fb") }
                });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "EnrollmentId", "FatherName", "FirstName", "KindergarterId", "MotherName", "SecondName", "TutorId" },
                values: new object[,]
                {
                    { new Guid("0062a4d0-cffb-4087-8b51-ee9cb2992989"), new Guid("00000000-0000-0000-0000-000000000000"), "Escobar", "Aaron", new Guid("18f78a41-0c80-46b2-905f-c1f1d34605fb"), "White", "Carlos", new Guid("c18fba5f-fa86-4662-ba54-27b6ea1c394c") },
                    { new Guid("0194db9f-e7b4-4dd3-8d13-eafadd3982bc"), new Guid("00000000-0000-0000-0000-000000000000"), "Faringtom", "Lyan", new Guid("18f78a41-0c80-46b2-905f-c1f1d34605fb"), "Snow", "Carlos", new Guid("c18fba5f-fa86-4662-ba54-27b6ea1c394c") },
                    { new Guid("03bf6564-c230-4364-ae6c-0f17b1bafba6"), new Guid("00000000-0000-0000-0000-000000000000"), "Lee", "Johan", new Guid("18f78a41-0c80-46b2-905f-c1f1d34605fb"), "White", "Enrique", new Guid("c18fba5f-fa86-4662-ba54-27b6ea1c394c") },
                    { new Guid("068f82e5-e0e2-4b4e-abca-9ec657106461"), new Guid("00000000-0000-0000-0000-000000000000"), "Escobar", "Aaron", new Guid("18f78a41-0c80-46b2-905f-c1f1d34605fb"), "Washinton", "Carlos", new Guid("c18fba5f-fa86-4662-ba54-27b6ea1c394c") },
                    { new Guid("070ee839-daa7-40e1-9c1a-0e93640fdd34"), new Guid("00000000-0000-0000-0000-000000000000"), "Lee", "Johan", new Guid("18f78a41-0c80-46b2-905f-c1f1d34605fb"), "Snow", "Carlos", new Guid("c18fba5f-fa86-4662-ba54-27b6ea1c394c") },
                    { new Guid("071d3565-fd70-4786-94e1-2a9eb4d050a3"), new Guid("00000000-0000-0000-0000-000000000000"), "Faringtom", "Johan", new Guid("18f78a41-0c80-46b2-905f-c1f1d34605fb"), "Worm", "Enrique", new Guid("c18fba5f-fa86-4662-ba54-27b6ea1c394c") },
                    { new Guid("07fa69ca-17c5-493c-b38d-64c0be924eaa"), new Guid("00000000-0000-0000-0000-000000000000"), "Faringtom", "Dylan", new Guid("18f78a41-0c80-46b2-905f-c1f1d34605fb"), "Washinton", "Emilio", new Guid("c18fba5f-fa86-4662-ba54-27b6ea1c394c") },
                    { new Guid("08aac7e1-a723-41df-97ab-0e27d1c8fb27"), new Guid("00000000-0000-0000-0000-000000000000"), "Faringtom", "Johan", new Guid("18f78a41-0c80-46b2-905f-c1f1d34605fb"), "Washinton", "Emilio", new Guid("c18fba5f-fa86-4662-ba54-27b6ea1c394c") },
                    { new Guid("08f91cec-b3f4-4255-99ea-1b8366e2b6df"), new Guid("00000000-0000-0000-0000-000000000000"), "Escobar", "Aaron", new Guid("18f78a41-0c80-46b2-905f-c1f1d34605fb"), "Washinton", "Emilio", new Guid("c18fba5f-fa86-4662-ba54-27b6ea1c394c") },
                    { new Guid("0af9b387-8d45-42af-be98-357242f3cefd"), new Guid("00000000-0000-0000-0000-000000000000"), "Escobar", "Aaron", new Guid("18f78a41-0c80-46b2-905f-c1f1d34605fb"), "White", "Eduardo", new Guid("c18fba5f-fa86-4662-ba54-27b6ea1c394c") }
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "Id", "ActivityTemplateId", "Description" },
                values: new object[,]
                {
                    { new Guid("29a6e898-db2c-4c8b-a389-bd553599f54d"), new Guid("3660793e-14de-490f-876b-4adcf6b32dcb"), "Clases de ingles" },
                    { new Guid("b8b6ce08-b584-4b01-a8a5-ffba6781a5ab"), new Guid("533491aa-edc9-497b-b618-755d9aeb455c"), "Cuidade matutino" },
                    { new Guid("fffeff63-d092-4960-90e9-ad5551376c4f"), new Guid("34f51eb1-e740-462c-b4e3-3ae66515c66e"), "Cuidado Vespertino" },
                    { new Guid("24626d65-fafe-438f-ab60-80297c8ec269"), new Guid("f430646a-87af-4775-89ac-97ce6e661df8"), "Cuidado dia completo" },
                    { new Guid("ab907c53-6fcd-4feb-834d-95341a3855fa"), new Guid("b4b89cbf-c44e-430e-b625-7ae4148eba52"), "Clases de Ballet" },
                    { new Guid("971e7f2e-e083-4cee-8ee2-d1a84d44b826"), new Guid("7cba2432-c5dd-4243-8e46-7c9f9c12a8e3"), "Clases de logica" }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Price", "Reference", "ActivityId", "Description", "ServicePeriod" },
                values: new object[,]
                {
                    { new Guid("e29c87ac-b7d4-409e-b0d5-aa1b8f1dbd26"), "Service", 533m, "SRV-304", new Guid("29a6e898-db2c-4c8b-a389-bd553599f54d"), "Service Clases de ingles", 77 },
                    { new Guid("ea7f0ba0-8325-492b-b799-936b6aa32b08"), "Service", 9752m, "SRV-349", new Guid("b8b6ce08-b584-4b01-a8a5-ffba6781a5ab"), "Service Cuidade matutino", 77 },
                    { new Guid("1826ef64-fe62-446c-abc8-5f5dbef70391"), "Service", 2998m, "SRV-558", new Guid("fffeff63-d092-4960-90e9-ad5551376c4f"), "Service Cuidado Vespertino", 77 },
                    { new Guid("43bccdf2-5fc8-4cd1-9836-a36d5916836b"), "Service", 3604m, "SRV-328", new Guid("24626d65-fafe-438f-ab60-80297c8ec269"), "Service Cuidado dia completo", 77 },
                    { new Guid("da12a751-06f8-4348-955f-5ab3be83abf1"), "Service", 678m, "SRV-579", new Guid("ab907c53-6fcd-4feb-834d-95341a3855fa"), "Service Clases de Ballet", 77 },
                    { new Guid("4cb96381-5bc2-454a-bc25-bfb083c150a9"), "Service", 6798m, "SRV-22", new Guid("971e7f2e-e083-4cee-8ee2-d1a84d44b826"), "Service Clases de logica", 77 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kid_EnrollmentId",
                table: "Kid",
                column: "EnrollmentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Kid_Enrollments_EnrollmentId",
                table: "Kid",
                column: "EnrollmentId",
                principalTable: "Enrollments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
