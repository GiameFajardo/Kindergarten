using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Remove_Kid_From_Enrollment2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("400d6d2f-fbc1-4b87-8837-715bd03ab30d"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("583236d1-0d13-4416-83cf-1c1687388c81"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("6d5c5f92-b4e0-4688-a69c-2dfcb40ab983"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("e4fb193c-e69f-4959-aba8-b1878a2eb4ed"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("f322c5fb-7102-4191-8e2e-ba7de2f72fa2"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("fccc0c79-e6a3-40a8-a07d-c0c1b87b663e"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("01edb270-9a07-43aa-aef3-3241ad036c47"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("022264b2-3a62-4d23-baaa-e6399a69c87b"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("02f3582a-8764-4f21-b946-6bc1c2171f73"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0339a60a-659b-477d-8173-e999bc221511"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("041f07d9-c738-46f5-abf9-eeef7639f294"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("043aa653-8133-43fc-a526-4bb973f617e7"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("052f5f35-664f-4f94-9182-69f8481bcd78"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("07e49c1f-de91-4f5c-9503-1f8e155f78d3"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0cf794f7-231d-4979-8e02-f339892f9b18"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0d66074d-d6c9-495c-89e8-4ee083fdf7da"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("a8782a4e-ae9b-4ce3-a1fb-54068537928a"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("33f9e0c2-57cc-4931-ab79-973245aa6ed6"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("5940c943-cd58-4aa4-93a4-ea91d4c088c1"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("9c08d64f-e56d-4530-81a5-71b9f162ff14"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("a5309473-c110-41c5-a1ba-8785491ca298"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("bb7b70d9-cb1e-4fdb-ac6d-e20af08b09a7"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("eca74429-1868-4dc3-a964-b5247ebc767d"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("c0bd3a32-4cef-4867-b4c1-48b4777a9cc1"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("7a746541-48d4-4c59-88f9-6590d4b29ec8"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("9ebe0415-a26e-4fb5-80f4-a048a118819c"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("d72dfd54-a769-469c-938a-1a7439e4daeb"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("d9f27104-bde6-4b60-b8b5-56798fd5a23f"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("f18fd1e2-0dea-410d-b800-6b13a79d388b"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("f3c3e8c4-9902-49a5-a9fc-9e9505c6a52b"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("e17ab00e-d325-47d3-ba68-57b03567fa5a"));

            migrationBuilder.DropColumn(
                name: "KidId",
                table: "Enrollments");

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("5a039392-f92e-41ca-ac56-adf596ac9f8c"), "Guarderia" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("ed6c6dec-edc0-4f26-ab73-ce3f444b12a5"), null, "Gregorio de Jesus", "Rojas Acosta", null, null, null });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("3bf12ded-29bf-40b4-9f28-8a0574663d21"), null, "Yadira", "Pinales Delgado", null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityTemplate",
                columns: new[] { "Id", "Description", "KindergarterId" },
                values: new object[,]
                {
                    { new Guid("0b2a7258-05b7-42cb-a584-9fc4b2a36d17"), "Clases de ingles", new Guid("5a039392-f92e-41ca-ac56-adf596ac9f8c") },
                    { new Guid("4abf1d2a-41a8-4330-a609-2bdbc8a696bf"), "Cuidade matutino", new Guid("5a039392-f92e-41ca-ac56-adf596ac9f8c") },
                    { new Guid("8407a9af-5fba-45a9-8ab8-8266b2a1d09f"), "Cuidado Vespertino", new Guid("5a039392-f92e-41ca-ac56-adf596ac9f8c") },
                    { new Guid("85a941c9-f595-4422-a5b1-fbd5954917de"), "Cuidado dia completo", new Guid("5a039392-f92e-41ca-ac56-adf596ac9f8c") },
                    { new Guid("5785aa8f-1a4d-4197-8b85-e35fc82feebb"), "Clases de Ballet", new Guid("5a039392-f92e-41ca-ac56-adf596ac9f8c") },
                    { new Guid("80383969-f1e4-44ff-95d9-5a239f90cf39"), "Clases de logica", new Guid("5a039392-f92e-41ca-ac56-adf596ac9f8c") }
                });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "FatherName", "FirstName", "KindergarterId", "MotherName", "SecondName", "TutorId" },
                values: new object[,]
                {
                    { new Guid("007e2185-6f93-45a2-8b38-13c236389e5f"), "Stackeetam", "Aaron", new Guid("5a039392-f92e-41ca-ac56-adf596ac9f8c"), "Washinton", "Carlos", new Guid("ed6c6dec-edc0-4f26-ab73-ce3f444b12a5") },
                    { new Guid("00d8a236-0426-401d-a559-d7b0e8b4164b"), "Faringtom", "Lyan", new Guid("5a039392-f92e-41ca-ac56-adf596ac9f8c"), "Worm", "Carlos", new Guid("ed6c6dec-edc0-4f26-ab73-ce3f444b12a5") },
                    { new Guid("01b7914f-5f76-455f-9e14-5649026ce7d3"), "Escobar", "Aaron", new Guid("5a039392-f92e-41ca-ac56-adf596ac9f8c"), "White", "Carlos", new Guid("ed6c6dec-edc0-4f26-ab73-ce3f444b12a5") },
                    { new Guid("0233d672-3349-4571-9a2f-b8165e0f1845"), "Escobar", "Dylan", new Guid("5a039392-f92e-41ca-ac56-adf596ac9f8c"), "Snow", "Emilio", new Guid("ed6c6dec-edc0-4f26-ab73-ce3f444b12a5") },
                    { new Guid("028b2819-fdcb-4232-a70a-67a44a30fbbc"), "Escobar", "Johan", new Guid("5a039392-f92e-41ca-ac56-adf596ac9f8c"), "Washinton", "Carlos", new Guid("ed6c6dec-edc0-4f26-ab73-ce3f444b12a5") },
                    { new Guid("03041a55-d5f4-4b23-88ff-3ef414444ebc"), "Faringtom", "Dylan", new Guid("5a039392-f92e-41ca-ac56-adf596ac9f8c"), "Worm", "Enrique", new Guid("ed6c6dec-edc0-4f26-ab73-ce3f444b12a5") },
                    { new Guid("044d1c2d-6ac5-4ec9-8a2e-10a94fcb3bcb"), "Stackeetam", "Lyan", new Guid("5a039392-f92e-41ca-ac56-adf596ac9f8c"), "Washinton", "Emilio", new Guid("ed6c6dec-edc0-4f26-ab73-ce3f444b12a5") },
                    { new Guid("04511344-55bc-4dd5-a962-43887c721126"), "Escobar", "Johan", new Guid("5a039392-f92e-41ca-ac56-adf596ac9f8c"), "Snow", "Emilio", new Guid("ed6c6dec-edc0-4f26-ab73-ce3f444b12a5") },
                    { new Guid("04644465-92b1-42cb-abcd-aecc54fa1433"), "Lee", "Lyan", new Guid("5a039392-f92e-41ca-ac56-adf596ac9f8c"), "White", "Enrique", new Guid("ed6c6dec-edc0-4f26-ab73-ce3f444b12a5") },
                    { new Guid("068a3fc5-958f-4dfc-b631-90d9b507382c"), "Faringtom", "Johan", new Guid("5a039392-f92e-41ca-ac56-adf596ac9f8c"), "Washinton", "Carlos", new Guid("ed6c6dec-edc0-4f26-ab73-ce3f444b12a5") }
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "Id", "ActivityTemplateId", "Description" },
                values: new object[,]
                {
                    { new Guid("0e226d3a-c94b-4aa0-b50b-9d0295200b15"), new Guid("0b2a7258-05b7-42cb-a584-9fc4b2a36d17"), "Clases de ingles" },
                    { new Guid("1f3952ac-0b44-48d5-8684-52929da87847"), new Guid("4abf1d2a-41a8-4330-a609-2bdbc8a696bf"), "Cuidade matutino" },
                    { new Guid("6a31a49d-32d1-486f-bbb9-ba4d1e058802"), new Guid("8407a9af-5fba-45a9-8ab8-8266b2a1d09f"), "Cuidado Vespertino" },
                    { new Guid("da7bc6bd-7ea0-488e-940a-449f60cbfc6f"), new Guid("85a941c9-f595-4422-a5b1-fbd5954917de"), "Cuidado dia completo" },
                    { new Guid("54a130c5-6eb2-46cc-879f-9f82aa531ed1"), new Guid("5785aa8f-1a4d-4197-8b85-e35fc82feebb"), "Clases de Ballet" },
                    { new Guid("7717b8eb-c6fd-4f8b-9fe1-7e88ee69d58b"), new Guid("80383969-f1e4-44ff-95d9-5a239f90cf39"), "Clases de logica" }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Price", "Reference", "ActivityId", "Description", "ServicePeriod" },
                values: new object[,]
                {
                    { new Guid("16f1d5df-2076-4877-8eae-1ac7a68e49a7"), "Service", 6616m, "SRV-877", new Guid("0e226d3a-c94b-4aa0-b50b-9d0295200b15"), "Service Clases de ingles", 77 },
                    { new Guid("bf2f6d16-059b-43e8-b1ff-4f2294da7cb8"), "Service", 7075m, "SRV-909", new Guid("1f3952ac-0b44-48d5-8684-52929da87847"), "Service Cuidade matutino", 77 },
                    { new Guid("bd5cc008-8d1b-449e-8b1f-ffadfc9a2c4b"), "Service", 6865m, "SRV-923", new Guid("6a31a49d-32d1-486f-bbb9-ba4d1e058802"), "Service Cuidado Vespertino", 77 },
                    { new Guid("2397a279-4ed1-4e5f-8193-a177595ae197"), "Service", 2836m, "SRV-13", new Guid("da7bc6bd-7ea0-488e-940a-449f60cbfc6f"), "Service Cuidado dia completo", 77 },
                    { new Guid("c3f3f4cb-b479-41a3-a914-c7b687248d00"), "Service", 7515m, "SRV-670", new Guid("54a130c5-6eb2-46cc-879f-9f82aa531ed1"), "Service Clases de Ballet", 77 },
                    { new Guid("b20721d8-495a-40f7-a9d9-26a408f6ee36"), "Service", 8702m, "SRV-67", new Guid("7717b8eb-c6fd-4f8b-9fe1-7e88ee69d58b"), "Service Clases de logica", 77 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("16f1d5df-2076-4877-8eae-1ac7a68e49a7"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("2397a279-4ed1-4e5f-8193-a177595ae197"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("b20721d8-495a-40f7-a9d9-26a408f6ee36"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("bd5cc008-8d1b-449e-8b1f-ffadfc9a2c4b"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("bf2f6d16-059b-43e8-b1ff-4f2294da7cb8"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("c3f3f4cb-b479-41a3-a914-c7b687248d00"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("007e2185-6f93-45a2-8b38-13c236389e5f"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("00d8a236-0426-401d-a559-d7b0e8b4164b"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("01b7914f-5f76-455f-9e14-5649026ce7d3"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0233d672-3349-4571-9a2f-b8165e0f1845"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("028b2819-fdcb-4232-a70a-67a44a30fbbc"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("03041a55-d5f4-4b23-88ff-3ef414444ebc"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("044d1c2d-6ac5-4ec9-8a2e-10a94fcb3bcb"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("04511344-55bc-4dd5-a962-43887c721126"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("04644465-92b1-42cb-abcd-aecc54fa1433"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("068a3fc5-958f-4dfc-b631-90d9b507382c"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("3bf12ded-29bf-40b4-9f28-8a0574663d21"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("0e226d3a-c94b-4aa0-b50b-9d0295200b15"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("1f3952ac-0b44-48d5-8684-52929da87847"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("54a130c5-6eb2-46cc-879f-9f82aa531ed1"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("6a31a49d-32d1-486f-bbb9-ba4d1e058802"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("7717b8eb-c6fd-4f8b-9fe1-7e88ee69d58b"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("da7bc6bd-7ea0-488e-940a-449f60cbfc6f"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("ed6c6dec-edc0-4f26-ab73-ce3f444b12a5"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("0b2a7258-05b7-42cb-a584-9fc4b2a36d17"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("4abf1d2a-41a8-4330-a609-2bdbc8a696bf"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("5785aa8f-1a4d-4197-8b85-e35fc82feebb"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("80383969-f1e4-44ff-95d9-5a239f90cf39"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("8407a9af-5fba-45a9-8ab8-8266b2a1d09f"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("85a941c9-f595-4422-a5b1-fbd5954917de"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("5a039392-f92e-41ca-ac56-adf596ac9f8c"));

            migrationBuilder.AddColumn<Guid>(
                name: "KidId",
                table: "Enrollments",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("e17ab00e-d325-47d3-ba68-57b03567fa5a"), "Guarderia" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("c0bd3a32-4cef-4867-b4c1-48b4777a9cc1"), null, "Gregorio de Jesus", "Rojas Acosta", null, null, null });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("a8782a4e-ae9b-4ce3-a1fb-54068537928a"), null, "Yadira", "Pinales Delgado", null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityTemplate",
                columns: new[] { "Id", "Description", "KindergarterId" },
                values: new object[,]
                {
                    { new Guid("9ebe0415-a26e-4fb5-80f4-a048a118819c"), "Clases de ingles", new Guid("e17ab00e-d325-47d3-ba68-57b03567fa5a") },
                    { new Guid("f3c3e8c4-9902-49a5-a9fc-9e9505c6a52b"), "Cuidade matutino", new Guid("e17ab00e-d325-47d3-ba68-57b03567fa5a") },
                    { new Guid("7a746541-48d4-4c59-88f9-6590d4b29ec8"), "Cuidado Vespertino", new Guid("e17ab00e-d325-47d3-ba68-57b03567fa5a") },
                    { new Guid("d72dfd54-a769-469c-938a-1a7439e4daeb"), "Cuidado dia completo", new Guid("e17ab00e-d325-47d3-ba68-57b03567fa5a") },
                    { new Guid("f18fd1e2-0dea-410d-b800-6b13a79d388b"), "Clases de Ballet", new Guid("e17ab00e-d325-47d3-ba68-57b03567fa5a") },
                    { new Guid("d9f27104-bde6-4b60-b8b5-56798fd5a23f"), "Clases de logica", new Guid("e17ab00e-d325-47d3-ba68-57b03567fa5a") }
                });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "FatherName", "FirstName", "KindergarterId", "MotherName", "SecondName", "TutorId" },
                values: new object[,]
                {
                    { new Guid("01edb270-9a07-43aa-aef3-3241ad036c47"), "Faringtom", "Lyan", new Guid("e17ab00e-d325-47d3-ba68-57b03567fa5a"), "Worm", "Carlos", new Guid("c0bd3a32-4cef-4867-b4c1-48b4777a9cc1") },
                    { new Guid("022264b2-3a62-4d23-baaa-e6399a69c87b"), "Lee", "Lyan", new Guid("e17ab00e-d325-47d3-ba68-57b03567fa5a"), "Worm", "Emilio", new Guid("c0bd3a32-4cef-4867-b4c1-48b4777a9cc1") },
                    { new Guid("02f3582a-8764-4f21-b946-6bc1c2171f73"), "Faringtom", "Dylan", new Guid("e17ab00e-d325-47d3-ba68-57b03567fa5a"), "Snow", "Emilio", new Guid("c0bd3a32-4cef-4867-b4c1-48b4777a9cc1") },
                    { new Guid("0339a60a-659b-477d-8173-e999bc221511"), "Stackeetam", "Lyan", new Guid("e17ab00e-d325-47d3-ba68-57b03567fa5a"), "White", "Eduardo", new Guid("c0bd3a32-4cef-4867-b4c1-48b4777a9cc1") },
                    { new Guid("041f07d9-c738-46f5-abf9-eeef7639f294"), "Stackeetam", "Lyan", new Guid("e17ab00e-d325-47d3-ba68-57b03567fa5a"), "Washinton", "Carlos", new Guid("c0bd3a32-4cef-4867-b4c1-48b4777a9cc1") },
                    { new Guid("043aa653-8133-43fc-a526-4bb973f617e7"), "Stackeetam", "Lyan", new Guid("e17ab00e-d325-47d3-ba68-57b03567fa5a"), "Worm", "Emilio", new Guid("c0bd3a32-4cef-4867-b4c1-48b4777a9cc1") },
                    { new Guid("052f5f35-664f-4f94-9182-69f8481bcd78"), "Escobar", "Johan", new Guid("e17ab00e-d325-47d3-ba68-57b03567fa5a"), "Snow", "Enrique", new Guid("c0bd3a32-4cef-4867-b4c1-48b4777a9cc1") },
                    { new Guid("07e49c1f-de91-4f5c-9503-1f8e155f78d3"), "Faringtom", "Johan", new Guid("e17ab00e-d325-47d3-ba68-57b03567fa5a"), "Washinton", "Eduardo", new Guid("c0bd3a32-4cef-4867-b4c1-48b4777a9cc1") },
                    { new Guid("0cf794f7-231d-4979-8e02-f339892f9b18"), "Faringtom", "Aaron", new Guid("e17ab00e-d325-47d3-ba68-57b03567fa5a"), "Washinton", "Eduardo", new Guid("c0bd3a32-4cef-4867-b4c1-48b4777a9cc1") },
                    { new Guid("0d66074d-d6c9-495c-89e8-4ee083fdf7da"), "Stackeetam", "Aaron", new Guid("e17ab00e-d325-47d3-ba68-57b03567fa5a"), "Snow", "Emilio", new Guid("c0bd3a32-4cef-4867-b4c1-48b4777a9cc1") }
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "Id", "ActivityTemplateId", "Description" },
                values: new object[,]
                {
                    { new Guid("eca74429-1868-4dc3-a964-b5247ebc767d"), new Guid("9ebe0415-a26e-4fb5-80f4-a048a118819c"), "Clases de ingles" },
                    { new Guid("a5309473-c110-41c5-a1ba-8785491ca298"), new Guid("f3c3e8c4-9902-49a5-a9fc-9e9505c6a52b"), "Cuidade matutino" },
                    { new Guid("33f9e0c2-57cc-4931-ab79-973245aa6ed6"), new Guid("7a746541-48d4-4c59-88f9-6590d4b29ec8"), "Cuidado Vespertino" },
                    { new Guid("5940c943-cd58-4aa4-93a4-ea91d4c088c1"), new Guid("d72dfd54-a769-469c-938a-1a7439e4daeb"), "Cuidado dia completo" },
                    { new Guid("bb7b70d9-cb1e-4fdb-ac6d-e20af08b09a7"), new Guid("f18fd1e2-0dea-410d-b800-6b13a79d388b"), "Clases de Ballet" },
                    { new Guid("9c08d64f-e56d-4530-81a5-71b9f162ff14"), new Guid("d9f27104-bde6-4b60-b8b5-56798fd5a23f"), "Clases de logica" }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Price", "Reference", "ActivityId", "Description", "ServicePeriod" },
                values: new object[,]
                {
                    { new Guid("400d6d2f-fbc1-4b87-8837-715bd03ab30d"), "Service", 4743m, "SRV-975", new Guid("eca74429-1868-4dc3-a964-b5247ebc767d"), "Service Clases de ingles", 77 },
                    { new Guid("f322c5fb-7102-4191-8e2e-ba7de2f72fa2"), "Service", 2204m, "SRV-525", new Guid("a5309473-c110-41c5-a1ba-8785491ca298"), "Service Cuidade matutino", 77 },
                    { new Guid("583236d1-0d13-4416-83cf-1c1687388c81"), "Service", 5756m, "SRV-883", new Guid("33f9e0c2-57cc-4931-ab79-973245aa6ed6"), "Service Cuidado Vespertino", 77 },
                    { new Guid("e4fb193c-e69f-4959-aba8-b1878a2eb4ed"), "Service", 6216m, "SRV-514", new Guid("5940c943-cd58-4aa4-93a4-ea91d4c088c1"), "Service Cuidado dia completo", 77 },
                    { new Guid("fccc0c79-e6a3-40a8-a07d-c0c1b87b663e"), "Service", 8997m, "SRV-534", new Guid("bb7b70d9-cb1e-4fdb-ac6d-e20af08b09a7"), "Service Clases de Ballet", 77 },
                    { new Guid("6d5c5f92-b4e0-4688-a69c-2dfcb40ab983"), "Service", 7425m, "SRV-46", new Guid("9c08d64f-e56d-4530-81a5-71b9f162ff14"), "Service Clases de logica", 77 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_KidId",
                table: "Enrollments",
                column: "KidId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Kid_KidId",
                table: "Enrollments",
                column: "KidId",
                principalTable: "Kid",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
