using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Adding_TShirtSize_to_Kid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "TShirtSize",
                table: "Kid",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "TShirtSize",
                table: "Kid");

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
    }
}
