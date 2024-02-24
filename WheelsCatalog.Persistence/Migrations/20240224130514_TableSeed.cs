using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WheelsCatalog.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class TableSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BrandEntityModel",
                columns: new[] { "Id", "CreateDateTime", "Description", "LogoUrl", "Name", "UpdateDateTime" },
                values: new object[,]
                {
                    { new Guid("017c2115-1986-4e3d-99b2-994d7b76551f"), new DateTime(2024, 2, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6268), "Description for Brand 9", "https://example.com/logo9.png", "Brand 9", new DateTime(2024, 2, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6269) },
                    { new Guid("27529e9e-2fd9-4eba-9be2-10882dde7dad"), new DateTime(2024, 2, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6285), "Description for Brand 15", "https://example.com/logo15.png", "Brand 15", new DateTime(2024, 2, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6286) },
                    { new Guid("289b3fe2-3356-4d5b-91dc-74ab0cc5ca15"), new DateTime(2024, 2, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6276), "Description for Brand 12", "https://example.com/logo12.png", "Brand 12", new DateTime(2024, 2, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6276) },
                    { new Guid("29cb2067-edef-4c3d-9fe8-6b939ac03e0a"), new DateTime(2024, 2, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6243), "Description for Brand 4", "https://example.com/logo4.png", "Brand 4", new DateTime(2024, 2, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6244) },
                    { new Guid("4737e704-8385-43ba-a8e8-8371812a0ae0"), new DateTime(2024, 2, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6281), "Description for Brand 13", "https://example.com/logo13.png", "Brand 13", new DateTime(2024, 2, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6281) },
                    { new Guid("47967e58-98d9-4a19-b964-576140c23115"), new DateTime(2024, 2, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6233), "Description for Brand 1", "https://example.com/logo1.png", "Brand 1", new DateTime(2024, 2, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6235) },
                    { new Guid("56348f47-d9d8-4f7b-9c26-c9a101719ba7"), new DateTime(2024, 2, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6264), "Description for Brand 7", "https://example.com/logo7.png", "Brand 7", new DateTime(2024, 2, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6264) },
                    { new Guid("642ec65d-2cd3-4c8c-8405-230662921e98"), new DateTime(2024, 2, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6271), "Description for Brand 10", "https://example.com/logo10.png", "Brand 10", new DateTime(2024, 2, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6272) },
                    { new Guid("6abdca2d-0e3f-440d-8e14-c766e232538c"), new DateTime(2024, 2, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6283), "Description for Brand 14", "https://example.com/logo14.png", "Brand 14", new DateTime(2024, 2, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6283) },
                    { new Guid("9f1d2f7a-44d7-411c-be98-49f47e44b043"), new DateTime(2024, 2, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6257), "Description for Brand 5", "https://example.com/logo5.png", "Brand 5", new DateTime(2024, 2, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6258) },
                    { new Guid("c5d52da9-7ea7-40de-8f7f-542a40195f3e"), new DateTime(2024, 2, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6266), "Description for Brand 8", "https://example.com/logo8.png", "Brand 8", new DateTime(2024, 2, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6266) },
                    { new Guid("c76f0799-3256-4801-b03b-d2e5e08b5069"), new DateTime(2024, 2, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6241), "Description for Brand 3", "https://example.com/logo3.png", "Brand 3", new DateTime(2024, 2, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6242) },
                    { new Guid("d767059f-a9eb-482a-8cd5-acf9a1b03c09"), new DateTime(2024, 2, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6262), "Description for Brand 6", "https://example.com/logo6.png", "Brand 6", new DateTime(2024, 2, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6262) },
                    { new Guid("e76da6fe-10a8-4f0e-8cb8-ab45d5ecffb8"), new DateTime(2024, 2, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6238), "Description for Brand 2", "https://example.com/logo2.png", "Brand 2", new DateTime(2024, 2, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6239) },
                    { new Guid("ecb6aa9a-9dad-432c-b746-c508bfa4917e"), new DateTime(2024, 2, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6274), "Description for Brand 11", "https://example.com/logo11.png", "Brand 11", new DateTime(2024, 2, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6274) }
                });

            migrationBuilder.InsertData(
                table: "ColorEntityModel",
                columns: new[] { "Id", "CreateDateTime", "HexCode", "Name", "UpdateDateTime" },
                values: new object[,]
                {
                    { new Guid("22eba9cc-bf1c-40e1-8f13-0dba18a37fbe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#00FF00", "Green", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2eb1c35c-b4f3-4be7-b7e9-b91ba418fee2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#008080", "Teal", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("316c5ce2-4101-4a51-ae18-adc78a540b33"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#FFFF00", "Yellow", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3968fd73-ef88-44bd-a9db-1c86f12ef11e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#FFFFFF", "White", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("444ee6c4-5db2-46e2-afa2-1dd9ae24803f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#00FF00", "Lime", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("62e1f37b-7ef9-466e-89cf-4bc4fc5b877a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#0000FF", "Blue", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6fb910df-ec79-4f6e-a5a1-8a1064698cb8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#800080", "Purple", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8d2a1524-609e-4bb4-bea6-848dc1b15197"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#000000", "Black", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("992ad250-2a1f-4e01-bc1b-b652627b179e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#A52A2A", "Brown", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("af1a0f5a-516c-4efd-b077-3dc806b02d7c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#FFA500", "Orange", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ca8f2b3f-7ae3-40ab-b411-835a249543e4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#00FFFF", "Cyan", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cb8e3e1a-8c4b-4406-877a-838e46adce69"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#808080", "Gray", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d173f7c3-9d79-4abd-875d-50d2ea44b9c2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#FFC0CB", "Pink", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e49387aa-517c-46a7-967b-0b0da0d17113"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#FF00FF", "Magenta", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f68ab9f6-caf2-4f30-a9ca-30fd68f630c8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#FF0000", "Red", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CurrencyEntityModel",
                columns: new[] { "Id", "Acronym", "CreateDateTime", "UpdateDateTime" },
                values: new object[] { new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), "USD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "ModelEntityModel",
                columns: new[] { "Id", "BrandId", "CreateDateTime", "Description", "Name", "UpdateDateTime" },
                values: new object[,]
                {
                    { new Guid("08950379-d767-450e-8be7-5a59235262c4"), new Guid("017c2115-1986-4e3d-99b2-994d7b76551f"), new DateTime(2023, 10, 16, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6674), "Description for Model1 for Brand 9", "Model1 for Brand 9", new DateTime(2024, 10, 10, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6674) },
                    { new Guid("09f97d76-3f54-4e75-a032-a3fea77c0ae9"), new Guid("29cb2067-edef-4c3d-9fe8-6b939ac03e0a"), new DateTime(2023, 12, 11, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6605), "Description for Model3 for Brand 4", "Model3 for Brand 4", new DateTime(2024, 6, 15, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6605) },
                    { new Guid("0a07c028-7075-4298-bb86-3774ed47d70e"), new Guid("9f1d2f7a-44d7-411c-be98-49f47e44b043"), new DateTime(2023, 11, 26, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6617), "Description for Model2 for Brand 5", "Model2 for Brand 5", new DateTime(2024, 9, 16, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6617) },
                    { new Guid("0ae9c1b2-763b-4e53-93a3-a04f0529ba35"), new Guid("47967e58-98d9-4a19-b964-576140c23115"), new DateTime(2023, 3, 29, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6556), "Description for Model3 for Brand 1", "Model3 for Brand 1", new DateTime(2023, 12, 27, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6556) },
                    { new Guid("1679dbe4-17ab-43dd-8d41-315f275e9577"), new Guid("9f1d2f7a-44d7-411c-be98-49f47e44b043"), new DateTime(2023, 10, 30, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6622), "Description for Model3 for Brand 5", "Model3 for Brand 5", new DateTime(2024, 1, 30, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6622) },
                    { new Guid("16ceeea8-98ea-4556-9e6b-3825e3ff4e62"), new Guid("289b3fe2-3356-4d5b-91dc-74ab0cc5ca15"), new DateTime(2023, 12, 8, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6736), "Description for Model3 for Brand 12", "Model3 for Brand 12", new DateTime(2024, 11, 6, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6736) },
                    { new Guid("19673770-7b54-4910-9364-3a2ca41c640b"), new Guid("27529e9e-2fd9-4eba-9be2-10882dde7dad"), new DateTime(2023, 7, 21, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6777), "Description for Model2 for Brand 15", "Model2 for Brand 15", new DateTime(2023, 10, 5, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6777) },
                    { new Guid("239a0d2d-2b00-4d35-9561-6121dc71093c"), new Guid("56348f47-d9d8-4f7b-9c26-c9a101719ba7"), new DateTime(2024, 2, 6, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6642), "Description for Model1 for Brand 7", "Model1 for Brand 7", new DateTime(2024, 5, 18, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6642) },
                    { new Guid("24faa202-d3c2-433d-bffc-cfbd05e4e984"), new Guid("289b3fe2-3356-4d5b-91dc-74ab0cc5ca15"), new DateTime(2023, 7, 18, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6731), "Description for Model2 for Brand 12", "Model2 for Brand 12", new DateTime(2024, 2, 25, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6731) },
                    { new Guid("26c1fd29-182a-4bf0-b27d-6156a0a7fb51"), new Guid("47967e58-98d9-4a19-b964-576140c23115"), new DateTime(2023, 4, 11, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6550), "Description for Model2 for Brand 1", "Model2 for Brand 1", new DateTime(2023, 12, 13, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6550) },
                    { new Guid("30298cb2-4f76-4b8a-b6db-8cd3aae93766"), new Guid("289b3fe2-3356-4d5b-91dc-74ab0cc5ca15"), new DateTime(2024, 2, 18, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6726), "Description for Model1 for Brand 12", "Model1 for Brand 12", new DateTime(2024, 9, 28, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6726) },
                    { new Guid("38d83291-7ca7-467b-beb0-1c1b030d89de"), new Guid("c5d52da9-7ea7-40de-8f7f-542a40195f3e"), new DateTime(2023, 3, 13, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6660), "Description for Model1 for Brand 8", "Model1 for Brand 8", new DateTime(2023, 5, 15, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6660) },
                    { new Guid("3ddab50e-83fa-4017-9eae-4a10ef5d3cb1"), new Guid("c76f0799-3256-4801-b03b-d2e5e08b5069"), new DateTime(2023, 12, 28, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6585), "Description for Model2 for Brand 3", "Model2 for Brand 3", new DateTime(2024, 3, 17, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6585) },
                    { new Guid("4d18cdc1-5f3c-4b6a-9b2d-a4f1e1d6acd1"), new Guid("d767059f-a9eb-482a-8cd5-acf9a1b03c09"), new DateTime(2023, 7, 13, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6638), "Description for Model3 for Brand 6", "Model3 for Brand 6", new DateTime(2024, 2, 21, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6638) },
                    { new Guid("4ebd62f9-b317-45c9-8474-7eee1a478c4b"), new Guid("e76da6fe-10a8-4f0e-8cb8-ab45d5ecffb8"), new DateTime(2023, 4, 30, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6575), "Description for Model3 for Brand 2", "Model3 for Brand 2", new DateTime(2023, 10, 31, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6575) },
                    { new Guid("5629799e-8d43-4559-a016-0f6969c0d253"), new Guid("4737e704-8385-43ba-a8e8-8371812a0ae0"), new DateTime(2023, 12, 16, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6743), "Description for Model1 for Brand 13", "Model1 for Brand 13", new DateTime(2024, 7, 21, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6743) },
                    { new Guid("5866024e-88a4-4768-beac-060a95591d93"), new Guid("d767059f-a9eb-482a-8cd5-acf9a1b03c09"), new DateTime(2023, 5, 17, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6632), "Description for Model2 for Brand 6", "Model2 for Brand 6", new DateTime(2023, 6, 4, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6632) },
                    { new Guid("5c95e9bf-1965-43a1-a37e-30a2595c5d52"), new Guid("d767059f-a9eb-482a-8cd5-acf9a1b03c09"), new DateTime(2023, 5, 6, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6627), "Description for Model1 for Brand 6", "Model1 for Brand 6", new DateTime(2023, 7, 20, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6627) },
                    { new Guid("5cfe6a4a-23b4-4b17-a9a8-ccad22593e6d"), new Guid("29cb2067-edef-4c3d-9fe8-6b939ac03e0a"), new DateTime(2023, 4, 26, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6600), "Description for Model2 for Brand 4", "Model2 for Brand 4", new DateTime(2024, 1, 6, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6600) },
                    { new Guid("5e363668-4c62-450a-a1f6-1b8a88d0342b"), new Guid("c76f0799-3256-4801-b03b-d2e5e08b5069"), new DateTime(2023, 4, 16, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6581), "Description for Model1 for Brand 3", "Model1 for Brand 3", new DateTime(2023, 4, 23, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6581) },
                    { new Guid("64282793-9c18-44d1-a7a1-33384e621569"), new Guid("ecb6aa9a-9dad-432c-b746-c508bfa4917e"), new DateTime(2024, 2, 3, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6705), "Description for Model1 for Brand 11", "Model1 for Brand 11", new DateTime(2024, 5, 19, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6705) },
                    { new Guid("64672665-8ec3-4af4-a6a1-219c0ed9ca1c"), new Guid("6abdca2d-0e3f-440d-8e14-c766e232538c"), new DateTime(2024, 2, 22, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6762), "Description for Model2 for Brand 14", "Model2 for Brand 14", new DateTime(2024, 3, 4, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6762) },
                    { new Guid("6f7590ee-6e21-4bea-89be-29eacfe2e30e"), new Guid("017c2115-1986-4e3d-99b2-994d7b76551f"), new DateTime(2023, 8, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6679), "Description for Model2 for Brand 9", "Model2 for Brand 9", new DateTime(2023, 9, 1, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6679) },
                    { new Guid("74f10e37-cdef-413f-95f0-39933de04207"), new Guid("56348f47-d9d8-4f7b-9c26-c9a101719ba7"), new DateTime(2023, 6, 7, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6647), "Description for Model2 for Brand 7", "Model2 for Brand 7", new DateTime(2023, 8, 31, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6647) },
                    { new Guid("7567b10c-d544-49e4-87ba-6cd47d764c11"), new Guid("6abdca2d-0e3f-440d-8e14-c766e232538c"), new DateTime(2023, 9, 16, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6767), "Description for Model3 for Brand 14", "Model3 for Brand 14", new DateTime(2024, 1, 8, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6767) },
                    { new Guid("7621a137-c102-48c7-b95b-c1ef5d24c296"), new Guid("6abdca2d-0e3f-440d-8e14-c766e232538c"), new DateTime(2023, 9, 17, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6758), "Description for Model1 for Brand 14", "Model1 for Brand 14", new DateTime(2023, 12, 2, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6758) },
                    { new Guid("76ac4417-55df-4704-bd3e-02e57325120c"), new Guid("e76da6fe-10a8-4f0e-8cb8-ab45d5ecffb8"), new DateTime(2023, 4, 30, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6561), "Description for Model1 for Brand 2", "Model1 for Brand 2", new DateTime(2023, 12, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6561) },
                    { new Guid("813d6340-e547-405a-ac1c-8fb23bb0127e"), new Guid("e76da6fe-10a8-4f0e-8cb8-ab45d5ecffb8"), new DateTime(2024, 1, 13, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6568), "Description for Model2 for Brand 2", "Model2 for Brand 2", new DateTime(2024, 11, 29, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6568) },
                    { new Guid("840abd5e-2e68-48eb-a565-fc1c81444df8"), new Guid("c76f0799-3256-4801-b03b-d2e5e08b5069"), new DateTime(2023, 6, 3, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6590), "Description for Model3 for Brand 3", "Model3 for Brand 3", new DateTime(2023, 7, 31, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6590) },
                    { new Guid("97d394e3-6705-4462-bde2-7a62d5e10dc6"), new Guid("27529e9e-2fd9-4eba-9be2-10882dde7dad"), new DateTime(2023, 6, 15, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6772), "Description for Model1 for Brand 15", "Model1 for Brand 15", new DateTime(2023, 11, 20, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6772) },
                    { new Guid("9ecd2074-81bf-4dd5-b909-b2dbc8fabfda"), new Guid("4737e704-8385-43ba-a8e8-8371812a0ae0"), new DateTime(2024, 1, 21, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6752), "Description for Model3 for Brand 13", "Model3 for Brand 13", new DateTime(2024, 2, 12, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6752) },
                    { new Guid("a2aae244-24a5-4a76-83c4-c883786f4a04"), new Guid("642ec65d-2cd3-4c8c-8405-230662921e98"), new DateTime(2023, 9, 17, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6688), "Description for Model1 for Brand 10", "Model1 for Brand 10", new DateTime(2024, 6, 29, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6688) },
                    { new Guid("a5a9de0b-95ef-4e2d-841b-5cea4f591469"), new Guid("47967e58-98d9-4a19-b964-576140c23115"), new DateTime(2024, 1, 3, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6526), "Description for Model1 for Brand 1", "Model1 for Brand 1", new DateTime(2024, 9, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6526) },
                    { new Guid("a6888946-d980-4a5c-8cc6-de66b911f5fc"), new Guid("4737e704-8385-43ba-a8e8-8371812a0ae0"), new DateTime(2023, 10, 12, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6747), "Description for Model2 for Brand 13", "Model2 for Brand 13", new DateTime(2023, 11, 23, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6747) },
                    { new Guid("b2a1d2e1-e72b-4928-8cbd-ec22a368cc69"), new Guid("642ec65d-2cd3-4c8c-8405-230662921e98"), new DateTime(2024, 2, 12, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6699), "Description for Model3 for Brand 10", "Model3 for Brand 10", new DateTime(2024, 6, 25, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6699) },
                    { new Guid("b3edf321-12c9-4452-96c7-bdb3105809f9"), new Guid("c5d52da9-7ea7-40de-8f7f-542a40195f3e"), new DateTime(2024, 2, 15, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6664), "Description for Model2 for Brand 8", "Model2 for Brand 8", new DateTime(2024, 5, 21, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6664) },
                    { new Guid("b56b17f3-7b64-4a94-b6e0-e0785a822309"), new Guid("017c2115-1986-4e3d-99b2-994d7b76551f"), new DateTime(2023, 10, 21, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6683), "Description for Model3 for Brand 9", "Model3 for Brand 9", new DateTime(2023, 11, 23, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6683) },
                    { new Guid("c42ff82a-977f-42f4-afc4-d3ab7f83689a"), new Guid("29cb2067-edef-4c3d-9fe8-6b939ac03e0a"), new DateTime(2023, 10, 15, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6596), "Description for Model1 for Brand 4", "Model1 for Brand 4", new DateTime(2024, 3, 14, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6596) },
                    { new Guid("cbc36dcc-5e7f-4a80-b37c-50e2ecccf918"), new Guid("9f1d2f7a-44d7-411c-be98-49f47e44b043"), new DateTime(2024, 1, 18, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6612), "Description for Model1 for Brand 5", "Model1 for Brand 5", new DateTime(2024, 1, 20, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6612) },
                    { new Guid("d52177d2-0c88-4ff0-8aa2-f8e933c7e00f"), new Guid("27529e9e-2fd9-4eba-9be2-10882dde7dad"), new DateTime(2023, 7, 13, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6783), "Description for Model3 for Brand 15", "Model3 for Brand 15", new DateTime(2023, 8, 22, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6783) },
                    { new Guid("dc30c833-47d2-4fb4-b324-96eb988a802c"), new Guid("56348f47-d9d8-4f7b-9c26-c9a101719ba7"), new DateTime(2023, 4, 17, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6654), "Description for Model3 for Brand 7", "Model3 for Brand 7", new DateTime(2023, 11, 29, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6654) },
                    { new Guid("e644b3ac-017e-4dcb-b5f4-10270b08b438"), new Guid("ecb6aa9a-9dad-432c-b746-c508bfa4917e"), new DateTime(2023, 6, 14, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6710), "Description for Model2 for Brand 11", "Model2 for Brand 11", new DateTime(2024, 5, 15, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6710) },
                    { new Guid("ef4c29b1-8124-47e3-9f9e-867b679247df"), new Guid("ecb6aa9a-9dad-432c-b746-c508bfa4917e"), new DateTime(2023, 7, 6, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6720), "Description for Model3 for Brand 11", "Model3 for Brand 11", new DateTime(2023, 11, 14, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6720) },
                    { new Guid("fcba018f-8a72-499d-bfab-aaae4ea1b27b"), new Guid("642ec65d-2cd3-4c8c-8405-230662921e98"), new DateTime(2023, 7, 5, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6695), "Description for Model2 for Brand 10", "Model2 for Brand 10", new DateTime(2024, 5, 26, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6695) },
                    { new Guid("ff5a9ab5-2cbf-4b5f-91d0-33cb3257181e"), new Guid("c5d52da9-7ea7-40de-8f7f-542a40195f3e"), new DateTime(2024, 2, 20, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6669), "Description for Model3 for Brand 8", "Model3 for Brand 8", new DateTime(2024, 10, 9, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6669) }
                });

            migrationBuilder.InsertData(
                table: "CarEntityModel",
                columns: new[] { "Id", "ColorId", "CreateDateTime", "Description", "EngineVolume", "ModelId", "UpdateDateTime" },
                values: new object[,]
                {
                    { new Guid("050d0469-17c6-4b19-8d11-8fbe2020dc67"), new Guid("444ee6c4-5db2-46e2-afa2-1dd9ae24803f"), new DateTime(2023, 4, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6912), "Description for car 9", 3323.0, new Guid("d52177d2-0c88-4ff0-8aa2-f8e933c7e00f"), new DateTime(2023, 4, 24, 22, 5, 14, 775, DateTimeKind.Utc).AddTicks(6912) },
                    { new Guid("1366dd18-bfab-446a-83d2-28c7487c0497"), new Guid("8d2a1524-609e-4bb4-bea6-848dc1b15197"), new DateTime(2023, 8, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6908), "Description for car 7", 4677.0, new Guid("ef4c29b1-8124-47e3-9f9e-867b679247df"), new DateTime(2023, 8, 25, 3, 5, 14, 775, DateTimeKind.Utc).AddTicks(6908) },
                    { new Guid("3904e4dc-1109-4e34-b23e-1c9155afb183"), new Guid("e49387aa-517c-46a7-967b-0b0da0d17113"), new DateTime(2023, 3, 17, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6926), "Description for car 14", 2246.0, new Guid("26c1fd29-182a-4bf0-b27d-6156a0a7fb51"), new DateTime(2023, 3, 17, 22, 5, 14, 775, DateTimeKind.Utc).AddTicks(6926) },
                    { new Guid("3aea5735-a5d6-4332-90c5-69dde645dd1f"), new Guid("316c5ce2-4101-4a51-ae18-adc78a540b33"), new DateTime(2023, 7, 4, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6879), "Description for car 1", 2606.0, new Guid("5e363668-4c62-450a-a1f6-1b8a88d0342b"), new DateTime(2023, 7, 5, 3, 5, 14, 775, DateTimeKind.Utc).AddTicks(6879) },
                    { new Guid("3f1f99a4-b4a3-4070-b027-cddaed606467"), new Guid("22eba9cc-bf1c-40e1-8f13-0dba18a37fbe"), new DateTime(2023, 9, 25, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6918), "Description for car 11", 1404.0, new Guid("19673770-7b54-4910-9364-3a2ca41c640b"), new DateTime(2023, 9, 26, 4, 5, 14, 775, DateTimeKind.Utc).AddTicks(6918) },
                    { new Guid("3fc4dab4-977c-4333-b6c5-b965ed1b7e2a"), new Guid("cb8e3e1a-8c4b-4406-877a-838e46adce69"), new DateTime(2023, 8, 26, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6932), "Description for car 16", 2459.0, new Guid("64672665-8ec3-4af4-a6a1-219c0ed9ca1c"), new DateTime(2023, 8, 26, 19, 5, 14, 775, DateTimeKind.Utc).AddTicks(6932) },
                    { new Guid("47b7149c-8a83-4a8e-9a3c-01b6cb8fd5b8"), new Guid("316c5ce2-4101-4a51-ae18-adc78a540b33"), new DateTime(2024, 2, 12, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6888), "Description for car 3", 1216.0, new Guid("64672665-8ec3-4af4-a6a1-219c0ed9ca1c"), new DateTime(2024, 2, 12, 20, 5, 14, 775, DateTimeKind.Utc).AddTicks(6888) },
                    { new Guid("6f5578b9-7c05-4f93-b74d-bd7cef606f53"), new Guid("316c5ce2-4101-4a51-ae18-adc78a540b33"), new DateTime(2023, 3, 4, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6921), "Description for car 12", 1891.0, new Guid("b2a1d2e1-e72b-4928-8cbd-ec22a368cc69"), new DateTime(2023, 3, 4, 17, 5, 14, 775, DateTimeKind.Utc).AddTicks(6921) },
                    { new Guid("7f05f7a5-5c96-43f7-b658-46acf1eb12ed"), new Guid("2eb1c35c-b4f3-4be7-b7e9-b91ba418fee2"), new DateTime(2023, 9, 3, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6910), "Description for car 8", 3979.0, new Guid("26c1fd29-182a-4bf0-b27d-6156a0a7fb51"), new DateTime(2023, 9, 3, 19, 5, 14, 775, DateTimeKind.Utc).AddTicks(6910) },
                    { new Guid("823924dd-a0e1-4b90-b94f-e5783d5b3ebb"), new Guid("af1a0f5a-516c-4efd-b077-3dc806b02d7c"), new DateTime(2023, 12, 27, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6935), "Description for car 17", 3941.0, new Guid("813d6340-e547-405a-ac1c-8fb23bb0127e"), new DateTime(2023, 12, 28, 4, 5, 14, 775, DateTimeKind.Utc).AddTicks(6935) },
                    { new Guid("a7f3d26e-d1ed-448b-aa57-718a5b479bd0"), new Guid("22eba9cc-bf1c-40e1-8f13-0dba18a37fbe"), new DateTime(2024, 2, 7, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6916), "Description for car 10", 4980.0, new Guid("ff5a9ab5-2cbf-4b5f-91d0-33cb3257181e"), new DateTime(2024, 2, 7, 21, 5, 14, 775, DateTimeKind.Utc).AddTicks(6916) },
                    { new Guid("a9609054-a4ab-47b5-b2e2-a4413320b43a"), new Guid("f68ab9f6-caf2-4f30-a9ca-30fd68f630c8"), new DateTime(2023, 8, 26, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6893), "Description for car 5", 3728.0, new Guid("19673770-7b54-4910-9364-3a2ca41c640b"), new DateTime(2023, 8, 27, 8, 5, 14, 775, DateTimeKind.Utc).AddTicks(6893) },
                    { new Guid("b00c374e-bf15-4cd7-9225-50617e7d3617"), new Guid("22eba9cc-bf1c-40e1-8f13-0dba18a37fbe"), new DateTime(2023, 8, 7, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6923), "Description for car 13", 4466.0, new Guid("5c95e9bf-1965-43a1-a37e-30a2595c5d52"), new DateTime(2023, 8, 7, 18, 5, 14, 775, DateTimeKind.Utc).AddTicks(6923) },
                    { new Guid("c2c513b9-e6b7-47d5-9424-cd8c4d74aa49"), new Guid("62e1f37b-7ef9-466e-89cf-4bc4fc5b877a"), new DateTime(2023, 11, 16, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6943), "Description for car 20", 3062.0, new Guid("08950379-d767-450e-8be7-5a59235262c4"), new DateTime(2023, 11, 17, 11, 5, 14, 775, DateTimeKind.Utc).AddTicks(6943) },
                    { new Guid("c35bc2dd-4ccc-4804-97fc-bf0b29afae5a"), new Guid("444ee6c4-5db2-46e2-afa2-1dd9ae24803f"), new DateTime(2023, 8, 26, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6940), "Description for car 19", 4937.0, new Guid("5c95e9bf-1965-43a1-a37e-30a2595c5d52"), new DateTime(2023, 8, 26, 19, 5, 14, 775, DateTimeKind.Utc).AddTicks(6940) },
                    { new Guid("c62d8f27-c142-4c14-8ab7-adc86f1aa001"), new Guid("6fb910df-ec79-4f6e-a5a1-8a1064698cb8"), new DateTime(2023, 11, 8, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6930), "Description for car 15", 4756.0, new Guid("74f10e37-cdef-413f-95f0-39933de04207"), new DateTime(2023, 11, 8, 16, 5, 14, 775, DateTimeKind.Utc).AddTicks(6930) },
                    { new Guid("cec34d58-4761-4cb8-bb1f-ef9b9d1f41b3"), new Guid("62e1f37b-7ef9-466e-89cf-4bc4fc5b877a"), new DateTime(2023, 10, 28, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6938), "Description for car 18", 3514.0, new Guid("fcba018f-8a72-499d-bfab-aaae4ea1b27b"), new DateTime(2023, 10, 29, 11, 5, 14, 775, DateTimeKind.Utc).AddTicks(6938) },
                    { new Guid("d451c319-ecf8-4b31-852f-763a26533831"), new Guid("8d2a1524-609e-4bb4-bea6-848dc1b15197"), new DateTime(2023, 4, 12, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6903), "Description for car 6", 3314.0, new Guid("ff5a9ab5-2cbf-4b5f-91d0-33cb3257181e"), new DateTime(2023, 4, 12, 21, 5, 14, 775, DateTimeKind.Utc).AddTicks(6903) },
                    { new Guid("d66269a4-8ec6-41f5-9a4a-a8c03dc5f952"), new Guid("8d2a1524-609e-4bb4-bea6-848dc1b15197"), new DateTime(2024, 2, 1, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6886), "Description for car 2", 3390.0, new Guid("d52177d2-0c88-4ff0-8aa2-f8e933c7e00f"), new DateTime(2024, 2, 1, 19, 5, 14, 775, DateTimeKind.Utc).AddTicks(6886) },
                    { new Guid("edbd8ae2-9111-4bbd-b0bc-7ace76ffd1b3"), new Guid("6fb910df-ec79-4f6e-a5a1-8a1064698cb8"), new DateTime(2023, 9, 18, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(6891), "Description for car 4", 1669.0, new Guid("813d6340-e547-405a-ac1c-8fb23bb0127e"), new DateTime(2023, 9, 19, 8, 5, 14, 775, DateTimeKind.Utc).AddTicks(6891) }
                });

            migrationBuilder.InsertData(
                table: "CarPhotoEntityModel",
                columns: new[] { "Id", "CarId", "PhotoUrl" },
                values: new object[,]
                {
                    { new Guid("0687e878-51e3-41c9-94cd-c20b78b5992a"), new Guid("a9609054-a4ab-47b5-b2e2-a4413320b43a"), "https://example.com/photo1.jpg" },
                    { new Guid("076b1cd5-d5ce-4ff7-84c2-cb834a19bc10"), new Guid("3aea5735-a5d6-4332-90c5-69dde645dd1f"), "https://example.com/photo3.jpg" },
                    { new Guid("09844346-7520-4b8f-baf9-17f30d71da3c"), new Guid("3fc4dab4-977c-4333-b6c5-b965ed1b7e2a"), "https://example.com/photo2.jpg" },
                    { new Guid("298741cc-6864-4ac9-aaba-51d043725fed"), new Guid("c62d8f27-c142-4c14-8ab7-adc86f1aa001"), "https://example.com/photo2.jpg" },
                    { new Guid("2c63e564-1de8-4680-8c27-6a8def827033"), new Guid("a7f3d26e-d1ed-448b-aa57-718a5b479bd0"), "https://example.com/photo1.jpg" },
                    { new Guid("2ddd062c-9342-400b-a48d-8a035c53901f"), new Guid("050d0469-17c6-4b19-8d11-8fbe2020dc67"), "https://example.com/photo1.jpg" },
                    { new Guid("3da8d7f7-554e-48a6-8f85-f363bd3eee92"), new Guid("47b7149c-8a83-4a8e-9a3c-01b6cb8fd5b8"), "https://example.com/photo1.jpg" },
                    { new Guid("3e91993e-417b-4e37-a2be-ed0103d21694"), new Guid("6f5578b9-7c05-4f93-b74d-bd7cef606f53"), "https://example.com/photo1.jpg" },
                    { new Guid("45e14afb-1019-4082-a5b7-c38b8034f5b0"), new Guid("d451c319-ecf8-4b31-852f-763a26533831"), "https://example.com/photo2.jpg" },
                    { new Guid("46e4fbdb-32da-4ee0-92bd-a508b3d40400"), new Guid("823924dd-a0e1-4b90-b94f-e5783d5b3ebb"), "https://example.com/photo4.jpg" },
                    { new Guid("51932cea-0d69-429e-969a-e1e7147be20a"), new Guid("823924dd-a0e1-4b90-b94f-e5783d5b3ebb"), "https://example.com/photo2.jpg" },
                    { new Guid("54a565e6-232d-4bb0-9eb8-6f74570e672e"), new Guid("3f1f99a4-b4a3-4070-b027-cddaed606467"), "https://example.com/photo3.jpg" },
                    { new Guid("6c2621af-e178-467b-b7b4-2b89aa5a9689"), new Guid("edbd8ae2-9111-4bbd-b0bc-7ace76ffd1b3"), "https://example.com/photo2.jpg" },
                    { new Guid("6fc3f95e-4898-4a63-925b-f72c829ed8e8"), new Guid("b00c374e-bf15-4cd7-9225-50617e7d3617"), "https://example.com/photo4.jpg" },
                    { new Guid("73acdc4f-38df-4477-9099-6a3f0019751a"), new Guid("3aea5735-a5d6-4332-90c5-69dde645dd1f"), "https://example.com/photo1.jpg" },
                    { new Guid("741915a5-39c3-47a3-a879-d59b8e453229"), new Guid("823924dd-a0e1-4b90-b94f-e5783d5b3ebb"), "https://example.com/photo1.jpg" },
                    { new Guid("77352bb3-5222-491b-839b-07be15c4cefb"), new Guid("c62d8f27-c142-4c14-8ab7-adc86f1aa001"), "https://example.com/photo3.jpg" },
                    { new Guid("7abda3a7-8266-465d-ab6b-437d05406aba"), new Guid("7f05f7a5-5c96-43f7-b658-46acf1eb12ed"), "https://example.com/photo1.jpg" },
                    { new Guid("81315449-819c-4e8f-a1ad-49520f076a25"), new Guid("d66269a4-8ec6-41f5-9a4a-a8c03dc5f952"), "https://example.com/photo1.jpg" },
                    { new Guid("81587924-e032-4be5-a683-0721e4cf43e6"), new Guid("b00c374e-bf15-4cd7-9225-50617e7d3617"), "https://example.com/photo2.jpg" },
                    { new Guid("854a1805-e057-400f-aa48-f331ae6ef06b"), new Guid("edbd8ae2-9111-4bbd-b0bc-7ace76ffd1b3"), "https://example.com/photo1.jpg" },
                    { new Guid("8777bc79-25ee-4bfc-b2cb-ead502e468dc"), new Guid("c2c513b9-e6b7-47d5-9424-cd8c4d74aa49"), "https://example.com/photo1.jpg" },
                    { new Guid("9a693ed3-0cb3-4add-99ff-5ec904cc69a0"), new Guid("b00c374e-bf15-4cd7-9225-50617e7d3617"), "https://example.com/photo3.jpg" },
                    { new Guid("9dde24ec-fdd7-45fd-a6ec-31b45dd9ebcd"), new Guid("d451c319-ecf8-4b31-852f-763a26533831"), "https://example.com/photo1.jpg" },
                    { new Guid("a769bf8f-a667-470e-befb-ed7c261af80c"), new Guid("c62d8f27-c142-4c14-8ab7-adc86f1aa001"), "https://example.com/photo1.jpg" },
                    { new Guid("a9fb9323-256d-4058-99c8-5cc3ed60659a"), new Guid("3f1f99a4-b4a3-4070-b027-cddaed606467"), "https://example.com/photo2.jpg" },
                    { new Guid("abc6a408-ef17-41a2-9614-e1bcfc5704e5"), new Guid("3aea5735-a5d6-4332-90c5-69dde645dd1f"), "https://example.com/photo2.jpg" },
                    { new Guid("af5699a0-0b56-4ce4-b3a1-8e035e283566"), new Guid("b00c374e-bf15-4cd7-9225-50617e7d3617"), "https://example.com/photo1.jpg" },
                    { new Guid("b333257d-b1f4-470f-b31c-1211d777633b"), new Guid("7f05f7a5-5c96-43f7-b658-46acf1eb12ed"), "https://example.com/photo2.jpg" },
                    { new Guid("d1ae4b44-4b4c-4312-bef6-44c87fbf260f"), new Guid("d66269a4-8ec6-41f5-9a4a-a8c03dc5f952"), "https://example.com/photo2.jpg" },
                    { new Guid("d6d68c85-8e12-4f29-b4ac-d4af91e7abc6"), new Guid("c35bc2dd-4ccc-4804-97fc-bf0b29afae5a"), "https://example.com/photo1.jpg" },
                    { new Guid("dbd4e3d2-9ce5-469f-b464-50fde407420a"), new Guid("3fc4dab4-977c-4333-b6c5-b965ed1b7e2a"), "https://example.com/photo1.jpg" },
                    { new Guid("dcf903b8-4834-4692-ab9b-0df2c4c9c08d"), new Guid("3f1f99a4-b4a3-4070-b027-cddaed606467"), "https://example.com/photo1.jpg" },
                    { new Guid("fb522dd4-9373-43be-8380-0198c8d24ffc"), new Guid("6f5578b9-7c05-4f93-b74d-bd7cef606f53"), "https://example.com/photo2.jpg" },
                    { new Guid("fe1b979e-77aa-4a9c-9bf8-c46f4dcd33eb"), new Guid("823924dd-a0e1-4b90-b94f-e5783d5b3ebb"), "https://example.com/photo3.jpg" }
                });

            migrationBuilder.InsertData(
                table: "PriceHistoryEntityModel",
                columns: new[] { "Id", "CarId", "CreateDateTime", "CurrencyId", "Price", "StartDate", "UpdateDateTime" },
                values: new object[,]
                {
                    { new Guid("02483318-3d00-4163-9fbc-9ce0fa42c309"), new Guid("3904e4dc-1109-4e34-b23e-1c9155afb183"), new DateTime(2024, 1, 27, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7249), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 227.0, new DateTime(2023, 8, 28, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7248), new DateTime(2024, 1, 28, 0, 5, 14, 775, DateTimeKind.Utc).AddTicks(7249) },
                    { new Guid("050a312f-5de9-4e72-b9bd-94cbbb03e039"), new Guid("47b7149c-8a83-4a8e-9a3c-01b6cb8fd5b8"), new DateTime(2024, 2, 13, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7169), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 96.0, new DateTime(2023, 7, 22, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7169), new DateTime(2024, 2, 13, 23, 5, 14, 775, DateTimeKind.Utc).AddTicks(7169) },
                    { new Guid("07afb832-c5fe-4659-84a0-819f0ae91d81"), new Guid("a7f3d26e-d1ed-448b-aa57-718a5b479bd0"), new DateTime(2024, 1, 31, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7212), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 997.0, new DateTime(2023, 9, 22, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7211), new DateTime(2024, 1, 31, 22, 5, 14, 775, DateTimeKind.Utc).AddTicks(7212) },
                    { new Guid("08277cea-d713-4563-add2-a5cc997b4c56"), new Guid("47b7149c-8a83-4a8e-9a3c-01b6cb8fd5b8"), new DateTime(2024, 2, 1, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7167), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 657.0, new DateTime(2024, 1, 21, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7166), new DateTime(2024, 2, 2, 4, 5, 14, 775, DateTimeKind.Utc).AddTicks(7167) },
                    { new Guid("0ef9203b-74e5-4240-a384-3f7ae5e5bd4c"), new Guid("d451c319-ecf8-4b31-852f-763a26533831"), new DateTime(2024, 2, 8, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7187), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 352.0, new DateTime(2023, 7, 10, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7187), new DateTime(2024, 2, 8, 16, 5, 14, 775, DateTimeKind.Utc).AddTicks(7187) },
                    { new Guid("0fce71da-00cc-40ce-aff3-89c7888cb5e1"), new Guid("b00c374e-bf15-4cd7-9225-50617e7d3617"), new DateTime(2024, 2, 17, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7239), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 24.0, new DateTime(2023, 3, 27, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7238), new DateTime(2024, 2, 17, 14, 5, 14, 775, DateTimeKind.Utc).AddTicks(7239) },
                    { new Guid("11eac694-8d5f-4d19-8dca-ae658e7f344d"), new Guid("b00c374e-bf15-4cd7-9225-50617e7d3617"), new DateTime(2024, 1, 26, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7236), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 233.0, new DateTime(2024, 1, 15, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7236), new DateTime(2024, 1, 27, 7, 5, 14, 775, DateTimeKind.Utc).AddTicks(7236) },
                    { new Guid("232d6340-7264-49e3-9450-eb100b5ea33c"), new Guid("823924dd-a0e1-4b90-b94f-e5783d5b3ebb"), new DateTime(2024, 2, 4, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7263), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 802.0, new DateTime(2023, 7, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7262), new DateTime(2024, 2, 5, 3, 5, 14, 775, DateTimeKind.Utc).AddTicks(7263) },
                    { new Guid("290584a6-44be-4c10-bdbf-d0872304d965"), new Guid("cec34d58-4761-4cb8-bb1f-ef9b9d1f41b3"), new DateTime(2024, 2, 22, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7270), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 379.0, new DateTime(2023, 4, 10, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7269), new DateTime(2024, 2, 23, 10, 5, 14, 775, DateTimeKind.Utc).AddTicks(7270) },
                    { new Guid("2b2911bb-b759-48b3-a01a-c4551af40519"), new Guid("050d0469-17c6-4b19-8d11-8fbe2020dc67"), new DateTime(2024, 2, 16, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7207), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 495.0, new DateTime(2024, 2, 22, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7206), new DateTime(2024, 2, 17, 0, 5, 14, 775, DateTimeKind.Utc).AddTicks(7207) },
                    { new Guid("2efa4fe2-1bea-4279-bca5-1fc01f436bac"), new Guid("47b7149c-8a83-4a8e-9a3c-01b6cb8fd5b8"), new DateTime(2024, 2, 11, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7163), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 196.0, new DateTime(2023, 10, 5, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7163), new DateTime(2024, 2, 12, 2, 5, 14, 775, DateTimeKind.Utc).AddTicks(7163) },
                    { new Guid("2f38dded-dd19-41df-8e95-41d745a3a697"), new Guid("c35bc2dd-4ccc-4804-97fc-bf0b29afae5a"), new DateTime(2024, 2, 20, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7281), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 115.0, new DateTime(2023, 11, 4, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7280), new DateTime(2024, 2, 20, 22, 5, 14, 775, DateTimeKind.Utc).AddTicks(7281) },
                    { new Guid("2f68afb7-38fa-4125-a5b6-c6dddafa60b6"), new Guid("c2c513b9-e6b7-47d5-9424-cd8c4d74aa49"), new DateTime(2024, 2, 11, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7286), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 585.0, new DateTime(2023, 6, 6, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7285), new DateTime(2024, 2, 12, 3, 5, 14, 775, DateTimeKind.Utc).AddTicks(7286) },
                    { new Guid("35b21b72-72a9-4f5f-9ca6-5a4047bd5d0a"), new Guid("d451c319-ecf8-4b31-852f-763a26533831"), new DateTime(2024, 2, 4, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7182), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 461.0, new DateTime(2023, 8, 28, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7182), new DateTime(2024, 2, 5, 11, 5, 14, 775, DateTimeKind.Utc).AddTicks(7182) },
                    { new Guid("49f46490-b44b-4de4-bbf5-954c54538fa8"), new Guid("3fc4dab4-977c-4333-b6c5-b965ed1b7e2a"), new DateTime(2024, 2, 12, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7254), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 616.0, new DateTime(2024, 1, 2, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7253), new DateTime(2024, 2, 12, 18, 5, 14, 775, DateTimeKind.Utc).AddTicks(7254) },
                    { new Guid("57701f2c-a735-4f21-9df5-c6e79067f37e"), new Guid("a7f3d26e-d1ed-448b-aa57-718a5b479bd0"), new DateTime(2024, 2, 19, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7216), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 903.0, new DateTime(2023, 8, 15, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7216), new DateTime(2024, 2, 20, 6, 5, 14, 775, DateTimeKind.Utc).AddTicks(7216) },
                    { new Guid("689ab377-9ecb-4753-a783-287e22a9c156"), new Guid("1366dd18-bfab-446a-83d2-28c7487c0497"), new DateTime(2024, 1, 27, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7194), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 23.0, new DateTime(2023, 3, 21, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7193), new DateTime(2024, 1, 28, 10, 5, 14, 775, DateTimeKind.Utc).AddTicks(7194) },
                    { new Guid("68a67248-7223-4b9b-88a6-71f303f6e513"), new Guid("823924dd-a0e1-4b90-b94f-e5783d5b3ebb"), new DateTime(2024, 2, 6, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7265), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 992.0, new DateTime(2023, 12, 30, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7265), new DateTime(2024, 2, 6, 17, 5, 14, 775, DateTimeKind.Utc).AddTicks(7265) },
                    { new Guid("6a7ec65a-13bb-40a6-96b5-19acb37d6844"), new Guid("d66269a4-8ec6-41f5-9a4a-a8c03dc5f952"), new DateTime(2024, 1, 29, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7160), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 275.0, new DateTime(2023, 8, 19, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7160), new DateTime(2024, 1, 30, 2, 5, 14, 775, DateTimeKind.Utc).AddTicks(7160) },
                    { new Guid("6c768c71-372e-4fde-804d-d7f4797c2b08"), new Guid("3f1f99a4-b4a3-4070-b027-cddaed606467"), new DateTime(2024, 2, 12, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7221), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 731.0, new DateTime(2023, 4, 4, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7221), new DateTime(2024, 2, 13, 6, 5, 14, 775, DateTimeKind.Utc).AddTicks(7221) },
                    { new Guid("7669d1ec-26e3-47b9-984f-3be119af6e9a"), new Guid("cec34d58-4761-4cb8-bb1f-ef9b9d1f41b3"), new DateTime(2024, 2, 10, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7276), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 783.0, new DateTime(2023, 8, 19, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7276), new DateTime(2024, 2, 11, 4, 5, 14, 775, DateTimeKind.Utc).AddTicks(7276) },
                    { new Guid("789299d7-c646-4a52-bf1a-bf1dd52c9257"), new Guid("1366dd18-bfab-446a-83d2-28c7487c0497"), new DateTime(2024, 2, 15, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7189), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 710.0, new DateTime(2023, 8, 13, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7189), new DateTime(2024, 2, 16, 8, 5, 14, 775, DateTimeKind.Utc).AddTicks(7189) },
                    { new Guid("78999fbd-cfe0-42e7-8781-da298d3bf89d"), new Guid("050d0469-17c6-4b19-8d11-8fbe2020dc67"), new DateTime(2024, 1, 30, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7209), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 52.0, new DateTime(2023, 11, 29, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7209), new DateTime(2024, 1, 30, 23, 5, 14, 775, DateTimeKind.Utc).AddTicks(7209) },
                    { new Guid("7bc0db6b-6b6e-40f2-8599-9ebc80a234a9"), new Guid("a9609054-a4ab-47b5-b2e2-a4413320b43a"), new DateTime(2024, 2, 20, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7177), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 538.0, new DateTime(2024, 2, 5, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7177), new DateTime(2024, 2, 20, 19, 5, 14, 775, DateTimeKind.Utc).AddTicks(7177) },
                    { new Guid("83548c59-cf4a-409d-9685-87eb023b126a"), new Guid("cec34d58-4761-4cb8-bb1f-ef9b9d1f41b3"), new DateTime(2024, 2, 15, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7274), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 187.0, new DateTime(2023, 11, 27, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7274), new DateTime(2024, 2, 16, 7, 5, 14, 775, DateTimeKind.Utc).AddTicks(7274) },
                    { new Guid("899206af-371e-4efd-89db-7535228946dd"), new Guid("7f05f7a5-5c96-43f7-b658-46acf1eb12ed"), new DateTime(2024, 1, 26, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7204), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 455.0, new DateTime(2023, 10, 26, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7204), new DateTime(2024, 1, 26, 14, 5, 14, 775, DateTimeKind.Utc).AddTicks(7204) },
                    { new Guid("96b10daa-3686-4135-af72-9027683cbeb9"), new Guid("d66269a4-8ec6-41f5-9a4a-a8c03dc5f952"), new DateTime(2024, 2, 12, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7158), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 686.0, new DateTime(2024, 2, 1, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7157), new DateTime(2024, 2, 13, 7, 5, 14, 775, DateTimeKind.Utc).AddTicks(7158) },
                    { new Guid("a6b45550-cdf8-4a31-a47f-d2126148e526"), new Guid("3aea5735-a5d6-4332-90c5-69dde645dd1f"), new DateTime(2024, 1, 30, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7152), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 527.0, new DateTime(2023, 10, 12, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7152), new DateTime(2024, 1, 31, 9, 5, 14, 775, DateTimeKind.Utc).AddTicks(7152) },
                    { new Guid("a868b4e6-e276-442c-a2fc-8a4f9c89c4d5"), new Guid("3904e4dc-1109-4e34-b23e-1c9155afb183"), new DateTime(2024, 2, 2, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7246), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 981.0, new DateTime(2024, 2, 21, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7245), new DateTime(2024, 2, 3, 7, 5, 14, 775, DateTimeKind.Utc).AddTicks(7246) },
                    { new Guid("ab029b25-f0ad-4928-b8eb-f837cf2a278f"), new Guid("3fc4dab4-977c-4333-b6c5-b965ed1b7e2a"), new DateTime(2024, 2, 11, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7258), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 737.0, new DateTime(2023, 11, 14, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7258), new DateTime(2024, 2, 12, 11, 5, 14, 775, DateTimeKind.Utc).AddTicks(7258) },
                    { new Guid("bbe35c1f-6cfa-4f2b-bb47-3bdecda5470a"), new Guid("6f5578b9-7c05-4f93-b74d-bd7cef606f53"), new DateTime(2024, 2, 7, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7225), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 62.0, new DateTime(2023, 3, 26, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7225), new DateTime(2024, 2, 8, 10, 5, 14, 775, DateTimeKind.Utc).AddTicks(7225) },
                    { new Guid("cbba1fe7-742d-45d4-8102-3bb8a4208510"), new Guid("a7f3d26e-d1ed-448b-aa57-718a5b479bd0"), new DateTime(2024, 2, 13, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7214), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 459.0, new DateTime(2023, 3, 5, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7214), new DateTime(2024, 2, 14, 8, 5, 14, 775, DateTimeKind.Utc).AddTicks(7214) },
                    { new Guid("cc271dd2-9cd0-451e-aea1-378e19ec88ca"), new Guid("c35bc2dd-4ccc-4804-97fc-bf0b29afae5a"), new DateTime(2024, 2, 12, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7279), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 74.0, new DateTime(2023, 4, 17, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7278), new DateTime(2024, 2, 12, 15, 5, 14, 775, DateTimeKind.Utc).AddTicks(7279) },
                    { new Guid("d032c459-2c60-4871-bd3f-fc20b95c9c9f"), new Guid("6f5578b9-7c05-4f93-b74d-bd7cef606f53"), new DateTime(2024, 2, 17, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7228), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 488.0, new DateTime(2023, 11, 29, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7227), new DateTime(2024, 2, 18, 1, 5, 14, 775, DateTimeKind.Utc).AddTicks(7228) },
                    { new Guid("d17f06e0-c3d4-4ca4-8694-f8fe69695db5"), new Guid("cec34d58-4761-4cb8-bb1f-ef9b9d1f41b3"), new DateTime(2024, 2, 22, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7268), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 353.0, new DateTime(2023, 3, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7267), new DateTime(2024, 2, 22, 21, 5, 14, 775, DateTimeKind.Utc).AddTicks(7268) },
                    { new Guid("d24354a2-4ab4-40aa-8f46-6ff863e5457d"), new Guid("1366dd18-bfab-446a-83d2-28c7487c0497"), new DateTime(2024, 2, 17, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7196), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 445.0, new DateTime(2023, 5, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7196), new DateTime(2024, 2, 17, 19, 5, 14, 775, DateTimeKind.Utc).AddTicks(7196) },
                    { new Guid("d739f8e7-798e-4c29-adcb-8435f082283a"), new Guid("c35bc2dd-4ccc-4804-97fc-bf0b29afae5a"), new DateTime(2024, 1, 27, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7283), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 734.0, new DateTime(2023, 8, 16, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7283), new DateTime(2024, 1, 27, 15, 5, 14, 775, DateTimeKind.Utc).AddTicks(7283) },
                    { new Guid("db23badd-a781-4dd5-8b60-d8aaff3aab63"), new Guid("d451c319-ecf8-4b31-852f-763a26533831"), new DateTime(2024, 2, 11, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7185), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 558.0, new DateTime(2023, 3, 6, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7184), new DateTime(2024, 2, 11, 21, 5, 14, 775, DateTimeKind.Utc).AddTicks(7185) },
                    { new Guid("dbd5ad58-e49f-4b28-88b7-da8737562a2e"), new Guid("3fc4dab4-977c-4333-b6c5-b965ed1b7e2a"), new DateTime(2024, 2, 15, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7256), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 334.0, new DateTime(2024, 2, 17, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7256), new DateTime(2024, 2, 16, 3, 5, 14, 775, DateTimeKind.Utc).AddTicks(7256) },
                    { new Guid("dc37a912-631b-4cb1-82bf-3c36f1360934"), new Guid("edbd8ae2-9111-4bbd-b0bc-7ace76ffd1b3"), new DateTime(2024, 2, 12, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7174), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 771.0, new DateTime(2023, 11, 28, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7174), new DateTime(2024, 2, 12, 16, 5, 14, 775, DateTimeKind.Utc).AddTicks(7174) },
                    { new Guid("e5f56d3c-410d-4a31-b0f4-a26d6c76d4d8"), new Guid("b00c374e-bf15-4cd7-9225-50617e7d3617"), new DateTime(2024, 2, 8, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7241), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 924.0, new DateTime(2023, 12, 17, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7240), new DateTime(2024, 2, 9, 7, 5, 14, 775, DateTimeKind.Utc).AddTicks(7241) },
                    { new Guid("e69901d6-02e5-4bc8-bee5-d75e4a3cfa54"), new Guid("3904e4dc-1109-4e34-b23e-1c9155afb183"), new DateTime(2024, 1, 28, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7243), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 569.0, new DateTime(2023, 5, 24, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7243), new DateTime(2024, 1, 28, 17, 5, 14, 775, DateTimeKind.Utc).AddTicks(7243) },
                    { new Guid("e7f954f0-7590-4ebb-932a-26242dbcbd5b"), new Guid("3f1f99a4-b4a3-4070-b027-cddaed606467"), new DateTime(2024, 2, 4, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7219), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 238.0, new DateTime(2023, 5, 12, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7218), new DateTime(2024, 2, 4, 21, 5, 14, 775, DateTimeKind.Utc).AddTicks(7219) },
                    { new Guid("eb2e671d-f44e-42bd-9981-feb3dce71fa9"), new Guid("1366dd18-bfab-446a-83d2-28c7487c0497"), new DateTime(2024, 2, 18, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7192), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 336.0, new DateTime(2023, 5, 17, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7191), new DateTime(2024, 2, 18, 16, 5, 14, 775, DateTimeKind.Utc).AddTicks(7192) },
                    { new Guid("f37cf12a-a294-4a65-a449-b092dbe50b61"), new Guid("823924dd-a0e1-4b90-b94f-e5783d5b3ebb"), new DateTime(2024, 1, 29, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7261), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 856.0, new DateTime(2023, 12, 20, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7260), new DateTime(2024, 1, 29, 23, 5, 14, 775, DateTimeKind.Utc).AddTicks(7261) },
                    { new Guid("f5b8ca47-ff39-4dd2-adbc-2c1b3af55236"), new Guid("edbd8ae2-9111-4bbd-b0bc-7ace76ffd1b3"), new DateTime(2024, 2, 1, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7172), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 278.0, new DateTime(2023, 4, 18, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7171), new DateTime(2024, 2, 2, 10, 5, 14, 775, DateTimeKind.Utc).AddTicks(7172) },
                    { new Guid("f8b78c2d-1529-464f-9172-4bc93cd7f87e"), new Guid("3aea5735-a5d6-4332-90c5-69dde645dd1f"), new DateTime(2024, 2, 16, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7136), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 588.0, new DateTime(2024, 1, 25, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7135), new DateTime(2024, 2, 17, 2, 5, 14, 775, DateTimeKind.Utc).AddTicks(7136) },
                    { new Guid("ff6871ec-1cff-4ea8-b577-43fd97a151a8"), new Guid("7f05f7a5-5c96-43f7-b658-46acf1eb12ed"), new DateTime(2024, 2, 6, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7200), new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"), 196.0, new DateTime(2023, 10, 19, 13, 5, 14, 775, DateTimeKind.Utc).AddTicks(7199), new DateTime(2024, 2, 7, 3, 5, 14, 775, DateTimeKind.Utc).AddTicks(7200) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("0687e878-51e3-41c9-94cd-c20b78b5992a"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("076b1cd5-d5ce-4ff7-84c2-cb834a19bc10"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("09844346-7520-4b8f-baf9-17f30d71da3c"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("298741cc-6864-4ac9-aaba-51d043725fed"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("2c63e564-1de8-4680-8c27-6a8def827033"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("2ddd062c-9342-400b-a48d-8a035c53901f"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("3da8d7f7-554e-48a6-8f85-f363bd3eee92"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("3e91993e-417b-4e37-a2be-ed0103d21694"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("45e14afb-1019-4082-a5b7-c38b8034f5b0"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("46e4fbdb-32da-4ee0-92bd-a508b3d40400"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("51932cea-0d69-429e-969a-e1e7147be20a"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("54a565e6-232d-4bb0-9eb8-6f74570e672e"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("6c2621af-e178-467b-b7b4-2b89aa5a9689"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("6fc3f95e-4898-4a63-925b-f72c829ed8e8"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("73acdc4f-38df-4477-9099-6a3f0019751a"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("741915a5-39c3-47a3-a879-d59b8e453229"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("77352bb3-5222-491b-839b-07be15c4cefb"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("7abda3a7-8266-465d-ab6b-437d05406aba"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("81315449-819c-4e8f-a1ad-49520f076a25"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("81587924-e032-4be5-a683-0721e4cf43e6"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("854a1805-e057-400f-aa48-f331ae6ef06b"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("8777bc79-25ee-4bfc-b2cb-ead502e468dc"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("9a693ed3-0cb3-4add-99ff-5ec904cc69a0"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("9dde24ec-fdd7-45fd-a6ec-31b45dd9ebcd"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("a769bf8f-a667-470e-befb-ed7c261af80c"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("a9fb9323-256d-4058-99c8-5cc3ed60659a"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("abc6a408-ef17-41a2-9614-e1bcfc5704e5"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("af5699a0-0b56-4ce4-b3a1-8e035e283566"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("b333257d-b1f4-470f-b31c-1211d777633b"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("d1ae4b44-4b4c-4312-bef6-44c87fbf260f"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("d6d68c85-8e12-4f29-b4ac-d4af91e7abc6"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("dbd4e3d2-9ce5-469f-b464-50fde407420a"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("dcf903b8-4834-4692-ab9b-0df2c4c9c08d"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("fb522dd4-9373-43be-8380-0198c8d24ffc"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("fe1b979e-77aa-4a9c-9bf8-c46f4dcd33eb"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("3968fd73-ef88-44bd-a9db-1c86f12ef11e"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("992ad250-2a1f-4e01-bc1b-b652627b179e"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("ca8f2b3f-7ae3-40ab-b411-835a249543e4"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("d173f7c3-9d79-4abd-875d-50d2ea44b9c2"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("09f97d76-3f54-4e75-a032-a3fea77c0ae9"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("0a07c028-7075-4298-bb86-3774ed47d70e"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("0ae9c1b2-763b-4e53-93a3-a04f0529ba35"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("1679dbe4-17ab-43dd-8d41-315f275e9577"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("16ceeea8-98ea-4556-9e6b-3825e3ff4e62"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("239a0d2d-2b00-4d35-9561-6121dc71093c"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("24faa202-d3c2-433d-bffc-cfbd05e4e984"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("30298cb2-4f76-4b8a-b6db-8cd3aae93766"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("38d83291-7ca7-467b-beb0-1c1b030d89de"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("3ddab50e-83fa-4017-9eae-4a10ef5d3cb1"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("4d18cdc1-5f3c-4b6a-9b2d-a4f1e1d6acd1"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("4ebd62f9-b317-45c9-8474-7eee1a478c4b"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("5629799e-8d43-4559-a016-0f6969c0d253"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("5866024e-88a4-4768-beac-060a95591d93"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("5cfe6a4a-23b4-4b17-a9a8-ccad22593e6d"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("64282793-9c18-44d1-a7a1-33384e621569"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("6f7590ee-6e21-4bea-89be-29eacfe2e30e"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("7567b10c-d544-49e4-87ba-6cd47d764c11"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("7621a137-c102-48c7-b95b-c1ef5d24c296"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("76ac4417-55df-4704-bd3e-02e57325120c"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("840abd5e-2e68-48eb-a565-fc1c81444df8"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("97d394e3-6705-4462-bde2-7a62d5e10dc6"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("9ecd2074-81bf-4dd5-b909-b2dbc8fabfda"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("a2aae244-24a5-4a76-83c4-c883786f4a04"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("a5a9de0b-95ef-4e2d-841b-5cea4f591469"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("a6888946-d980-4a5c-8cc6-de66b911f5fc"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("b3edf321-12c9-4452-96c7-bdb3105809f9"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("b56b17f3-7b64-4a94-b6e0-e0785a822309"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("c42ff82a-977f-42f4-afc4-d3ab7f83689a"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("cbc36dcc-5e7f-4a80-b37c-50e2ecccf918"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("dc30c833-47d2-4fb4-b324-96eb988a802c"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("e644b3ac-017e-4dcb-b5f4-10270b08b438"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("02483318-3d00-4163-9fbc-9ce0fa42c309"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("050a312f-5de9-4e72-b9bd-94cbbb03e039"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("07afb832-c5fe-4659-84a0-819f0ae91d81"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("08277cea-d713-4563-add2-a5cc997b4c56"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("0ef9203b-74e5-4240-a384-3f7ae5e5bd4c"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("0fce71da-00cc-40ce-aff3-89c7888cb5e1"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("11eac694-8d5f-4d19-8dca-ae658e7f344d"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("232d6340-7264-49e3-9450-eb100b5ea33c"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("290584a6-44be-4c10-bdbf-d0872304d965"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("2b2911bb-b759-48b3-a01a-c4551af40519"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("2efa4fe2-1bea-4279-bca5-1fc01f436bac"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("2f38dded-dd19-41df-8e95-41d745a3a697"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("2f68afb7-38fa-4125-a5b6-c6dddafa60b6"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("35b21b72-72a9-4f5f-9ca6-5a4047bd5d0a"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("49f46490-b44b-4de4-bbf5-954c54538fa8"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("57701f2c-a735-4f21-9df5-c6e79067f37e"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("689ab377-9ecb-4753-a783-287e22a9c156"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("68a67248-7223-4b9b-88a6-71f303f6e513"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("6a7ec65a-13bb-40a6-96b5-19acb37d6844"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("6c768c71-372e-4fde-804d-d7f4797c2b08"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("7669d1ec-26e3-47b9-984f-3be119af6e9a"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("789299d7-c646-4a52-bf1a-bf1dd52c9257"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("78999fbd-cfe0-42e7-8781-da298d3bf89d"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("7bc0db6b-6b6e-40f2-8599-9ebc80a234a9"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("83548c59-cf4a-409d-9685-87eb023b126a"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("899206af-371e-4efd-89db-7535228946dd"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("96b10daa-3686-4135-af72-9027683cbeb9"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("a6b45550-cdf8-4a31-a47f-d2126148e526"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("a868b4e6-e276-442c-a2fc-8a4f9c89c4d5"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("ab029b25-f0ad-4928-b8eb-f837cf2a278f"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("bbe35c1f-6cfa-4f2b-bb47-3bdecda5470a"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("cbba1fe7-742d-45d4-8102-3bb8a4208510"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("cc271dd2-9cd0-451e-aea1-378e19ec88ca"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("d032c459-2c60-4871-bd3f-fc20b95c9c9f"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("d17f06e0-c3d4-4ca4-8694-f8fe69695db5"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("d24354a2-4ab4-40aa-8f46-6ff863e5457d"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("d739f8e7-798e-4c29-adcb-8435f082283a"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("db23badd-a781-4dd5-8b60-d8aaff3aab63"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("dbd5ad58-e49f-4b28-88b7-da8737562a2e"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("dc37a912-631b-4cb1-82bf-3c36f1360934"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("e5f56d3c-410d-4a31-b0f4-a26d6c76d4d8"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("e69901d6-02e5-4bc8-bee5-d75e4a3cfa54"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("e7f954f0-7590-4ebb-932a-26242dbcbd5b"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("eb2e671d-f44e-42bd-9981-feb3dce71fa9"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("f37cf12a-a294-4a65-a449-b092dbe50b61"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("f5b8ca47-ff39-4dd2-adbc-2c1b3af55236"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("f8b78c2d-1529-464f-9172-4bc93cd7f87e"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("ff6871ec-1cff-4ea8-b577-43fd97a151a8"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("289b3fe2-3356-4d5b-91dc-74ab0cc5ca15"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("29cb2067-edef-4c3d-9fe8-6b939ac03e0a"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("4737e704-8385-43ba-a8e8-8371812a0ae0"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("9f1d2f7a-44d7-411c-be98-49f47e44b043"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("050d0469-17c6-4b19-8d11-8fbe2020dc67"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("1366dd18-bfab-446a-83d2-28c7487c0497"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("3904e4dc-1109-4e34-b23e-1c9155afb183"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("3aea5735-a5d6-4332-90c5-69dde645dd1f"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("3f1f99a4-b4a3-4070-b027-cddaed606467"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("3fc4dab4-977c-4333-b6c5-b965ed1b7e2a"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("47b7149c-8a83-4a8e-9a3c-01b6cb8fd5b8"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("6f5578b9-7c05-4f93-b74d-bd7cef606f53"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("7f05f7a5-5c96-43f7-b658-46acf1eb12ed"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("823924dd-a0e1-4b90-b94f-e5783d5b3ebb"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("a7f3d26e-d1ed-448b-aa57-718a5b479bd0"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("a9609054-a4ab-47b5-b2e2-a4413320b43a"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("b00c374e-bf15-4cd7-9225-50617e7d3617"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("c2c513b9-e6b7-47d5-9424-cd8c4d74aa49"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("c35bc2dd-4ccc-4804-97fc-bf0b29afae5a"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("c62d8f27-c142-4c14-8ab7-adc86f1aa001"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("cec34d58-4761-4cb8-bb1f-ef9b9d1f41b3"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("d451c319-ecf8-4b31-852f-763a26533831"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("d66269a4-8ec6-41f5-9a4a-a8c03dc5f952"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("edbd8ae2-9111-4bbd-b0bc-7ace76ffd1b3"));

            migrationBuilder.DeleteData(
                table: "CurrencyEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("65039a20-a8fc-4911-91bb-a46e3dd73487"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("22eba9cc-bf1c-40e1-8f13-0dba18a37fbe"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("2eb1c35c-b4f3-4be7-b7e9-b91ba418fee2"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("316c5ce2-4101-4a51-ae18-adc78a540b33"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("444ee6c4-5db2-46e2-afa2-1dd9ae24803f"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("62e1f37b-7ef9-466e-89cf-4bc4fc5b877a"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("6fb910df-ec79-4f6e-a5a1-8a1064698cb8"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("8d2a1524-609e-4bb4-bea6-848dc1b15197"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("af1a0f5a-516c-4efd-b077-3dc806b02d7c"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("cb8e3e1a-8c4b-4406-877a-838e46adce69"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("e49387aa-517c-46a7-967b-0b0da0d17113"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("f68ab9f6-caf2-4f30-a9ca-30fd68f630c8"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("08950379-d767-450e-8be7-5a59235262c4"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("19673770-7b54-4910-9364-3a2ca41c640b"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("26c1fd29-182a-4bf0-b27d-6156a0a7fb51"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("5c95e9bf-1965-43a1-a37e-30a2595c5d52"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("5e363668-4c62-450a-a1f6-1b8a88d0342b"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("64672665-8ec3-4af4-a6a1-219c0ed9ca1c"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("74f10e37-cdef-413f-95f0-39933de04207"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("813d6340-e547-405a-ac1c-8fb23bb0127e"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("b2a1d2e1-e72b-4928-8cbd-ec22a368cc69"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("d52177d2-0c88-4ff0-8aa2-f8e933c7e00f"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("ef4c29b1-8124-47e3-9f9e-867b679247df"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("fcba018f-8a72-499d-bfab-aaae4ea1b27b"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("ff5a9ab5-2cbf-4b5f-91d0-33cb3257181e"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("017c2115-1986-4e3d-99b2-994d7b76551f"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("27529e9e-2fd9-4eba-9be2-10882dde7dad"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("47967e58-98d9-4a19-b964-576140c23115"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("56348f47-d9d8-4f7b-9c26-c9a101719ba7"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("642ec65d-2cd3-4c8c-8405-230662921e98"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("6abdca2d-0e3f-440d-8e14-c766e232538c"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("c5d52da9-7ea7-40de-8f7f-542a40195f3e"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("c76f0799-3256-4801-b03b-d2e5e08b5069"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("d767059f-a9eb-482a-8cd5-acf9a1b03c09"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("e76da6fe-10a8-4f0e-8cb8-ab45d5ecffb8"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("ecb6aa9a-9dad-432c-b746-c508bfa4917e"));
        }
    }
}
