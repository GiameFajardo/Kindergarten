using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KindergartenAppService.Migrations
{
    public partial class Remove_Kid_From_Enrollment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("1c43e6d1-1fff-4727-a10e-4eaa15939dbc"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("2a05f3ea-83c8-4773-87ed-d86f09830227"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("4b4804a9-6d51-4496-b08c-a9f4fba035de"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("4ff02c44-f7c0-4337-8b11-3cff4849820c"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("de439620-81f6-4cfb-90ef-2953a2586300"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("f8db1edf-3e74-4103-925c-8c0d53885e63"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0064873e-1568-4fb6-ad36-d4947d51497b"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("011ac463-23d2-4fd2-b2f2-9cf61333b176"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("0165fb1f-703c-4b03-b0c0-ce98a20ae2fe"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("030f1ddf-cc6e-4a1b-a282-14137325fcc8"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("03829b93-9356-4359-92f7-e675c2044627"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("06447503-271f-4d84-a9c9-803b8479ccce"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("06d8e76e-336d-4e25-99d4-c5698a9bfea5"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("06ec4a8a-0b2d-4a48-ac22-7dc668396980"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("07c18f9c-8129-46aa-bec4-daaffbdacd89"));

            migrationBuilder.DeleteData(
                table: "Kid",
                keyColumn: "Id",
                keyValue: new Guid("09e63d6a-15cd-41e9-a098-0ab11a02a45d"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("cc873f7a-13a4-473d-bb8d-3bd345d17fea"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("132fbefa-982f-4e27-98bb-2f846aae7176"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("5a3d8aeb-9f95-4cac-91ca-08e751ac805a"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("63323267-a10c-4bfb-9f22-c7d0f297fc73"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("77993c94-1523-4890-85ab-d767bc87697f"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("a6c5ffd2-8103-4d8c-9c0a-2a46cdf9deae"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: new Guid("c9f38097-4f54-4a57-b68d-d19e79d58374"));

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: new Guid("725cb50c-2249-4874-9449-40a4131d9af9"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("0807cc78-0ac6-4c88-b2b4-b01ca22cc149"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("6a80c76c-f235-4e40-962e-38f32cf8bf52"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("9183f68e-d32c-40dc-bbc8-ee99cc25107b"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("ab7c7726-ab62-4b8c-8749-b947b3b572cd"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("d2794bf3-8776-454c-b836-b0901151d011"));

            migrationBuilder.DeleteData(
                table: "ActivityTemplate",
                keyColumn: "Id",
                keyValue: new Guid("e9b0e1f4-23a9-4a6b-b621-4789522c6e5a"));

            migrationBuilder.DeleteData(
                table: "Kindergarters",
                keyColumn: "Id",
                keyValue: new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315"));

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Kindergarters",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315"), "Guarderia" });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("725cb50c-2249-4874-9449-40a4131d9af9"), null, "Gregorio de Jesus", "Rojas Acosta", null, null, null });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Mail", "MovilNumber", "PhoneNumber" },
                values: new object[] { new Guid("cc873f7a-13a4-473d-bb8d-3bd345d17fea"), null, "Yadira", "Pinales Delgado", null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityTemplate",
                columns: new[] { "Id", "Description", "KindergarterId" },
                values: new object[,]
                {
                    { new Guid("e9b0e1f4-23a9-4a6b-b621-4789522c6e5a"), "Clases de ingles", new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315") },
                    { new Guid("d2794bf3-8776-454c-b836-b0901151d011"), "Cuidade matutino", new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315") },
                    { new Guid("9183f68e-d32c-40dc-bbc8-ee99cc25107b"), "Cuidado Vespertino", new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315") },
                    { new Guid("ab7c7726-ab62-4b8c-8749-b947b3b572cd"), "Cuidado dia completo", new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315") },
                    { new Guid("0807cc78-0ac6-4c88-b2b4-b01ca22cc149"), "Clases de Ballet", new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315") },
                    { new Guid("6a80c76c-f235-4e40-962e-38f32cf8bf52"), "Clases de logica", new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315") }
                });

            migrationBuilder.InsertData(
                table: "Kid",
                columns: new[] { "Id", "FatherName", "FirstName", "KindergarterId", "MotherName", "SecondName", "TutorId" },
                values: new object[,]
                {
                    { new Guid("0064873e-1568-4fb6-ad36-d4947d51497b"), "Faringtom", "Johan", new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315"), "Worm", "Eduardo", new Guid("725cb50c-2249-4874-9449-40a4131d9af9") },
                    { new Guid("011ac463-23d2-4fd2-b2f2-9cf61333b176"), "Escobar", "Lyan", new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315"), "Washinton", "Eduardo", new Guid("725cb50c-2249-4874-9449-40a4131d9af9") },
                    { new Guid("0165fb1f-703c-4b03-b0c0-ce98a20ae2fe"), "Escobar", "Aaron", new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315"), "Worm", "Eduardo", new Guid("725cb50c-2249-4874-9449-40a4131d9af9") },
                    { new Guid("030f1ddf-cc6e-4a1b-a282-14137325fcc8"), "Faringtom", "Dylan", new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315"), "Washinton", "Carlos", new Guid("725cb50c-2249-4874-9449-40a4131d9af9") },
                    { new Guid("03829b93-9356-4359-92f7-e675c2044627"), "Escobar", "Johan", new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315"), "Worm", "Emilio", new Guid("725cb50c-2249-4874-9449-40a4131d9af9") },
                    { new Guid("06447503-271f-4d84-a9c9-803b8479ccce"), "Faringtom", "Johan", new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315"), "White", "Eduardo", new Guid("725cb50c-2249-4874-9449-40a4131d9af9") },
                    { new Guid("06d8e76e-336d-4e25-99d4-c5698a9bfea5"), "Escobar", "Dylan", new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315"), "Washinton", "Carlos", new Guid("725cb50c-2249-4874-9449-40a4131d9af9") },
                    { new Guid("06ec4a8a-0b2d-4a48-ac22-7dc668396980"), "Lee", "Lyan", new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315"), "Snow", "Enrique", new Guid("725cb50c-2249-4874-9449-40a4131d9af9") },
                    { new Guid("07c18f9c-8129-46aa-bec4-daaffbdacd89"), "Faringtom", "Dylan", new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315"), "Snow", "Enrique", new Guid("725cb50c-2249-4874-9449-40a4131d9af9") },
                    { new Guid("09e63d6a-15cd-41e9-a098-0ab11a02a45d"), "Escobar", "Johan", new Guid("d21e24a5-59fa-441f-a0f2-3a284e304315"), "Snow", "Enrique", new Guid("725cb50c-2249-4874-9449-40a4131d9af9") }
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "Id", "ActivityTemplateId", "Description" },
                values: new object[,]
                {
                    { new Guid("77993c94-1523-4890-85ab-d767bc87697f"), new Guid("e9b0e1f4-23a9-4a6b-b621-4789522c6e5a"), "Clases de ingles" },
                    { new Guid("5a3d8aeb-9f95-4cac-91ca-08e751ac805a"), new Guid("d2794bf3-8776-454c-b836-b0901151d011"), "Cuidade matutino" },
                    { new Guid("c9f38097-4f54-4a57-b68d-d19e79d58374"), new Guid("9183f68e-d32c-40dc-bbc8-ee99cc25107b"), "Cuidado Vespertino" },
                    { new Guid("63323267-a10c-4bfb-9f22-c7d0f297fc73"), new Guid("ab7c7726-ab62-4b8c-8749-b947b3b572cd"), "Cuidado dia completo" },
                    { new Guid("132fbefa-982f-4e27-98bb-2f846aae7176"), new Guid("0807cc78-0ac6-4c88-b2b4-b01ca22cc149"), "Clases de Ballet" },
                    { new Guid("a6c5ffd2-8103-4d8c-9c0a-2a46cdf9deae"), new Guid("6a80c76c-f235-4e40-962e-38f32cf8bf52"), "Clases de logica" }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Price", "Reference", "ActivityId", "Description", "ServicePeriod" },
                values: new object[,]
                {
                    { new Guid("4b4804a9-6d51-4496-b08c-a9f4fba035de"), "Service", 3920m, "SRV-818", new Guid("77993c94-1523-4890-85ab-d767bc87697f"), "Service Clases de ingles", 77 },
                    { new Guid("2a05f3ea-83c8-4773-87ed-d86f09830227"), "Service", 260m, "SRV-798", new Guid("5a3d8aeb-9f95-4cac-91ca-08e751ac805a"), "Service Cuidade matutino", 77 },
                    { new Guid("de439620-81f6-4cfb-90ef-2953a2586300"), "Service", 5842m, "SRV-262", new Guid("c9f38097-4f54-4a57-b68d-d19e79d58374"), "Service Cuidado Vespertino", 77 },
                    { new Guid("1c43e6d1-1fff-4727-a10e-4eaa15939dbc"), "Service", 4141m, "SRV-698", new Guid("63323267-a10c-4bfb-9f22-c7d0f297fc73"), "Service Cuidado dia completo", 77 },
                    { new Guid("4ff02c44-f7c0-4337-8b11-3cff4849820c"), "Service", 5229m, "SRV-782", new Guid("132fbefa-982f-4e27-98bb-2f846aae7176"), "Service Clases de Ballet", 77 },
                    { new Guid("f8db1edf-3e74-4103-925c-8c0d53885e63"), "Service", 6932m, "SRV-4", new Guid("a6c5ffd2-8103-4d8c-9c0a-2a46cdf9deae"), "Service Clases de logica", 77 }
                });
        }
    }
}
