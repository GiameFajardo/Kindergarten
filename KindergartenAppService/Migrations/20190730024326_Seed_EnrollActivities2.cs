using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Seed_EnrollActivities2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("558f2e57-ca8e-4a48-b825-78aece4236d3"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("8bd105f9-7d43-42eb-8e54-74f2ef4b4d8c"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("d4184ebd-5ef3-4618-8ab1-666083da6ee4"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("df2069b5-c043-4789-9fc8-92af70c62210"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("f60b31db-e846-4426-9722-e65f1260106e"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("0dc66912-c3db-4c55-80fe-66588234b5c4"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("6a79be14-0688-467c-984e-7eb4ec095307"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("a384a48d-258e-45e6-a185-4ff2ee66a62c"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("a6889965-3f9e-483a-a562-48da43f42b67"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("aa59b855-1fe9-4c83-83b3-c79c51ebc48e"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("d5c6015d-2cff-4d8a-b2fa-bee8d29ca855"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0517cdb0-2c15-4d89-aab3-ade3fb985b66"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("072850cf-067f-4cc3-ba4b-3cedc5a2b7b7"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("080e1706-4b26-4ab8-a2db-552c1d6753e4"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0a9e667c-6ab8-462a-83f3-0c3117186cea"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0b747182-2f12-47cc-b86c-cce59c41a915"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("bafe44c4-2fff-4bf7-925a-685d041b93ed"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("2e45600c-66f6-4bc2-ab64-456e88c77a74"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("3813895e-4a64-44de-bb53-e3eb1bc87d19"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("947dc684-0dc2-49aa-a418-ae792a577e8b"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("959fa775-964c-4278-b9ce-2070a1064bbd"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("cb041400-ba9c-4ad2-b2c2-d0bd28a45609"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("f452209d-b588-4921-8801-bd72885f6771"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("0ed17062-bf53-4b60-a43b-e4aa7a8cb868"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("22fb6cc6-fed5-4a92-a67c-530dd719f7b8"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("62336d51-b603-4b71-85b5-1ecbe21ffb40"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("776f68f9-794e-4c89-bd14-81bf7cadb551"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("f27f22ea-29a1-4798-ad16-72f6842923a2"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("015a153f-3731-49a8-bc13-7a18e7d7e58c"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("2ebfae27-2b87-4de9-a6d3-62c0d4ee3441"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("36b53fde-e7d6-4922-8cab-81011ffff6d5"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("5e9a56eb-1ca9-4fe7-97a9-00da731b2f0e"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("917501a4-1371-4cd8-90f4-1d3c70d8fd2e"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("c3d3a5aa-7deb-4932-9610-c21e3abeb1eb"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("01e44d8c-00f5-49d7-b144-3d4a1bf16a7e"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("01ea6a08-191e-4ca5-a8cd-f96d02d8f94a"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0243ac54-57ac-46ea-b6c8-e367bb63f15a"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("02e7411a-02e4-4d25-8bef-a40a679a9d4a"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("042de502-a5bf-4163-9b0e-cc216b25b555"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("99ef7750-b1db-4c8d-9635-e44d26a5b539"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("d2f5687e-d23f-49f4-a84d-570e9f87d7ab"));

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("fcba11e2-6214-49c3-acf9-0440b7860b1d"), "KPH" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("92ab4f1a-2d77-45e2-81e5-2484c1822937"), null, "Gregorio de Jesus", "Rojas Acosta", null, null, null });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("38e2c50f-85a6-4389-84f2-faf2d44f6fc4"), null, "Yadira", "Pinales Delgado", null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityTemplate",
                columns: new[] { "Id", "Description", "KindergarterId" },
                values: new object[,]
                {
                    { new Guid("2c185253-07e4-4b67-8ea7-68c120165d1e"), "Clases de ingles", new Guid("fcba11e2-6214-49c3-acf9-0440b7860b1d") },
                    { new Guid("f5904279-0e34-4203-a421-7826723d7bcd"), "Cuidade matutino", new Guid("fcba11e2-6214-49c3-acf9-0440b7860b1d") },
                    { new Guid("e23f8c2b-0f11-405d-a3a8-736e7b9e70f8"), "Cuidado Vespertino", new Guid("fcba11e2-6214-49c3-acf9-0440b7860b1d") },
                    { new Guid("73a319c1-4f22-48b8-88c0-c7380101d2bd"), "Cuidado dia completo", new Guid("fcba11e2-6214-49c3-acf9-0440b7860b1d") },
                    { new Guid("3d68df41-9e8f-4bf3-ad70-9463ba8e4b47"), "Clases de Ballet", new Guid("fcba11e2-6214-49c3-acf9-0440b7860b1d") },
                    { new Guid("f6b42990-5c24-4a34-a83c-47ddab5ecaab"), "Clases de logica", new Guid("fcba11e2-6214-49c3-acf9-0440b7860b1d") }
                });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "FatherName", "FirstName", "KindergarterId", "MotherName", "SecondName", "TutorId" },
                values: new object[,]
                {
                    { new Guid("009767eb-8dee-4bae-b1e3-c66e748d2f17"), "Escobar", "Johan", new Guid("fcba11e2-6214-49c3-acf9-0440b7860b1d"), "White", "Enrique", new Guid("92ab4f1a-2d77-45e2-81e5-2484c1822937") },
                    { new Guid("00f813af-3599-4607-9d37-d86f3d843131"), "Lee", "Aaron", new Guid("fcba11e2-6214-49c3-acf9-0440b7860b1d"), "Snow", "Eduardo", new Guid("92ab4f1a-2d77-45e2-81e5-2484c1822937") },
                    { new Guid("017fdc4c-dcc7-4b2a-be40-a1e79651c219"), "Faringtom", "Aaron", new Guid("fcba11e2-6214-49c3-acf9-0440b7860b1d"), "Washinton", "Carlos", new Guid("92ab4f1a-2d77-45e2-81e5-2484c1822937") },
                    { new Guid("02082e23-902f-4752-bb85-9e8c3d411e71"), "Stackeetam", "Aaron", new Guid("fcba11e2-6214-49c3-acf9-0440b7860b1d"), "Snow", "Enrique", new Guid("92ab4f1a-2d77-45e2-81e5-2484c1822937") },
                    { new Guid("02dfa196-6800-4fd3-a7fd-c457cc49e903"), "Lee", "Johan", new Guid("fcba11e2-6214-49c3-acf9-0440b7860b1d"), "Snow", "Carlos", new Guid("92ab4f1a-2d77-45e2-81e5-2484c1822937") },
                    { new Guid("02f1f338-42ac-4981-9ebe-d8a3a7d9086d"), "Escobar", "Johan", new Guid("fcba11e2-6214-49c3-acf9-0440b7860b1d"), "Snow", "Eduardo", new Guid("92ab4f1a-2d77-45e2-81e5-2484c1822937") },
                    { new Guid("049ffa96-ccbc-4c1e-9f2c-7c1ba3c21079"), "Stackeetam", "Dylan", new Guid("fcba11e2-6214-49c3-acf9-0440b7860b1d"), "Snow", "Enrique", new Guid("92ab4f1a-2d77-45e2-81e5-2484c1822937") },
                    { new Guid("04db3ddf-ef67-4da7-be26-72e7ff4d4b10"), "Faringtom", "Dylan", new Guid("fcba11e2-6214-49c3-acf9-0440b7860b1d"), "Washinton", "Carlos", new Guid("92ab4f1a-2d77-45e2-81e5-2484c1822937") },
                    { new Guid("05765a28-4a48-4835-86a4-b42bb638a42f"), "Faringtom", "Aaron", new Guid("fcba11e2-6214-49c3-acf9-0440b7860b1d"), "Worm", "Carlos", new Guid("92ab4f1a-2d77-45e2-81e5-2484c1822937") },
                    { new Guid("058d1c8e-481a-46da-8879-72a9132b09c0"), "Escobar", "Aaron", new Guid("fcba11e2-6214-49c3-acf9-0440b7860b1d"), "White", "Eduardo", new Guid("92ab4f1a-2d77-45e2-81e5-2484c1822937") }
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "Id", "ActivityTemplateId", "Description" },
                values: new object[,]
                {
                    { new Guid("740385de-3583-4861-92b0-4920e2bf0b8b"), new Guid("2c185253-07e4-4b67-8ea7-68c120165d1e"), "Clases de ingles" },
                    { new Guid("67ff4ae2-14ef-4579-abcb-5ebd3ff03564"), new Guid("f5904279-0e34-4203-a421-7826723d7bcd"), "Cuidade matutino" },
                    { new Guid("780a2f5b-f20f-47f8-8b99-95bd0ef78ba6"), new Guid("e23f8c2b-0f11-405d-a3a8-736e7b9e70f8"), "Cuidado Vespertino" },
                    { new Guid("a0975dcd-013a-4011-be7e-c835605fbe2f"), new Guid("73a319c1-4f22-48b8-88c0-c7380101d2bd"), "Cuidado dia completo" },
                    { new Guid("e92ea0b6-2f8b-49a3-8e57-a9449221991c"), new Guid("3d68df41-9e8f-4bf3-ad70-9463ba8e4b47"), "Clases de Ballet" },
                    { new Guid("1255ca99-0286-45b7-8131-0c9809d486cc"), new Guid("f6b42990-5c24-4a34-a83c-47ddab5ecaab"), "Clases de logica" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "Comment", "EnrollDay", "KidId" },
                values: new object[,]
                {
                    { new Guid("8aba2ecb-f2c6-45d0-b4ff-046655fcb66b"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("009767eb-8dee-4bae-b1e3-c66e748d2f17") },
                    { new Guid("f3716c08-e9f4-44a3-8e77-e69dc0a48f64"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00f813af-3599-4607-9d37-d86f3d843131") },
                    { new Guid("8dc70026-8315-4c19-8330-e869bc58200f"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("017fdc4c-dcc7-4b2a-be40-a1e79651c219") },
                    { new Guid("122e3dd0-e5b0-45d8-bd07-773727cc1159"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("02082e23-902f-4752-bb85-9e8c3d411e71") },
                    { new Guid("946241c5-b152-4578-996c-6770904bebb1"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("02dfa196-6800-4fd3-a7fd-c457cc49e903") }
                });

            migrationBuilder.InsertData(
                table: "EnrollActivity",
                columns: new[] { "Id", "ActivityId", "EnrollmentId" },
                values: new object[,]
                {
                    { new Guid("311fe313-69a9-4fb4-9dce-afd047f007f8"), new Guid("67ff4ae2-14ef-4579-abcb-5ebd3ff03564"), new Guid("8aba2ecb-f2c6-45d0-b4ff-046655fcb66b") },
                    { new Guid("a8f3286f-6dd0-4fcd-8d56-6e1734907a5d"), new Guid("a0975dcd-013a-4011-be7e-c835605fbe2f"), new Guid("f3716c08-e9f4-44a3-8e77-e69dc0a48f64") },
                    { new Guid("40d2a86f-f552-4f83-8930-bcfbdb34037f"), new Guid("740385de-3583-4861-92b0-4920e2bf0b8b"), new Guid("8dc70026-8315-4c19-8330-e869bc58200f") },
                    { new Guid("ff62299d-9468-43c7-9fca-36901103f674"), new Guid("e92ea0b6-2f8b-49a3-8e57-a9449221991c"), new Guid("122e3dd0-e5b0-45d8-bd07-773727cc1159") },
                    { new Guid("80b45bc0-f81e-49bd-911d-8cd02a85b67e"), new Guid("a0975dcd-013a-4011-be7e-c835605fbe2f"), new Guid("946241c5-b152-4578-996c-6770904bebb1") }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Price", "Reference", "ActivityId", "Description", "ServicePeriod" },
                values: new object[,]
                {
                    { new Guid("ad54e781-a041-4b66-aef7-620674830f07"), "Service", 5377m, "SRV-907", new Guid("740385de-3583-4861-92b0-4920e2bf0b8b"), "Service Clases de ingles", 77 },
                    { new Guid("1274c751-e505-4ce9-afaf-58b93fc1a163"), "Service", 9377m, "SRV-386", new Guid("67ff4ae2-14ef-4579-abcb-5ebd3ff03564"), "Service Cuidade matutino", 77 },
                    { new Guid("36b091b9-a0c1-4dc0-a86f-43fceaecafc2"), "Service", 8049m, "SRV-979", new Guid("780a2f5b-f20f-47f8-8b99-95bd0ef78ba6"), "Service Cuidado Vespertino", 77 },
                    { new Guid("3d38774e-1aad-42b5-982a-62e5a68226c6"), "Service", 7094m, "SRV-545", new Guid("a0975dcd-013a-4011-be7e-c835605fbe2f"), "Service Cuidado dia completo", 77 },
                    { new Guid("7c84ef8d-e8d1-4c0c-982e-b477acd01441"), "Service", 4397m, "SRV-232", new Guid("e92ea0b6-2f8b-49a3-8e57-a9449221991c"), "Service Clases de Ballet", 77 },
                    { new Guid("7530f576-cffa-4cbb-81f8-bde60c7dfec0"), "Service", 3211m, "SRV-584", new Guid("1255ca99-0286-45b7-8131-0c9809d486cc"), "Service Clases de logica", 77 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("311fe313-69a9-4fb4-9dce-afd047f007f8"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("40d2a86f-f552-4f83-8930-bcfbdb34037f"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("80b45bc0-f81e-49bd-911d-8cd02a85b67e"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("a8f3286f-6dd0-4fcd-8d56-6e1734907a5d"));

            migrationBuilder.DeleteData(
                table: "EnrollActivity",
                keyColumn: "Id",
                keyValue: new Guid("ff62299d-9468-43c7-9fca-36901103f674"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("1274c751-e505-4ce9-afaf-58b93fc1a163"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("36b091b9-a0c1-4dc0-a86f-43fceaecafc2"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("3d38774e-1aad-42b5-982a-62e5a68226c6"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("7530f576-cffa-4cbb-81f8-bde60c7dfec0"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("7c84ef8d-e8d1-4c0c-982e-b477acd01441"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("ad54e781-a041-4b66-aef7-620674830f07"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("02f1f338-42ac-4981-9ebe-d8a3a7d9086d"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("049ffa96-ccbc-4c1e-9f2c-7c1ba3c21079"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("04db3ddf-ef67-4da7-be26-72e7ff4d4b10"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("05765a28-4a48-4835-86a4-b42bb638a42f"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("058d1c8e-481a-46da-8879-72a9132b09c0"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("38e2c50f-85a6-4389-84f2-faf2d44f6fc4"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("1255ca99-0286-45b7-8131-0c9809d486cc"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("67ff4ae2-14ef-4579-abcb-5ebd3ff03564"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("740385de-3583-4861-92b0-4920e2bf0b8b"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("780a2f5b-f20f-47f8-8b99-95bd0ef78ba6"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("a0975dcd-013a-4011-be7e-c835605fbe2f"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("e92ea0b6-2f8b-49a3-8e57-a9449221991c"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("122e3dd0-e5b0-45d8-bd07-773727cc1159"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("8aba2ecb-f2c6-45d0-b4ff-046655fcb66b"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("8dc70026-8315-4c19-8330-e869bc58200f"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("946241c5-b152-4578-996c-6770904bebb1"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("f3716c08-e9f4-44a3-8e77-e69dc0a48f64"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("2c185253-07e4-4b67-8ea7-68c120165d1e"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("3d68df41-9e8f-4bf3-ad70-9463ba8e4b47"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("73a319c1-4f22-48b8-88c0-c7380101d2bd"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("e23f8c2b-0f11-405d-a3a8-736e7b9e70f8"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("f5904279-0e34-4203-a421-7826723d7bcd"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("f6b42990-5c24-4a34-a83c-47ddab5ecaab"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("009767eb-8dee-4bae-b1e3-c66e748d2f17"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("00f813af-3599-4607-9d37-d86f3d843131"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("017fdc4c-dcc7-4b2a-be40-a1e79651c219"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("02082e23-902f-4752-bb85-9e8c3d411e71"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("02dfa196-6800-4fd3-a7fd-c457cc49e903"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("fcba11e2-6214-49c3-acf9-0440b7860b1d"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("92ab4f1a-2d77-45e2-81e5-2484c1822937"));

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("99ef7750-b1db-4c8d-9635-e44d26a5b539"), "KPH" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("d2f5687e-d23f-49f4-a84d-570e9f87d7ab"), null, "Gregorio de Jesus", "Rojas Acosta", null, null, null });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("bafe44c4-2fff-4bf7-925a-685d041b93ed"), null, "Yadira", "Pinales Delgado", null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityTemplate",
                columns: new[] { "Id", "Description", "KindergarterId" },
                values: new object[,]
                {
                    { new Guid("917501a4-1371-4cd8-90f4-1d3c70d8fd2e"), "Clases de ingles", new Guid("99ef7750-b1db-4c8d-9635-e44d26a5b539") },
                    { new Guid("c3d3a5aa-7deb-4932-9610-c21e3abeb1eb"), "Cuidade matutino", new Guid("99ef7750-b1db-4c8d-9635-e44d26a5b539") },
                    { new Guid("5e9a56eb-1ca9-4fe7-97a9-00da731b2f0e"), "Cuidado Vespertino", new Guid("99ef7750-b1db-4c8d-9635-e44d26a5b539") },
                    { new Guid("015a153f-3731-49a8-bc13-7a18e7d7e58c"), "Cuidado dia completo", new Guid("99ef7750-b1db-4c8d-9635-e44d26a5b539") },
                    { new Guid("36b53fde-e7d6-4922-8cab-81011ffff6d5"), "Clases de Ballet", new Guid("99ef7750-b1db-4c8d-9635-e44d26a5b539") },
                    { new Guid("2ebfae27-2b87-4de9-a6d3-62c0d4ee3441"), "Clases de logica", new Guid("99ef7750-b1db-4c8d-9635-e44d26a5b539") }
                });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "FatherName", "FirstName", "KindergarterId", "MotherName", "SecondName", "TutorId" },
                values: new object[,]
                {
                    { new Guid("01e44d8c-00f5-49d7-b144-3d4a1bf16a7e"), "Stackeetam", "Lyan", new Guid("99ef7750-b1db-4c8d-9635-e44d26a5b539"), "Snow", "Eduardo", new Guid("d2f5687e-d23f-49f4-a84d-570e9f87d7ab") },
                    { new Guid("01ea6a08-191e-4ca5-a8cd-f96d02d8f94a"), "Escobar", "Johan", new Guid("99ef7750-b1db-4c8d-9635-e44d26a5b539"), "Snow", "Emilio", new Guid("d2f5687e-d23f-49f4-a84d-570e9f87d7ab") },
                    { new Guid("0243ac54-57ac-46ea-b6c8-e367bb63f15a"), "Lee", "Lyan", new Guid("99ef7750-b1db-4c8d-9635-e44d26a5b539"), "Worm", "Carlos", new Guid("d2f5687e-d23f-49f4-a84d-570e9f87d7ab") },
                    { new Guid("02e7411a-02e4-4d25-8bef-a40a679a9d4a"), "Faringtom", "Dylan", new Guid("99ef7750-b1db-4c8d-9635-e44d26a5b539"), "Washinton", "Carlos", new Guid("d2f5687e-d23f-49f4-a84d-570e9f87d7ab") },
                    { new Guid("042de502-a5bf-4163-9b0e-cc216b25b555"), "Lee", "Johan", new Guid("99ef7750-b1db-4c8d-9635-e44d26a5b539"), "Washinton", "Carlos", new Guid("d2f5687e-d23f-49f4-a84d-570e9f87d7ab") },
                    { new Guid("0517cdb0-2c15-4d89-aab3-ade3fb985b66"), "Faringtom", "Lyan", new Guid("99ef7750-b1db-4c8d-9635-e44d26a5b539"), "Snow", "Eduardo", new Guid("d2f5687e-d23f-49f4-a84d-570e9f87d7ab") },
                    { new Guid("072850cf-067f-4cc3-ba4b-3cedc5a2b7b7"), "Escobar", "Johan", new Guid("99ef7750-b1db-4c8d-9635-e44d26a5b539"), "White", "Emilio", new Guid("d2f5687e-d23f-49f4-a84d-570e9f87d7ab") },
                    { new Guid("080e1706-4b26-4ab8-a2db-552c1d6753e4"), "Faringtom", "Johan", new Guid("99ef7750-b1db-4c8d-9635-e44d26a5b539"), "Worm", "Carlos", new Guid("d2f5687e-d23f-49f4-a84d-570e9f87d7ab") },
                    { new Guid("0a9e667c-6ab8-462a-83f3-0c3117186cea"), "Lee", "Lyan", new Guid("99ef7750-b1db-4c8d-9635-e44d26a5b539"), "White", "Emilio", new Guid("d2f5687e-d23f-49f4-a84d-570e9f87d7ab") },
                    { new Guid("0b747182-2f12-47cc-b86c-cce59c41a915"), "Escobar", "Dylan", new Guid("99ef7750-b1db-4c8d-9635-e44d26a5b539"), "Worm", "Carlos", new Guid("d2f5687e-d23f-49f4-a84d-570e9f87d7ab") }
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "Id", "ActivityTemplateId", "Description" },
                values: new object[,]
                {
                    { new Guid("959fa775-964c-4278-b9ce-2070a1064bbd"), new Guid("917501a4-1371-4cd8-90f4-1d3c70d8fd2e"), "Clases de ingles" },
                    { new Guid("3813895e-4a64-44de-bb53-e3eb1bc87d19"), new Guid("c3d3a5aa-7deb-4932-9610-c21e3abeb1eb"), "Cuidade matutino" },
                    { new Guid("947dc684-0dc2-49aa-a418-ae792a577e8b"), new Guid("5e9a56eb-1ca9-4fe7-97a9-00da731b2f0e"), "Cuidado Vespertino" },
                    { new Guid("2e45600c-66f6-4bc2-ab64-456e88c77a74"), new Guid("015a153f-3731-49a8-bc13-7a18e7d7e58c"), "Cuidado dia completo" },
                    { new Guid("cb041400-ba9c-4ad2-b2c2-d0bd28a45609"), new Guid("36b53fde-e7d6-4922-8cab-81011ffff6d5"), "Clases de Ballet" },
                    { new Guid("f452209d-b588-4921-8801-bd72885f6771"), new Guid("2ebfae27-2b87-4de9-a6d3-62c0d4ee3441"), "Clases de logica" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "Comment", "EnrollDay", "KidId" },
                values: new object[,]
                {
                    { new Guid("f27f22ea-29a1-4798-ad16-72f6842923a2"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("01e44d8c-00f5-49d7-b144-3d4a1bf16a7e") },
                    { new Guid("0ed17062-bf53-4b60-a43b-e4aa7a8cb868"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("01ea6a08-191e-4ca5-a8cd-f96d02d8f94a") },
                    { new Guid("62336d51-b603-4b71-85b5-1ecbe21ffb40"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0243ac54-57ac-46ea-b6c8-e367bb63f15a") },
                    { new Guid("776f68f9-794e-4c89-bd14-81bf7cadb551"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("02e7411a-02e4-4d25-8bef-a40a679a9d4a") },
                    { new Guid("22fb6cc6-fed5-4a92-a67c-530dd719f7b8"), null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("042de502-a5bf-4163-9b0e-cc216b25b555") }
                });

            migrationBuilder.InsertData(
                table: "EnrollActivity",
                columns: new[] { "Id", "ActivityId", "EnrollmentId" },
                values: new object[,]
                {
                    { new Guid("558f2e57-ca8e-4a48-b825-78aece4236d3"), new Guid("959fa775-964c-4278-b9ce-2070a1064bbd"), new Guid("f27f22ea-29a1-4798-ad16-72f6842923a2") },
                    { new Guid("f60b31db-e846-4426-9722-e65f1260106e"), new Guid("3813895e-4a64-44de-bb53-e3eb1bc87d19"), new Guid("0ed17062-bf53-4b60-a43b-e4aa7a8cb868") },
                    { new Guid("df2069b5-c043-4789-9fc8-92af70c62210"), new Guid("947dc684-0dc2-49aa-a418-ae792a577e8b"), new Guid("62336d51-b603-4b71-85b5-1ecbe21ffb40") },
                    { new Guid("d4184ebd-5ef3-4618-8ab1-666083da6ee4"), new Guid("cb041400-ba9c-4ad2-b2c2-d0bd28a45609"), new Guid("776f68f9-794e-4c89-bd14-81bf7cadb551") },
                    { new Guid("8bd105f9-7d43-42eb-8e54-74f2ef4b4d8c"), new Guid("3813895e-4a64-44de-bb53-e3eb1bc87d19"), new Guid("22fb6cc6-fed5-4a92-a67c-530dd719f7b8") }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Price", "Reference", "ActivityId", "Description", "ServicePeriod" },
                values: new object[,]
                {
                    { new Guid("a6889965-3f9e-483a-a562-48da43f42b67"), "Service", 8154m, "SRV-842", new Guid("959fa775-964c-4278-b9ce-2070a1064bbd"), "Service Clases de ingles", 77 },
                    { new Guid("a384a48d-258e-45e6-a185-4ff2ee66a62c"), "Service", 6326m, "SRV-248", new Guid("3813895e-4a64-44de-bb53-e3eb1bc87d19"), "Service Cuidade matutino", 77 },
                    { new Guid("d5c6015d-2cff-4d8a-b2fa-bee8d29ca855"), "Service", 5483m, "SRV-710", new Guid("947dc684-0dc2-49aa-a418-ae792a577e8b"), "Service Cuidado Vespertino", 77 },
                    { new Guid("0dc66912-c3db-4c55-80fe-66588234b5c4"), "Service", 3825m, "SRV-534", new Guid("2e45600c-66f6-4bc2-ab64-456e88c77a74"), "Service Cuidado dia completo", 77 },
                    { new Guid("aa59b855-1fe9-4c83-83b3-c79c51ebc48e"), "Service", 1032m, "SRV-799", new Guid("cb041400-ba9c-4ad2-b2c2-d0bd28a45609"), "Service Clases de Ballet", 77 },
                    { new Guid("6a79be14-0688-467c-984e-7eb4ec095307"), "Service", 2832m, "SRV-310", new Guid("f452209d-b588-4921-8801-bd72885f6771"), "Service Clases de logica", 77 }
                });
        }
    }
}
