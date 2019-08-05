using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Adding_Sex_to_Kid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Sex",
                table: "Kid",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("64bb4973-6892-426f-a93e-179db3f18059"), "KPH" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("fecaefa5-5e6c-4000-8dc8-ad461dc9073e"), null, "Gregorio de Jesus", "Rojas Acosta", null, null, null });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("e267df5a-32ed-42d9-9715-901fe9e0ba19"), null, "Yadira", "Pinales Delgado", null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityTemplate",
                columns: new[] { "Id", "Description", "KindergarterId" },
                values: new object[,]
                {
                    { new Guid("c3a3c2c1-66a8-4516-97d3-48b56cecdf8e"), "Clases de ingles", new Guid("64bb4973-6892-426f-a93e-179db3f18059") },
                    { new Guid("96842ae8-5ad4-4b76-8751-077977e221a6"), "Cuidade matutino", new Guid("64bb4973-6892-426f-a93e-179db3f18059") },
                    { new Guid("7ad872f9-6889-40be-b7cf-a958d6aaf499"), "Cuidado Vespertino", new Guid("64bb4973-6892-426f-a93e-179db3f18059") },
                    { new Guid("d9386be6-94a7-4d18-af0a-6cb323a00cac"), "Cuidado dia completo", new Guid("64bb4973-6892-426f-a93e-179db3f18059") },
                    { new Guid("9da7ae7c-68a7-4a7b-9502-dfddeeec888e"), "Clases de Ballet", new Guid("64bb4973-6892-426f-a93e-179db3f18059") },
                    { new Guid("7fdd0071-cdd8-47aa-92aa-2f26c9758459"), "Clases de logica", new Guid("64bb4973-6892-426f-a93e-179db3f18059") }
                });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "Address", "BirthDate", "Diseases", "FatherName", "FavoriteActivities", "FirstName", "KindergarterId", "MotherName", "SecondName", "Sex", "SiblingCount", "TutorId" },
                values: new object[,]
                {
                    { new Guid("002ec496-09da-46c7-a12e-30d59604d747"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lee", null, "Lyan", new Guid("64bb4973-6892-426f-a93e-179db3f18059"), "Washinton", "Emilio", 0, 0, new Guid("fecaefa5-5e6c-4000-8dc8-ad461dc9073e") },
                    { new Guid("004db9f2-af05-43e6-9c6b-0ffb269871d7"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Faringtom", null, "Lyan", new Guid("64bb4973-6892-426f-a93e-179db3f18059"), "Washinton", "Emilio", 0, 0, new Guid("fecaefa5-5e6c-4000-8dc8-ad461dc9073e") },
                    { new Guid("01d8b9d2-fb79-4cd0-9126-c53758e079aa"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Escobar", null, "Dylan", new Guid("64bb4973-6892-426f-a93e-179db3f18059"), "Snow", "Carlos", 0, 0, new Guid("fecaefa5-5e6c-4000-8dc8-ad461dc9073e") },
                    { new Guid("02c9237a-393d-4d3a-ad94-53ed36409244"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Stackeetam", null, "Lyan", new Guid("64bb4973-6892-426f-a93e-179db3f18059"), "Worm", "Carlos", 0, 0, new Guid("fecaefa5-5e6c-4000-8dc8-ad461dc9073e") },
                    { new Guid("0475b56f-1ab3-4cae-a689-44ee43dc281d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Faringtom", null, "Lyan", new Guid("64bb4973-6892-426f-a93e-179db3f18059"), "Washinton", "Eduardo", 0, 0, new Guid("fecaefa5-5e6c-4000-8dc8-ad461dc9073e") },
                    { new Guid("05566409-768f-4cab-a7d2-0c0b96b8de16"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Escobar", null, "Johan", new Guid("64bb4973-6892-426f-a93e-179db3f18059"), "White", "Eduardo", 0, 0, new Guid("fecaefa5-5e6c-4000-8dc8-ad461dc9073e") },
                    { new Guid("072c04dd-99fd-4e6e-a0ca-98d707aeca8a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Escobar", null, "Dylan", new Guid("64bb4973-6892-426f-a93e-179db3f18059"), "Snow", "Emilio", 0, 0, new Guid("fecaefa5-5e6c-4000-8dc8-ad461dc9073e") },
                    { new Guid("09009f6e-be57-4a3a-bf8c-9f5f3c707a62"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Faringtom", null, "Johan", new Guid("64bb4973-6892-426f-a93e-179db3f18059"), "Snow", "Eduardo", 0, 0, new Guid("fecaefa5-5e6c-4000-8dc8-ad461dc9073e") },
                    { new Guid("0a01848f-b5a4-4a23-ab1f-78d183b2873a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lee", null, "Lyan", new Guid("64bb4973-6892-426f-a93e-179db3f18059"), "Washinton", "Eduardo", 0, 0, new Guid("fecaefa5-5e6c-4000-8dc8-ad461dc9073e") },
                    { new Guid("0ce3bd10-9733-45a7-aa88-7d55462ec8c6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Faringtom", null, "Lyan", new Guid("64bb4973-6892-426f-a93e-179db3f18059"), "Snow", "Carlos", 0, 0, new Guid("fecaefa5-5e6c-4000-8dc8-ad461dc9073e") }
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "Id", "ActivityTemplateId", "Description" },
                values: new object[,]
                {
                    { new Guid("02852eea-cd8c-4e42-9e46-691dc19585a2"), new Guid("c3a3c2c1-66a8-4516-97d3-48b56cecdf8e"), "Clases de ingles" },
                    { new Guid("747f6fd4-4b68-439a-bc41-9eb6f1bd55f1"), new Guid("96842ae8-5ad4-4b76-8751-077977e221a6"), "Cuidade matutino" },
                    { new Guid("08a44ae6-3ffc-4805-94e2-05d88cd3d994"), new Guid("7ad872f9-6889-40be-b7cf-a958d6aaf499"), "Cuidado Vespertino" },
                    { new Guid("90e50ba1-980d-4340-87f4-44ae63850dc8"), new Guid("d9386be6-94a7-4d18-af0a-6cb323a00cac"), "Cuidado dia completo" },
                    { new Guid("14e4dc48-010d-49ec-a73d-6cac772968d1"), new Guid("9da7ae7c-68a7-4a7b-9502-dfddeeec888e"), "Clases de Ballet" },
                    { new Guid("691ee267-6ebe-40b3-b70a-433ffbe2cc78"), new Guid("7fdd0071-cdd8-47aa-92aa-2f26c9758459"), "Clases de logica" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "Comment", "EnrollDay", "KidId" },
                values: new object[,]
                {
                    { new Guid("a1610565-617a-4274-9833-746b485cab50"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("002ec496-09da-46c7-a12e-30d59604d747") },
                    { new Guid("7ac1d474-fcee-4187-a00b-036e621dd2d1"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("004db9f2-af05-43e6-9c6b-0ffb269871d7") },
                    { new Guid("06c096cc-49ec-4303-9d39-df6de5bd3838"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("01d8b9d2-fb79-4cd0-9126-c53758e079aa") },
                    { new Guid("2cfe78c3-033d-47eb-b83d-647dd9ae8869"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("02c9237a-393d-4d3a-ad94-53ed36409244") },
                    { new Guid("3305dac8-1f34-49d1-abc9-77177198de32"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0475b56f-1ab3-4cae-a689-44ee43dc281d") }
                });

            migrationBuilder.InsertData(
                table: "EnrollActivity",
                columns: new[] { "Id", "ActivityId", "EnrollmentId" },
                values: new object[,]
                {
                    { new Guid("f856c279-3e08-4003-aa9a-6434976c6de8"), new Guid("14e4dc48-010d-49ec-a73d-6cac772968d1"), new Guid("a1610565-617a-4274-9833-746b485cab50") },
                    { new Guid("9cd9dca7-34f5-4959-a094-f03b4f011781"), new Guid("14e4dc48-010d-49ec-a73d-6cac772968d1"), new Guid("7ac1d474-fcee-4187-a00b-036e621dd2d1") },
                    { new Guid("65ce4479-c66f-411a-97e6-2b2e8f38e586"), new Guid("747f6fd4-4b68-439a-bc41-9eb6f1bd55f1"), new Guid("06c096cc-49ec-4303-9d39-df6de5bd3838") },
                    { new Guid("5c3a60e8-f930-4688-bca4-2fd62725f72b"), new Guid("747f6fd4-4b68-439a-bc41-9eb6f1bd55f1"), new Guid("2cfe78c3-033d-47eb-b83d-647dd9ae8869") },
                    { new Guid("d1f4b701-a2f4-481b-af2d-80d032135ec5"), new Guid("08a44ae6-3ffc-4805-94e2-05d88cd3d994"), new Guid("3305dac8-1f34-49d1-abc9-77177198de32") }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Price", "Reference", "ActivityId", "Description", "ServicePeriod" },
                values: new object[,]
                {
                    { new Guid("0f6169a6-4840-40f0-8b63-36c03547e495"), "Service", 5926m, "SRV-651", new Guid("02852eea-cd8c-4e42-9e46-691dc19585a2"), "Service Clases de ingles", 77 },
                    { new Guid("bcb278fc-7429-46b7-8b6e-70c5194da5a5"), "Service", 1856m, "SRV-99", new Guid("747f6fd4-4b68-439a-bc41-9eb6f1bd55f1"), "Service Cuidade matutino", 77 },
                    { new Guid("0f0578dc-87f0-4f51-a7ca-aa464a48b062"), "Service", 4527m, "SRV-853", new Guid("08a44ae6-3ffc-4805-94e2-05d88cd3d994"), "Service Cuidado Vespertino", 77 },
                    { new Guid("b7327fc9-84a3-4e96-ac73-617d8ebf48d9"), "Service", 7375m, "SRV-481", new Guid("90e50ba1-980d-4340-87f4-44ae63850dc8"), "Service Cuidado dia completo", 77 },
                    { new Guid("e1389f6e-4c54-4794-8d7a-716e285a82af"), "Service", 5052m, "SRV-115", new Guid("14e4dc48-010d-49ec-a73d-6cac772968d1"), "Service Clases de Ballet", 77 },
                    { new Guid("e4fa9e0e-71cb-472d-9cbe-bab6f8f7393b"), "Service", 7377m, "SRV-953", new Guid("691ee267-6ebe-40b3-b70a-433ffbe2cc78"), "Service Clases de logica", 77 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("5c3a60e8-f930-4688-bca4-2fd62725f72b"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("65ce4479-c66f-411a-97e6-2b2e8f38e586"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("9cd9dca7-34f5-4959-a094-f03b4f011781"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("d1f4b701-a2f4-481b-af2d-80d032135ec5"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("f856c279-3e08-4003-aa9a-6434976c6de8"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("0f0578dc-87f0-4f51-a7ca-aa464a48b062"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("0f6169a6-4840-40f0-8b63-36c03547e495"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("b7327fc9-84a3-4e96-ac73-617d8ebf48d9"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("bcb278fc-7429-46b7-8b6e-70c5194da5a5"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("e1389f6e-4c54-4794-8d7a-716e285a82af"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("e4fa9e0e-71cb-472d-9cbe-bab6f8f7393b"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("05566409-768f-4cab-a7d2-0c0b96b8de16"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("072c04dd-99fd-4e6e-a0ca-98d707aeca8a"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("09009f6e-be57-4a3a-bf8c-9f5f3c707a62"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0a01848f-b5a4-4a23-ab1f-78d183b2873a"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0ce3bd10-9733-45a7-aa88-7d55462ec8c6"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("e267df5a-32ed-42d9-9715-901fe9e0ba19"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("02852eea-cd8c-4e42-9e46-691dc19585a2"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("08a44ae6-3ffc-4805-94e2-05d88cd3d994"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("14e4dc48-010d-49ec-a73d-6cac772968d1"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("691ee267-6ebe-40b3-b70a-433ffbe2cc78"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("747f6fd4-4b68-439a-bc41-9eb6f1bd55f1"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("90e50ba1-980d-4340-87f4-44ae63850dc8"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("06c096cc-49ec-4303-9d39-df6de5bd3838"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("2cfe78c3-033d-47eb-b83d-647dd9ae8869"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("3305dac8-1f34-49d1-abc9-77177198de32"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("7ac1d474-fcee-4187-a00b-036e621dd2d1"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("a1610565-617a-4274-9833-746b485cab50"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("7ad872f9-6889-40be-b7cf-a958d6aaf499"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("7fdd0071-cdd8-47aa-92aa-2f26c9758459"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("96842ae8-5ad4-4b76-8751-077977e221a6"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("9da7ae7c-68a7-4a7b-9502-dfddeeec888e"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("c3a3c2c1-66a8-4516-97d3-48b56cecdf8e"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("d9386be6-94a7-4d18-af0a-6cb323a00cac"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("002ec496-09da-46c7-a12e-30d59604d747"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("004db9f2-af05-43e6-9c6b-0ffb269871d7"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("01d8b9d2-fb79-4cd0-9126-c53758e079aa"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("02c9237a-393d-4d3a-ad94-53ed36409244"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0475b56f-1ab3-4cae-a689-44ee43dc281d"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("64bb4973-6892-426f-a93e-179db3f18059"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("fecaefa5-5e6c-4000-8dc8-ad461dc9073e"));

            migrationBuilder.DropColumn(
                name: "Sex",
                table: "Kid");

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
    }
}
