using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Adding_ServicePeriod_to_Service : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("462bc18f-3136-4751-9ea3-e30e580fbcfd"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("553a0c12-0a06-4f8c-961b-b9c3292cdebe"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("6eb1ae54-38ce-4735-88cd-8b2480b8d959"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("8dcac50d-6a28-4a7f-88d5-f76ce01d0529"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("c4bbeff6-581e-42cb-863e-c985accbe844"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("cb010801-bc46-4d75-a3da-f9a98aae009a"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("00d90097-053a-4235-b309-0e177d9ad80b"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("02460234-85ac-44a4-b8a8-82159381c297"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("02de298b-1c68-4b0c-b4c7-bd2692f72db9"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("032525ca-feed-4c0f-a39c-f5e70bc6ad2f"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0507c91b-c5d2-470a-acd4-0502448131fc"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("064e00c2-2e2e-4c5a-ae65-434fceda49dd"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("078a8b7d-985c-435b-967d-d249ad5aaf33"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("07e402e8-ac87-42cc-9468-85cda5cf3f85"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0a11fd30-e556-40a8-9a51-c5debc94e378"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0b2dd5c2-33bc-4bcd-be0a-ed693f99b398"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("d43278e6-2b6e-4d49-9b2e-ffb9a9db7b66"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("088bae7b-0dff-4c36-8aa5-06e0777dc4e9"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("0976b125-869c-4514-8398-0c685f42af1c"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("17f1044a-a62e-4d44-a0b4-6a83d15df146"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("47e8bfd9-2a90-40f5-880c-68ec886e293e"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("4d02ba95-2231-4b6b-8094-d5aae15fa41f"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("ed4f41ab-0a86-4d96-a977-6a7585b2c6b9"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("24841f2f-706a-4248-9bad-054093f2362f"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("7ddd6a6e-eb88-4cef-84a7-15229eb96bba"));

            migrationBuilder.AlterColumn<string>(
                name: "Reference",
                table: "Item",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServicePeriod",
                table: "Item",
                nullable: true);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "ServicePeriod",
                table: "Item");

            migrationBuilder.AlterColumn<string>(
                name: "Reference",
                table: "Item",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("7ddd6a6e-eb88-4cef-84a7-15229eb96bba"), "Guarderia" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("24841f2f-706a-4248-9bad-054093f2362f"), null, "Gregorio de Jesus", "Rojas Acosta", null, null, null });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("d43278e6-2b6e-4d49-9b2e-ffb9a9db7b66"), null, "Yadira", "Pinales Delgado", null, null, null });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "Id", "Description", "KindergarterId" },
                values: new object[,]
                {
                    { new Guid("4d02ba95-2231-4b6b-8094-d5aae15fa41f"), "Clases de ingles", new Guid("7ddd6a6e-eb88-4cef-84a7-15229eb96bba") },
                    { new Guid("ed4f41ab-0a86-4d96-a977-6a7585b2c6b9"), "Cuidade matutino", new Guid("7ddd6a6e-eb88-4cef-84a7-15229eb96bba") },
                    { new Guid("0976b125-869c-4514-8398-0c685f42af1c"), "Cuidado Vespertino", new Guid("7ddd6a6e-eb88-4cef-84a7-15229eb96bba") },
                    { new Guid("088bae7b-0dff-4c36-8aa5-06e0777dc4e9"), "Cuidado dia completo", new Guid("7ddd6a6e-eb88-4cef-84a7-15229eb96bba") },
                    { new Guid("17f1044a-a62e-4d44-a0b4-6a83d15df146"), "Clases de Ballet", new Guid("7ddd6a6e-eb88-4cef-84a7-15229eb96bba") },
                    { new Guid("47e8bfd9-2a90-40f5-880c-68ec886e293e"), "Clases de logica", new Guid("7ddd6a6e-eb88-4cef-84a7-15229eb96bba") }
                });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "FatherName", "FirstName", "KindergarterId", "MotherName", "SecondName", "TutorId" },
                values: new object[,]
                {
                    { new Guid("00d90097-053a-4235-b309-0e177d9ad80b"), "Stackeetam", "Aaron", new Guid("7ddd6a6e-eb88-4cef-84a7-15229eb96bba"), "Worm", "Eduardo", new Guid("24841f2f-706a-4248-9bad-054093f2362f") },
                    { new Guid("02460234-85ac-44a4-b8a8-82159381c297"), "Faringtom", "Dylan", new Guid("7ddd6a6e-eb88-4cef-84a7-15229eb96bba"), "White", "Enrique", new Guid("24841f2f-706a-4248-9bad-054093f2362f") },
                    { new Guid("02de298b-1c68-4b0c-b4c7-bd2692f72db9"), "Escobar", "Aaron", new Guid("7ddd6a6e-eb88-4cef-84a7-15229eb96bba"), "Worm", "Enrique", new Guid("24841f2f-706a-4248-9bad-054093f2362f") },
                    { new Guid("032525ca-feed-4c0f-a39c-f5e70bc6ad2f"), "Escobar", "Aaron", new Guid("7ddd6a6e-eb88-4cef-84a7-15229eb96bba"), "Washinton", "Enrique", new Guid("24841f2f-706a-4248-9bad-054093f2362f") },
                    { new Guid("0507c91b-c5d2-470a-acd4-0502448131fc"), "Stackeetam", "Lyan", new Guid("7ddd6a6e-eb88-4cef-84a7-15229eb96bba"), "Snow", "Emilio", new Guid("24841f2f-706a-4248-9bad-054093f2362f") },
                    { new Guid("064e00c2-2e2e-4c5a-ae65-434fceda49dd"), "Escobar", "Johan", new Guid("7ddd6a6e-eb88-4cef-84a7-15229eb96bba"), "Washinton", "Enrique", new Guid("24841f2f-706a-4248-9bad-054093f2362f") },
                    { new Guid("078a8b7d-985c-435b-967d-d249ad5aaf33"), "Lee", "Lyan", new Guid("7ddd6a6e-eb88-4cef-84a7-15229eb96bba"), "Snow", "Eduardo", new Guid("24841f2f-706a-4248-9bad-054093f2362f") },
                    { new Guid("07e402e8-ac87-42cc-9468-85cda5cf3f85"), "Lee", "Lyan", new Guid("7ddd6a6e-eb88-4cef-84a7-15229eb96bba"), "Snow", "Enrique", new Guid("24841f2f-706a-4248-9bad-054093f2362f") },
                    { new Guid("0a11fd30-e556-40a8-9a51-c5debc94e378"), "Lee", "Lyan", new Guid("7ddd6a6e-eb88-4cef-84a7-15229eb96bba"), "Washinton", "Carlos", new Guid("24841f2f-706a-4248-9bad-054093f2362f") },
                    { new Guid("0b2dd5c2-33bc-4bcd-be0a-ed693f99b398"), "Lee", "Aaron", new Guid("7ddd6a6e-eb88-4cef-84a7-15229eb96bba"), "Snow", "Enrique", new Guid("24841f2f-706a-4248-9bad-054093f2362f") }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Price", "Reference", "ActivityId", "Description" },
                values: new object[,]
                {
                    { new Guid("c4bbeff6-581e-42cb-863e-c985accbe844"), "Service", 4779m, "SRV-154", new Guid("4d02ba95-2231-4b6b-8094-d5aae15fa41f"), "Service Clases de ingles" },
                    { new Guid("8dcac50d-6a28-4a7f-88d5-f76ce01d0529"), "Service", 5173m, "SRV-632", new Guid("ed4f41ab-0a86-4d96-a977-6a7585b2c6b9"), "Service Cuidade matutino" },
                    { new Guid("462bc18f-3136-4751-9ea3-e30e580fbcfd"), "Service", 8471m, "SRV-134", new Guid("0976b125-869c-4514-8398-0c685f42af1c"), "Service Cuidado Vespertino" },
                    { new Guid("553a0c12-0a06-4f8c-961b-b9c3292cdebe"), "Service", 8859m, "SRV-394", new Guid("088bae7b-0dff-4c36-8aa5-06e0777dc4e9"), "Service Cuidado dia completo" },
                    { new Guid("cb010801-bc46-4d75-a3da-f9a98aae009a"), "Service", 4589m, "SRV-232", new Guid("17f1044a-a62e-4d44-a0b4-6a83d15df146"), "Service Clases de Ballet" },
                    { new Guid("6eb1ae54-38ce-4735-88cd-8b2480b8d959"), "Service", 8531m, "SRV-532", new Guid("47e8bfd9-2a90-40f5-880c-68ec886e293e"), "Service Clases de logica" }
                });
        }
    }
}
