using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Feeding_activities_and_services : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("017db7ca-deee-4412-884b-d4b46fc372e7"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("02e2617d-e74d-4ef4-a13e-deca76d10bc8"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0379cc56-36d8-4316-98fb-ef9e9edfab35"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("03c9df9a-d484-45f0-b858-fbe75520b320"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("03ec5db0-fe1f-4503-be6e-e8d8dc27449c"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("049349af-fc53-41b4-90d8-947bfcc38fd1"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("04fb0a57-8134-45ed-86b3-160cbbec3996"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("056a4650-ef32-46f1-9a4d-4b8ab28c142c"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("05bf9154-4750-410f-b6c1-99d2320d794a"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("06645412-9112-4d7f-869c-5a6f87998a58"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("380a7446-94f4-480f-9806-5091afcde014"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"), "Guarderia" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d"), null, "Gregorio de Jesus", "Rojas Acosta", null, null, null });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("380a7446-94f4-480f-9806-5091afcde014"), null, "Yadira", "Pinales Delgado", null, null, null });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "FatherName", "FirstName", "KindergarterId", "MotherName", "SecondName", "TutorId" },
                values: new object[,]
                {
                    { new Guid("017db7ca-deee-4412-884b-d4b46fc372e7"), "Escobar", "Lyan", new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"), "Washinton", "Enrique", new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d") },
                    { new Guid("02e2617d-e74d-4ef4-a13e-deca76d10bc8"), "Faringtom", "Johan", new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"), "Snow", "Enrique", new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d") },
                    { new Guid("0379cc56-36d8-4316-98fb-ef9e9edfab35"), "Faringtom", "Lyan", new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"), "Worm", "Carlos", new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d") },
                    { new Guid("03c9df9a-d484-45f0-b858-fbe75520b320"), "Faringtom", "Aaron", new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"), "Snow", "Enrique", new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d") },
                    { new Guid("03ec5db0-fe1f-4503-be6e-e8d8dc27449c"), "Faringtom", "Johan", new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"), "Washinton", "Carlos", new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d") },
                    { new Guid("049349af-fc53-41b4-90d8-947bfcc38fd1"), "Faringtom", "Johan", new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"), "White", "Emilio", new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d") },
                    { new Guid("04fb0a57-8134-45ed-86b3-160cbbec3996"), "Lee", "Lyan", new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"), "Worm", "Emilio", new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d") },
                    { new Guid("056a4650-ef32-46f1-9a4d-4b8ab28c142c"), "Escobar", "Johan", new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"), "Snow", "Enrique", new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d") },
                    { new Guid("05bf9154-4750-410f-b6c1-99d2320d794a"), "Stackeetam", "Johan", new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"), "Snow", "Enrique", new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d") },
                    { new Guid("06645412-9112-4d7f-869c-5a6f87998a58"), "Faringtom", "Johan", new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"), "Worm", "Eduardo", new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d") }
                });
        }
    }
}
