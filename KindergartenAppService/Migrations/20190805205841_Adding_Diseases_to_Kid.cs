using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Adding_Diseases_to_Kid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("26506b0c-9308-49b9-925d-d007a47154e0"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("6983dd07-3165-4e10-9a95-cf06599e3834"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("94885b1f-c5c5-4561-90af-d8645be3a327"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("af6f77f3-0dc0-4af1-99b3-71257d540a59"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("b97f035a-f6b2-4290-ae14-e4fa0dfc278d"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("0633c3f6-3a8e-4765-bfe6-3b59799c9b4d"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("6e05a1d7-5a3d-458c-a748-2300e4cfa880"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("704c6e7a-c8de-447a-bf58-e708cc79ea45"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("832baabe-ead6-41fd-b790-24719b6b6962"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("a7598aff-7340-457e-8ac8-867501dd24b0"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("ae20cfaf-2f2c-4c42-a84d-48b7053e014d"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("04e4690b-74b1-48ab-95df-0ac3d46580e0"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("05eada6b-ee1f-415c-927d-5dc9a76a0cd0"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("06095d50-99c0-4e5e-88cf-b2434b82276e"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("066f005f-1c36-433a-925b-d4be4688ea0e"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0764e7eb-3c42-4217-a71d-909931b59e83"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("b7370d63-cec0-4d74-b669-d3539140c869"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("0d4fbdbc-6d67-4855-ac68-4a4a47c76bb4"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("4dfd6ae0-f00d-46b2-a567-2f5c94de134b"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("b189d9df-946e-4315-bf6f-986ca1c36e69"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("bb6ec32c-bc6d-4286-a631-0b641cdea782"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("dec6a963-9e08-4373-9238-91713b80a7b6"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("f0d3d0fc-a7eb-4772-9e4f-725d167014fe"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("48208912-5cd1-4e19-9309-fc7d74bb198a"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("540c8f37-5ab4-4a16-9fae-fbcb6318459d"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("64d6cd49-3369-4885-b6b3-09782b60a3ff"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("d1081690-b33d-48ed-b20b-d60fb8cadbe5"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("fbdafe7a-d595-42eb-8955-ab80811e8d1e"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("66bca942-7b3b-4f3e-831c-b7863268030d"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("7aea95d2-9f9a-4d62-920c-dc442be0af2d"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("c7a0c679-1717-46f7-9f45-da9153a6a9a4"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("d3d23037-7ae3-4005-8cc2-235acaaf0f54"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("ea3c552b-98df-4e3c-9127-9650639cae76"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("fd6e0d8f-f92b-46c7-a37a-501f5528e144"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("012202b9-61ee-494e-9099-ba6bce67aac6"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0146bf6c-39fa-4e3a-9e9c-2c861384b4a0"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0329e38b-c48c-48d0-9994-295db8ede606"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("032fddb7-a66a-44f5-8b72-d89263bd306a"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("04af1463-3174-4cae-b3c8-f6f85005d269"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("04cbeadb-e000-4b9f-80a0-ee997cbc0bf8"));

            migrationBuilder.AddColumn<string>(
                name: "Diseases",
                table: "Kid",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("61fbf9e3-5109-4046-88c7-7ad0dc9d5bfd"), "KPH" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("a39d64d3-1213-4afe-b819-9c6ad903e4fa"), null, "Gregorio de Jesus", "Rojas Acosta", null, null, null });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("7b7a55eb-0888-43cf-b0c6-6c448124dc2c"), null, "Yadira", "Pinales Delgado", null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityTemplate",
                columns: new[] { "Id", "Description", "KindergarterId" },
                values: new object[,]
                {
                    { new Guid("07ada114-9c9f-44f0-902e-8ae5c30c3ec0"), "Clases de ingles", new Guid("61fbf9e3-5109-4046-88c7-7ad0dc9d5bfd") },
                    { new Guid("d574a125-c9ef-4abd-86b7-08c762f42144"), "Cuidade matutino", new Guid("61fbf9e3-5109-4046-88c7-7ad0dc9d5bfd") },
                    { new Guid("f015fb28-1594-434b-9ec5-341b45229af2"), "Cuidado Vespertino", new Guid("61fbf9e3-5109-4046-88c7-7ad0dc9d5bfd") },
                    { new Guid("0e6b8d42-1793-4ff3-b4fb-54ff8fb0b303"), "Cuidado dia completo", new Guid("61fbf9e3-5109-4046-88c7-7ad0dc9d5bfd") },
                    { new Guid("76eec8c5-3efd-48ea-be18-a5b584dc1acc"), "Clases de Ballet", new Guid("61fbf9e3-5109-4046-88c7-7ad0dc9d5bfd") },
                    { new Guid("1369cafd-86e3-426d-8316-662c650590bc"), "Clases de logica", new Guid("61fbf9e3-5109-4046-88c7-7ad0dc9d5bfd") }
                });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "Address", "BirthDate", "Diseases", "FatherName", "FavoriteActivities", "FirstName", "KindergarterId", "MotherName", "SecondName", "SiblingCount", "TutorId" },
                values: new object[,]
                {
                    { new Guid("01609e67-66a1-4f44-a704-2d1ebe07a985"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Faringtom", null, "Dylan", new Guid("61fbf9e3-5109-4046-88c7-7ad0dc9d5bfd"), "White", "Eduardo", 0, new Guid("a39d64d3-1213-4afe-b819-9c6ad903e4fa") },
                    { new Guid("0219bcd6-ca2e-45d8-962e-9fdbd9a6c965"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lee", null, "Johan", new Guid("61fbf9e3-5109-4046-88c7-7ad0dc9d5bfd"), "Washinton", "Enrique", 0, new Guid("a39d64d3-1213-4afe-b819-9c6ad903e4fa") },
                    { new Guid("04c2d0cd-e3df-4fde-8a1a-57eb0c94eb4c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Faringtom", null, "Aaron", new Guid("61fbf9e3-5109-4046-88c7-7ad0dc9d5bfd"), "Washinton", "Eduardo", 0, new Guid("a39d64d3-1213-4afe-b819-9c6ad903e4fa") },
                    { new Guid("0586b92f-d400-4924-bec8-a1651aa19362"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Stackeetam", null, "Aaron", new Guid("61fbf9e3-5109-4046-88c7-7ad0dc9d5bfd"), "Worm", "Eduardo", 0, new Guid("a39d64d3-1213-4afe-b819-9c6ad903e4fa") },
                    { new Guid("063389db-bb81-426c-9836-60804278f620"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Escobar", null, "Dylan", new Guid("61fbf9e3-5109-4046-88c7-7ad0dc9d5bfd"), "White", "Enrique", 0, new Guid("a39d64d3-1213-4afe-b819-9c6ad903e4fa") },
                    { new Guid("06d136a0-b3d9-430d-a44d-0e4f3b6a343c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Escobar", null, "Dylan", new Guid("61fbf9e3-5109-4046-88c7-7ad0dc9d5bfd"), "Worm", "Carlos", 0, new Guid("a39d64d3-1213-4afe-b819-9c6ad903e4fa") },
                    { new Guid("08582111-c005-44f8-983a-51ffe0ed7da8"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Faringtom", null, "Johan", new Guid("61fbf9e3-5109-4046-88c7-7ad0dc9d5bfd"), "White", "Enrique", 0, new Guid("a39d64d3-1213-4afe-b819-9c6ad903e4fa") },
                    { new Guid("0872a88b-4c84-4293-8b1f-5e1a5025f127"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Stackeetam", null, "Dylan", new Guid("61fbf9e3-5109-4046-88c7-7ad0dc9d5bfd"), "Washinton", "Eduardo", 0, new Guid("a39d64d3-1213-4afe-b819-9c6ad903e4fa") },
                    { new Guid("08760263-b501-407d-93a9-0f43e511fae0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Faringtom", null, "Dylan", new Guid("61fbf9e3-5109-4046-88c7-7ad0dc9d5bfd"), "White", "Enrique", 0, new Guid("a39d64d3-1213-4afe-b819-9c6ad903e4fa") },
                    { new Guid("0a15c9d8-eab6-40ca-bbcc-5d68904b4cf0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lee", null, "Aaron", new Guid("61fbf9e3-5109-4046-88c7-7ad0dc9d5bfd"), "White", "Emilio", 0, new Guid("a39d64d3-1213-4afe-b819-9c6ad903e4fa") }
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "Id", "ActivityTemplateId", "Description" },
                values: new object[,]
                {
                    { new Guid("e559dbfe-5134-4f22-8401-4af72823c7b2"), new Guid("07ada114-9c9f-44f0-902e-8ae5c30c3ec0"), "Clases de ingles" },
                    { new Guid("d286f309-3ec8-4fc8-b2ab-961eca9e5741"), new Guid("d574a125-c9ef-4abd-86b7-08c762f42144"), "Cuidade matutino" },
                    { new Guid("060e81b8-2604-42db-b7ab-9665d34efb0e"), new Guid("f015fb28-1594-434b-9ec5-341b45229af2"), "Cuidado Vespertino" },
                    { new Guid("59f590c1-0bbb-494b-a463-48d73cbf5339"), new Guid("0e6b8d42-1793-4ff3-b4fb-54ff8fb0b303"), "Cuidado dia completo" },
                    { new Guid("8366304a-a7a1-4472-afc3-aec8a908e810"), new Guid("76eec8c5-3efd-48ea-be18-a5b584dc1acc"), "Clases de Ballet" },
                    { new Guid("859cd2ff-057f-483a-9338-519a31dfbd99"), new Guid("1369cafd-86e3-426d-8316-662c650590bc"), "Clases de logica" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "Comment", "EnrollDay", "KidId" },
                values: new object[,]
                {
                    { new Guid("ea8adc79-8547-461c-897b-cdfbdab03db9"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("01609e67-66a1-4f44-a704-2d1ebe07a985") },
                    { new Guid("9c7e6a6e-aba7-4af0-8c5b-f63e2fda6863"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0219bcd6-ca2e-45d8-962e-9fdbd9a6c965") },
                    { new Guid("b0763444-cbb2-4c7c-b81a-bfe12cd485dd"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("04c2d0cd-e3df-4fde-8a1a-57eb0c94eb4c") },
                    { new Guid("c720c158-321f-40a0-882a-27b71f940298"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0586b92f-d400-4924-bec8-a1651aa19362") },
                    { new Guid("2f085670-1cff-423f-bff1-5cafe11b0b41"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("063389db-bb81-426c-9836-60804278f620") }
                });

            migrationBuilder.InsertData(
                table: "EnrollActivity",
                columns: new[] { "Id", "ActivityId", "EnrollmentId" },
                values: new object[,]
                {
                    { new Guid("b09c42e3-f817-40b0-a185-55b9913b0e3a"), new Guid("59f590c1-0bbb-494b-a463-48d73cbf5339"), new Guid("ea8adc79-8547-461c-897b-cdfbdab03db9") },
                    { new Guid("fe84c153-5a07-4003-bade-3ec1c4a7a4bc"), new Guid("859cd2ff-057f-483a-9338-519a31dfbd99"), new Guid("9c7e6a6e-aba7-4af0-8c5b-f63e2fda6863") },
                    { new Guid("9d33235e-ebf8-49c2-b974-7a52f8c33e3b"), new Guid("859cd2ff-057f-483a-9338-519a31dfbd99"), new Guid("b0763444-cbb2-4c7c-b81a-bfe12cd485dd") },
                    { new Guid("906b5da6-7925-4696-aadb-417657f1d079"), new Guid("d286f309-3ec8-4fc8-b2ab-961eca9e5741"), new Guid("c720c158-321f-40a0-882a-27b71f940298") },
                    { new Guid("a1906eba-6377-4fa8-891a-28d8224194b4"), new Guid("8366304a-a7a1-4472-afc3-aec8a908e810"), new Guid("2f085670-1cff-423f-bff1-5cafe11b0b41") }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Price", "Reference", "ActivityId", "Description", "ServicePeriod" },
                values: new object[,]
                {
                    { new Guid("be14cad9-6580-497d-ba84-29bb40093eb9"), "Service", 5063m, "SRV-754", new Guid("e559dbfe-5134-4f22-8401-4af72823c7b2"), "Service Clases de ingles", 77 },
                    { new Guid("4e2b81b4-8af2-4353-b47d-daf190493290"), "Service", 2563m, "SRV-36", new Guid("d286f309-3ec8-4fc8-b2ab-961eca9e5741"), "Service Cuidade matutino", 77 },
                    { new Guid("5ca5fa7b-0be4-45fe-8dbf-5aebf4c2108e"), "Service", 1498m, "SRV-567", new Guid("060e81b8-2604-42db-b7ab-9665d34efb0e"), "Service Cuidado Vespertino", 77 },
                    { new Guid("e8e2c83e-35cf-4bc5-b12b-8bf93b920b91"), "Service", 1804m, "SRV-459", new Guid("59f590c1-0bbb-494b-a463-48d73cbf5339"), "Service Cuidado dia completo", 77 },
                    { new Guid("5bd4e44f-4ffe-4143-b6df-026844dec690"), "Service", 1716m, "SRV-620", new Guid("8366304a-a7a1-4472-afc3-aec8a908e810"), "Service Clases de Ballet", 77 },
                    { new Guid("a55776f8-04f1-4712-bbc1-19987d433dea"), "Service", 3986m, "SRV-78", new Guid("859cd2ff-057f-483a-9338-519a31dfbd99"), "Service Clases de logica", 77 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("906b5da6-7925-4696-aadb-417657f1d079"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("9d33235e-ebf8-49c2-b974-7a52f8c33e3b"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("a1906eba-6377-4fa8-891a-28d8224194b4"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("b09c42e3-f817-40b0-a185-55b9913b0e3a"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("fe84c153-5a07-4003-bade-3ec1c4a7a4bc"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("4e2b81b4-8af2-4353-b47d-daf190493290"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("5bd4e44f-4ffe-4143-b6df-026844dec690"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("5ca5fa7b-0be4-45fe-8dbf-5aebf4c2108e"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("a55776f8-04f1-4712-bbc1-19987d433dea"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("be14cad9-6580-497d-ba84-29bb40093eb9"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("e8e2c83e-35cf-4bc5-b12b-8bf93b920b91"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("06d136a0-b3d9-430d-a44d-0e4f3b6a343c"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("08582111-c005-44f8-983a-51ffe0ed7da8"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0872a88b-4c84-4293-8b1f-5e1a5025f127"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("08760263-b501-407d-93a9-0f43e511fae0"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0a15c9d8-eab6-40ca-bbcc-5d68904b4cf0"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("7b7a55eb-0888-43cf-b0c6-6c448124dc2c"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("060e81b8-2604-42db-b7ab-9665d34efb0e"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("59f590c1-0bbb-494b-a463-48d73cbf5339"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("8366304a-a7a1-4472-afc3-aec8a908e810"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("859cd2ff-057f-483a-9338-519a31dfbd99"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("d286f309-3ec8-4fc8-b2ab-961eca9e5741"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("e559dbfe-5134-4f22-8401-4af72823c7b2"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("2f085670-1cff-423f-bff1-5cafe11b0b41"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("9c7e6a6e-aba7-4af0-8c5b-f63e2fda6863"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("b0763444-cbb2-4c7c-b81a-bfe12cd485dd"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("c720c158-321f-40a0-882a-27b71f940298"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("ea8adc79-8547-461c-897b-cdfbdab03db9"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("07ada114-9c9f-44f0-902e-8ae5c30c3ec0"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("0e6b8d42-1793-4ff3-b4fb-54ff8fb0b303"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("1369cafd-86e3-426d-8316-662c650590bc"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("76eec8c5-3efd-48ea-be18-a5b584dc1acc"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("d574a125-c9ef-4abd-86b7-08c762f42144"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("f015fb28-1594-434b-9ec5-341b45229af2"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("01609e67-66a1-4f44-a704-2d1ebe07a985"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0219bcd6-ca2e-45d8-962e-9fdbd9a6c965"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("04c2d0cd-e3df-4fde-8a1a-57eb0c94eb4c"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0586b92f-d400-4924-bec8-a1651aa19362"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("063389db-bb81-426c-9836-60804278f620"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("61fbf9e3-5109-4046-88c7-7ad0dc9d5bfd"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("a39d64d3-1213-4afe-b819-9c6ad903e4fa"));

            migrationBuilder.DropColumn(
                name: "Diseases",
                table: "Kid");

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c"), "KPH" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("04cbeadb-e000-4b9f-80a0-ee997cbc0bf8"), null, "Gregorio de Jesus", "Rojas Acosta", null, null, null });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("b7370d63-cec0-4d74-b669-d3539140c869"), null, "Yadira", "Pinales Delgado", null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityTemplate",
                columns: new[] { "Id", "Description", "KindergarterId" },
                values: new object[,]
                {
                    { new Guid("7aea95d2-9f9a-4d62-920c-dc442be0af2d"), "Clases de ingles", new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c") },
                    { new Guid("c7a0c679-1717-46f7-9f45-da9153a6a9a4"), "Cuidade matutino", new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c") },
                    { new Guid("fd6e0d8f-f92b-46c7-a37a-501f5528e144"), "Cuidado Vespertino", new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c") },
                    { new Guid("ea3c552b-98df-4e3c-9127-9650639cae76"), "Cuidado dia completo", new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c") },
                    { new Guid("d3d23037-7ae3-4005-8cc2-235acaaf0f54"), "Clases de Ballet", new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c") },
                    { new Guid("66bca942-7b3b-4f3e-831c-b7863268030d"), "Clases de logica", new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c") }
                });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "Address", "BirthDate", "FatherName", "FavoriteActivities", "FirstName", "KindergarterId", "MotherName", "SecondName", "SiblingCount", "TutorId" },
                values: new object[,]
                {
                    { new Guid("012202b9-61ee-494e-9099-ba6bce67aac6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee", null, "Dylan", new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c"), "Snow", "Carlos", 0, new Guid("04cbeadb-e000-4b9f-80a0-ee997cbc0bf8") },
                    { new Guid("0146bf6c-39fa-4e3a-9e9c-2c861384b4a0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Faringtom", null, "Aaron", new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c"), "White", "Carlos", 0, new Guid("04cbeadb-e000-4b9f-80a0-ee997cbc0bf8") },
                    { new Guid("0329e38b-c48c-48d0-9994-295db8ede606"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Faringtom", null, "Johan", new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c"), "Snow", "Eduardo", 0, new Guid("04cbeadb-e000-4b9f-80a0-ee997cbc0bf8") },
                    { new Guid("032fddb7-a66a-44f5-8b72-d89263bd306a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stackeetam", null, "Johan", new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c"), "White", "Carlos", 0, new Guid("04cbeadb-e000-4b9f-80a0-ee997cbc0bf8") },
                    { new Guid("04af1463-3174-4cae-b3c8-f6f85005d269"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee", null, "Aaron", new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c"), "Worm", "Enrique", 0, new Guid("04cbeadb-e000-4b9f-80a0-ee997cbc0bf8") },
                    { new Guid("04e4690b-74b1-48ab-95df-0ac3d46580e0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Escobar", null, "Johan", new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c"), "Snow", "Eduardo", 0, new Guid("04cbeadb-e000-4b9f-80a0-ee997cbc0bf8") },
                    { new Guid("05eada6b-ee1f-415c-927d-5dc9a76a0cd0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Faringtom", null, "Aaron", new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c"), "Washinton", "Emilio", 0, new Guid("04cbeadb-e000-4b9f-80a0-ee997cbc0bf8") },
                    { new Guid("06095d50-99c0-4e5e-88cf-b2434b82276e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Escobar", null, "Lyan", new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c"), "Snow", "Enrique", 0, new Guid("04cbeadb-e000-4b9f-80a0-ee997cbc0bf8") },
                    { new Guid("066f005f-1c36-433a-925b-d4be4688ea0e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Faringtom", null, "Dylan", new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c"), "Worm", "Eduardo", 0, new Guid("04cbeadb-e000-4b9f-80a0-ee997cbc0bf8") },
                    { new Guid("0764e7eb-3c42-4217-a71d-909931b59e83"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stackeetam", null, "Lyan", new Guid("7a9c17fa-02ee-466e-97f8-feb6e20f599c"), "Worm", "Enrique", 0, new Guid("04cbeadb-e000-4b9f-80a0-ee997cbc0bf8") }
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "Id", "ActivityTemplateId", "Description" },
                values: new object[,]
                {
                    { new Guid("f0d3d0fc-a7eb-4772-9e4f-725d167014fe"), new Guid("7aea95d2-9f9a-4d62-920c-dc442be0af2d"), "Clases de ingles" },
                    { new Guid("bb6ec32c-bc6d-4286-a631-0b641cdea782"), new Guid("c7a0c679-1717-46f7-9f45-da9153a6a9a4"), "Cuidade matutino" },
                    { new Guid("b189d9df-946e-4315-bf6f-986ca1c36e69"), new Guid("fd6e0d8f-f92b-46c7-a37a-501f5528e144"), "Cuidado Vespertino" },
                    { new Guid("dec6a963-9e08-4373-9238-91713b80a7b6"), new Guid("ea3c552b-98df-4e3c-9127-9650639cae76"), "Cuidado dia completo" },
                    { new Guid("0d4fbdbc-6d67-4855-ac68-4a4a47c76bb4"), new Guid("d3d23037-7ae3-4005-8cc2-235acaaf0f54"), "Clases de Ballet" },
                    { new Guid("4dfd6ae0-f00d-46b2-a567-2f5c94de134b"), new Guid("66bca942-7b3b-4f3e-831c-b7863268030d"), "Clases de logica" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "Comment", "EnrollDay", "KidId" },
                values: new object[,]
                {
                    { new Guid("fbdafe7a-d595-42eb-8955-ab80811e8d1e"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("012202b9-61ee-494e-9099-ba6bce67aac6") },
                    { new Guid("48208912-5cd1-4e19-9309-fc7d74bb198a"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0146bf6c-39fa-4e3a-9e9c-2c861384b4a0") },
                    { new Guid("d1081690-b33d-48ed-b20b-d60fb8cadbe5"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0329e38b-c48c-48d0-9994-295db8ede606") },
                    { new Guid("64d6cd49-3369-4885-b6b3-09782b60a3ff"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("032fddb7-a66a-44f5-8b72-d89263bd306a") },
                    { new Guid("540c8f37-5ab4-4a16-9fae-fbcb6318459d"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("04af1463-3174-4cae-b3c8-f6f85005d269") }
                });

            migrationBuilder.InsertData(
                table: "EnrollActivity",
                columns: new[] { "Id", "ActivityId", "EnrollmentId" },
                values: new object[,]
                {
                    { new Guid("94885b1f-c5c5-4561-90af-d8645be3a327"), new Guid("b189d9df-946e-4315-bf6f-986ca1c36e69"), new Guid("fbdafe7a-d595-42eb-8955-ab80811e8d1e") },
                    { new Guid("af6f77f3-0dc0-4af1-99b3-71257d540a59"), new Guid("b189d9df-946e-4315-bf6f-986ca1c36e69"), new Guid("48208912-5cd1-4e19-9309-fc7d74bb198a") },
                    { new Guid("6983dd07-3165-4e10-9a95-cf06599e3834"), new Guid("b189d9df-946e-4315-bf6f-986ca1c36e69"), new Guid("d1081690-b33d-48ed-b20b-d60fb8cadbe5") },
                    { new Guid("b97f035a-f6b2-4290-ae14-e4fa0dfc278d"), new Guid("b189d9df-946e-4315-bf6f-986ca1c36e69"), new Guid("64d6cd49-3369-4885-b6b3-09782b60a3ff") },
                    { new Guid("26506b0c-9308-49b9-925d-d007a47154e0"), new Guid("f0d3d0fc-a7eb-4772-9e4f-725d167014fe"), new Guid("540c8f37-5ab4-4a16-9fae-fbcb6318459d") }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Price", "Reference", "ActivityId", "Description", "ServicePeriod" },
                values: new object[,]
                {
                    { new Guid("832baabe-ead6-41fd-b790-24719b6b6962"), "Service", 1758m, "SRV-840", new Guid("f0d3d0fc-a7eb-4772-9e4f-725d167014fe"), "Service Clases de ingles", 77 },
                    { new Guid("0633c3f6-3a8e-4765-bfe6-3b59799c9b4d"), "Service", 7692m, "SRV-851", new Guid("bb6ec32c-bc6d-4286-a631-0b641cdea782"), "Service Cuidade matutino", 77 },
                    { new Guid("704c6e7a-c8de-447a-bf58-e708cc79ea45"), "Service", 3734m, "SRV-615", new Guid("b189d9df-946e-4315-bf6f-986ca1c36e69"), "Service Cuidado Vespertino", 77 },
                    { new Guid("ae20cfaf-2f2c-4c42-a84d-48b7053e014d"), "Service", 8703m, "SRV-491", new Guid("dec6a963-9e08-4373-9238-91713b80a7b6"), "Service Cuidado dia completo", 77 },
                    { new Guid("a7598aff-7340-457e-8ac8-867501dd24b0"), "Service", 1116m, "SRV-942", new Guid("0d4fbdbc-6d67-4855-ac68-4a4a47c76bb4"), "Service Clases de Ballet", 77 },
                    { new Guid("6e05a1d7-5a3d-458c-a748-2300e4cfa880"), "Service", 890m, "SRV-941", new Guid("4dfd6ae0-f00d-46b2-a567-2f5c94de134b"), "Service Clases de logica", 77 }
                });
        }
    }
}
